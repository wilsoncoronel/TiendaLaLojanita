using SistemaTienda.DTO;
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
    public partial class FrmPrincipal : Form
    {

        private List<PermisosRolDTO> PermisosRol;
        public FrmPrincipal(List<PermisosRolDTO> permisosRol)
        {
            InitializeComponent();
            PermisosRol = permisosRol;
            this.CargarListaPermisosTabControl();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CargarListaPermisosTabControl()
        {
            tabControl1.TabPages.Clear();
            foreach (var item in PermisosRol)
            {
                TabPage tab = new TabPage(item.Menu.Nombre);
                tab.Tag = item.Menu.Nombre;
                tabControl1.TabPages.Add(tab);

            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.Action != TabControlAction.Selected) return;
            string nombreFormulario = e.TabPage.Tag?.ToString();
            if (string.IsNullOrEmpty(nombreFormulario)) return;
            CargarFomrularioEnTab(e.TabPage, nombreFormulario);
            
        }
        private void CargarFomrularioEnTab(TabPage tab, string nombreFormulario)
        {
            if (tab.Controls.Count > 0) return;
            Type tipoFormulario = Type.GetType($"TiendaLaLojanita.Views.{nombreFormulario}, TiendaLaLojanita");

            if(tipoFormulario == null)
            {
                MessageBox.Show("No se encontro el formulario: " +nombreFormulario);
                return;
            }

            Form frm =(Form)Activator.CreateInstance(tipoFormulario);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tab.Controls.Add(frm);
            frm.Show();
        }
    }
}
