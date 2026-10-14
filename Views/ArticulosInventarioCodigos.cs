using System.Globalization;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Utilidad;

namespace TiendaLaLojanita.Views
{
    public partial class ArticulosInventarioCodigos : Form
    {
        private List<InventarioLoteDTO> ListaExistencias = new List<InventarioLoteDTO>();
        public ArticulosInventarioCodigos(List<InventarioLoteDTO> listaExistencias)
        {
            InitializeComponent();
            this.ListaExistencias = listaExistencias ?? new List<InventarioLoteDTO>();
            this.Load += ArticulosInventarioCodigos_Load;
            this.txtArticuloBusqueda.TextChanged += txtArticuloBusqueda_TextChanged;
            this.button2.Click += button2_Click;
            this.dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void ArticulosInventarioCodigos_Load(object? sender, EventArgs e)
        {
            this.MostrarExistencias(this.ListaExistencias);
        }

        private void MostrarExistencias(IEnumerable<InventarioLoteDTO> existencias)
        {
            this.dataGridView1.Rows.Clear();

            foreach (var existencia in existencias)
            {
                this.dataGridView1.Rows.Add(
                    existencia.Id,
                    existencia.ArticuloDTO?.Nombre ?? string.Empty,
                    existencia.NumeroLote ?? string.Empty,
                    existencia.Codigo ?? string.Empty);
            }
        }

        private void FiltrarExistencias()
        {
            string texto = this.txtArticuloBusqueda.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                this.MostrarExistencias(this.ListaExistencias);
                return;
            }

            var resultados = this.ListaExistencias.Where(existencia =>
                existencia.IdArticulo.ToString(CultureInfo.InvariantCulture).Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                existencia.ArticuloDTO?.Nombre?.Contains(texto, StringComparison.OrdinalIgnoreCase) == true ||
                existencia.Codigo?.Contains(texto, StringComparison.OrdinalIgnoreCase) == true ||
                existencia.NumeroLote?.Contains(texto, StringComparison.OrdinalIgnoreCase) == true);

            this.MostrarExistencias(resultados);
        }

        private void txtArticuloBusqueda_TextChanged(object? sender, EventArgs e)
        {
            this.FiltrarExistencias();
        }

        private void btnBuscar_Click_1(object? sender, EventArgs e)
        {
            this.FiltrarExistencias();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
                this.dataGridView1.Columns[e.ColumnIndex].Name != "Imprimir")
            {
                return;
            }

            if (!int.TryParse(this.dataGridView1.Rows[e.RowIndex].Cells[nameof(Id)].Value?.ToString(), out int id))
            {
                return;
            }

            var existencia = this.ListaExistencias.FirstOrDefault(item => item.Id == id);
            this.PrepararImpresion(existencia);
        }

        private void PrepararImpresion(InventarioLoteDTO? existencia)
        {
            if (existencia == null || string.IsNullOrWhiteSpace(existencia.Codigo))
            {
                MessageBox.Show("La existencia seleccionada no tiene un código para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!this.TrySolicitarCantidad(out int cantidad))
            {
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Desea imprimir {cantidad} código(s) para el artículo {existencia.ArticuloDTO?.Nombre ?? string.Empty}?\nCódigo: {existencia.Codigo}",
                "Confirmar impresión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var impresiones = new Impresiones();
                bool generado = impresiones.ImpresionCodigoArticulo(
                    existencia.Codigo,
                    existencia.ArticuloDTO?.Nombre ?? string.Empty,
                    existencia.NumeroLote,
                    cantidad);

                if (generado)
                {
                    MessageBox.Show(
                        "Los códigos fueron generados correctamente.",
                        "Impresión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron generar los códigos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool TrySolicitarCantidad(out int cantidad)
        {
            cantidad = 0;
            using var dialogo = new Form
            {
                Text = "Cantidad de códigos",
                Width = 320,
                Height = 150,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false
            };

            var etiqueta = new Label { Text = "Cantidad a imprimir:", Left = 15, Top = 15, AutoSize = true };
            var entrada = new NumericUpDown { Left = 15, Top = 40, Width = 270, Minimum = 1, Maximum = 1000, Value = 1 };
            var aceptar = new Button { Text = "Aceptar", DialogResult = DialogResult.OK, Left = 115, Top = 75, Width = 80 };
            var cancelar = new Button { Text = "Cancelar", DialogResult = DialogResult.Cancel, Left = 205, Top = 75, Width = 80 };

            dialogo.Controls.AddRange(new Control[] { etiqueta, entrada, aceptar, cancelar });
            dialogo.AcceptButton = aceptar;
            dialogo.CancelButton = cancelar;

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return false;
            }

            cantidad = (int)entrada.Value;
            return cantidad > 0;
        }

    }
}
