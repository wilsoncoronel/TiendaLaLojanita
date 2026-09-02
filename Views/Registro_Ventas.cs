using FluentValidation.Results;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TiendaLaLojanita.Mapeos;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Ventas : Form, ISesionReceptor
    {
        private int idCliente = 0;
        private readonly IClienteService clienteService;
        private readonly IArticuloService articuloService;
        private readonly IVentaService _ventaService;
        private readonly IInventarioService inventarioService;
        private readonly IProveedorService proveedorService;
        private List<ArticuloInventarioDTO> listaArticulos;
        private List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>> listaImpuestos;
        private decimal imp = 0;
        private int contador = 0;
        private int cant = 1;
        private decimal TotalGeneral = 0m;
        private List<EstadoVentaDTO> ListaEstados;
        private List<ArticuloInventarioDTO> listaTemp;
        private List<TransaccionInventarioDTO> ListaTransacciones;

        ProgressBar pro;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }
        public Registro_Ventas(IClienteService clienteService, IArticuloService articuloService, IVentaService ventaService, IInventarioService inventarioService, IProveedorService proveedorService)
        {
            InitializeComponent();
            this.clienteService = clienteService;
            this.articuloService = articuloService;
            this._ventaService = ventaService;
            this.inventarioService = inventarioService;
            this.proveedorService = proveedorService;
            this.listaArticulos = new List<ArticuloInventarioDTO>();
            this.ListaTransacciones = new List<TransaccionInventarioDTO>();
            listaImpuestos = new List<Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>>();
        }
        private async void Registro_Ventas_Load(object sender, EventArgs e)
        {
            this.listaArticulos = await this.CargarListaArticulos();
            this.lblUsuario.Text = $"Usuario: {Sesion?.Usuario}";
            this.lblFechaIngreso.Text = $"Fecha Ingreso: {DateTime.Now.ToString("g")}";
            this.listaArticulos = await this.CargarListaArticulos();
            this.ListaTransacciones = await this.inventarioService.ListaTransaccionesInventario();
            this.CargarDatosInciales();
            AutoCompleteArt();
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

        private async Task CargarCliente(string identificacion)
        {
            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show(
                    "Debe ingresar una identificación válida.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                pro = new ProgressBar();
                pro.Show();

                ClienteDTO cliente = await this.clienteService.ObtenerClienteCI(
                    identificacion.Trim());

                if (cliente is null)
                {
                    MessageBox.Show(
                        "No se encontró ningún cliente con la identificación ingresada.",
                        "Cliente no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                this.txtNombreCliente.Text = cliente.Nombres ?? string.Empty;
                this.txtTelefono.Text = cliente.Telefono ?? string.Empty;
                this.txtEmail.Text = cliente.Mail ?? string.Empty;

                this.txtDireccionCliente.Text =
                    $"Dirección: {cliente.DireccionDto?.Descripcion ?? string.Empty}, " +
                    $"Ciudad: {cliente.DireccionDto?.Ciudad?.Nombre ?? string.Empty}";

                this.idCliente = cliente.Id;
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
                this.txtIdentificaconCliente.Clear();
            }
            finally
            {
                pro?.Hide();
                pro?.Dispose();
                pro = null;
            }
        }

        private async void txtIdentificaconCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;

            string identificacion = this.txtIdentificaconCliente.Text.Trim();

            await CargarCliente(identificacion);
        }



        private List<ArticuloInventarioDTO> BuscarNombreArticulo(string pNom)
        {
            listaTemp = new List<ArticuloInventarioDTO>();
            listaTemp = this.listaArticulos.ToList();
            return listaTemp.Where(art => art.Articulo.Nombre.Contains(pNom)).ToList();
        }

        private void AutoCompleteArt()
        {
            AutoCompleteStringCollection colArticulo = new AutoCompleteStringCollection();
            List<ArticuloInventarioDTO> listaArticuloAuto = BuscarNombreArticulo(this.txtArticuloBusqueda.Text);
            foreach (ArticuloInventarioDTO art in listaArticuloAuto)
            {
                colArticulo.Add(art.Articulo.Nombre);
            }
            this.txtArticuloBusqueda.AutoCompleteCustomSource = colArticulo;
            this.txtArticuloBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtArticuloBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BusquedaArticulo()
        {
            string query = this.txtArticuloBusqueda?.Text?.Trim() ?? string.Empty;
            ArticuloInventarioDTO articuloActual = null;
            int temp = 0;
            // Primero intentar buscar por código (string) sin depender de TryParse
            articuloActual = this.listaArticulos.FirstOrDefault(art => art.Codigo != null && art.Codigo.Equals(query, StringComparison.OrdinalIgnoreCase));
            // Si no se encuentra por código, intentar buscar por Id si la entrada es numérica
            if (articuloActual == null && int.TryParse(query, out temp))
            {
                articuloActual = this.listaArticulos.FirstOrDefault(art => art.Articulo.Id == temp);
            }
            // Finalmente, intentar buscar por nombre (comparación exacta, insensible a mayúsculas)
            if (articuloActual == null)
            {
                articuloActual = this.listaArticulos.FirstOrDefault(art => art.Articulo.Nombre != null && art.Articulo.Nombre.Equals(query, StringComparison.OrdinalIgnoreCase) || art.NumeroLote.Equals(query, StringComparison.OrdinalIgnoreCase));
            }
            if (articuloActual is null || articuloActual.Articulo.Id == 0)
            {
                MessageBox.Show("No se encontro ningun artículo con el nombre o código ingresado!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtArticuloBusqueda.Text = "";
            }
            else
            {
                bool resp = this.ComprobarArticuloDgv(articuloActual);
                if (resp)
                {
                    foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
                    {
                        if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == articuloActual.Articulo.Id && row.Cells["Lote"].Value != null && row.Cells["Lote"].Value.ToString() == articuloActual.NumeroLote)
                        {
                            row.Cells["Cantidad"].Value = Convert.ToInt32(row.Cells["Cantidad"].Value) + 1;
                            //this.ActualizarCantidad(articuloActual.Articulo.Id, Convert.ToInt32(row.Cells["Cantidad"].Value), Convert.ToDecimal(row.Cells["ValorVenta"].Value));
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

        private void CargarDataGrid(ArticuloInventarioDTO articuloActual)
        {
            /*var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(articuloActual.Articulo.ImpuestoArticuloDto.Nombre));
            if (existente != null)
            {
                existente[articuloActual.Articulo.ImpuestoArticuloDto.Nombre].Add(new ImpuestoArticuloCalculadoDTO
                {
                    NombreImpuesto = articuloActual.Articulo.ImpuestoArticuloDto.Nombre,
                    IdArticulo = articuloActual.Articulo.Id,
                    ValorImpuesto = articuloActual.Articulo.ImpuestoArticuloDto.ValorImpuesto,
                    ValorVenta = articuloActual.Articulo.ValorVenta,
                    Id = contador,
                    Cantidad = cant
                });
            }
            else
            {
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
                {
                    { articuloActual.Articulo.ImpuestoArticuloDto.Nombre, new List<ImpuestoArticuloCalculadoDTO>
                        {
                            new ImpuestoArticuloCalculadoDTO
                            {
                                NombreImpuesto = articuloActual.Articulo.ImpuestoArticuloDto.Nombre,
                                IdArticulo = articuloActual.Articulo.Id,
                                ValorImpuesto = articuloActual.Articulo.ImpuestoArticuloDto.ValorImpuesto,
                                ValorVenta = articuloActual.Articulo.ValorVenta,
                                Id = contador,
                                Cantidad = cant
                            }
                        }
                    }
                });
            }*/
            int index = this.dgvDetallesVenta.Rows.Add(new object[] {
                contador,
                0,
                articuloActual.NumeroLote,
                articuloActual.Codigo,
                articuloActual.Articulo.Id,
                articuloActual.Articulo.Nombre,
                articuloActual.Articulo.Descripcion,
                cant,
                articuloActual.Articulo.ValorCompra,
                articuloActual.Articulo.ValorVenta,
                0,
            });

            DataGridViewRow fila = this.dgvDetallesVenta.Rows[index];
            DataGridViewCell celdaContador = fila.Cells[0];
            fila.Cells[10].Value = articuloActual.Articulo.ValorVenta * Convert.ToInt32(fila.Cells[7].Value);
            contador++;
            this.CalcularTotales();
        }

        private void LimpiarValores()
        {
            this.imp = 0;
            this.txtArticuloBusqueda.Text = "";
        }
        private void CalcularTotales()
        {
            this.TotalGeneral = 0;
            //this.dgvTotales.Rows.Clear();
            foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
            {
                this.TotalGeneral += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
            }

            this.txtTotal.Text = this.TotalGeneral.ToString();
            this.TotalGeneral = 0m;
        }

        /*private void ActualizarCantidad(int idArticulo, decimal cantidad, decimal valorVenta)
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
        }*/

        private bool ComprobarArticuloDgv(ArticuloInventarioDTO articuloInventario)
        {
            foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
            {
                if (row.Cells["IdArticulo"].Value != null && Convert.ToInt32(row.Cells["IdArticulo"].Value) == articuloInventario.IdArticulo && row.Cells["Lote"].Value != null && row.Cells["Lote"].Value.ToString() == articuloInventario.NumeroLote && row.Cells["Codigo"].Value.ToString() == articuloInventario.Codigo)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private async Task<List<ArticuloInventarioDTO>> CargarListaArticulos()
        {
            List<ArticuloInventarioDTO> listaArticulos;
            listaArticulos = await this.articuloService.ListarTodosArticulos(true);
            if (listaArticulos is null || listaArticulos.Count == 0)
            {
                MessageBox.Show("No se encontraron articulos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("No se encontraron articulos en el sistema");
            }
            return listaArticulos;
        }

        private async void GenerarReporteVenta(int idVenta)
        {
            DialogResult respuesta = MessageBox.Show(
                    $"Quiere generar el PDF de la venta?",
                    "Confirmar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
            if (respuesta == DialogResult.OK)
            {
                pro = new ProgressBar();
                Show();
                var ventaActual = new VentaDTO();
                ventaActual = await this.CargarVentaActual(idVenta);
                Hide();
                MessageBox.Show($"Reporte Generado!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ImprimirVenta(ventaActual);
            }
        }

        private void ImprimirVenta(VentaDTO ventaActual)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = $"Venta_{ventaActual.Id}_{ventaActual.Cliente.Nombres}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";

            // El recurso repote_venta está guardado como byte[] en Resources -> convertir a string usando UTF8
            

            if (guardar.ShowDialog() == DialogResult.OK) {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {

                using (PdfWriter writer = new PdfWriter(stream))
                using (PdfDocument pdf = new PdfDocument(writer))
                using (Document doc = new Document(pdf, PageSize.A4))
                {
                    // Ajustar márgenes si se desea ocupar todo el ancho de la hoja
                    doc.SetMargins(10f, 10f, 10f, 10f);
                        //Encabezado
                        doc.Add(new Paragraph("______________________________________FACTURA______________________________________"))
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(12);
                        // Encabezado: Datos tienda (izquierda) y Datos SRI (derecha) en el mismo nivel
                        // Crear la tabla del encabezado con anchos relativos usando CreatePercentArray
                        Table headerTable = new Table(UnitValue.CreatePercentArray(new float[] { 50f, 50f }))
                            .SetWidth(UnitValue.CreatePercentValue(100));

                        Cell leftCell = new Cell();
                        leftCell.Add(new Paragraph("Tabacundo barrio 18 de Septiembre").SetFontSize(12));
                        leftCell.Add(new Paragraph("Pedro Moncayo - Ecuador").SetFontSize(12));
                        leftCell.Add(new Paragraph($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}"));
                        leftCell.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                        leftCell.SetTextAlignment(TextAlignment.LEFT);

                        Cell rightCell = new Cell();
                        rightCell.Add(new Paragraph($"Venta: {ventaActual.Id}").SetFontSize(12));
                        rightCell.Add(new Paragraph($"RUC/CI: 1700000000000").SetFontSize(12));
                        rightCell.SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                        rightCell.SetTextAlignment(TextAlignment.RIGHT);

                        headerTable.AddCell(leftCell);
                        headerTable.AddCell(rightCell);

                        doc.Add(headerTable);

                        //Datos CLiente
                        doc.Add(new Paragraph($"--------------------------------------------------------------------------------------------------------------------")).SetTextAlignment(TextAlignment.LEFT);
                        doc.Add(new Paragraph($"Cliente: {ventaActual.Cliente.Nombres} {ventaActual.Cliente.Apellidos}")).SetTextAlignment(TextAlignment.LEFT);
                        doc.Add(new Paragraph($"Direccion: {ventaActual.Cliente.DireccionDto.Descripcion}"));
                        doc.Add(new Paragraph($"Telefono: {ventaActual.Cliente.Telefono}"));
                        doc.Add(new Paragraph("\n"));

                        //Tabla de productos
                        // Definir anchos relativos por columna usando constructor con percent array
                        // Evitar el uso de SetWidths (crea problemas en algunas versiones), usar el constructor y establecer el ancho total
                        Table tabla = new Table(UnitValue.CreatePercentArray(new float[] { 10f, 50f, 10f, 15f, 15f }))
                            .SetWidth(UnitValue.CreatePercentValue(100));
                        // Mantener centrada si aplica visualmente (aunque al 100% ocupará todo el ancho disponible)
                        tabla.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        tabla.AddHeaderCell("Nro.");
                        tabla.AddHeaderCell("Producto");
                        tabla.AddHeaderCell("Cantidad");
                        tabla.AddHeaderCell("Precio Unitario");
                        tabla.AddHeaderCell("Total");
                        decimal totalVenta = 0;
                        int contador = 1;
                        foreach (var detalle in ventaActual.DetalleVenta)
                        {
                            totalVenta += detalle.Cantidad * detalle.ValorVenta;
                            tabla.AddCell( Convert.ToString(contador));
                            tabla.AddCell(detalle.Articulo.Nombre);
                            tabla.AddCell(detalle.Cantidad.ToString());
                            tabla.AddCell(detalle.ValorVenta.ToString("C"));
                            tabla.AddCell((detalle.Cantidad * detalle.ValorVenta).ToString("C"));
                            contador++;
                        }

                        doc.Add(tabla);
                        doc.Add(new Paragraph("\n"));

                        // Calcular subtotal e impuestos agrupados por tipo (usar Articulo.ImpuestoArticuloDto como multiplicador 0.12/0.15)
                        
                       

                        // Crear tabla de totales (dos columnas) y alinearla a la derecha
                        Table totalsTable = new Table(UnitValue.CreatePercentArray(new float[] { 70f, 30f }))
                            .SetWidth(UnitValue.CreatePercentValue(40));
                        totalsTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);

                        // Fila Subtotal
                        totalsTable.AddCell(new Cell().Add(new Paragraph("Total")).SetBorder(iText.Layout.Borders.Border.NO_BORDER));
                        totalsTable.AddCell(new Cell().Add(new Paragraph(totalVenta.ToString("C"))).SetBorder(iText.Layout.Borders.Border.NO_BORDER).SetTextAlignment(TextAlignment.RIGHT));

                        // Filas por cada impuesto agrupado
                        doc.Add(totalsTable);

                        // Pie de página
                        doc.Add(new Paragraph("\nGracias por su compra.")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10));
                    }
                }
            }
        }

        private async Task<VentaDTO> CargarVentaActual(int idVenta)
        {
            VentaDTO ventaActual = new VentaDTO();
            ventaActual = await this._ventaService.ObtenerVenta(idVenta);
            return ventaActual;
        }
        private async Task<int> CrearVenta()
        {
            try
            {
                int idVenta = 0;
                VentaCreacionDTO ventaCreacionDTO = new VentaCreacionDTO();
                ventaCreacionDTO.IdCliente = this.idCliente; // Reemplazar con el ID real del proveedor
                ventaCreacionDTO.FechaCompra = this.dtpVenta.Value;
                ventaCreacionDTO.IdEstado = Convert.ToInt32(this.cbxEstadosVenta.SelectedValue); // Estado "Pendiente" por defecto
                ventaCreacionDTO.EstadoVisual = true; // Estado visual "Activo" por defecto
                ventaCreacionDTO.UsuarioCreadorId = this.Sesion.Id; // Reemplazar con el ID real del usuario creador
                ventaCreacionDTO.DetalleVentaCreacionDto = new List<DetalleVentaCreacionDTO>();
                ventaCreacionDTO.IdTransaccion = this.ListaTransacciones.FirstOrDefault(t => t.Nombre.ToUpper() == "VENTA").Id;
                foreach (DataGridViewRow row in dgvDetallesVenta.Rows)
                {
                    if (row.IsNewRow) continue; // Saltar la fila nueva
                    DetalleVentaCreacionDTO detalle = new DetalleVentaCreacionDTO
                    {
                       
                        IdArticulo = Convert.ToInt32(row.Cells["IdArticulo"].Value),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        ValorCompra = Convert.ToDecimal(row.Cells["ValorCompra"].Value),
                        ValorVenta = Convert.ToDecimal(row.Cells["ValorVenta"].Value),
                        ImpuestoValor = 0,
                        ValotTotal = Convert.ToDecimal(row.Cells["ValorTotal"].Value),
                        Descripcion = row.Cells["Descripcion"].Value?.ToString().ToUpper(),
                       
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

        private async void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            VerificacionFechas(sender, e);
        }

        private async void VerificacionFechas(object sender, EventArgs e)
        {
            try
            {
                // Verificar existencia de los controles
                if (this.dtpFechaInicio == null || this.dtpFechaFin == null)
                    return;

                DateTimePicker picker = sender as DateTimePicker;
                if (picker == null || (picker.ShowCheckBox && !picker.Checked))
                    return;

                // Validar rango de fechas
                if (dtpFechaInicio.Value > dtpFechaFin.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.",
                                    "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener y mostrar las ventas filtradas
                pro = new ProgressBar();
                pro.Show();
                List<VentaMinDTO> listaVentas = await this.listarVentasCreadas();
                pro.Hide();
                this.CargarTablaVentasCreadas(listaVentas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar fechas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void CargarTablaVentasCreadas(List<VentaMinDTO> listaVentas)
        {
            this.dgvVentas.Rows.Clear();
            foreach (var venta in listaVentas)
            {
                int index = this.dgvVentas.Rows.Add(new object[]
                {
                    venta.Id,
                    venta.FechaVenta.ToString("dd/MM/yyyy"),
                    venta.ClienteMinDTO.Id,
                    venta.ClienteMinDTO.Nombres,
                    venta.FechaModificacion?.ToString("dd/MM/yyyy"),
                    venta.EstadoVentaDTO.Id,
                    venta.EstadoVentaDTO.Nombre,
                    venta.Documento,
                    venta.UsuarioMinDTO.Nombres,
                });
            }
        }

        private async Task<List<VentaMinDTO>> listarVentasCreadas()
        {
            DateOnly fechaIni = DateOnly.FromDateTime(this.dtpFechaInicio.Value);
            DateOnly fechaFin = DateOnly.FromDateTime(this.dtpFechaFin.Value);

            List<VentaMinDTO> listaVentas = await this._ventaService.ListarVenta(fechaIni, fechaFin);

            return listaVentas;
        }

        private async void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            VerificacionFechas(sender, e);
        }


        private async void ObtenerVenta(int idVenta)
        {
            var venta = await this._ventaService.ObtenerVenta(idVenta);
            this.idCliente = venta.IdCliente;
            this.txtIdentificaconCliente.Text = venta.Cliente.Identificacion;
            this.txtIdVenta.Text = Convert.ToString(venta.Id);
            this.txtNombreCliente.Text = venta.Cliente.Nombres;
            this.txtTelefono.Text = venta.Cliente.Telefono;
            this.txtDireccionCliente.Text = $"Dirección: {venta.Cliente.DireccionDto.Descripcion}, Ciudad:{venta.Cliente.DireccionDto.Ciudad.Nombre}";
            this.txtDocumento.Text = venta.Documento;
            this.dtpVenta.Value = venta.FechaVenta;
            this.cbxEstadosVenta.SelectedValue = venta.IdEstado;
            this.dgvDetallesVenta.Rows.Clear();
            this.listaImpuestos.Clear();
            ArticuloDTO articuloActual = new ArticuloDTO();
            foreach (var detalle in venta.DetalleVenta)
            {
                int index = this.dgvDetallesVenta.Rows.Add(new object[] {
                    detalle.Id,
                    detalle.IdVenta,
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

        private void CargarListaImpuestos(DetalleVentaDTO detalle)
        {
            // Si ya existe un diccionario para este tipo de impuesto, agregar al listado; si no, crear uno nuevo
            string nombreImpuesto = detalle.Articulo?.ImpuestoArticuloDto?.Nombre ?? "SIN_IMPUESTO";
            var existente = listaImpuestos.FirstOrDefault(dic => dic.ContainsKey(nombreImpuesto));
            var nuevoImpuesto = new ImpuestoArticuloCalculadoDTO
            {
                NombreImpuesto = nombreImpuesto,
                IdArticulo = detalle.Articulo.Id,
                ValorImpuesto = detalle.Articulo.ImpuestoArticuloDto.ValorImpuesto,
                ValorVenta = detalle.ValorVenta,
                Id = detalle.Id,
                Cantidad = detalle.Cantidad
            };

            if (existente != null)
            {
                existente[nombreImpuesto].Add(nuevoImpuesto);
            }
            else
            {
                listaImpuestos.Add(new Dictionary<string, List<ImpuestoArticuloCalculadoDTO>>
                {
                    { nombreImpuesto, new List<ImpuestoArticuloCalculadoDTO> { nuevoImpuesto } }
                });
            }
        }
        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            this.txtIdVenta.Text = "";
            this.txtIdentificaconCliente.Text = "";
            this.txtEmail.Text = "";
            this.txtDocumento.Text = "";
            this.txtDireccionCliente.Text = "";
            this.txtNombreCliente.Text = "";
            this.txtTelefono.Text = "";
            this.dgvDetallesVenta = new DataGridView();
            this.contador = 0;
            this.TotalGeneral = 0m;
            this.listaImpuestos.Clear();
            this.dgvTotales = new DataGridView();
            this.txtTotal.Text = "0";
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            IClienteService clienteService = this.clienteService;
            IMapeosClientes mapeos = new MapeosClientes();
            IProveedorService proveedorService = this.proveedorService;
            Cliente clienteForm = new Cliente(clienteService, mapeos, proveedorService);
            clienteForm.StartPosition = FormStartPosition.CenterScreen;
            clienteForm.Show();
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

        private async void btnRecargarConfiguraciones_Click(object sender, EventArgs e)
        {
            this.CargarDatosInciales();
            this.listaArticulos = new List<ArticuloInventarioDTO>();
            this.listaArticulos = await this.CargarListaArticulos();
        }

        private void dgvVentas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvVentas.Columns[e.ColumnIndex].Name == "Editar")
                {
                    id = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value);
                    this.ObtenerVenta(id);
                }
                else if (dgvVentas.Columns[e.ColumnIndex].Name == "Imprimir")
                {
                    id = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["IdVenta"].Value);
                    this.GenerarReporteVenta(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void dgvDetallesVenta_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                textBox.KeyPress -= textBox_KeyPress;
                textBox.KeyPress -= textBox_KeyPressPunto;
                switch (dgvDetallesVenta.Columns[dgvDetallesVenta.CurrentCell.ColumnIndex].Name)
                {
                    case "ValorVenta":
                        textBox.KeyPress += textBox_KeyPress; // solo números y decimal
                        break;

                    case "Cantidad":
                        textBox.KeyPress += textBox_KeyPressPunto; // solo números enteros
                        break;

                    case "Descripcion":
                        break;
                    default:
                        // Para cualquier otra columna, también permitimos texto libre
                        break;
                }
            }
        }

        private void dgvDetallesVenta_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            decimal cantida;
            decimal valorVenta;
            if (dgvDetallesVenta.Columns[e.ColumnIndex].Name == "Cantidad" || dgvDetallesVenta.Columns[e.ColumnIndex].Name == "ValorVenta")
            {

                DataGridViewRow fila = dgvDetallesVenta.Rows[e.RowIndex];
                if (decimal.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantida) && decimal.TryParse(fila.Cells["ValorVenta"].Value?.ToString(), out valorVenta))
                {
                    fila.Cells["ValorTotal"].Value = cantida * valorVenta;
                    //this.ActualizarCantidad(Convert.ToInt32(fila.Cells["IdArticulo"].Value), Convert.ToDecimal(fila.Cells["Cantidad"].Value), Convert.ToDecimal(fila.Cells["ValorVenta"].Value));
                    this.CalcularTotales();
                }
            }
            this.imp = 0;
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


        private void dgvDetallesVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvDetallesVenta.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    EliminarImpuestoPorId(Convert.ToInt32(dgvDetallesVenta.Rows[e.RowIndex].Cells["Id"].Value));
                    dgvDetallesVenta.Rows.RemoveAt(e.RowIndex);
                    this.CalcularTotales();
                }
            }
            catch
            {
                throw;
            }
        }

        private async void btnInventario_Click(object sender, EventArgs e)
        {
            Show();
            var listaExistencias = await this.ProcesarExistencias();
            Hide();
            this.CargarVentanaExistencias(listaExistencias);

        }

        private void CargarVentanaExistencias(List<InventarioLoteDTO> listaExistencias)
        {
            Existencias existenciaForm = new Existencias(listaExistencias);
            existenciaForm.StartPosition = FormStartPosition.CenterScreen;
            existenciaForm.Show();
        }

        private async Task<List<InventarioLoteDTO>> ProcesarExistencias()
        {
            
            var ListaExistenciasArticulos = await this.inventarioService.ExistenciasInventario(true);
            return ListaExistenciasArticulos;
        }

        public void Show()
        {
            pro = new ProgressBar();
            pro.Show();
        }
        public void Hide()
        {
            if (pro != null) pro.Close();
        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido "ding"
                if (!string.IsNullOrWhiteSpace(this.txtPago.Text))
                {
                    this.CalcularCambio();
                }
            }
        }

        private void CalcularCambio()
        {
            this.txtTotal.Text = string.IsNullOrWhiteSpace(this.txtTotal.Text) ? "0" : this.txtTotal.Text;
            var valorSinTrans = Convert.ToDecimal(this.txtTotal.Text) - Convert.ToDecimal(this.txtPago.Text);
            if(valorSinTrans < 0)
            {
                valorSinTrans = valorSinTrans * -1;
            }
            this.txtCambio.Text = Convert.ToString(valorSinTrans);
        }

        private async void btnRecargarArticulos_Click_1(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                    $"Se recargarán los articulos de venta, Desea continuar?",
                    "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
            if (respuesta == DialogResult.OK)
            {
                pro = new ProgressBar();
                Show();
                this.listaArticulos = new List<ArticuloInventarioDTO>();
                this.listaArticulos = await this.CargarListaArticulos();
                this.listaTemp = new List<ArticuloInventarioDTO>();
                this.listaTemp = this.listaArticulos.ToList();
                this.AutoCompleteArt();
                Hide();
                MessageBox.Show($"Artículos recargados!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnGuardar_Click_1(object sender, EventArgs e)
        {
            var resp = 0;
            var respEditar = false;
            if (this.txtIdVenta is null || this.txtIdVenta.Text == "")
            {
                resp = await this.CrearVenta();
                if (resp == 0) MessageBox.Show("No se pudo crear la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int idVenta = resp;
                    MessageBox.Show($"Venta creada con éxito con el ID: {idVenta}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.GenerarReporteVenta(idVenta);

                }
                this.LimpiarValores();
                this.LimpiarFormulario();
            }
        }
    }
}
