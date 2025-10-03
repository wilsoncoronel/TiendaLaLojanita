using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Compras : Form, ISesionReceptor
    {
        private readonly IProveedorService proveedorService;
        private readonly IArticuloService articuloService;
        List<ArticuloDTO> listaArticulos;
        private int contador = 0;
        private decimal imp = 0;
        private int cant = 1;
        private int IdProveedor = 0;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Compras(IProveedorService proveedorService, IArticuloService articuloService)
        {
            InitializeComponent();
            this.proveedorService = proveedorService;
            this.articuloService = articuloService;
            this.listaArticulos = new List<ArticuloDTO>();
        }

        private async void Registro_Compras_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = $"Usuario: {Sesion?.Usuario}";
            this.lblFechaIngreso.Text = $"Fecha Ingreso: {DateTime.Now.ToString("g")}";
            this.listaArticulos = await this.CargarListaArticulos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private async Task<int> CrearCompra()
        {
            CompraCreacionDTO compraCreacionDTO = new CompraCreacionDTO();
            compraCreacionDTO.IdProveedor = this.IdProveedor; // Reemplazar con el ID real del proveedor
            compraCreacionDTO.Documento = this.txtDocumento.Text;
            compraCreacionDTO.FechaCompra = this.dtpCompra.Value;
            compraCreacionDTO.IdEstado = Convert.ToInt32(this.cbxEstadoCompra.SelectedValue); // Estado "Pendiente" por defecto
            compraCreacionDTO.EstadoVisual = true; // Estado visual "Activo" por defecto
            compraCreacionDTO.IdUsuarioCreador = this.Sesion.Id; // Reemplazar con el ID real del usuario creador
            compraCreacionDTO.DetalleComprasCreacionDto = new List<DetalleCompraCreacionDTO>();
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                if (row.IsNewRow) continue; // Saltar la fila nueva
                DetalleCompraCreacionDTO detalle = new DetalleCompraCreacionDTO
                {
                    ArticuloId = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                    Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                    ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                    ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                    ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                    ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                    Descripcion = row.Cells["Descripcion"].Value?.ToString()
                };
                compraCreacionDTO.DetalleComprasCreacionDto.Add(detalle);
            }
            var validator = new CompraValidator();
            ValidationResult result = validator.Validate(compraCreacionDTO);
        }

        private void btbBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.CargarProveedor(this.txtIdentificacionProveedor.Text);
        }
        private async Task<List<ArticuloDTO>> CargarListaArticulos()
        {
            List<ArticuloDTO> listaArticulos;
            listaArticulos = await this.articuloService.ListarTodosArticulos();
            if (listaArticulos is null || listaArticulos.Count == 0)
            {
                MessageBox.Show("No se encontraron articulos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("No se encontraron articulos en el sistema");
            }
            return listaArticulos;
        }
        private async void CargarProveedor(string identificacion)
        {
            if (identificacion is null || identificacion == "")
            {
                MessageBox.Show("Debe ingresar una identificacion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ProveedorDTO proveedor = await this.proveedorService.ObtenerProveedorCI(identificacion);
                    if (proveedor is null)
                    {
                        MessageBox.Show("No se encontro ningun proveedor con la identificacion ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("No se encontro ningun proveedor con la identificacion ingresada");
                    }
                    this.IdProveedor = proveedor.Id;
                    this.txtRazonSocial.Text = proveedor.RazonSocial;
                    this.txtTelefono.Text = proveedor.Telefono;
                    this.txtDireccion.Text = proveedor.Direccion;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al buscar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BusquedaArticulo();
        }

        private void txtArticuloBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticuloBusqueda.Text))
            {
                return;
            }
            this.BusquedaArticulo();
        }

        private void BusquedaArticulo()
        {
            ArticuloDTO articuloActual = new ArticuloDTO();
            articuloActual = this.listaArticulos.FirstOrDefault(art => art.Nombre == this.txtArticuloBusqueda.Text || art.Codigo == this.txtArticuloBusqueda.Text);
            if (articuloActual is null || articuloActual.Id == 0)
            {
                MessageBox.Show("No se encontro ningun articulo con el nombre o código ingresado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtArticuloBusqueda.Text = "";
            }
            else
            {
                bool resp = this.ComprobarArticuloDgv(articuloActual.Id);
                if (resp)
                {
                    foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                    {
                        if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == articuloActual.Id)
                        {
                            row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                        }
                    }
                    this.LimpiarValores();
                }
                else
                {
                    this.CargarDataGrid(articuloActual);
                    this.LimpiarValores();
                }
            }
        }

        private void CargarDataGrid(ArticuloDTO articuloActual)
        {
            this.dgvDetalleCompra.Rows.Add(new object[] {
                contador++,
                0,
                articuloActual.Id,
                articuloActual.Nombre,
                articuloActual.Descripcion,
                cant,
                articuloActual.ValorCompra,
                articuloActual.ValorVenta,
                this.CalcularValorImpuesto(cant, articuloActual.ImpuestoArticuloDto.ValorImpuesto, articuloActual.ValorVenta),
                (articuloActual.ValorVenta* cant) + this.imp,
            });
        }

        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }

        private bool ComprobarArticuloDgv(int idArticulo)
        {
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == idArticulo)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private decimal? CalcularValorImpuesto(int cant, decimal? valorImp, decimal valorVenta)
        {
            decimal? tot = (cant * valorVenta) * valorImp;
            this.imp = tot ?? 0;
            return tot;
        }

        private void dgvDetalleCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cantida;
            decimal valorVenta;
            if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetalleCompra.Columns[e.ColumnIndex].Name == "ValorVenta")
            {

                DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                if (int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorVenta"].Value?.ToString(), out valorVenta))
                {
                    this.CalcularValorImpuesto(Convert.ToInt32(fila.Cells["Cantidad"].Value), Convert.ToDecimal(fila.Cells["ImpuestoValor"].Value), Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                    fila.Cells["ValorTotal"].Value = (cantida * valorVenta) + this.imp;
                }
            }
            this.imp = 0;
        }

        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    dgvDetalleCompra.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch
            {
                throw;
            }
        }

        private void dgvDetalleCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dgvDetalleCompra.Columns[dgvDetalleCompra.CurrentCell.ColumnIndex].Name)
            {
                case "ValorVenta":
                    if (e.Control is TextBox)
                    {
                        TextBox textBox = e.Control as TextBox;
                        textBox.KeyPress -= new KeyPressEventHandler(textBox_KeyPress);
                        textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
                    }
                    break;
                case "Cantidad":
                    if (e.Control is TextBox)
                    {
                        TextBox textBox = e.Control as TextBox;
                        textBox.KeyPress -= new KeyPressEventHandler(textBox_KeyPressPunto);
                        textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPressPunto);
                    }
                    break;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtenemos el separador decimal del sistema
            char separadorDecimal = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            // Permitimos dígitos, el separador decimal y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == separadorDecimal || e.KeyChar == (char)Keys.Back)
            {
                // Permitimos la tecla
                e.Handled = false;
            }
            else
            {
                // Cancelamos la tecla (no la mostramos en la celda)
                e.Handled = true;
            }
        }

        private void textBox_KeyPressPunto(object sender, KeyPressEventArgs e)
        {
            // Permitimos dígitos, y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Permitimos la tecla
                e.Handled = false;
            }
            else
            {
                // Cancelamos la tecla (no la mostramos en la celda)
                e.Handled = true;
            }
        }

        private void txtIdentificacionProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CargarProveedor(this.txtIdentificacionProveedor.Text);
                e.SuppressKeyPress = true; // Evita el sonido de "ding" al presionar Enter
            }
        }
    }
}
