using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using TiendaLaLojanita.Controllers;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Views;

namespace TiendaLaLojanita
{
    public partial class FrmLoggin : Form
    {
        private SesionDTO sesionDto;
        private readonly IServiceProvider servicePorvider;

        public FrmLoggin(IServiceProvider servicePorvider)
        {
            InitializeComponent();
            sesionDto = new SesionDTO();
            this.servicePorvider = servicePorvider;
        }
        private async void GetPermisos(string user, string password)
        {
            var logginService = servicePorvider.GetRequiredService<ILogginService>();
            List<PermisosRolDTO> listaPermisos = await logginService.IniciarSesion(user, password);
            
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


        private void btbIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsurio.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Campos vacíos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btbIngresar.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {

                GetPermisos(txtUsurio.Text, txtPassword.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btbIngresar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
