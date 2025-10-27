using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Cliente : Form
    {
        private readonly IClienteService _clienteService;
        private List<TipoIdentificacionDTO> ListaTiposIdentificacion;
        private List<CiudadDTO> ListaCiudades;
        private ClienteDTO ClienteActual;

        public Cliente(IClienteService clienteService)
        {
            this.ClienteActual = new ClienteDTO();
            InitializeComponent();
            this._clienteService =  clienteService;
            ListaTiposIdentificacion = new List<TipoIdentificacionDTO>();
            this.CargarDatosCombos();
            this.ListaCiudades = new List<CiudadDTO>();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Funcionalidad en desarrollo, IdUsuario " + this.idUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (this.txtIdCLiente is null || this.txtIdCLiente.Text == "")
            {
                var resp = await this.CrearCliente();
                if (resp != null && resp > 0)
                {
                    MessageBox.Show($"Cliente creado con éxito con el id: {resp}", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClienteActual.Id = resp;
                    this.AgregarListaCliente();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el cliente!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*else
            {
                this.CargarEditarArticuloDTO();
                var resp = await this.EditarArticulo();
                if (resp)
                {
                    MessageBox.Show($"Articulo con el id: {artEditarActual.Id}, editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"No se pudo crear el articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

        private async void CargarDatosCombos()
        {
            this.ListaTiposIdentificacion = await this._clienteService.ListarTiposIdentificacion();
            cbxTipoIdentificacion.DataSource = this.ListaTiposIdentificacion;
            this.cbxTipoIdentificacion.DisplayMember = "Nombre";
            this.cbxTipoIdentificacion.ValueMember = "Id";

            this.ListaCiudades = await this._clienteService.ListarCiudades();
            cbxCiudad.DataSource = this.ListaCiudades;
            this.cbxCiudad.DisplayMember = "Nombre";
            this.cbxCiudad.ValueMember = "Id";
        }


        private void AgregarListaCliente() {
            
        }
        private async Task<int> CrearCliente()
        {
            ClienteCreacionDTO clienteDto = new ClienteCreacionDTO();
            clienteDto.Apellidos = txtApellidos.Text.ToUpper();
            clienteDto.Nombres = txtNombres.Text.ToUpper();
            clienteDto.Telefono= txtTelefono.Text;
            clienteDto.Identificacion = txtIdentificacion.Text;
            clienteDto.Mail = txtEmail.Text;
            clienteDto.Estado = (cbxEstado.SelectedIndex == 0);
            clienteDto.IdTipoIdentificacion = Convert.ToInt32(cbxTipoIdentificacion.SelectedValue);
            clienteDto.DireccionCreacionDto = new DireccionCreacionDTO{
                Descripcion = txtDireccion.Text.ToUpper(),
                IdCiudad = Convert.ToInt32(cbxCiudad.SelectedValue),
                EstadoVisual = true
            };
            clienteDto.EstadoVisual = true;
            var validator = new ClienteValidator();
            ValidationResult result = validator.Validate(clienteDto);
            if (!result.IsValid)
            {
                RecorrerErrores(result);
                return 0;
            }
            else
            {
                this.LimpiarFormulario();
                //this.ClienteActual = this.mapeos.MapeoArticuloCreacionDtoAArticuloDto(articuloDto);
                return await this._clienteService.CrearCliente(clienteDto);
            }
        }

        private void LimpiarFormulario()
        {
            txtIdCLiente.Clear();
            txtApellidos.Clear();
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            if (cbxTipoIdentificacion.Items.Count > 0) cbxTipoIdentificacion.SelectedIndex = 0;
            if (cbxCiudad.Items.Count > 0) cbxCiudad.SelectedIndex = 0;
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
    }
}
