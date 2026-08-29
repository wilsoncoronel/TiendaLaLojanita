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
using TiendaLaLojanita.Services;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Cliente : Form
    {
        private readonly IClienteService _clienteService;
        private readonly IMapeosClientes mapeos;
        private readonly IProveedorService _proveedorService;
        private List<TipoIdentificacionDTO> ListaTiposIdentificacion;
        private List<CiudadDTO> ListaCiudades;
        private ClienteDTO ClienteActual;
        private List<ClienteDTO> ListaClientes;
        private ClienteEditarDTO ClienteEditar;
        private ProgressBar prog;

        public Cliente(IClienteService clienteService, IMapeosClientes mapeos, IProveedorService proveedorService)
        {
            this.ClienteActual = new ClienteDTO();
            InitializeComponent();
            this._clienteService = clienteService;
            this.mapeos = mapeos;
            this._proveedorService = proveedorService;
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
            prog = new ProgressBar();

            try
            {
                prog.Show();

                bool esNuevo = string.IsNullOrWhiteSpace(txtIdCLiente?.Text);

                if (esNuevo)
                {
                    int idCliente = await CrearCliente();

                    if (idCliente <= 0)
                        return;

                    ClienteActual.Id = idCliente;

                    ClienteDTO clienteTemp =
                        CargarDatosRelacionados(ClienteActual);

                    ListaClientes.Add(clienteTemp);

                    MessageBox.Show(
                        $"Cliente creado con éxito con el id: {idCliente}",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClienteActual = new ClienteDTO();

                    CargarTablaClientes();

                    LimpiarFormulario();

                    return;
                }

                // EDITAR CLIENTE
                CargarCliente();

                bool editado = await EditarCliente();

                if (!editado)
                {
                    MessageBox.Show(
                        "No se pudo editar el cliente.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                for (int i = 0; i < ListaClientes.Count; i++)
                {
                    if (ListaClientes[i].Id == ClienteActual.Id)
                    {
                        MapearEdicionAClienteDto(
                            ListaClientes[i],
                            ClienteEditar);

                        break;
                    }
                }

                CargarTablaClientes();

                MessageBox.Show(
                    $"Cliente con el id: {ClienteActual.Id} editado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarFormulario();

                ClienteEditar = new ClienteEditarDTO();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error inesperado.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                prog?.Close();
                prog?.Dispose();
                prog = null;
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

        private void MapearEdicionAClienteDto(ClienteDTO destino, ClienteEditarDTO origen)
        {
            if (destino == null || origen == null) return;
            destino.Nombres = origen.Nombres;
            destino.Apellidos = origen.Apellidos;
            destino.Identificacion = origen.Identificacion;
            destino.Telefono = origen.Telefono;
            destino.Mail = origen.Mail;
            destino.Estado = origen.Estado;
            // actualizar tipo de identificación relacionado
            destino.TipoIdentificacionDto = this.ListaTiposIdentificacion.FirstOrDefault(t => t.Id == origen.IdTipoIdentificacion);

            if (destino.DireccionDto == null) destino.DireccionDto = new DireccionDTO();
            if (origen.DireccionEdicionDto != null)
            {
                destino.DireccionDto.Id = origen.DireccionEdicionDto.Id;
                destino.DireccionDto.Descripcion = origen.DireccionEdicionDto.Descripcion;
                destino.DireccionDto.IdCiudad = origen.DireccionEdicionDto.IdCiudad;
                destino.DireccionDto.Ciudad = this.ListaCiudades.FirstOrDefault(c => c.Id == origen.DireccionEdicionDto.IdCiudad);
            }
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

        private void CargarCliente(int idCliente)
        {
            this.ClienteActual = new ClienteDTO();
            this.ClienteActual = this.ListaClientes.FirstOrDefault(cli => cli.Id == idCliente);
            this.txtIdCLiente.Text = Convert.ToString(ClienteActual.Id);
            this.txtNombres.Text = ClienteActual.Nombres.ToUpper();
            this.txtApellidos.Text = ClienteActual.Apellidos.ToUpper();
            this.txtDireccion.Text = ClienteActual.DireccionDto.Descripcion.ToUpper();
            this.txtEmail.Text = ClienteActual.Mail;
            this.txtTelefono.Text = ClienteActual.Telefono;
            this.cbxCiudad.SelectedValue = ClienteActual.DireccionDto.IdCiudad;
            this.cbxTipoIdentificacion.SelectedValue = ClienteActual.TipoIdentificacionDto.Id;
            this.txtIdentificacion.Text = ClienteActual.Identificacion;
            this.cbxEstado.SelectedIndex = ClienteActual.Estado ? 0 : 1;
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            e.Handled = true;

            string identificacion = txtIdentificacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show(
                    "Ingrese una identificación válida.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (identificacion.Length > 13)
            {
                MessageBox.Show(
                    "La identificación no puede superar los 13 caracteres.",
                    "Identificación inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            prog = new ProgressBar();

            try
            {
                prog.Show();

                var sriContribuyente =
                    await _proveedorService.ConsultarRUC(
                        identificacion,
                        true);

                if (sriContribuyente is null)
                {
                    MessageBox.Show(
                        "No se encontró información para la identificación ingresada.",
                        "Contribuyente no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                string razonSocial =
                    sriContribuyente.RazonSocial ?? string.Empty;

                string[] partes = razonSocial.Split(
                    ' ',
                    StringSplitOptions.RemoveEmptyEntries);

                txtApellidos.Text =
                    string.Join(" ", partes.Take(2));

                txtNombres.Text =
                    string.Join(" ", partes.Skip(2));

                txtDireccion.Text =
                    sriContribuyente.Establecimiento
                        ?.DireccionCompleta
                    ?? string.Empty;
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error inesperado.\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                prog?.Close();
                prog?.Dispose();
                prog = null;
            }
        }
    }
}
