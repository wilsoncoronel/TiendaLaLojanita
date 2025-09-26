using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Articulos : Form, ISesionReceptor
    {
        private readonly IArticuloService articuloService;
        private List<MarcaDTO> listaMarcas;
        private List<TipoArticuloDTO> listaTipoArticulo;
        private List<ImpuestoArticuloDTO> listaimpuestos;
        private ArticuloDTO artActual;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SesionDTO Sesion { get; set; }

        private int IdUsuario;

        public Registro_Articulos(IArticuloService articuloService)
        {

            InitializeComponent();
            this.articuloService = articuloService;
            this.limpiarCombos();
            this.dtpFechaInicial.Value = DateTime.Now.AddDays(-7);
            this.dtpFechaFinal.Value = DateTime.Now;
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

            var resp = await this.CrearArticulo();
            if (resp != null && resp > 0)
            {
                MessageBox.Show($"Articulo creado con exito con el id: {resp}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se pudo crear el articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Registro_Articulos_Load(object sender, EventArgs e)
        {
            await this.cargarConfiguraciones();
            this.cargarCombos();
            IdUsuario = this.Sesion.Id;
        }

        private async Task<int> CrearArticulo()
        {

            ArticuloCreacionDTO articuloDto = new ArticuloCreacionDTO();
            articuloDto.Codigo = txtCodigo.Text;
            articuloDto.Descripcion = txtDescripcion.Text;
            articuloDto.IdUsuarioCreador = IdUsuario;
            articuloDto.Nombre = txtNombre.Text;
            articuloDto.ValorCompra = Convert.ToDecimal(nudValorCompra.Value);
            articuloDto.ValorVenta = Convert.ToDecimal(nudValorVenta.Value);
            articuloDto.IdMarca = Convert.ToInt32(cbxMarca.SelectedValue);
            articuloDto.IdTipoArticulo = Convert.ToInt32(cbxTipoArticulo.SelectedValue);
            articuloDto.IdImpuesto = Convert.ToInt32(cbxImpuesto.SelectedValue);
            articuloDto.Unidad = txtUnidad.Text;
            articuloDto.UnidadValor = Convert.ToDecimal(nudUnidadValor.Value);
            articuloDto.FechaCaducidad = dtpCaducidad.Value;
            articuloDto.FechaCreacion = DateTime.Now;
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
        }

        private async Task<List<ArticuloDTO>> CargarListaArticulos(DateOnly fechaIni, DateOnly fechaFin)
        {
            try
            {
                List<ArticuloDTO> listaArticulos = await this.articuloService.ListaArticulos(fechaIni, fechaFin);
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
                    art.Nombre,
                    art.Descripcion,
                    art.MarcaDTO.Nombre,
                    art.TipoArticuloDTO.Nombre,
                    art.ImpuestoArticuloDto.Nombre,
                    art.Estado ? "Activo" : "Inactivo",
                    art.FechaCreacion.ToString("dd/MM/yyyy"),
                    art.ValorCompra.ToString("C2", new CultureInfo("en-US")),
                    art.ValorVenta.ToString("C2", new CultureInfo("en-US")),
                    art.Unidad,
                    art.UnidadValor.ToString()
                    );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
        }
    }
}
