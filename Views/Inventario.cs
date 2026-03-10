using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Inventario : Form, ISesionReceptor
    {
        private List<TransaccionInventarioDTO> ListaTranInv;
        private readonly IInventarioService inventarioService;
        private readonly IProcesarExcel procesarExcel;
        private readonly ICompraService compraService;
        private readonly IProveedorService proveedorService;
        private List<InventarioDTO> ListaInventario;
        private List<DetalleInventarioDTO> ListaDetallesInventario;
        private List<ProveedorDTO> ListaProveedores;
        private ProgressBar prog;

        private readonly IMarcaService marcaService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Inventario(IInventarioService inventarioService, IProcesarExcel procesarExcel, ICompraService compraService, IProveedorService proveedorService)
        {
            InitializeComponent();
            ListaProveedores = new List<ProveedorDTO>();
            ListaTranInv = new List<TransaccionInventarioDTO>();
            ListaInventario = new List<InventarioDTO>();
            ListaDetallesInventario = new List<DetalleInventarioDTO>();
            this.inventarioService = inventarioService;
            this.procesarExcel = procesarExcel;
            this.compraService = compraService;
            this.proveedorService = proveedorService;
            this.CargarListaInventario();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            this.CargarDatosIniciales();
        }
        private async void CargarDatosIniciales()
        {
            this.ListaTranInv = await this.inventarioService.ListaTransaccionesInventario();
            this.cbxTransaccion.Items.Clear();
            this.cbxTransaccion.DataSource = this.ListaTranInv;
            this.cbxTransaccion.DisplayMember = "Nombre";
            this.cbxTransaccion.ValueMember = "Id";

            this.ListaProveedores = await this.proveedorService.ListarProveedores();
            this.cbxProveedor.Items.Clear();
            this.cbxProveedor.DataSource = this.ListaProveedores;
            this.cbxProveedor.DisplayMember = "Nombres";
            this.cbxProveedor.ValueMember = "Id";

            AutoCompleteStringCollection collecion = new AutoCompleteStringCollection();
            foreach (var prov in ListaProveedores) {
                collecion.Add(Convert.ToString(prov.RazonSocial));
            }

            cbxProveedor.AutoCompleteCustomSource = collecion;
            cbxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            List<DetalleCompraCreacionDTO> listaDetalles = new List<DetalleCompraCreacionDTO>();
            if (ofdArchivos.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text = ofdArchivos.FileName;
                prog = new ProgressBar();
                prog.Show();
                var (sheet, sharedStrings) = this.procesarExcel.LeerExcel(lblArchivo.Text);
                listaDetalles = this.procesarExcel.LeerShetDetallesCompra(sheet, sharedStrings);
                prog.Hide();
                DialogResult respuesta = MessageBox.Show(
                    $"Se han cargado {listaDetalles.Count} artículos desde el archivo Excel. ¿Está seguro de guardarlos en la BD?",
                    "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.OK)
                {
                    // GuardarArticulosEnBaseDeDatos(articulosExcel);
                    prog = new ProgressBar();
                    prog.Show();
                    var Compra = this.CrearTransaccionMemoria(listaDetalles);
                    var validator = new CompraValidator();
                    ValidationResult result = validator.Validate(Compra);

                    if (!result.IsValid)
                    {
                        string errores = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                        MessageBox.Show($"Errores de validación:\n{errores}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var resp = await this.CrearTransaccionCompraDB(Compra);
                        prog.Hide();
                        if (resp != null) MessageBox.Show($"Transacción creada sin error!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show($"Ocurrio un error al registrar la transacción!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private CompraCreacionDTO CrearTransaccionMemoria(List<DetalleCompraCreacionDTO> listaDetalles)
        {
            var compra = new CompraCreacionDTO
            {
                IdEstado = 1,
                Documento = this.txtDocumento.Text,
                EstadoVisual = true,
                IdProveedor = Convert.ToInt32(this.cbxProveedor.SelectedValue),
                FechaCompra = DateTime.Now,
                IdUsuarioCreador = this.Sesion.Id,
                DetalleComprasCreacionDto = listaDetalles,
            };

            return compra;
        }
        private async Task<int> CrearTransaccionCompraDB(CompraCreacionDTO compra)
        {
            var resp = await this.compraService.RegistrarCompra(compra);
            return resp;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private async void CargarListaInventario()
        {
            DateOnly fechaIni = DateOnly.FromDateTime(this.dtpFechaInicio.Value);
            DateOnly fechaFin = DateOnly.FromDateTime(this.dtpFechaFin.Value);
            prog = new ProgressBar();
            prog.Show();
            this.ListaInventario = await this.inventarioService.ListaInventario(fechaIni, fechaFin);
            prog.Hide();
            this.CargarTablaInv();
        }

        private void CargarTablaInv()
        {
            this.dgvInventario.Rows.Clear();
            foreach (var inv in ListaInventario)
            {
                int index = this.dgvInventario.Rows.Add(new object[]
                {
                    inv.Id,
                    inv.FechaCreacion,
                    Convert.ToString(inv.FechaActualizacion)?? "",
                    Convert.ToString(inv.FechaReversion)?? "",
                    inv.CompraDTO != null ? $"Compra Id: {inv.CompraDTO.Id}, Documento: {inv.CompraDTO.Documento}" : $"Venta Id: {inv.VentaDTO.Id}, Documento: {inv.VentaDTO.Documento}",
                });
            }
        }

        private async void CargarDetalles(int idInventario)
        {
            this.ListaDetallesInventario.Clear();
            this.ListaDetallesInventario = await this.inventarioService.ListaDetallesInventario(idInventario);
            if (this.ListaDetallesInventario.Count > 0)
            {
                this.CargarTablaDetallesInventario();
            }
        }
        private void CargarTablaDetallesInventario()
        {
            this.dgvDetallesInventario.Rows.Clear();
            foreach (var detalle in ListaDetallesInventario)
            {
                int index = this.dgvDetallesInventario.Rows.Add(new object[]
                {
                    detalle.Id,
                    detalle.ArticuloDTO.Nombre,
                    detalle.ArticuloDTO.Descripcion,
                    detalle.ArticuloDTO.ImpuestoArticuloDto.ValorImpuesto,
                    detalle.Cantidad,
                    detalle.PrecioCompra,
                    detalle.PrecioVenta,
                    detalle.ArticuloDTO.Papeleria == true ? "SI" : "NO"
                });
            }
        }
        private void btnBusquedaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btbBuscarInv_Click(object sender, EventArgs e)
        {
            this.CargarListaInventario();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evita clics en el encabezado
                if (e.RowIndex < 0)
                    return;

                // Obtén el ID siempre, sin importar dónde haya hecho clic
                int id = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["IdInventario"].Value);
                // Llama al método que necesites
                if (dgvInventario.Columns[e.ColumnIndex].Name == "Reversar")
                {
                    MessageBox.Show($"Esta transacción afecta a inventario, seguro quiere reversarla?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.CargarDetalles(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el Id: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxTransaccion.Text == "Compra")
            {

                if (cbxReportes.SelectedItem.ToString() == "Resumen Ventas al Día")
                {
                    MessageBoxFunction(cbxReportes.SelectedItem.ToString());

                }
                else if (cbxReportes.SelectedItem.ToString() == "Resumen Mensual")
                {
                    MessageBoxFunction(cbxReportes.SelectedItem.ToString());
                }
            }
        }

        private async void MessageBoxFunction(string msn)
        {
            DialogResult respuesta = MessageBox.Show($"Se creara el reporte de: {msn}",
                    "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
            if (respuesta == DialogResult.OK)
            {

                prog = new ProgressBar();
                prog.Show();
                if (msn == "Resumen Ventas al Día")
                {
                    var resp = await this.ResumenVentasDiarioDTO();
                    FormularioResumenVentas resVentas = new FormularioResumenVentas(resp);
                    resVentas.StartPosition = FormStartPosition.CenterScreen;
                    resVentas.Show();
                }
                else
                {
                    var resp = await this.ResumenVentasMensualDTO();
                    FormularioResumenVentas resVentas = new FormularioResumenVentas(resp);
                    resVentas.StartPosition = FormStartPosition.CenterScreen;
                    resVentas.Show();
                }
                prog.Hide();
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<List<ResumenVentasDiarioDTO>> ResumenVentasDiarioDTO()
        {
            var resp = await this.inventarioService.ResumenVentasDiario(this.dtpFechaResumen.Value);
            return resp;
        }

        private async Task<List<ResumenVentasDiarioDTO>> ResumenVentasMensualDTO()
        {
            var resp = await this.inventarioService.ResumenVentasMensual(this.dtpFechaResumen.Value);
            return resp;
        }

        
    }
}
