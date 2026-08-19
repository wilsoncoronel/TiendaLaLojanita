using Microsoft.Extensions.DependencyInjection;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Views;

namespace TiendaLaLojanita
{
    public partial class FrmLoggin : Form
    {
        private SesionDTO sesionDto;
        private readonly IServiceProvider servicePorvider;
        private System.Windows.Forms.ProgressBar prog;

        public FrmLoggin(IServiceProvider servicePorvider)
        {
            InitializeComponent();
            sesionDto = new SesionDTO();
            this.servicePorvider = servicePorvider;
        }
        private async Task GetPermisos(string user, string password)
        {
            var logginService = servicePorvider.GetRequiredService<ILogginService>();
            prog = new System.Windows.Forms.ProgressBar();
            prog.Show();
            List<PermisosRolDTO> listaPermisos = await logginService.IniciarSesion(user, password);
            prog.Hide();
            if (listaPermisos != null && listaPermisos.Count != 0)
            {
                SesionDTO sesion = await logginService.ExtraerSesion(user);
                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal(listaPermisos, servicePorvider, sesion);
                frmPrincipal.Show();
            }
            else
            {
                txtPassword.Clear();
                txtUsurio.Clear();
            }

        }


        private async void btbIngresar_Click(object sender, EventArgs e)
        {
            await this.VerificacionDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await this.VerificacionDatos();
            }
        }

        private async Task VerificacionDatos()
        {
            string usuario = txtUsurio.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Campos vacíos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btbIngresar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                await GetPermisos(txtUsurio.Text, txtPassword.Text);
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            finally
            {
                btbIngresar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
