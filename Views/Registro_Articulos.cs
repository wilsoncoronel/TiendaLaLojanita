using FluentValidation.Results;
using System.ComponentModel;
using System.DirectoryServices;
using System.Globalization;
using System.IO.Compression;
using System.Xml;
using TiendaLaLojanita.Mapeos;
using TiendaLaLojanita.Models;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Articulos : Form, ISesionReceptor
    {
        private readonly IArticuloService articuloService;
        private readonly ITiposArticulosService tipoArticuloService;
        private readonly IImpuestoService impuestoService;
        private readonly IPorcentajeService porcentajeService;
        private readonly IMapeosArticulos mapeos;
        private readonly IProcesarExcel procesarExcel;
        private List<MarcaDTO> listaMarcas;
        private List<TipoArticuloDTO> listaTipoArticulo;
        private List<ImpuestoArticuloDTO> listaimpuestos;
        private List<PorcentajeGananciaDTO> listaPorcentajeGanancias;
        private ArticuloDTO artActual;
        private ArticuloEdicionDTO artEditarActual;
        List<ArticuloDTO> listaArticulos;
        ProgressBar pro;
        private readonly IMarcaService marcaService;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }

        private int IdUsuario;

        public Registro_Articulos(IArticuloService articuloService, IMapeosArticulos mapeos, IProcesarExcel procesarExcel, IMarcaService marcaService, ITiposArticulosService tipoArticuloService, IImpuestoService impuestoService, IPorcentajeService porcentajeService)
        {
            InitializeComponent();
            this.articuloService = articuloService;
            this.mapeos = mapeos;
            this.procesarExcel = procesarExcel;
            this.marcaService = marcaService;
            this.limpiarCombos();
            this.dtpFechaInicial.Value = DateTime.Now.AddDays(-7);
            this.dtpFechaFinal.Value = DateTime.Now;
            this.listaArticulos = new List<ArticuloDTO>();
            this.listaPorcentajeGanancias = new List<PorcentajeGananciaDTO>();
            this.tipoArticuloService = tipoArticuloService;
            this.impuestoService = impuestoService;
            this.porcentajeService = porcentajeService;
            // Suscribir TextChanged de los TextBox internos de los NumericUpDown para normalizar pegado
            try
            {
                // Asegurar que los NumericUpDown permitan solo 4 decimales
                this.nudValorCompra.DecimalPlaces = 4;
                this.nudValorVenta.DecimalPlaces = 4;
                this.nudUnidadValor.DecimalPlaces = 4;

                var tbCompra = this.nudValorCompra.Controls.OfType<TextBox>().FirstOrDefault();
                if (tbCompra != null) tbCompra.TextChanged += (s, e) => NormalizarTextoDecimal(this.nudValorCompra);

                var tbVenta = this.nudValorVenta.Controls.OfType<TextBox>().FirstOrDefault();
                if (tbVenta != null) tbVenta.TextChanged += (s, e) => NormalizarTextoDecimal(this.nudValorVenta);

                var tbUnidad = this.nudUnidadValor.Controls.OfType<TextBox>().FirstOrDefault();
                if (tbUnidad != null) tbUnidad.TextChanged += (s, e) => NormalizarTextoDecimal(this.nudUnidadValor);

                // Asegurar que los NumericUpDown muestren 0 al inicio (evita que el Text interno quede vacío)
                try
                {
                    if (this.nudValorCompra.Minimum <= 0 && this.nudValorCompra.Value == 0) this.nudValorCompra.Value = 0m;
                    if (this.nudValorVenta.Minimum <= 0 && this.nudValorVenta.Value == 0) this.nudValorVenta.Value = 0m;
                    if (this.nudUnidadValor.Minimum <= 0 && this.nudUnidadValor.Value == 0) this.nudUnidadValor.Value = 0m;
                }
                catch
                {
                    // Ignorar si no es posible asignar en tiempo de diseño
                }
            }
            catch
            {
                // Ignorar si no se pueden obtener los controles en tiempo de diseño
            }
            // Suscribir eventos para cálculo de valor de venta
            try
            {
                // Calcular sólo al presionar Enter o al perder el foco del control de compra
                this.nudValorCompra.KeyDown += nudValorCompra_KeyDown;
                this.nudValorCompra.Leave += nudValorCompra_Leave;

                // Recalcular si el usuario cambia la selección de impuesto o porcentaje (si ya hay valor de compra)
                this.cbxImpuesto.SelectedIndexChanged += (s, e) => CalcularValorVentaSiListo();
                this.cbxPorcentajeGanancia.SelectedIndexChanged += (s, e) => CalcularValorVentaSiListo();
            }
            catch
            {
                // Si no existen los controles en tiempo de diseño, ignorar
            }
        }
        private async void Registro_Articulos_Load(object sender, EventArgs e)
        {
            await this.cargarConfiguraciones();
            this.cargarCombos();
            IdUsuario = this.Sesion.Id;
        }
        private async Task cargarConfiguraciones()
        {
            this.listaimpuestos = await this.articuloService.ListaImpuestoArticulo();
            this.listaMarcas = await this.articuloService.ListaMarcaArticulo();
            this.listaTipoArticulo = await this.articuloService.ListaTipoArticulo();
            this.listaPorcentajeGanancias = await this.porcentajeService.ListarPorcentajes();
        }

        private void cargarCombos()
        {
            this.cbxPorcentajeGanancia.DataSource = listaPorcentajeGanancias;
            this.cbxPorcentajeGanancia.DisplayMember = "PorcentajeGanancia";
            this.cbxPorcentajeGanancia.ValueMember = "Id";

            this.cbxImpuesto.DataSource = listaimpuestos;
            this.cbxImpuesto.DisplayMember = "Nombre";
            this.cbxImpuesto.ValueMember = "Id";
            this.cbxMarca.DataSource = listaMarcas;
            this.cbxMarca.DisplayMember = "Nombre";
            this.cbxMarca.ValueMember = "Id";
            this.cbxTipoArticulo.DataSource = listaTipoArticulo;
            this.cbxTipoArticulo.DisplayMember = "Nombre";
            this.cbxTipoArticulo.ValueMember = "Id";
            this.lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.lblUser.Text = Sesion.Usuario;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection coleccion3 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection coleccion4 = new AutoCompleteStringCollection();
            foreach (var imp in listaimpuestos)
            {
                coleccion.Add(Convert.ToString(imp.Nombre).ToUpper());
            }

            foreach (var marc in listaMarcas)
            {
                coleccion2.Add(Convert.ToString(marc.Nombre).ToUpper());
            }

            foreach (var tipArt in listaTipoArticulo)
            {
                coleccion3.Add(Convert.ToString(tipArt.Nombre).ToUpper());
            }
            foreach (var porcen in listaPorcentajeGanancias)
            {
                coleccion4.Add(Convert.ToString(porcen.PorcentajeGanancia).ToUpper());
            }

            cbxImpuesto.AutoCompleteCustomSource = coleccion;
            cbxImpuesto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxImpuesto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbxMarca.AutoCompleteCustomSource = coleccion2;
            cbxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbxTipoArticulo.AutoCompleteCustomSource = coleccion3;
            cbxTipoArticulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxTipoArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cbxPorcentajeGanancia.AutoCompleteCustomSource = coleccion4;
            cbxPorcentajeGanancia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPorcentajeGanancia.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void limpiarCombos()
        {
            this.listaMarcas = [];
            this.listaimpuestos = [];
            this.listaTipoArticulo = [];
            this.listaPorcentajeGanancias = [];
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtId is null || this.txtId.Text == "")
            {
                var resp = await this.CrearArticulo();
                if (resp != null && resp > 0)
                {
                    MessageBox.Show($"Artículo creado con éxito con el id: {resp}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.artActual.Id = resp;
                    ArticuloDTO artiTemp = this.CargarDatosRelacionados(this.artActual);
                    artiTemp.Codigo = Convert.ToString(resp);
                    this.listaArticulos.Add(artiTemp);
                    this.artActual = new ArticuloDTO();
                    this.CargarTabla(this.listaArticulos);
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.CargarEditarArticuloDTO();
                var resp = await this.EditarArticulo();
                if (resp)
                {
                    MessageBox.Show($"Artículo con el id: {artEditarActual.Id}, editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArticuloDTO art = this.mapeos.MapeoArticuloEdionDtoAArticuloDto(artEditarActual);
                    art = this.CargarDatosRelacionados(art);
                    for (int i = 0; i < this.listaArticulos.Count; i++)
                    {
                        DateTime fecha;
                        if (this.listaArticulos[i].Id == art.Id)
                        {
                            fecha = this.listaArticulos[i].FechaCreacion;
                            this.listaArticulos[i] = art;
                            this.listaArticulos[i].FechaCreacion = fecha;
                        }
                    }
                    this.CargarTabla(this.listaArticulos);
                    this.LimpiarFormulario();
                    this.artEditarActual = new ArticuloEdicionDTO();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el artículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private ArticuloDTO CargarDatosRelacionados(ArticuloDTO art)
        {
            if (this.artEditarActual != null)
            {

                art.MarcaDTO = this.listaMarcas.FirstOrDefault(m => m.Id == artEditarActual.IdMarca);
                art.TipoArticuloDTO = this.listaTipoArticulo.FirstOrDefault(t => t.Id == artEditarActual.IdTipoArticulo);
                art.ImpuestoArticuloDto = this.listaimpuestos.FirstOrDefault(i => i.Id == artEditarActual.IdImpuesto);
                art.PorcentajeDTO = this.listaPorcentajeGanancias.FirstOrDefault(p => p.Id == artEditarActual.IdPorcentajeGanancia);
            }
            else if (this.artActual != null)
            {
                art.MarcaDTO = this.listaMarcas.FirstOrDefault(m => m.Id == artActual.IdMarca);
                art.TipoArticuloDTO = this.listaTipoArticulo.FirstOrDefault(t => t.Id == artActual.IdTipoArticulo);
                art.ImpuestoArticuloDto = this.listaimpuestos.FirstOrDefault(i => i.Id == artActual.IdImpuesto);
                art.PorcentajeDTO = this.listaPorcentajeGanancias.FirstOrDefault(p => p.Id == artActual.IdPorcentajeGanancia);
            }
            return art;
        }
        private void CargarEditarArticuloDTO()
        {
            this.artEditarActual = new ArticuloEdicionDTO();
            this.artEditarActual.Id = Convert.ToInt32(txtId.Text);
            this.artEditarActual.Nombre = this.txtNombre.Text.ToUpper();
            this.artEditarActual.Descripcion = txtDescripcion.Text.ToUpper();
            this.artEditarActual.ValorCompra = Convert.ToDecimal(nudValorCompra.Value);
            this.artEditarActual.ValorVenta = Convert.ToDecimal(nudValorVenta.Value);
            this.artEditarActual.IdMarca = Convert.ToInt32(cbxMarca.SelectedValue);
            this.artEditarActual.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.SelectedValue);
            this.artEditarActual.IdImpuesto = Convert.ToInt32(cbxImpuesto.SelectedValue);
            this.artEditarActual.IdPorcentajeGanancia = Convert.ToInt32(cbxPorcentajeGanancia.SelectedValue);
            this.artEditarActual.Unidad = txtUnidad.Text;
            this.artEditarActual.UnidadValor = Convert.ToDecimal(nudUnidadValor.Value);
            this.artEditarActual.FechaCaducidad = dtpCaducidad.Value;
            this.artEditarActual.FechaActualizacion = DateTime.Now;
            this.artEditarActual.Estado = cbxEstado.SelectedIndex == 0 ? true : false;
            this.artEditarActual.Papeleria = false;
        }
        private async Task<bool> EditarArticulo()
        {
            bool resultado = await this.articuloService.EditarArticulo(this.artEditarActual);
            return resultado;
        }

        private async Task<int> CrearArticulo()
        {
            ArticuloCreacionDTO articuloDto = new ArticuloCreacionDTO();
            articuloDto.Codigo = txtId.Text;
            articuloDto.Descripcion = txtDescripcion.Text.ToUpper();
            articuloDto.IdUsuarioCreador = IdUsuario;
            articuloDto.Nombre = this.txtNombre.Text.ToUpper();
            articuloDto.ValorCompra = Convert.ToDecimal(nudValorCompra.Value);
            articuloDto.ValorVenta = Convert.ToDecimal(nudValorVenta.Value);
            articuloDto.IdMarca = Convert.ToInt32(cbxMarca.SelectedValue);
            articuloDto.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.SelectedValue);
            articuloDto.IdImpuesto = Convert.ToInt32(cbxImpuesto.SelectedValue);
            articuloDto.IdPorcentajeGanancia = Convert.ToInt32(cbxPorcentajeGanancia.SelectedValue);
            articuloDto.Unidad = txtUnidad.Text.ToUpper();
            articuloDto.Estado = (cbxEstado.SelectedIndex == 0);
            articuloDto.UnidadValor = Convert.ToDecimal(nudUnidadValor.Value);
            articuloDto.FechaCaducidad = dtpCaducidad.Value;
            articuloDto.FechaCreacion = DateTime.Now;
            articuloDto.Papeleria = false;
            var validator = new ArticuloValidator();
            ValidationResult result = validator.Validate(articuloDto);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return 0;
            }
            else
            {
                this.LimpiarFormulario();
                this.artActual = this.mapeos.MapeoArticuloCreacionDtoAArticuloDto(articuloDto);
                return await this.articuloService.CrearArticulo(articuloDto);
            }
        }
        private void RecorrerErrores(ValidationResult result)
        {
            if (result.Errors.Count > 1)
            {
                MessageBox.Show($"Error de Validacion,  hay campos obligatorios vacios!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show(error.ErrorMessage, $"Error de Validacion, {error.PropertyName}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtDescripcion.Clear();
            txtNombre.Clear();
            nudValorCompra.Value = 0;
            nudValorVenta.Value = 0;
            txtUnidad.Clear();
            nudUnidadValor.Value = 0;
            dtpCaducidad.Value = DateTime.Now;
            if (cbxImpuesto.Items.Count > 0) cbxImpuesto.SelectedIndex = 0;
            if (cbxMarca.Items.Count > 0) cbxMarca.SelectedIndex = 0;
            if (cbxTipoArticulo.Items.Count > 0) cbxTipoArticulo.SelectedIndex = 0;
            if (cbxPorcentajeGanancia.Items.Count>0) cbxPorcentajeGanancia.SelectedIndex = 0;
        }

        private async Task<List<ArticuloDTO>> CargarListaArticulos(DateOnly fechaIni, DateOnly fechaFin)
        {
            try
            {
                this.listaArticulos = await this.articuloService.ListaArticulos(fechaIni, fechaFin);
                if (listaArticulos is null || listaArticulos.Count == 0)
                {
                    MessageBox.Show($"No existen articulos registrados en ese rango de fechas, Intente cambiando el rango de fechas actual!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return listaArticulos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvArticulos.AutoGenerateColumns = false;
            var fechaAnterior = DateOnly.FromDateTime(this.dtpFechaInicial.Value);
            var fechaFin = DateOnly.FromDateTime(this.dtpFechaFinal.Value);
            pro = new ProgressBar();
            pro.Show();
            var listArt = await this.CargarListaArticulos(fechaAnterior, fechaFin);
            pro.Hide();
            this.CargarTabla(listArt);
        }

        private void CargarTabla(List<ArticuloDTO> listArt)
        {
            this.dgvArticulos.Rows.Clear();
            if (listArt == null) return;

            foreach (var art in listArt)
            {
                // Seguridad ante propiedades null
                var nombre = art?.Nombre?.ToUpper() ?? string.Empty;
                var descripcion = art?.Descripcion?.ToUpper() ?? string.Empty;
                var papeleria = art?.Papeleria == true ? "SI" : "NO";

                var marcaId = art?.MarcaDTO?.Id ?? 0;
                var marcaNombre = art?.MarcaDTO?.Nombre?.ToUpper() ?? string.Empty;

                var tipoId = art?.TipoArticuloDTO?.Id ?? 0;
                var tipoNombre = art?.TipoArticuloDTO?.Nombre?.ToUpper() ?? string.Empty;

                var impuestoId = art?.ImpuestoArticuloDto?.Id ?? 0;
                var impuestoNombre = art?.ImpuestoArticuloDto?.Nombre?.ToUpper() ?? string.Empty;

                var porcentajeId = art?.PorcentajeDTO?.Id ?? 0;
                var porcentajeStr = art?.PorcentajeDTO != null ? art.PorcentajeDTO.PorcentajeGanancia.ToString() : "SIN PORCENTAJE";

                var estado = art?.Estado == true ? "ACTIVO" : "INACTIVO";

                var fechaCreacion = art?.FechaCreacion.ToString("dd/MM/yyyy") ?? string.Empty;
                var fechaActualizacion = art?.FechaActualizacion.ToString("dd/MM/yyyy") ?? string.Empty;

                var valorCompra = art != null ? art.ValorCompra.ToString("C2", new System.Globalization.CultureInfo("en-US")) : string.Empty;
                var valorVenta = art != null ? art.ValorVenta.ToString("C2", new System.Globalization.CultureInfo("en-US")) : string.Empty;

                var unidad = art?.Unidad?.ToUpper() ?? string.Empty;
                var unidadValor = art?.UnidadValor.HasValue == true ? art.UnidadValor.Value.ToString().ToUpper() : string.Empty;

                dgvArticulos.Rows.Add(
                    art?.Id ?? 0,
                    nombre,
                    descripcion,
                    papeleria,
                    marcaId,
                    marcaNombre,
                    tipoId,
                    tipoNombre,
                    impuestoId,
                    impuestoNombre,
                    porcentajeId,
                    porcentajeStr,
                    estado,
                    fechaCreacion,
                    fechaActualizacion,
                    valorCompra,
                    valorVenta,
                    unidad,
                    unidadValor
                );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        private async void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvArticulos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    this.CargarEditarArticulo(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void CargarEditarArticulo(int idArticulo)
        {
            ArticuloDTO articuloActual = this.listaArticulos.FirstOrDefault(a => a.Id == idArticulo);
            this.txtNombre.Text = articuloActual.Nombre.ToUpper();
            this.txtDescripcion.Text = articuloActual.Descripcion.ToUpper();
            this.txtId.Text = Convert.ToString(articuloActual.Id);
            this.txtUnidad.Text = articuloActual.Unidad.ToUpper();
            this.nudUnidadValor.Value = Convert.ToDecimal(articuloActual.UnidadValor);
            this.nudValorCompra.Value = Convert.ToDecimal(articuloActual.ValorCompra);
            this.nudValorVenta.Value = Convert.ToDecimal(articuloActual.ValorVenta);
            this.dtpCaducidad.Value = articuloActual.FechaCaducidad ?? DateTime.Now;
            this.dtpCreacion.Value = articuloActual.FechaCreacion;
            this.cbxEstado.SelectedIndex = articuloActual.Estado ? 0 : 1;
            this.cbxImpuesto.SelectedValue = articuloActual.ImpuestoArticuloDto.Id;
            this.cbxMarca.SelectedValue = articuloActual.MarcaDTO.Id;
            this.cbxTipoArticulo.SelectedValue = articuloActual.TipoArticuloDTO.Id;
            this.cbxPorcentajeGanancia.SelectedValue = articuloActual.PorcentajeDTO?.Id ?? 0;
        }

        private void nudValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ControlAccesoTeclado(sender, e);
        }
        public void ControlAccesoTeclado(object sender, KeyPressEventArgs e)
        {
            // Usamos coma como separador decimal según requisito
            char separadorDecimal = ',';
            var control = sender as NumericUpDown;

            if (control == null)
            {
                e.Handled = true;
                return;
            }

            string textoActual = control.Text ?? string.Empty;

            // Si el usuario presiona punto, lo convertimos a coma
            if (e.KeyChar == '.')
            {
                e.KeyChar = separadorDecimal;
            }

            // Permitimos dígitos y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            // Permitimos el separador decimal (coma) solo si no existe ya en el texto
            if (e.KeyChar == separadorDecimal)
            {
                if (textoActual.Contains(separadorDecimal))
                {
                    e.Handled = true; // ya existe separador
                }
                else
                {
                    e.Handled = false; // permitir primera coma
                }
                return;
            }

            // Cualquier otra tecla la bloqueamos
            e.Handled = true;
        }

        private void NormalizarTextoDecimal(NumericUpDown control)
        {
            if (control == null) return;

            var tb = control.Controls.OfType<TextBox>().FirstOrDefault();
            if (tb == null) return;

            string texto = tb.Text ?? string.Empty;
            if (texto == string.Empty) return;

            // Reemplazar puntos por comas
            string normalizado = texto.Replace('.', ',');

            // Si hay más de una coma, conservar solo la primera
            int primeraComa = normalizado.IndexOf(',');
            if (primeraComa >= 0)
            {
                string antes = normalizado.Substring(0, primeraComa + 1);
                string despues = normalizado.Substring(primeraComa + 1).Replace(",", string.Empty);
                normalizado = antes + despues;
            }

            // Si comienza con coma, anteponer 0
            if (normalizado.StartsWith(",")) normalizado = "0" + normalizado;

            // Intentar parsear usando cultura es-ES para la coma
            if (decimal.TryParse(normalizado, System.Globalization.NumberStyles.Number, CultureInfo.GetCultureInfo("es-ES"), out decimal valor))
            {
                // Ajustar al rango permitido
                if (valor < control.Minimum) valor = control.Minimum;
                if (valor > control.Maximum) valor = control.Maximum;
                // Asignar valor al control (esto actualizará también el Text interno)
                control.Value = valor;
                // Actualizar el TextBox con la representación normalizada
                tb.Text = normalizado;
                tb.SelectionStart = tb.Text.Length;
            }
            else
            {
                // No se pudo parsear: actualizar solo el texto normalizado para mostrar al usuario
                tb.Text = normalizado;
                tb.SelectionStart = tb.Text.Length;
            }
        }

        // Eventos y lógica para el cálculo del valor de venta
        private void nudValorCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CalcularValorVentaSiListo();
            }
        }

        private void nudValorCompra_Leave(object sender, EventArgs e)
        {
            CalcularValorVentaSiListo();
        }

        private void CalcularValorVentaSiListo()
        {
            // Si falta impuesto o porcentaje no hacemos nada y dejamos el valor actual
            if (cbxImpuesto.SelectedValue == null || cbxPorcentajeGanancia.SelectedValue == null) return;
            if (!int.TryParse(cbxImpuesto.SelectedValue.ToString(), out int idImpuesto) || idImpuesto <= 0) return;
            if (!int.TryParse(cbxPorcentajeGanancia.SelectedValue.ToString(), out int idPorcentaje) || idPorcentaje <= 0) return;
            if (nudValorCompra.Value <= 0m) return;

            CalcularValorVenta(idImpuesto, idPorcentaje);
        }

        private void CalcularValorVenta(int idImpuesto, int idPorcentaje)
        {
            try
            {
                decimal valorCompra = nudValorCompra.Value;

                var impuestoObj = listaimpuestos?.FirstOrDefault(x => x.Id == idImpuesto);
                var porcentajeObj = listaPorcentajeGanancias?.FirstOrDefault(x => x.Id == idPorcentaje);

                decimal valorImpuesto = impuestoObj?.ValorImpuesto ?? 0m;
                decimal valorPorcentaje = porcentajeObj?.Valor ?? 0m;

                // Los valores de impuesto y porcentaje ya vienen en formato decimal (por ejemplo 0.12),
                // por lo que no es necesario normalizarlos.

                decimal valorImpuestoCompra = valorCompra * valorImpuesto;
                decimal valorCompraFinal = valorCompra + valorImpuestoCompra;
                decimal valorPorcentajeAplicado = valorCompraFinal * valorPorcentaje;
                decimal valorVenta = valorCompraFinal + valorPorcentajeAplicado;

                valorVenta = Math.Round(valorVenta, 2);
                if (valorVenta > nudValorVenta.Maximum) valorVenta = nudValorVenta.Maximum;
                if (valorVenta < nudValorVenta.Minimum) valorVenta = nudValorVenta.Minimum;

                nudValorVenta.Value = valorVenta;
            }
            catch
            {
                // Comportamiento silencioso: no modificamos nudValorVenta
            }
        }

        /// <summary>
        /// Calcula y asigna el ValorVenta para cada artículo que viene desde el Excel
        /// usando las listas cargadas de impuestos y porcentajes.
        /// </summary>
        /// <param name="articulos">Lista de artículos leídos desde Excel</param>
        private void calcularvalorVentaarticulosExcel(List<ArticuloCreacionDTO> articulos)
        {
            if (articulos == null || articulos.Count == 0) return;

            foreach (var art in articulos)
            {
                try
                {
                    decimal impuesto = 0m;
                    var imp = this.listaimpuestos?.FirstOrDefault(x => x.Id == art.IdImpuesto);
                    if (imp != null) impuesto = imp.ValorImpuesto;

                    decimal valorImpuesto = art.ValorCompra * impuesto;
                    decimal valorCompraFin = art.ValorCompra + valorImpuesto;

                    decimal porcentaje = 0m;
                    if (art.IdPorcentajeGanancia.HasValue)
                    {
                        var por = this.listaPorcentajeGanancias?.FirstOrDefault(x => x.Id == art.IdPorcentajeGanancia.Value);
                        if (por != null) porcentaje = por.Valor;
                    }

                    decimal valorPorcentaje = valorCompraFin * porcentaje;
                    decimal valorVenta = valorCompraFin + valorPorcentaje;

                    // Mantener consistencia con el cálculo de la UI: redondeo a 2 decimales
                    art.ValorVenta = Math.Round(valorVenta, 2);
                }
                catch
                {
                    // Ignorar errores en cálculo de un artículo concreto y dejar ValorVenta por defecto
                }
            }
        }

        private void nudValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ControlAccesoTeclado(sender, e);
        }

        private void nudUnidadValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ControlAccesoTeclado(sender, e);
        }

        private async void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            List<ArticuloCreacionDTO> articulosExcel = new List<ArticuloCreacionDTO>();
            if (ofdArticulos.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text = ofdArticulos.FileName;
                var (sheet, sharedStrings) = this.procesarExcel.LeerExcel(lblArchivo.Text);
                articulosExcel = this.procesarExcel.LeerShetArticulo(sheet, sharedStrings);

                // Primero calcular el valor de venta para cada articulo cargado desde Excel
                this.calcularvalorVentaarticulosExcel(articulosExcel);

                // Validar cada artículo usando el validador específico para importación (Validaciones.ExcelArticuloValidator)
                var validator = new Validaciones.ExcelArticuloValidator();
                var articulosInvalidos = new List<(ArticuloCreacionDTO Art, List<string> Errores)>();

                for (int i = 0; i < articulosExcel.Count; i++)
                {
                    var art = articulosExcel[i];
                    var errores = validator.ValidateArticulo(art, this.listaMarcas, this.listaTipoArticulo, this.listaimpuestos, this.listaPorcentajeGanancias);
                    if (errores.Any()) articulosInvalidos.Add((art, errores));
                }

                // Si se encontraron artículos inválidos, mostrar en el DataGridView de errores y anular la carga
                if (articulosInvalidos.Any())
                {
                    MessageBox.Show("Se encontraron artículos inválidos. Se ha detenido la importación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ErroresRegistroArticuloExcel erroArti = new ErroresRegistroArticuloExcel();
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    $"Se han cargado {articulosExcel.Count} artículos desde el archivo Excel. ¿Está seguro de guardarlos en la BD?",
                    "Confirmación",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                // Capturas la respuesta del usuario
                if (respuesta == DialogResult.OK)
                {
                    // 👉 El usuario presionó OK
                    pro = new ProgressBar();
                    pro.Show();
                    var resp = await this.EnviarArticulosBd(articulosExcel);
                    pro.Hide();
                    if (resp) MessageBox.Show($"Artículos registrados sin error!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show($"Ocurrio un error al registrar los Artículos!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // 👉 El usuario presionó Cancelar o cerró el cuadro
                    MessageBox.Show("Operación cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async Task<bool> EnviarArticulosBd(List<ArticuloCreacionDTO> articulos)
        {
            return await this.articuloService.CrearArticuloLista(articulos);
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

        private void btnAgregarDatosConfiguraciones_Click(object sender, EventArgs e)
        {
            IMarcaService marcaService = this.marcaService;
            ITiposArticulosService tipoArticuloService = this.tipoArticuloService;
            IImpuestoService impuestoService = this.impuestoService;
            IPorcentajeService porcentajeService = this.porcentajeService;
            DatosConfiguraciones datConf = new DatosConfiguraciones(marcaService, tipoArticuloService, impuestoService, porcentajeService);
            datConf.StartPosition = FormStartPosition.CenterScreen;
            datConf.Show();
        }

        private async void btnRecargarDatosConfiguraciones_Click(object sender, EventArgs e)
        {
            pro = new ProgressBar();
            pro.Show();
            await this.cargarConfiguraciones();
            this.cargarCombos();
            pro.Hide();
            MessageBox.Show("Datos de configuracion recargados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvCodsArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            var control = sender as NumericUpDown;

            string textoActual = control.Text;

            // Permitimos dígitos, el separador decimal y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar))
            {
                // Permitimos la tecla
                e.Handled = true;
            }
        }

        private void cbxPorcentajeGanancia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
