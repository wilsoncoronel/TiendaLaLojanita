using FluentValidation.Results;
using System.ComponentModel;
using System.Globalization;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Services;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Ajustes_Inventario : Form
    {
        private sealed class ImpuestoAjusteMemoria
        {
            public int IdImpuesto { get; init; }
            public string Nombre { get; init; } = string.Empty;
            public int IdTipoCalculo { get; init; }
            public decimal Valor { get; init; }
            public TipoImpuestoDTO TipoImpuesto { get; init; } = null!;
        }

        private sealed class DetalleAjusteMemoria
        {
            public int IdArticulo { get; init; }
            public int IdLote { get; init; }
            public string Lote { get; init; } = string.Empty;
            public string Codigo { get; init; } = string.Empty;
            public string NombreArticulo { get; init; } = string.Empty;
            public decimal CostoUnitario { get; init; }
            public int Cantidad { get; set; }
            public DateOnly? FechaExpiracion { get; init; }
            public List<ImpuestoAjusteMemoria> Impuestos { get; init; } = new();
        }

        private List<TransaccionInventarioDTO> ListaTransacciones;
        public List<EstadosAjusteDTO> ListaEstadosAjuste;
        private readonly IInventarioService _inventarioService;
        private AjusteInventarioCrearDTO AjusteInventarioCrear;
        private List<ArticuloVentaDTO> ListaArticulosInventario;
        private readonly int IdUsuario;
        private readonly IArticuloService articuloService;
        private readonly List<DetalleAjusteMemoria> detallesAjuste;
        private int versionCarga;
        private bool ajusteCargadoDesdeBd;

        public Registro_Ajustes_Inventario(IInventarioService inventarioService, int IdUsuario, IArticuloService articuloService)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            this.IdUsuario = IdUsuario;
            this.articuloService = articuloService;
            ListaEstadosAjuste = new List<EstadosAjusteDTO>();
            ListaTransacciones = new List<TransaccionInventarioDTO>();
            this.ListaArticulosInventario = new List<ArticuloVentaDTO>();
            this.detallesAjuste = new List<DetalleAjusteMemoria>();

            this.dtpInicio.ValueChanged += async (s, e) => await this.CargarAjustes();
            this.dtpFinal.ValueChanged += async (s, e) => await this.CargarAjustes();
            this.dgvAjustes.CellContentClick += async (s, e) => await this.AccionAjuste(e);
            this.btnBuscarArticulo.Click += async (s, e) => await this.AgregarArticuloDesdeBusqueda();
            this.dgvDetallesAjuste.CellContentClick += this.dgvDetallesAjuste_CellContentClick;
            this.dgvDetallesAjuste.CellEndEdit += this.dgvDetallesAjuste_CellEndEdit;
            this.btnCancelar.Click += btnCancelar_Click;
        }

        private void AutoCompleteArt()
        {
            AutoCompleteStringCollection colArticulo = new AutoCompleteStringCollection();
            var valoresAgregados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (ArticuloVentaDTO art in this.ListaArticulosInventario)
            {
                foreach (var valor in new[] { art.Nombre, art.Codigo, art.Lote })
                {
                    if (!string.IsNullOrWhiteSpace(valor) && valoresAgregados.Add(valor))
                    {
                        colArticulo.Add(valor);
                    }
                }
            }

            this.txtArticuloBusqueda.AutoCompleteCustomSource = null;
            this.txtArticuloBusqueda.AutoCompleteCustomSource = colArticulo;
            this.txtArticuloBusqueda.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtArticuloBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async Task CargarAjustes()
        {
            if (dtpInicio.Value.Date > dtpFinal.Value.Date)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var version = ++versionCarga;
            var progreso = new ProgressBar();
            progreso.Show(this);
            try
            {
                var ajustes = await _inventarioService.ListarAjusteInventarioFechas(DateOnly.FromDateTime(dtpInicio.Value), DateOnly.FromDateTime(dtpFinal.Value));
                if (version != versionCarga)
                {
                    return;
                }

                ajustes ??= new List<AjusteInventarioDTO>();
                dgvAjustes.Rows.Clear();
                if (ajustes.Count == 0)
                {
                    MessageBox.Show("No se encontraron ajustes en el rango de fechas seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var ajuste in ajustes)
                {
                    dgvAjustes.Rows.Add(
                        ajuste.Id,
                        ajuste.IdTransaccion,
                        ajuste.transaccionInventarioDTO?.Nombre,
                        ajuste.UsuarioDTO != null ? $"{ajuste.UsuarioDTO.Nombres} {ajuste.UsuarioDTO.Apellidos}" : null,
                        ajuste.Motivo,
                        ajuste.FechaCreacion.ToString("dd/MM/yyyy"),
                        ajuste.IdEstado,
                        ajuste.EstadosAjusteDTO?.Nombre,
                        ajuste.FechaReversion?.ToString("dd/MM/yyyy"),
                        null,
                        null);
                }

                MessageBox.Show($"Se han cargado {ajustes.Count} ajustes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los ajustes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progreso.Close();
                progreso.Dispose();
            }
        }

        private async Task AccionAjuste(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvAjustes.Columns[e.ColumnIndex].Name != "Reversar")
            {
                return;
            }

            var idAjuste = Convert.ToInt32(dgvAjustes.Rows[e.RowIndex].Cells["IdAjsute"].Value);
            if (!ConfirmaAccion($"¿Desea reversar el ajuste con ID: {idAjuste}?"))
            {
                return;
            }

            dgvAjustes.Enabled = false;
            var progreso = new ProgressBar();
            progreso.Show(this);
            try
            {
                var reversado = await ReversarAjuste(idAjuste);
                if (!reversado)
                {
                    MessageBox.Show("No se pudo reversar el ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await CargarAjustes();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al reversar el ajuste: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progreso.Close();
                progreso.Dispose();
                dgvAjustes.Enabled = true;
            }
        }

        private async Task CargarAjusteCompleto(int idAjuste)
        {
            if (idAjuste <= 0)
            {
                return;
            }

            var progreso = new ProgressBar();
            progreso.Show(this);
            try
            {
                var ajuste = await this._inventarioService.ListarAjusteInventarioCompleto(idAjuste);
                if (ajuste == null)
                {
                    MessageBox.Show("No se encontró el ajuste seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var articulosInventario = await this._inventarioService.ListaArticulosInventario();
                var detallesCargados = new List<DetalleAjusteMemoria>();
                foreach (var detalle in ajuste.Detalles ?? new List<DetalleAjusteInventarioCompletoDTO>())
                {
                    var articulo = articulosInventario?.FirstOrDefault(item => item.IdLote == detalle.IdLote);
                    if (articulo == null)
                    {
                        throw new InvalidOperationException($"No se encontró información del lote {detalle.IdLote}.");
                    }

                    var detalleMemoria = new DetalleAjusteMemoria
                    {
                        IdArticulo = articulo.IdArticulo,
                        IdLote = articulo.IdLote,
                        Lote = articulo.NumeroLote ?? string.Empty,
                        Codigo = articulo.Codigo ?? string.Empty,
                        NombreArticulo = string.IsNullOrWhiteSpace(articulo.NombreArticulo)
                            ? articulo.NombreCompuesto
                            : articulo.NombreArticulo,
                        CostoUnitario = detalle.CostoUnitario,
                        Cantidad = detalle.Cantidad,
                        FechaExpiracion = articulo.FechaExpiracion,
                        Impuestos = await this.CargarImpuestosMemoria(articulo)
                    };

                    detallesCargados.Add(detalleMemoria);
                }

                this.LimpiarFormulario();
                this.txtIdAjuste.Text = ajuste.Id.ToString();
                this.txtMotivoAjuste.Text = ajuste.Motivo;
                this.dtpFechaCreacion.Value = ajuste.FechaCreacion;
                this.dtpFechaReversion.Value = ajuste.FechaReversion ?? DateTime.Now;
                this.cbxEstadoAjuste.SelectedValue = ajuste.IdEstado;
                this.cbxTransaccionAjuste.SelectedValue = ajuste.IdTransaccion;
                this.detallesAjuste.AddRange(detallesCargados);

                foreach (var detalle in detallesCargados)
                {
                    this.AgregarFila(detalle);
                }

                this.CalcularTotalesDesdeArticulo();
                this.ConfigurarModoConsulta(true);
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el ajuste: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progreso.Close();
                progreso.Dispose();
            }
        }

        private async Task CargarListas()
        {
            ListaEstadosAjuste = await _inventarioService.ListaEstadosAjuste();
            ListaTransacciones = await _inventarioService.ListaTransaccionesInventario();

            cbxEstadoAjuste.DataSource = ListaEstadosAjuste;
            cbxEstadoAjuste.DisplayMember = "Nombre";
            cbxEstadoAjuste.ValueMember = "Id";

            cbxTransaccionAjuste.DataSource = ListaTransacciones
                .Where(t => t.Nombre.Equals("Merma", StringComparison.OrdinalIgnoreCase)
                    || t.Nombre.Equals("Reversion Ajuste", StringComparison.OrdinalIgnoreCase)
                    || t.Nombre.Equals("Ajuste Entrada", StringComparison.OrdinalIgnoreCase)
                    || t.Nombre.Equals("Ajuste Salida", StringComparison.OrdinalIgnoreCase))
                .ToList();
            cbxTransaccionAjuste.DisplayMember = "Nombre";
            cbxTransaccionAjuste.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.CrearAjuste();
        }

        private async Task<int> CrearAjuste()
        {
            var resp = 0;
            if (this.ajusteCargadoDesdeBd)
            {
                return resp;
            }

            if (this.txtIdAjuste is null || this.txtIdAjuste.Text == "")
            {
                var ajuste = this.CargarAjusteInventario();
                if (ajuste == null)
                {
                    return 0;
                }

                resp = await this._inventarioService.CrearAjusteInventario(ajuste);
                if (resp == 0)
                {
                    MessageBox.Show("No se pudo crear el ajuste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.LimpiarFormulario();
                }
            }

            return resp;
        }

        private AjusteInventarioCrearDTO? CargarAjusteInventario()
        {
            this.SincronizarDetallesDesdeGrilla();

            AjusteInventarioCrear = new AjusteInventarioCrearDTO();
            AjusteInventarioCrear.IdUsuarioCreador = this.IdUsuario;
            AjusteInventarioCrear.IdEstado = (int)this.cbxEstadoAjuste.SelectedValue;
            AjusteInventarioCrear.IdTransaccion = (int)this.cbxTransaccionAjuste.SelectedValue;
            AjusteInventarioCrear.Motivo = this.txtMotivoAjuste.Text.ToUpperInvariant();
            AjusteInventarioCrear.Detalles = this.detallesAjuste
                .Select(detalle => new DetalleAjusteInventarioCrearDTO
                {
                    IdLote = detalle.IdLote,
                    Cantidad = detalle.Cantidad,
                    CostoUnitario = detalle.CostoUnitario,
                    Estado = true
                })
                .ToList();

            var validator = new AjusteCrearValidator();
            ValidationResult result = validator.Validate(AjusteInventarioCrear);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return null;
            }

            return AjusteInventarioCrear;
        }

        private void RecorrerErrores(ValidationResult result)
        {
            if (result.Errors.Count > 1)
            {
                MessageBox.Show("Error de Validación, hay campos obligatorios vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, $"Error de Validación, {error.PropertyName}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<bool> ReversarAjuste(int IdAjuste)
        {
            if (IdAjuste == 0)
            {
                return false;
            }

            var resp = await this._inventarioService.ReversarAjusteInventario(IdAjuste);
            return resp;
        }

        private bool ConfirmaAccion(string mensaje)
        {
            DialogResult respuesta = MessageBox.Show(
                mensaje,
                "Confirmar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            return respuesta == DialogResult.OK;
        }

        private void LimpiarFormulario()
        {
            this.txtIdAjuste.Text = "";
            this.txtMotivoAjuste.Text = "";
            this.cbxEstadoAjuste.SelectedIndex = 0;
            this.cbxTransaccionAjuste.SelectedIndex = 0;
            this.dgvDetallesAjuste.Rows.Clear();
            this.detallesAjuste.Clear();
            this.dgvImpuestos.Rows.Clear();
            this.txtTotales.Text = 0m.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
            this.LimpiarBusquedaArticulo();
            this.ConfigurarModoConsulta(false);
        }

        private void ConfigurarModoConsulta(bool soloLectura)
        {
            this.ajusteCargadoDesdeBd = soloLectura;
            this.txtMotivoAjuste.ReadOnly = soloLectura;
            this.cbxEstadoAjuste.Enabled = !soloLectura;
            this.cbxTransaccionAjuste.Enabled = !soloLectura;
            this.dtpFechaCreacion.Enabled = !soloLectura;
            this.dtpFechaReversion.Enabled = !soloLectura;
            this.btnGuardar.Enabled = !soloLectura;
            this.dgvDetallesAjuste.ReadOnly = soloLectura;
            this.HabilitarBusqueda(!soloLectura);
        }

        private async void Registro_Ajustes_Inventario_Load(object sender, EventArgs e)
        {
            this.HabilitarBusqueda(false);

            try
            {
                await this.CargarListas();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al cargar los catálogos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            try
            {
                this.ListaArticulosInventario = await this.CargarListaArticulos();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al cargar los artículos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            AutoCompleteArt();
            this.HabilitarBusqueda(true);
            this.txtTotales.Text = 0m.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
        }

        private async Task<List<ArticuloVentaDTO>> CargarListaArticulos()
        {
            var listaArticulos = await this.articuloService.ListaDevolucionArticulos();
            if (listaArticulos is null || listaArticulos.Count == 0)
            {
                MessageBox.Show("No se encontraron artículos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("No se encontraron artículos en el sistema");
            }

            return listaArticulos;
        }

        private void HabilitarBusqueda(bool habilitar)
        {
            this.txtArticuloBusqueda.Enabled = habilitar;
            this.btnBuscarArticulo.Enabled = habilitar;
        }

        private async void txtArticuloBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!string.IsNullOrWhiteSpace(txtArticuloBusqueda.Text))
                {
                    await this.AgregarArticuloDesdeBusqueda();
                }
            }
        }

        private async Task AgregarArticuloDesdeBusqueda()
        {
            string consulta = this.txtArticuloBusqueda.Text.Trim();
            if (string.IsNullOrWhiteSpace(consulta))
            {
                MessageBox.Show("Ingrese un nombre, código, lote o ID de artículo.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var articulo = this.ListaArticulosInventario.FirstOrDefault(item =>
                string.Equals(item.Nombre, consulta, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(item.Codigo, consulta, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(item.Lote, consulta, StringComparison.OrdinalIgnoreCase));

            if (articulo == null && int.TryParse(consulta, out int idArticulo))
            {
                articulo = this.ListaArticulosInventario.FirstOrDefault(item => item.Id == idArticulo);
            }

            if (articulo == null)
            {
                MessageBox.Show("No se encontró ningún artículo con el valor ingresado.", "Artículo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await this.AgregarArticulo(articulo);
        }

        private async Task AgregarArticulo(ArticuloVentaDTO articuloBusqueda)
        {
            try
            {
                var articuloInventarioList = await this._inventarioService.ListaArticulosInventario(idArticulo: articuloBusqueda.Id);
                if (articuloInventarioList == null || articuloInventarioList.Count == 0)
                {
                    MessageBox.Show("El artículo no tiene inventario disponible.", "Artículo no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ArticuloLoteInventarioDTO? articuloSeleccionado;
                if (articuloInventarioList.Count == 1)
                {
                    articuloSeleccionado = articuloInventarioList[0];
                }
                else
                {
                    using var selector = new ArticuloInventarioLote(articuloInventarioList);
                    selector.StartPosition = FormStartPosition.CenterParent;
                    if (selector.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    articuloSeleccionado = selector.ArticuloSeleccionado;
                }

                if (articuloSeleccionado == null)
                {
                    return;
                }

                await this.AgregarDetalleSeleccionado(articuloSeleccionado);
                this.LimpiarBusquedaArticulo();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AgregarDetalleSeleccionado(ArticuloLoteInventarioDTO articuloSeleccionado)
        {
            var codigo = articuloSeleccionado.Codigo ?? string.Empty;
            var lote = articuloSeleccionado.NumeroLote ?? string.Empty;

            var existente = this.detallesAjuste.FirstOrDefault(detalle =>
                detalle.IdArticulo == articuloSeleccionado.IdArticulo &&
                detalle.IdLote == articuloSeleccionado.IdLote &&
                string.Equals(detalle.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

            if (existente != null)
            {
                existente.Cantidad++;
                this.SincronizarFila(existente);
                this.CalcularTotalesDesdeArticulo();
                return;
            }

            var detalleNuevo = new DetalleAjusteMemoria
            {
                IdArticulo = articuloSeleccionado.IdArticulo,
                IdLote = articuloSeleccionado.IdLote,
                Lote = lote,
                Codigo = codigo,
                NombreArticulo = string.IsNullOrWhiteSpace(articuloSeleccionado.NombreArticulo)
                    ? articuloSeleccionado.NombreCompuesto
                    : articuloSeleccionado.NombreArticulo,
                CostoUnitario = articuloSeleccionado.PrecioCompra,
                Cantidad = 1,
                FechaExpiracion = articuloSeleccionado.FechaExpiracion,
                Impuestos = await this.CargarImpuestosMemoria(articuloSeleccionado)
            };

            this.detallesAjuste.Add(detalleNuevo);
            this.AgregarFila(detalleNuevo);
            this.CalcularTotalesDesdeArticulo();
        }

        private async Task<List<ImpuestoAjusteMemoria>> CargarImpuestosMemoria(ArticuloLoteInventarioDTO articuloSeleccionado)
        {
            var impuestosArticulo = await this.articuloService.ListaImpuestosArticuloId(articuloSeleccionado.IdArticulo);
            var tiposPorId = (impuestosArticulo ?? new List<ImpuestoDTO>())
                .Where(item => item != null)
                .GroupBy(item => item.Id)
                .ToDictionary(grupo => grupo.Key, grupo => grupo.First().TipoImpuestoDTO);

            return (articuloSeleccionado.Impuestos ?? new List<DetalleImpuestoDTO>())
                .Select(item => new ImpuestoAjusteMemoria
                {
                    IdImpuesto = item.IdImpuesto,
                    Nombre = item.Nombre,
                    IdTipoCalculo = item.IdTipoCalculo,
                    Valor = item.Valor,
                    TipoImpuesto = this.ResolverTipoImpuesto(item, tiposPorId)
                })
                .ToList();
        }

        private TipoImpuestoDTO ResolverTipoImpuesto(DetalleImpuestoDTO impuesto, Dictionary<int, TipoImpuestoDTO> tiposPorId)
        {
            if (tiposPorId.TryGetValue(impuesto.IdImpuesto, out TipoImpuestoDTO? tipo) && tipo != null)
            {
                return tipo;
            }

            return new TipoImpuestoDTO
            {
                Id = impuesto.IdTipoCalculo,
                TipoCalculo = impuesto.IdTipoCalculo == 1 ? "PORCENTAJE" : "UNIDAD",
                Estado = true,
                EstadoVisual = true
            };
        }

        private void AgregarFila(DetalleAjusteMemoria detalle)
        {
            var valorCompra = this.CalcularValorCompra(detalle);
            this.dgvDetallesAjuste.Rows.Add(
                detalle.IdArticulo,
                detalle.Lote,
                detalle.Codigo,
                detalle.NombreArticulo,
                detalle.FechaExpiracion.HasValue ? detalle.FechaExpiracion.Value.ToString("dd/MM/yyyy") : "N/A",
                detalle.Cantidad,
                valorCompra,
                null);
        }

        private void SincronizarFila(DetalleAjusteMemoria detalle)
        {
            foreach (DataGridViewRow row in this.dgvDetallesAjuste.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                if (Convert.ToInt32(row.Cells["Id"].Value ?? 0) != detalle.IdArticulo)
                {
                    continue;
                }

                if (!string.Equals(row.Cells["Lote"].Value?.ToString(), detalle.Lote, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (!string.Equals(row.Cells["Codigo"].Value?.ToString(), detalle.Codigo, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                row.Cells["Cantidad"].Value = detalle.Cantidad;
                row.Cells["ValorCompra"].Value = this.CalcularValorCompra(detalle);
                return;
            }
        }

        private decimal CalcularValorCompra(DetalleAjusteMemoria detalle)
        {
            return detalle.CostoUnitario * detalle.Cantidad;
        }

        private void ActualizarValoresCompraEnGrilla()
        {
            foreach (DataGridViewRow row in this.dgvDetallesAjuste.Rows)
            {
                if (row.IsNewRow ||
                    !int.TryParse(row.Cells["Id"].Value?.ToString(), out int idArticulo))
                {
                    continue;
                }

                string lote = row.Cells["Lote"].Value?.ToString() ?? string.Empty;
                string codigo = row.Cells["Codigo"].Value?.ToString() ?? string.Empty;

                var detalle = this.detallesAjuste.FirstOrDefault(item =>
                    item.IdArticulo == idArticulo &&
                    string.Equals(item.Lote, lote, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

                if (detalle != null)
                {
                    row.Cells["ValorCompra"].Value = this.CalcularValorCompra(detalle);
                }
            }
        }

        private void SincronizarDetallesDesdeGrilla()
        {
            foreach (DataGridViewRow row in this.dgvDetallesAjuste.Rows)
            {
                if (row.IsNewRow ||
                    !int.TryParse(row.Cells["Id"].Value?.ToString(), out int idArticulo) ||
                    !int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad))
                {
                    continue;
                }

                string lote = row.Cells["Lote"].Value?.ToString() ?? string.Empty;
                string codigo = row.Cells["Codigo"].Value?.ToString() ?? string.Empty;

                var detalle = this.detallesAjuste.FirstOrDefault(item =>
                    item.IdArticulo == idArticulo &&
                    string.Equals(item.Lote, lote, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

                if (detalle != null && cantidad >= 0)
                {
                    detalle.Cantidad = cantidad;
                }
            }
        }

        private void CalcularTotalesDesdeArticulo()
        {
            this.SincronizarDetallesDesdeGrilla();
            this.ActualizarValoresCompraEnGrilla();
            decimal subtotal = 0m;
            var impuestos = new Dictionary<(int Id, string Nombre), decimal>();

            foreach (var detalle in this.detallesAjuste)
            {
                subtotal += detalle.CostoUnitario * detalle.Cantidad;

                foreach (var impuesto in detalle.Impuestos ?? new List<ImpuestoAjusteMemoria>())
                {
                    decimal valorImpuesto = CalcularImpuestos.Calcular(
                        impuesto.TipoImpuesto,
                        detalle.CostoUnitario,
                        detalle.Cantidad,
                        impuesto.Valor);

                    var clave = (impuesto.IdImpuesto, impuesto.Nombre ?? string.Empty);
                    impuestos[clave] = impuestos.TryGetValue(clave, out decimal acumulado)
                        ? acumulado + valorImpuesto
                        : valorImpuesto;
                }
            }

            this.dgvImpuestos.Rows.Clear();
            foreach (var impuesto in impuestos)
            {
                this.dgvImpuestos.Rows.Add(impuesto.Key.Nombre, impuesto.Value.ToString("N2", CultureInfo.InvariantCulture));
            }

            decimal totalGeneral = subtotal + impuestos.Values.Sum();
            this.txtTotales.Text = totalGeneral.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
        }

        private void LimpiarBusquedaArticulo()
        {
            this.txtArticuloBusqueda.Clear();
            this.txtArticuloBusqueda.Focus();
        }

        private void dgvDetallesAjuste_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dgvDetallesAjuste.Columns[e.ColumnIndex].Name != "Quitar")
            {
                return;
            }

            if (!int.TryParse(this.dgvDetallesAjuste.Rows[e.RowIndex].Cells["Id"].Value?.ToString(), out int idArticulo))
            {
                return;
            }

            string lote = this.dgvDetallesAjuste.Rows[e.RowIndex].Cells["Lote"].Value?.ToString() ?? string.Empty;
            string codigo = this.dgvDetallesAjuste.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;

            var detalle = this.detallesAjuste.FirstOrDefault(item =>
                item.IdArticulo == idArticulo &&
                string.Equals(item.Lote, lote, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(item.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

            if (detalle == null)
            {
                return;
            }

            this.detallesAjuste.Remove(detalle);
            this.dgvDetallesAjuste.Rows.RemoveAt(e.RowIndex);
            this.CalcularTotalesDesdeArticulo();
        }

        private void dgvDetallesAjuste_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dgvDetallesAjuste.Columns[e.ColumnIndex].Name != "Cantidad")
            {
                return;
            }

            var row = this.dgvDetallesAjuste.Rows[e.RowIndex];
            if (!int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad) || cantidad < 1)
            {
                row.Cells["Cantidad"].Value = 1;
            }

            this.CalcularTotalesDesdeArticulo();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvAjustes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                this.dgvAjustes.Columns[e.ColumnIndex].Name != "Ver")
            {
                return;
            }

            if (!int.TryParse(this.dgvAjustes.Rows[e.RowIndex].Cells["IdAjsute"].Value?.ToString(), out int idAjuste))
            {
                return;
            }

            await this.CargarAjusteCompleto(idAjuste);
        }
    }
}
