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
using TiendaLaLojanita.Utilidad;

namespace TiendaLaLojanita.Views
{
    public partial class FormularioResumenVentas : Form
    {
        private readonly List<ResumenVentasDiarioDTO> listaRes;
        private readonly IProcesarExcel procesarExcel;

        public FormularioResumenVentas(List<ResumenVentasDiarioDTO> listaRes, IProcesarExcel procesarExcel)
        {
            InitializeComponent();
            this.listaRes = listaRes;
            this.procesarExcel = procesarExcel;
            this.CargarTablaResumenVentas();
        }

        private void CargarTablaResumenVentas()
        {
            var totalVentas = listaRes
                .Where(r => !string.Equals(
                    r.TransaccionesDTO?.Nombre?.Trim(),
                    "Reversion Venta",
                    StringComparison.OrdinalIgnoreCase))
                .Sum(r => r.ValorVenta);
            var totalUtilidad = listaRes.Sum(r => r.UtilidadBruta);
            dgvResumenDiario.Rows.Clear();
            foreach (var res in listaRes)
            {
                dgvResumenDiario.Rows.Add(new object[]
                {
                    res.Articulo.Id,
                    res.Articulo.Nombre,
                    res.TransaccionesDTO?.Nombre,
                    res.CantidadVendida,
                    res.ValorCompra,
                    res.ValorImpuestos,
                    res.ValorCompra + res.ValorImpuestos,
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

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "xlsx",
                FileName = $"ResumenVentas_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx",
                Filter = "Archivo de Excel (*.xlsx)|*.xlsx",
                OverwritePrompt = true,
                Title = "Guardar resumen de ventas"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                this.procesarExcel.ExportarDataGridView(
                    this.dgvResumenDiario,
                    dialogo.FileName,
                    "ResumenVentas");

                MessageBox.Show(
                    "El archivo de Excel se exportó correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo exportar el archivo de Excel: {ex.Message}",
                    "Error de exportación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
