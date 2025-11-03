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

namespace TiendaLaLojanita.Views
{
    public partial class Existencias : Form
    {
        private List<ExistenciaDTO> ListaExistencias = new List<ExistenciaDTO>();
        public Existencias(List<ExistenciaDTO> existencias)
        {
            InitializeComponent();
            ListaExistencias = existencias;
        }

        private void Existencias_Load(object sender, EventArgs e)
        {
            this.CargarTablaExistencias();
        }

        private void CargarTablaExistencias()
        {
            this.dgvExistencias.Rows.Clear();
            foreach (var exis in ListaExistencias)
            {
                int index = this.dgvExistencias.Rows.Add(new object[] {
                    exis.IdArticulo,
                    exis.NombreArticulo,
                    exis.TotalCantidad
                });
            }
        }

        private void txtArticuloBusqueda_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
