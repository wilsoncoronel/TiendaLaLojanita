using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaLaLojanita.Views
{
    public partial class Cliente : Form
    {
        private int idUsuario = 0;
        public Cliente(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad en desarrollo, IdUsuario " + this.idUsuario, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
