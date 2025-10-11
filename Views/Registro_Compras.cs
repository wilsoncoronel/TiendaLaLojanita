using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
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
        private readonly ICompraService compraService;
        List<ArticuloDTO> listaArticulos;
        private int contador = 0;
        private decimal imp = 0;
        private int cant = 1;
        private int IdProveedor = 0;
        private List<EstadoCompraDTO> ListaEstados;
        private List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>> listaImpuestos;
        private decimal TotalGeneral = 0m;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Compras(IProveedorService proveedorService, IArticuloService articuloService, ICompraService compraService)
        {
            InitializeComponent();
            this.proveedorService = proveedorService;
            this.articuloService = articuloService;
            this.compraService = compraService;
            this.listaArticulos = new List<ArticuloDTO>();
            listaImpuestos = new List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>>();
        }

        private async void CargarDatosInciales()
        {
            this.ListaEstados = await this.compraService.ListarEstadosCompra();
            this.CargarCombos();
        }
        private void CargarCombos()
        {
            this.cbxEstadoCompra.DataSource = this.ListaEstados;
            this.cbxEstadoCompra.DisplayMember = "Nombre";
            this.cbxEstadoCompra.ValueMember = "Id";
        }

        private async void Registro_Compras_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = $"Usuario: {Sesion?.Usuario}";
            this.lblFechaIngreso.Text = $"Fecha Ingreso: {DateTime.Now.ToString("g")}";
            this.listaArticulos = await this.CargarListaArticulos();
            this.CargarDatosInciales();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var resp = 0;
            var respEditar = false;
            if (this.txtIdCompra is null || this.txtIdCompra.Text == "")
            {
                resp = await this.CrearCompra();
                if (resp == 0) MessageBox.Show("No se pudo crear la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int idCompra = resp;
                    MessageBox.Show($"Compra creada con exito con el ID: {idCompra}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                respEditar = await this.EditarCompra();
                if (respEditar == false) MessageBox.Show("No se pudo editar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show($"Compra editada con exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> EditarCompra()
        {
            try
            {
                bool resp = false;
                CompraEditarDTO compraEditarDTO = new CompraEditarDTO();
                compraEditarDTO.Id = Convert.ToInt32(this.txtIdCompra.Text);
                compraEditarDTO.IdProveedor = this.IdProveedor; // Reemplazar con el ID real del proveedor
                compraEditarDTO.Documento = this.txtDocumento.Text;
                compraEditarDTO.FechaCompra = this.dtpCompra.Value;
                compraEditarDTO.IdEstado = Convert.ToInt32(this.cbxEstadoCompra.SelectedValue); // Estado "Pendiente" por defecto
                compraEditarDTO.EstadoVisual = true; // Estado visual "Activo" por defecto
                compraEditarDTO.IdUsuarioCreador = this.Sesion.Id; // Reemplazar con el ID real del usuario creador
                compraEditarDTO.DetalleComprasEditarDto = new List<DetalleCompraEditarDTO>();
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleCompraEditarDTO detalle = new DetalleCompraEditarDTO
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        ArticuloId = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                        ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString()
                    };
                    compraEditarDTO.DetalleComprasEditarDto.Add(detalle);
                }
                var validator = new CompraEdicionValidator();
                ValidationResult result = validator.Validate(compraEditarDTO);
                if (!result.IsValid)
                {
                    string errores = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show($"Errores de validación:\n{errores}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resp = await this.compraService.EditarCompra(compraEditarDTO);
                    return resp;
                }
                return resp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<int> CrearCompra()
        {
            try
            {
                int idCompra = 0;
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

                if (!result.IsValid)
                {
                    string errores = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                    MessageBox.Show($"Errores de validación:\n{errores}", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idCompra = await this.compraService.RegistrarCompra(compraCreacionDTO);
                    return idCompra;
                }
                return idCompra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            int index = this.dgvDetalleCompra.Rows.Add(new object[] {
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

            DataGridViewRow fila = this.dgvDetalleCompra.Rows[index];
            DataGridViewCell celdaContador = fila.Cells[0];
            decimal valorImpuesto = (cant * articuloActual.ValorVenta) * articuloActual.ImpuestoArticuloDto.ValorImpuesto;
            fila.Cells[8].Value = valorImpuesto;
            fila.Cells[9].Value = articuloActual.ValorVenta * cant;
            contador++;
        }
        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }

        private void CalcularTotales()
        {
            decimal totIva15 = 0m;
            decimal totIva12 = 0m;
            decimal totIvaIncluido15 = 0m;
            decimal totIva0 = 0m;

            foreach (var imp in this.listaImpuestos)
            {
                foreach (var nom in imp)
                {
                    if (nom.Key == "15 %")
                    {
                        totIva15 = nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad));
                        this.imp = totIva15;
                    }
                    if (nom.Key == "12 %")
                    {
                        totIva12 = nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad));
                        this.imp = totIva12;
                    }
                    if (nom.Key == "Incluido Iva 15%")
                    {
                        totIva12 = nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad));
                        this.imp = totIvaIncluido15;
                    }
                    if (nom.Key == "0%")
                    {
                        totIva0 = nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * x.Cantidad));
                        this.imp = totIva0;
                    }
                    this.TotalGeneral = TotalGeneral + (nom.Value.Sum(x => x.ValorVenta * x.Cantidad));
                }
            }
            this.lblIva15.Text = $"Sub. Iva 15%: {totIva15}";
            this.lblIncluidoIva15.Text = $"Sub. Iva 15% Inlcuido: {totIvaIncluido15}";
            this.lblSubSinIva.Text = $"Sub. 0%: {totIva0}";
            this.TotalGeneral = TotalGeneral + totIva0 + totIva12 + totIva15;
            this.lblTotal.Text = this.TotalGeneral.ToString("C2", new CultureInfo("en-US"));
            this.TotalGeneral = 0m;
        }

        private void EliminarImpuestoPorId(int id)
        {
            // Recorremos cada diccionario (por cada tipo de impuesto)
            foreach (var dic in listaImpuestos)
            {
                // Obtenemos la clave (nombre del impuesto)
                string nombreImpuesto = dic.Keys.First();

                // Eliminamos todos los ImpuestoCalculadoDTO con ese ID
                dic[nombreImpuesto].RemoveAll(x => x.Id == id);
            }

            // También puedes eliminar el diccionario si la lista quedó vacía
            listaImpuestos.RemoveAll(dic => dic.Values.First().Count == 0);
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

        private void dgvDetalleCompra_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cantida;
            decimal valorVenta;
            if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetalleCompra.Columns[e.ColumnIndex].Name == "ValorVenta")
            {

                DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                if (int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorVenta"].Value?.ToString(), out valorVenta))
                {
                    fila.Cells["ValorTotal"].Value = cantida * valorVenta;
                    this.ActualizarCantidad(Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToInt32(fila.Cells["Cantidad"].Value), Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                    this.CalcularTotales();
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
                    EliminarImpuestoPorId(Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["Id"].Value));
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


        /*------------------------------------------------------Compras creadas--------------------------------------------------*/
        private async void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            await this.listarComprasCreadas();
            List<CompraMinDTO> listaCompras = await this.listarComprasCreadas();
            this.CargarTablaComprasCreadas(listaCompras);
        }

        private async void CargarTablaComprasCreadas(List<CompraMinDTO> listaCompras)
        {
            this.dgvCompras.Rows.Clear();
            foreach (var compra in listaCompras)
            {
                int index = this.dgvCompras.Rows.Add(new object[]
                {
                    compra.Id,
                    compra.FechaCompra.ToString("dd/MM/yyyy"),
                    compra.ProveedorMinDto.Id,
                    compra.ProveedorMinDto.RazonSocial,
                    compra.EstadoCompra.Id,
                    compra.EstadoCompra.Nombre,
                    compra.Documento,
                    compra.UsuarioCreadorMinDTO.Id,
                    compra.UsuarioCreadorMinDTO.Nombres,
                });
            }
        }
        private async Task<List<CompraMinDTO>> listarComprasCreadas()
        {
            DateOnly fechaIni = DateOnly.FromDateTime(this.dtpFechaInicial.Value);
            DateOnly fechaFin = DateOnly.FromDateTime(this.dtpFechaFinal.Value);

            List<CompraMinDTO> listaCompras = await this.compraService.ListarCompras(fechaIni, fechaFin);

            return listaCompras;
        }

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvCompras.Columns[e.ColumnIndex].Name == "Editar")
                {
                    id = Convert.ToInt32(dgvCompras.Rows[e.RowIndex].Cells["IdComp"].Value);
                    this.ObtenerCompra(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private async void ObtenerCompra(int idCompra)
        {
            var compra = await this.compraService.ObtenerCompra(idCompra);
            this.IdProveedor = compra.IdProveedor;
            this.txtIdentificacionProveedor.Text = compra.ProveedorDto.Identificacion;
            this.txtIdCompra.Text = Convert.ToString(compra.Id);
            this.txtRazonSocial.Text = compra.ProveedorDto.RazonSocial;
            this.txtTelefono.Text = compra.ProveedorDto.Telefono;
            this.txtDireccion.Text = compra.ProveedorDto.Direccion;
            this.txtDocumento.Text = compra.Documento;
            this.dtpCompra.Value = compra.FechaCompra;
            this.cbxEstadoCompra.SelectedValue = compra.IdEstado;
            this.dgvDetalleCompra.Rows.Clear();
            ArticuloDTO articuloActual = new ArticuloDTO();
            foreach (var detalle in compra.DetalleCompras)
            {
                int index = this.dgvDetalleCompra.Rows.Add(new object[] {
                    detalle.Id,
                    detalle.IdCompra,
                    detalle.Articulo.Id,
                    detalle.Articulo.Nombre,
                    detalle.Descripcion,
                    detalle.Cantidad,
                    detalle.ValorCompra,
                    detalle.ValorVenta,
                    detalle.ImpuestoValor,
                    detalle.ValorTotal,
                });
               
               this.CargarListaImpuestos(detalle);
            }
            this.CalcularTotales();
        }
        private void CargarListaImpuestos( DetalleCompraDTO detalle)
        {
            listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
            {
                { detalle.Articulo.ImpuestoArticuloDto.Nombre, new List<ImpuestoArticuloCalculadoDTO>
                    {
                        new ImpuestoArticuloCalculadoDTO
                        {
                            NombreImpuesto = detalle.Articulo.ImpuestoArticuloDto.Nombre,
                            IdArticulo = detalle.Articulo.Id,
                            ValorImpuesto = detalle.ImpuestoValor,
                            ValorVenta = detalle.ValorVenta,
                            Id = detalle.Id,
                            Cantidad = detalle.Cantidad
                        }
                    }
                }
            });
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtDocumento.Text = "";
            this.txtDireccion.Text = "";
            this.txtDocumento.Text = "";
            this.txtRazonSocial.Text = "";
            this.txtTelefono.Text = "";
            this.dgvDetalleCompra.Rows.Clear();
            this.contador = 0;
            this.TotalGeneral = 0m;
            this.listaImpuestos.Clear();
        }
    }
}