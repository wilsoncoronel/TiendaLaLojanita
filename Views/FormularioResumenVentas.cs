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
    public partial class FormularioResumenVentas : Form
    {
        private readonly List<ResumenVentasDiarioDTO> listaRes;
        public FormularioResumenVentas(List<ResumenVentasDiarioDTO> listaRes)
        {
            InitializeComponent();
            this.listaRes = listaRes;
            this.CargarTablaResumenVentas();
        }

        private void CargarTablaResumenVentas()
        {
            var totalVentas = listaRes.Sum(r => r.ValorVenta);
            var totalUtilidad = listaRes.Sum(r => r.UtilidadBruta);
            dgvResumenDiario.Rows.Clear();
            foreach (var res in listaRes)
            {
                dgvResumenDiario.Rows.Add(new object[]
                {
                    res.Articulo.Id,
                    res.Articulo.Nombre,
                    res.CantidadVendida,
                    res.ValorCompra,
                    res.ValorVenta,
                    res.UtilidadBruta
                });
            }
            this.txtTotalVentas.Text = totalVentas.ToString();
            this.txtGanancia.Text = totalUtilidad.ToString();
        }
        private void FormularioResumenVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
