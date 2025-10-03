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
            SesionDTO sesion = await logginService.ExtraerSesion(user);
            if (sesionDto != null)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal(listaPermisos, servicePorvider, sesion);

                this.Hide();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show($"No se pudo obtener la peticion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btbIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                GetPermisos(txtUsurio.Text, txtPassword.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
