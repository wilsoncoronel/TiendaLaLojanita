using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using TiendaLaLojanita.Mapeos;
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
        private readonly IInventarioService inventarioService;
        private DateTimePicker dateTimePicker;
        private List<InventarioLoteDTO> listaArticulos;
        private int contador = 0;
        private decimal imp = 0;
        private int cant = 1;
        private int IdProveedor = 0;
        private List<EstadoCompraDTO> ListaEstados;
        private List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>> listaImpuestos;
        private List<TransaccionInventarioDTO> ListaTransacciones;
        private decimal TotalGeneral = 0m;
        private List<InventarioLoteDTO> listaTemp;
        private ProgressBar prog;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Compras(IProveedorService proveedorService, IArticuloService articuloService, ICompraService compraService, IInventarioService inventarioService)
        {
            InitializeComponent();
            this.proveedorService = proveedorService;
            this.articuloService = articuloService;
            this.compraService = compraService;
            this.inventarioService = inventarioService;
            this.listaArticulos = new List<InventarioLoteDTO>();
            this.ListaTransacciones = new List<TransaccionInventarioDTO>();
            listaImpuestos = new List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>>();
        }

        private async void CargarDatosInciales()
        {
            this.ListaEstados = await this.compraService.ListarEstadosCompra();
            this.ListaTransacciones = await this.inventarioService.ListaTransaccionesInventario();
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
            AutoCompleteArt();
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
                    this.LimpiarFormulario();
                    
                    MessageBox.Show($"Compra creada con exito con el ID: {idCompra}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                respEditar = await this.EditarCompra();
                if (respEditar == false) MessageBox.Show("No se pudo editar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show($"Compra editada con exito!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.LimpiarValores();
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
                compraEditarDTO.IdTransaccion = this.ListaTransacciones.FirstOrDefault(t => t.Nombre.ToUpper() == "COMPRA").Id; ;
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleCompraEditarDTO detalle = new DetalleCompraEditarDTO
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        NumeroLote = row.Cells["Lote"].Value?.ToString(),
                        Codigo = row.Cells["Codigo"].Value?.ToString(),
                        ArticuloId = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                        ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString(),
                        FechaCaducidad = row.Cells["FechaExpiracion"].Value != null ? DateOnly.Parse(row.Cells["FechaExpiracion"].Value.ToString()) : null
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
                compraCreacionDTO.IdTransaccion = this.ListaTransacciones.FirstOrDefault(t => t.Nombre.ToUpper() == "COMPRA").Id;
                foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleCompraCreacionDTO detalle = new DetalleCompraCreacionDTO
                    {
                        NumeroLote = row.Cells["Lote"].Value?.ToString(),
                        Codigo = row.Cells["Codigo"].Value?.ToString(),
                        IdArticulo = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = Convert.ToDecimal(row.Cells["ImpuestoValor"].Value),
                        ValorTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString(),
                        FechaExpiracion = row.Cells["FechaExpiracion"].Value != null ? DateOnly.FromDateTime(Convert.ToDateTime(row.Cells["FechaExpiracion"].Value)) : null
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
        private async Task<List<InventarioLoteDTO>> CargarListaArticulos()
        {
            List<InventarioLoteDTO> listaArticulos;
            listaArticulos = await this.articuloService.ListarTodosArticulos();
            if (listaArticulos is null || listaArticulos.Count == 0)
            {
                MessageBox.Show("No se encontraron articulos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaArticulos;
        }
        private async void CargarProveedor(string identificacion)
        {

            prog = new ProgressBar();
            if (identificacion is null || identificacion == "")
            {
                MessageBox.Show("Debe ingresar una identificacion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    prog.Show();
                    ProveedorDTO proveedor = await this.proveedorService.ObtenerProveedorCI(identificacion);
                    prog.Hide();
                    if (proveedor is null)
                    {
                        MessageBox.Show("No se encontró ningún proveedor con la identificación ingresada!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.IdProveedor = proveedor.Id;
                    this.txtRazonSocial.Text = proveedor.RazonSocial;
                    this.txtTelefono.Text = proveedor.Telefono;

                    this.txtDireccion.Text = $"{proveedor.DireccionDto.Descripcion} {proveedor.DireccionDto.Ciudad.Nombre}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al buscar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdentificacionProveedor.Text = "";

                }
            }
        }

        private List<InventarioLoteDTO> BuscarNombreArticulo(string pNom)
        {
            var listaTemp = new List<InventarioLoteDTO>();
            listaTemp = this.listaArticulos.ToList();
            return listaTemp.Where(art => art.ArticuloDTO.Nombre.Contains(pNom)).ToList();
        }

        private void AutoCompleteArt()
        {
            AutoCompleteStringCollection colArticulo = new AutoCompleteStringCollection();
            List<InventarioLoteDTO> listaArticuloAuto = BuscarNombreArticulo(this.txtArticuloBusqueda.Text);
            foreach (InventarioLoteDTO art in listaArticuloAuto)
            {
                colArticulo.Add(art.ArticuloDTO.Nombre);
            }
            this.txtArticuloBusqueda.AutoCompleteCustomSource = colArticulo;
            this.txtArticuloBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtArticuloBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BusquedaArticulo()
        {
            InventarioLoteDTO articuloActual = new InventarioLoteDTO();
            int temp = 0;
            if (int.TryParse(txtArticuloBusqueda.Text, out temp)) articuloActual = this.listaArticulos.FirstOrDefault(art => art.Codigo == this.txtArticuloBusqueda.Text || art.Id == Convert.ToInt32(this.txtArticuloBusqueda.Text));
            else articuloActual = this.listaArticulos.FirstOrDefault(art => art.ArticuloDTO.Nombre.ToUpper() == this.txtArticuloBusqueda.Text.ToUpper());
            if (articuloActual is null || articuloActual.Id == 0)
            {
                MessageBox.Show("No se encontro ningun artículo con el nombre o código ingresado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            this.ActualizarCantidad(articuloActual.Id, Convert.ToInt32(row.Cells["Cantidad"].Value), Convert.ToDecimal(row.Cells["ValorCompra"].Value));
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

        private void ActualizarCantidad(int idArticulo, decimal cantidad, decimal valorCompra)
        
        {

            foreach (var c in this.listaImpuestos)
            {
                foreach (var imp in c)
                {
                    imp.Value.Where(x => x.IdArticulo == idArticulo).ToList().ForEach(x =>
                    {
                        x.Cantidad = Convert.ToDecimal(cantidad);
                        x.ValorCompra = valorCompra;
                    });
                }
            }
        }
        private void CargarDataGrid(InventarioLoteDTO articuloActual)
        {
            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(articuloActual.ArticuloDTO.ImpuestoArticuloDto.Nombre));
            if (existente != null)
            {
                existente[articuloActual.ArticuloDTO.ImpuestoArticuloDto.Nombre].Add(new ImpuestoArticuloCalculadoDTO
                {
                    NombreImpuesto = articuloActual.ArticuloDTO.ImpuestoArticuloDto.Nombre,
                    IdArticulo = articuloActual.Id,
                    ValorImpuesto = articuloActual.ArticuloDTO.ImpuestoArticuloDto.ValorImpuesto,
                    ValorCompra = articuloActual.ArticuloDTO.ValorCompra,
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
                    { articuloActual.ArticuloDTO.ImpuestoArticuloDto.Nombre, new List<ImpuestoArticuloCalculadoDTO>
                        {
                            new ImpuestoArticuloCalculadoDTO
                            {
                                NombreImpuesto = articuloActual.ArticuloDTO.ImpuestoArticuloDto.Nombre,
                                IdArticulo = articuloActual.Id,
                                ValorImpuesto = articuloActual.ArticuloDTO.ImpuestoArticuloDto.ValorImpuesto,
                                ValorCompra = articuloActual.ArticuloDTO.ValorCompra,
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
                "",
                "",
                articuloActual.ArticuloDTO.Nombre,
                articuloActual.ArticuloDTO.Descripcion,
                cant,
                articuloActual.ArticuloDTO.ValorCompra,
                articuloActual.ArticuloDTO.ValorVenta,
                0,
                0,
                Convert.ToString(DateTime.Now)
            });

            DataGridViewRow fila = this.dgvDetalleCompra.Rows[index];
            DataGridViewCell celdaContador = fila.Cells[0];
            decimal valorImpuesto = (cant * articuloActual.ArticuloDTO.ValorCompra) * articuloActual.ArticuloDTO.ImpuestoArticuloDto.ValorImpuesto;
            fila.Cells[10].Value = valorImpuesto;
            fila.Cells[11].Value = articuloActual.ArticuloDTO.ValorCompra * cant;
            contador++;
        }
        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }

        private void CalcularTotales()
        {
            // Usar variables locales para evitar acumulaci F3n entre llamadas
            decimal totImpuestosLocal = 0m;
            decimal totalValorCompraLocal = 0m;
            this.dgvTotales.Rows.Clear();

            foreach (var imp in this.listaImpuestos)
            {
                foreach (var nom in imp)
                {
                    // Calcular el impuesto sobre ValorCompra (seg FAn especificaci F3n)
                    decimal impuestoTotal = nom.Value.Sum(x => x.ValorImpuesto * (x.ValorCompra * Convert.ToDecimal(x.Cantidad)));
                    decimal subtotalValorCompra = nom.Value.Sum(x => x.ValorCompra * Convert.ToDecimal(x.Cantidad));

                    this.dgvTotales.Rows.Add(new object[]
                    {
                        nom.Key,
                        impuestoTotal,
                    });

                    totImpuestosLocal += impuestoTotal;
                    totalValorCompraLocal += subtotalValorCompra;
                }
            }

            decimal totalGeneralLocal = totalValorCompraLocal + totImpuestosLocal;
            // Actualizar la etiqueta con formato en-US
            this.lblTotal.Text = totalGeneralLocal.ToString("C2", new CultureInfo("en-US"));
            // Mantener el campo de clase sincronizado con el total calculado (no acumulativo)
            this.TotalGeneral = totalGeneralLocal;
        }

        /*private void CalcularTotales()
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
                        nom.Value.Sum(x => x.ValorImpuesto * (x.ValorVenta * Convert.ToDecimal( x.Cantidad))),
                    });
                    totImpuestos = totImpuestos + nom.Value.Sum(x => x.ValorImpuesto * (x.ValorCompra * Convert.ToDecimal(x.Cantidad)));
                    TotalGeneral = TotalGeneral + (nom.Value.Sum(x => x.ValorCompra * Convert.ToDecimal(x.Cantidad)));
                }
            }

            this.TotalGeneral = TotalGeneral + totImpuestos;
            this.lblTotal.Text = this.TotalGeneral.ToString("C2", new CultureInfo("en-US"));
            this.TotalGeneral = 0m;
        }*/

        private void EliminarImpuestoPorId(int id)
        {
            foreach (var dic in listaImpuestos)
            {
                string nombreImpuesto = dic.Keys.First();
                dic[nombreImpuesto].RemoveAll(x => x.Id == id);
            }
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
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtenemos el separador decimal del sistema
            TextBox txt = sender as TextBox;

            // Si el usuario escribe punto, lo convertimos en coma
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            // Permitimos números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitimos una sola coma
            else if (e.KeyChar == ',' && !txt.Text.Contains(","))
            {
                e.Handled = false;
            }
            // Permitimos borrar
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyPressPunto(object sender, KeyPressEventArgs e)
        {
            // Permitimos dígitos, y la tecla de retroceso (para borrar)
            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permitir Backspace
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            // Permitir una sola coma
            else if (e.KeyChar == ',' && !txt.Text.Contains(","))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacionProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CargarProveedor(this.txtIdentificacionProveedor.Text.Trim());
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
            prog = new ProgressBar();
            prog.Show();
            await this.listarComprasCreadas();
            prog.Hide();
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

        private async void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(dgvCompras.Rows[e.RowIndex].Cells["IdComp"].Value);
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvCompras.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.listaImpuestos.Clear();
                    this.lblTotal.Text = "0,00";
                    this.ObtenerCompra(id);
                }
                else if (dgvCompras.Columns[e.ColumnIndex].Name == "Reversar")
                {
                    bool resp = await this.compraService.ReversarCompra(id);
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
            this.txtDireccion.Text = $"{compra.ProveedorDto.DireccionDto.Descripcion} {compra.ProveedorDto.DireccionDto.Ciudad.Nombre}";
            this.txtDocumento.Text = compra.Documento;
            this.dtpCompra.Value = compra.FechaCompra;
            this.cbxEstadoCompra.SelectedValue = compra.IdEstado;
            this.dgvDetalleCompra.Rows.Clear();
            //ArticuloDTO articuloActual = new ArticuloDTO();
            foreach (var detalle in compra.DetalleCompras)
            {
                int index = this.dgvDetalleCompra.Rows.Add(new object[] {
                    detalle.Id,
                    detalle.IdCompra,
                    detalle.ArticuloDTO.Id,
                    detalle.Codigo?? "",
                    detalle.Lote?? "",
                    detalle.ArticuloDTO.Nombre,
                    detalle.Descripcion,
                    detalle.Cantidad,
                    detalle.ValorCompra,
                    detalle.ValorVenta,
                    detalle.ImpuestoValor,
                    detalle.ValorTotal,
                    detalle.FechaCaducidad?.ToString("dd/MM/yyyy") ?? ""
                });

                this.CargarListaImpuestos(detalle);
            }
            this.CalcularTotales();
        }
        private void CargarListaImpuestos(DetalleCompraDTO detalle)
        {
            var nombreImpuesto = detalle.ArticuloDTO.ImpuestoArticuloDto.Nombre;
            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(nombreImpuesto));
            if (existente != null)
            {
                existente[nombreImpuesto].Add(new ImpuestoArticuloCalculadoDTO
                {
                    NombreImpuesto = nombreImpuesto,
                    IdArticulo = detalle.ArticuloDTO.Id,
                    ValorImpuesto = detalle.ImpuestoValor,
                    ValorCompra = detalle.ValorCompra,
                    Id = detalle.Id,
                    Cantidad = detalle.Cantidad
                });
            }
            else
            {
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
                {
                    { nombreImpuesto, new List<ImpuestoArticuloCalculadoDTO>
                        {
                            new ImpuestoArticuloCalculadoDTO
                            {
                                NombreImpuesto = nombreImpuesto,
                                IdArticulo = detalle.ArticuloDTO.Id,
                                ValorImpuesto = detalle.ImpuestoValor,
                                ValorCompra = detalle.ValorCompra,
                                Id = detalle.Id,
                                Cantidad = detalle.Cantidad
                            }
                        }
                    }
                });
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.BusquedaArticulo();
        }

        private void dgvDetalleCompra_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            decimal cantida;
            decimal valorCompra;
            if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetalleCompra.Columns[e.ColumnIndex].Name == "ValorCompra")
            {
                DataGridViewRow fila = dgvDetalleCompra.Rows[e.RowIndex];
                if (decimal.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorCompra"].Value?.ToString(), out valorCompra))
                {
                    fila.Cells["ValorTotal"].Value = cantida * valorCompra;
                    this.ActualizarCantidad(Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToDecimal(fila.Cells["Cantidad"].Value), Convert.ToDecimal(fila.Cells["ValorCompra"].Value));
                    this.CalcularTotales();
                }
            }
            this.imp = 0;
        }

        private void dgvDetalleCompra_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "FechaExpiracion")
                {
                    dateTimePicker = new DateTimePicker();
                    dgvDetalleCompra.Controls.Add(dateTimePicker);
                    dateTimePicker.Format = DateTimePickerFormat.Short;
                    Rectangle rectangle = dgvDetalleCompra.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                    dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                    dateTimePicker.CloseUp += new EventHandler(dateTimePicker_CloseUp);
                    dateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);
                    dateTimePicker.Visible = true;
                }
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvDetalleCompra.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    EliminarImpuestoPorId(Convert.ToInt32(dgvDetalleCompra.Rows[e.RowIndex].Cells["Id"].Value));
                    dgvDetalleCompra.Rows.RemoveAt(e.RowIndex);
                    this.CalcularTotales();
                }
            }
            catch
            {
                throw;
            }
        }

        private void dateTimePicker_OnTextChange(object? sender, EventArgs e)
        {
            dgvDetalleCompra.CurrentCell.Value = dateTimePicker.Text.ToString();
        }

        private void dateTimePicker_CloseUp(object? sender, EventArgs e)
        {
            dateTimePicker.Visible = false;
        }

        private void txtArticuloBusqueda_KeyDown_1(object sender, KeyEventArgs e)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            this.txtIdCompra.Text = "";
            this.txtDocumento.Text = "";
            this.txtDireccion.Text = "";
            this.txtDocumento.Text = "";
            this.txtRazonSocial.Text = "";
            this.txtTelefono.Text = "";
            this.dgvDetalleCompra.Rows.Clear();
            this.contador = 0;
            this.TotalGeneral = 0m;
            this.listaImpuestos.Clear();
            this.dgvTotales.Rows.Clear();
            this.lblTotal.Text = "";
            this.TotalGeneral = 0m;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            IProveedorService proveedorService = this.proveedorService;
            IMapeoProveedor mapeos = new MapeoProveedor();
            Proveedor prov = new Proveedor(proveedorService, mapeos);
            prov.StartPosition = FormStartPosition.CenterScreen;
            prov.Show();
        }

        private async void btnRecargarArticulos_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                    $"Se recargarán los articulos de compra, Desea continuar?",
                    "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
            if (respuesta == DialogResult.OK)
            {
                prog = new ProgressBar();
                prog.Show();
                this.listaArticulos = new List<InventarioLoteDTO>();
                this.listaArticulos = await this.CargarListaArticulos();
                this.listaTemp = new List<InventarioLoteDTO>();
                this.listaTemp = this.listaArticulos.ToList();
                this.AutoCompleteArt();
                prog.Hide();
                MessageBox.Show($"Artículos recargados!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDetalleCompra_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dgvDetalleCompra.Columns[dgvDetalleCompra.CurrentCell.ColumnIndex].Name)
            {
                case "ValorCompra":
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
    }
}