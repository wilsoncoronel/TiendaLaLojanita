using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class Registro_Ventas : Form, ISesionReceptor
    {
        private int idCliente = 0;
        private readonly IClienteService clienteService;
        private readonly IArticuloService articuloService;
        private readonly IVentaService _ventaService;
        private List<ArticuloDTO> listaArticulos;
        private List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>> listaImpuestos;
        private decimal imp = 0;
        private int contador = 0;
        private int cant = 1;
        private decimal TotalGeneral = 0m;
        private List<EstadoVentaDTO> ListaEstados;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Ventas(IClienteService clienteService, IArticuloService articuloService, IVentaService ventaService)
        {
            InitializeComponent();
            this.clienteService = clienteService;
            this.articuloService = articuloService;
            this._ventaService = ventaService;
            this.listaArticulos = new List<ArticuloDTO>();
            listaImpuestos = new List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>>();
        }
        private async void Registro_Ventas_Load(object sender, EventArgs e)
        {
            this.listaArticulos = await this.CargarListaArticulos();
            this.CargarDatosInciales();
        }
        private async void CargarDatosInciales()
        {
            this.ListaEstados = await this._ventaService.ListarEstadosVenta();
            this.CargarCombos();
        }

        private void CargarCombos()
        {
            this.cbxEstadosVenta.DataSource = this.ListaEstados;
            this.cbxEstadosVenta.DisplayMember = "Nombre";
            this.cbxEstadosVenta.ValueMember = "Id";
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            this.CargarCliente(this.txtIdentificaconCliente.Text);
        }

        private async void CargarCliente(string identificacion)
        {
            if (identificacion is null || identificacion == "")
            {
                MessageBox.Show("Debe ingresar una identificacion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ClienteDTO cliente = await this.clienteService.ObtenerClienteCI(identificacion);
                    if (cliente is null)
                    {
                        MessageBox.Show("No se encontró ningún cliente con la identificación ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("No se encontro ningún cliente con la identificacion ingresada");
                    }
                    this.txtIdentificaconCliente.Text = identificacion;
                    this.txtNombreCliente.Text = cliente.Nombres;
                    this.txtTelefono.Text = cliente.Telefono;
                    this.txtEmail.Text = cliente.Mail;
                    this.txtDireccionCliente.Text = $"Dirección: {cliente.DireccionDto.Descripcion}, Ciudad: {cliente.DireccionDto.Ciudad.Nombre}";
                    this.idCliente = cliente.Id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al buscar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void txtIdentificaconCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CargarCliente(this.txtIdentificaconCliente.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void txtArticuloBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido "ding"

                if (!string.IsNullOrWhiteSpace(txtArticuloBusqueda.Text))
                {
                    this.BusquedaArticulo();
                }
            }
        }
        private void BusquedaArticulo()
        {
            ArticuloDTO articuloActual = new ArticuloDTO();
            articuloActual = this.listaArticulos.FirstOrDefault(art => art.Nombre == this.txtArticuloBusqueda.Text || art.Codigo == this.txtArticuloBusqueda.Text || art.Id == Convert.ToInt32(this.txtArticuloBusqueda.Text));
            if (articuloActual is null || articuloActual.Id == 0)
            {
                MessageBox.Show("No se encontró ningún artículo con el nombre o código ingresado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtArticuloBusqueda.Text = "";
            }
            else
            {
                bool resp = this.ComprobarArticuloDgv(articuloActual.Id);
                if (resp)
                {
                    foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
                    {
                        if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == articuloActual.Id)
                        {
                            row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                            this.ActualizarCantidad(articuloActual.Id, Convert.ToInt32(row.Cells["Cantidad"].Value), Convert.ToDecimal(row.Cells["ValorVenta"].Value));
                            this.CalcularTotales();
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
            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(articuloActual.ImpuestoArticuloDto.Nombre));
            if (existente != null)
            {
                existente[articuloActual.ImpuestoArticuloDto.Nombre].Add(new ImpuestoArticuloCalculadoDTO
                {
                    NombreImpuesto = articuloActual.ImpuestoArticuloDto.Nombre,
                    IdArticulo = articuloActual.Id,
                    ValorImpuesto = articuloActual.ImpuestoArticuloDto.ValorImpuesto,
                    ValorVenta = articuloActual.ValorVenta,
                    Id = contador,
                    Cantidad = cant
                });
                this.CalcularTotales();
            }
            else
            {
                //this.CargarListaImpuestos(articuloActual);
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
                {
                    { articuloActual.ImpuestoArticuloDto.Nombre, new List<ImpuestoArticuloCalculadoDTO>
                        {
                            new ImpuestoArticuloCalculadoDTO
                            {
                                NombreImpuesto = articuloActual.ImpuestoArticuloDto.Nombre,
                                IdArticulo = articuloActual.Id,
                                ValorImpuesto = articuloActual.ImpuestoArticuloDto.ValorImpuesto,
                                ValorVenta = articuloActual.ValorVenta,
                                Id = contador,
                                Cantidad = cant
                            }
                        }
                    }
                });
                this.CalcularTotales();
            }
            int index = this.dgvDetallesVenta.Rows.Add(new object[] {
                contador,
                0,
                articuloActual.Id,
                articuloActual.Nombre,
                articuloActual.Descripcion,
                cant,
                articuloActual.ValorCompra,
                articuloActual.ValorVenta,
                0,
                0,
            });

            DataGridViewRow fila = this.dgvDetallesVenta.Rows[index];
            DataGridViewCell celdaContador = fila.Cells[0];
            decimal valorImpuesto = (cant * articuloActual.ValorVenta) * articuloActual.ImpuestoArticuloDto.ValorImpuesto;
            fila.Cells[8].Value = valorImpuesto;
            fila.Cells[9].Value = articuloActual.ValorVenta * Convert.ToInt32(fila.Cells[5].Value);
            contador++;
        }

        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }
        private void CalcularTotales()
        {
            decimal totImpuestos = 0m;
            this.dgvTotales.Rows.Clear();

            foreach (var imp in this.listaImpuestos)
            {
                foreach (var nom in imp)
                {
                    this.dgvTotales.Rows.Add(new object[]
                    {
                        nom.Key,
                        nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad)),
                    });
                    totImpuestos = totImpuestos + nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad));
                    TotalGeneral = TotalGeneral + (nom.Value.Sum(x => x.ValorVenta * x.Cantidad));
                }
            }

            this.TotalGeneral = TotalGeneral + totImpuestos;
            this.txtTotal.Text = this.TotalGeneral.ToString("C2", new CultureInfo("en-US"));
            this.TotalGeneral = 0m;
        }

        private void ActualizarCantidad(int idArticulo, int cantidad, decimal valorVenta)
        {
            foreach (var c in this.listaImpuestos)
            {
                foreach (var imp in c)
                {
                    imp.Value.Where(x => x.IdArticulo == idArticulo).ToList().ForEach(x =>
                    {
                        x.Cantidad = cantidad;
                        x.ValorVenta = valorVenta;
                    });
                }
            }
        }

        private bool ComprobarArticuloDgv(int idArticulo)
        {
            foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
            {
                if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == idArticulo)
                {
                    return true;
                    break;
                }
            }
            return false;
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

        private void dgvDetallesVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cantida;
            decimal valorVenta;
            if (dgvDetallesVenta.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetallesVenta.Columns[e.ColumnIndex].Name == "Valor Venta")
            {

                DataGridViewRow fila = dgvDetallesVenta.Rows[e.RowIndex];
                if (int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorVenta"].Value?.ToString(), out valorVenta))
                {
                    fila.Cells["ValorTotal"].Value = cantida * valorVenta;
                    this.ActualizarCantidad(Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToInt32(fila.Cells["Cantidad"].Value), Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                    this.CalcularTotales();
                }
            }
            this.imp = 0;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var resp = 0;
            var respEditar = false;
            if (this.txtIdVenta is null || this.txtIdVenta.Text == "")
            {
                resp = await this.CrearVenta();
                if (resp == 0) MessageBox.Show("No se pudo crear la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int idCompra = resp;
                    MessageBox.Show($"Compra creada con exito con el ID: {idCompra}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            /*else
            {
                respEditar = await this.EditarCompra();
                if (respEditar == false) MessageBox.Show("No se pudo editar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show($"Compra editada con exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private async Task<int> CrearVenta()
        {
            try
            {
                int idVenta = 0;
                VentaCreacionDTO ventaCreacionDTO = new VentaCreacionDTO();
                ventaCreacionDTO.IdCliente = this.idCliente; // Reemplazar con el ID real del proveedor
                ventaCreacionDTO.Documento = this.txtDocumento.Text;
                ventaCreacionDTO.FechaCompra = this.dtpCompra.Value;
                ventaCreacionDTO.IdEstado = Convert.ToInt32(this.cbxEstadosVenta.SelectedValue); // Estado "Pendiente" por defecto
                ventaCreacionDTO.EstadoVisual = true; // Estado visual "Activo" por defecto
                ventaCreacionDTO.UsuarioCreadorId = this.Sesion.Id; // Reemplazar con el ID real del usuario creador
                ventaCreacionDTO.DetalleVentaCreacionDto = new List<DetalleVentaCreacionDTO>();
                foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleVentaCreacionDTO detalle = new DetalleVentaCreacionDTO
                    {
                        ArticuloId = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                        ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString()
                    };
                    ventaCreacionDTO.DetalleVentaCreacionDto.Add(detalle);
                }
                var validator = new VentaValidator();
                ValidationResult result = validator.Validate(ventaCreacionDTO);

                if (!result.IsValid)
                {
                    string errores = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show($"Errores de validación:\n{errores}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idVenta = await this._ventaService.RegistrarVenta(ventaCreacionDTO);
                    return idVenta;
                } 
                return idVenta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
