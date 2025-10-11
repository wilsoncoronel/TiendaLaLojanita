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

namespace TiendaLaLojanita.Views
{
    public partial class FrmPrincipal : Form
    {

        private List<PermisosRolDTO> PermisosRol;
        private readonly IServiceProvider serviceProvider;
        private SesionDTO sesion;
        private readonly Dictionary<string, Form> formulariosAbiertos = new();

        public FrmPrincipal(List<PermisosRolDTO> permisosRol, IServiceProvider serviceProvider, SesionDTO sesion)
        {
            InitializeComponent();
            PermisosRol = permisosRol;
            this.serviceProvider = serviceProvider;
            this.CargarListaPermisosTabControl();
            this.WindowState = FormWindowState.Maximized;
            this.sesion = sesion;
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
            if (formulariosAbiertos.ContainsKey(nombreFormulario))
            {
                var frmExistente = formulariosAbiertos[nombreFormulario];
                if (frmExistente != null && !frmExistente.IsDisposed)
                {
                    tab.Controls.Add(frmExistente);
                    frmExistente.Show();
                    frmExistente.BringToFront();
                    return;
                }
            }
            Type tipoFormulario = Type.GetType($"TiendaLaLojanita.Views.{nombreFormulario}, TiendaLaLojanita");

            if (tipoFormulario == null)
            {
                MessageBox.Show("No se encontro el formulario: " + nombreFormulario);
                return;
            }

            var frm = serviceProvider.GetService(tipoFormulario) as Form;
            
            if (frm == null)
            {
                MessageBox.Show("No se pudo crear el formulario: " + nombreFormulario);
                return;
            }
            if(frm is ISesionReceptor receptor)
            {
                receptor.Sesion = this.sesion;
            }
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            tab.Controls.Add(frm);
            frm.Show();
            formulariosAbiertos[nombreFormulario] = frm;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
