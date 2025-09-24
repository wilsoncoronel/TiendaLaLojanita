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
        private readonly ILogginService loginService;

        public FrmLoggin(ILogginService loginService)
        {
            InitializeComponent();
            sesionDto = new SesionDTO();
            this.loginService = loginService;
        }
        private async void GetSession(string user, string password)
        {
            List<PermisosRolDTO>  listaPermisos = await this.loginService.IniciarSesion(user, password);
            if (sesionDto != null)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal(listaPermisos);
                
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
            GetSession(txtUsurio.Text, txtPassword.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
