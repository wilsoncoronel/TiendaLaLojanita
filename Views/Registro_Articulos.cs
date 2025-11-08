using FluentValidation.Results;
using System.ComponentModel;
using System.Globalization;
using System.IO.Compression;
using System.Xml;
using TiendaLaLojanita.Mapeos;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Articulos : Form, ISesionReceptor
    {
        private readonly IArticuloService articuloService;
        private readonly IMapeosArticulos mapeos;
        private readonly IProcesarExcel procesarExcel;
        private List<MarcaDTO> listaMarcas;
        private List<TipoArticuloDTO> listaTipoArticulo;
        private List<ImpuestoArticuloDTO> listaimpuestos;
        private ArticuloDTO artActual;
        private ArticuloEdicionDTO artEditarActual;
        List<ArticuloDTO> listaArticulos;
        ProgressBar pro;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }

        private int IdUsuario;

        public Registro_Articulos(IArticuloService articuloService, IMapeosArticulos mapeos, IProcesarExcel procesarExcel)
        {

            InitializeComponent();
            this.articuloService = articuloService;
            this.mapeos = mapeos;
            this.procesarExcel = procesarExcel;
            this.limpiarCombos();
            this.dtpFechaInicial.Value = DateTime.Now.AddDays(-7);
            this.dtpFechaFinal.Value = DateTime.Now;
            this.listaArticulos = new List<ArticuloDTO>();
            this.chckPapeleria.Checked = false;
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
        }

        private void cargarCombos()
        {
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
        }

        private void limpiarCombos()
        {
            this.listaMarcas = [];
            this.listaimpuestos = [];
            this.listaTipoArticulo = [];
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo is null || this.txtCodigo.Text == "")
            {
                var resp = await this.CrearArticulo();
                if (resp != null && resp > 0)
                {
                    MessageBox.Show($"Articulo creado con exito con el id: {resp}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            else if (this.artActual != null)
            {
                art.MarcaDTO = this.listaMarcas.FirstOrDefault(m => m.Id == artActual.IdMarca);
                art.TipoArticuloDTO = this.listaTipoArticulo.FirstOrDefault(t => t.Id == artActual.IdTipoArticulo);
                art.ImpuestoArticuloDto = this.listaimpuestos.FirstOrDefault(i => i.Id == artActual.IdImpuesto);
            }
            return art;
        }
        private void CargarEditarArticuloDTO()
        {
            this.artEditarActual = new ArticuloEdicionDTO();
            this.artEditarActual.Id = Convert.ToInt32(txtCodigo.Text);
            this.artEditarActual.Nombre = this.txtNombre.Text.ToUpper();
            this.artEditarActual.Descripcion = txtDescripcion.Text.ToUpper();
            this.artEditarActual.ValorCompra = Convert.ToDecimal(nudValorCompra.Value);
            this.artEditarActual.ValorVenta = Convert.ToDecimal(nudValorVenta.Value);
            this.artEditarActual.IdMarca = Convert.ToInt32(cbxMarca.SelectedValue);
            this.artEditarActual.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.SelectedValue);
            this.artEditarActual.IdImpuesto = Convert.ToInt32(cbxImpuesto.SelectedValue);
            this.artEditarActual.Unidad = txtUnidad.Text;
            this.artEditarActual.UnidadValor = Convert.ToDecimal(nudUnidadValor.Value);
            this.artEditarActual.FechaCaducidad = dtpCaducidad.Value;
            this.artEditarActual.FechaActualizacion = DateTime.Now;
            this.artEditarActual.Estado = cbxEstado.SelectedIndex == 0 ? true : false;
            this.artEditarActual.Papeleria = this.chckPapeleria.Checked;
        }
        private async Task<bool> EditarArticulo()
        {
            bool resultado = await this.articuloService.EditarArticulo(this.artEditarActual);
            return resultado;
        }

        private async Task<int> CrearArticulo()
        {
            ArticuloCreacionDTO articuloDto = new ArticuloCreacionDTO();
            articuloDto.Codigo = txtCodigo.Text;
            articuloDto.Descripcion = txtDescripcion.Text.ToUpper();
            articuloDto.IdUsuarioCreador = IdUsuario;
            articuloDto.Nombre = this.txtDescripcion.Text.ToUpper();
            articuloDto.ValorCompra = Convert.ToDecimal(nudValorCompra.Value);
            articuloDto.ValorVenta = Convert.ToDecimal(nudValorVenta.Value);
            articuloDto.IdMarca = Convert.ToInt32(cbxMarca.SelectedValue);
            articuloDto.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.SelectedValue);
            articuloDto.IdImpuesto = Convert.ToInt32(cbxImpuesto.SelectedValue);
            articuloDto.Unidad = txtUnidad.Text.ToUpper();
            articuloDto.Estado = (cbxEstado.SelectedIndex == 0);
            articuloDto.UnidadValor = Convert.ToDecimal(nudUnidadValor.Value);
            articuloDto.FechaCaducidad = dtpCaducidad.Value;
            articuloDto.FechaCreacion = DateTime.Now;
            articuloDto.Papeleria = this.chckPapeleria.Checked;
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
            txtCodigo.Clear();
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
            this.chckPapeleria.Checked = false;
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
            var listArt = await this.CargarListaArticulos(fechaAnterior, fechaFin);

            this.CargarTabla(listArt);
        }

        private void CargarTabla(List<ArticuloDTO> listArt)
        {
            this.dgvArticulos.Rows.Clear();
            foreach (var art in listArt)
            {
                dgvArticulos.Rows.Add(
                    art.Id,
                    art.Nombre.ToUpper(),
                    art.Descripcion.ToUpper(),
                    art.Papeleria == true ? "SI" : "NO",
                    art.MarcaDTO.Id,
                    art.MarcaDTO.Nombre.ToUpper(),
                    art.TipoArticuloDTO.Id,
                    art.TipoArticuloDTO.Nombre.ToUpper(),
                    art.ImpuestoArticuloDto.Id,
                    art.ImpuestoArticuloDto.Nombre.ToUpper(),
                    art.Estado ? "ACTIVO" : "INACTIVO",
                    art.FechaCreacion.ToString("dd/MM/yyyy"),
                    art.FechaActualizacion.ToString("dd/MM/yyyy"),
                    art.ValorCompra.ToString("C2", new CultureInfo("en-US")),
                    art.ValorVenta.ToString("C2", new CultureInfo("en-US")),
                    art.Unidad,
                    art.UnidadValor.ToString().ToUpper()
                    );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvArticulos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    id = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value);
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
            this.txtCodigo.Text = Convert.ToString(articuloActual.Id);
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
            this.chckPapeleria.Checked = articuloActual.Papeleria ?? false;
        }

        private void nudValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ControlAccesoTeclado(sender, e);
        }
        public void ControlAccesoTeclado(object sender, KeyPressEventArgs e)
        {
            char separadorDecimal = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            var contorl = sender as NumericUpDown;

            string textoActual = contorl.Text;

            // Permitimos dígitos, el separador decimal y la tecla de retroceso (para borrar)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Permitimos la tecla
                e.Handled = false;
            }
            else if (e.KeyChar == separadorDecimal)
            {
                if (textoActual.Contains(separadorDecimal))
                {
                    e.Handled = true;
                }
                else
                {
                    // Cancelamos la tecla (no la mostramos en la celda)
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
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
                articulosExcel = this.procesarExcel.LeerExcel(lblArchivo.Text);
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
                    // GuardarArticulosEnBaseDeDatos(articulosExcel);
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
            DatosConfiguraciones datConf = new DatosConfiguraciones();
            datConf.StartPosition = FormStartPosition.CenterScreen;
            datConf.Show();
        }
    }
}