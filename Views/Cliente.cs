using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Mapeos;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Cliente : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IMapeosClientes mapeos;
        private List<TipoIdentificacionDTO> ListaTiposIdentificacion;
        private List<CiudadDTO> ListaCiudades;
        private ClienteDTO ClienteActual;
        private List<ClienteDTO> ListaClientes;
        private ClienteEditarDTO ClienteEditar;

        public Cliente(IClienteService clienteService, IMapeosClientes mapeos)
        {
            this.ClienteActual = new ClienteDTO();
            InitializeComponent();
            this._clienteService = clienteService;
            this.mapeos = mapeos;
            ListaTiposIdentificacion = new List<TipoIdentificacionDTO>();
            this.CargarDatosCombos();
            this.ListaCiudades = new List<CiudadDTO>();
            this.ListaClientes = new List<ClienteDTO>();
            this.CargarListaClientes();
        }

        private async void CargarListaClientes()
        {
            this.ListaClientes = await this._clienteService.ListarClientes();
            this.CargarTablaClientes();
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.LimpiarFormulario();
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
                    ClienteDTO cliTemp = this.CargarDatosRelacionados(this.ClienteActual);
                    this.ListaClientes.Add(cliTemp);
                    this.ClienteActual = new ClienteDTO();
                    this.CargarTablaClientes();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el cliente!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.CargarCliente();
                var resp = await this.EditarCliente();
                if (resp)
                {
                    MessageBox.Show($"Cliente con el id: {ClienteActual.Id}, editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    for (int i = 0; i < this.ListaClientes.Count; i++)
                    {
                        if (this.ListaClientes[i].Id == ClienteActual.Id)
                        {
                            this.ListaClientes[i] = ClienteActual;
                        }
                    }
                    this.CargarTablaClientes();
                    this.LimpiarFormulario();
                    this.ClienteEditar = new ClienteEditarDTO();
                }
                else
                {
                    MessageBox.Show($"No se pudo crear el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task<bool> EditarCliente()
        {
            return await this._clienteService.EditarCliente(this.ClienteEditar);
        }
        private void CargarCliente()
        {
            ClienteEditarDTO clienteEditarDto = new ClienteEditarDTO();
            clienteEditarDto.Id = ClienteActual.Id;
            clienteEditarDto.Apellidos = txtApellidos.Text.ToUpper();
            clienteEditarDto.Nombres = txtNombres.Text.ToUpper();
            clienteEditarDto.Telefono = txtTelefono.Text;
            clienteEditarDto.Identificacion = txtIdentificacion.Text;
            clienteEditarDto.Mail = txtEmail.Text;
            clienteEditarDto.Estado = (cbxEstado.SelectedIndex == 0);
            clienteEditarDto.IdTipoIdentificacion = Convert.ToInt32(cbxTipoIdentificacion.SelectedValue);
            clienteEditarDto.FechaModificacion = DateTime.Now;
            clienteEditarDto.DireccionEdicionDto = new DireccionEdicionDTO
            {
                Id = ClienteActual.DireccionDto.Id,
                Descripcion = txtDireccion.Text.ToUpper(),
                IdCiudad = Convert.ToInt32(cbxCiudad.SelectedValue),
                EstadoVisual = true
            };
            clienteEditarDto.EstadoVisual = true;
            this.ClienteEditar = clienteEditarDto;

        }

        private ClienteDTO CargarDatosRelacionados(ClienteDTO cliente)
        {
            if (this.ClienteEditar != null)
            {

                cliente.TipoIdentificacionDto = this.ListaTiposIdentificacion.FirstOrDefault(ti => ti.Id == ClienteActual.TipoIdentificacionDto.Id);
                cliente.DireccionDto.Ciudad = this.ListaCiudades.FirstOrDefault(c => c.Id == ClienteActual.DireccionDto.IdCiudad);
            }
            else if (this.ClienteActual != null)
            {
                cliente.TipoIdentificacionDto = this.ListaTiposIdentificacion.FirstOrDefault(ti => ti.Id == ClienteActual.TipoIdentificacionDto.Id);
                cliente.DireccionDto.Ciudad = this.ListaCiudades.FirstOrDefault(c => c.Id == ClienteActual.DireccionDto.IdCiudad);
            }
            return cliente;
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


        private void CargarTablaClientes()
        {
            this.dgvClientes.Rows.Clear();
            foreach (var cli in ListaClientes)
            {
                dgvClientes.Rows.Add(
                    cli.Id,
                    cli.Nombres,
                    cli.Apellidos,
                    cli.TipoIdentificacionDto.Id,
                    cli.TipoIdentificacionDto.Nombre,
                    cli.Identificacion,
                    cli.Mail,
                    cli.Telefono,
                    cli.DireccionDto.Descripcion,
                    cli.DireccionDto.Ciudad.Nombre,
                    cli.Estado ? "Activo" : "Inactivo"
                );
            }
        }
        private async Task<int> CrearCliente()
        {
            ClienteCreacionDTO clienteDto = new ClienteCreacionDTO();
            clienteDto.Apellidos = txtApellidos.Text.ToUpper();
            clienteDto.Nombres = txtNombres.Text.ToUpper();
            clienteDto.Telefono = txtTelefono.Text;
            clienteDto.Identificacion = txtIdentificacion.Text;
            clienteDto.Mail = txtEmail.Text;
            clienteDto.Estado = (cbxEstado.SelectedIndex == 0);
            clienteDto.IdTipoIdentificacion = Convert.ToInt32(cbxTipoIdentificacion.SelectedValue);
            clienteDto.DireccionCreacionDto = new DireccionCreacionDTO
            {
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
                this.ClienteActual = this.mapeos.MapeoClienteCreacionDtoAClienteDto(clienteDto);
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = 0;
                if (e.ColumnIndex < 0)
                {
                    MessageBox.Show($"Celda no valida!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dgvClientes.Columns[e.ColumnIndex].Name == "Editar")
                {
                    id = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Id"].Value);
                    this.CargarCliente(id);
                }
            }
            catch
            {
                throw;
            }
        }

        private void CargarCliente(int idCliente)
        {
            this.ClienteActual = new ClienteDTO();
            this.ClienteActual = this.ListaClientes.FirstOrDefault(cli => cli.Id == idCliente);
            this.txtIdCLiente.Text = Convert.ToString(ClienteActual.Id);
            this.txtNombres.Text = ClienteActual.Nombres;
            this.txtApellidos.Text = ClienteActual.Apellidos;
            this.txtDireccion.Text = ClienteActual.DireccionDto.Descripcion;
            this.txtEmail.Text = ClienteActual.Mail;
            this.txtTelefono.Text = ClienteActual.Telefono;
            this.cbxCiudad.SelectedValue = ClienteActual.DireccionDto.IdCiudad;
            this.cbxTipoIdentificacion.SelectedValue = ClienteActual.TipoIdentificacionDto.Id;
            this.txtIdentificacion.Text = ClienteActual.Identificacion;
            this.cbxEstado.SelectedIndex = ClienteActual.Estado ? 0 : 1;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
