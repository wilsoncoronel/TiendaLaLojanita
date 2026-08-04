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
        private List<InventarioLoteDTO> ListaExistencias = new List<InventarioLoteDTO>();
        public Existencias(List<InventarioLoteDTO> existencias)
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
                    exis.NumeroLote,
                    exis.Codigo,
                    exis.ArticuloDTO.Nombre,
                    exis.StockDisponible,
                    exis.FechaExpiracion.HasValue ? exis.FechaExpiracion.Value.ToString("dd/MM/yyyy") : "N/A",
                });
            }
        }

        private void txtArticuloBusqueda_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
