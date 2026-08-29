using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Views
{
    public partial class ErroresRegistroArticuloExcel : Form
    {
        private readonly List<ArticuloErrorExcelDTO> errores;

        public ErroresRegistroArticuloExcel()
            : this(new List<ArticuloErrorExcelDTO>())
        {
        }

        public ErroresRegistroArticuloExcel(List<ArticuloErrorExcelDTO> errores)
        {
            InitializeComponent();
            this.errores = errores ?? new List<ArticuloErrorExcelDTO>();
            this.ConfigurarGrid();
            this.CargarErrores();
        }

        private void ConfigurarGrid()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            this.dataGridView1.Columns.Clear();

            

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.Nombre),
                HeaderText = "Nombre",
                Width = 180,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.Descripcion),
                HeaderText = "Descripción",
                Width = 180,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.IdMarca),
                HeaderText = "Id Marca",
                Width = 80,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.IdTipoArticulo),
                HeaderText = "Id Tipo",
                Width = 80,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.IdImpuesto),
                HeaderText = "Id Impuesto",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.IdPorcentajeGanancia),
                HeaderText = "Id Porcentaje",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

           /* this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.Unidad),
                HeaderText = "Unidad",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });*/

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.UnidadValor),
                HeaderText = "Valor Unidad",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.ValorCompra),
                HeaderText = "Valor Compra",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nameof(ArticuloCreacionDTO.ValorVenta),
                HeaderText = "Valor Venta",
                Width = 90,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fila",
                HeaderText = "Fila Excel",
                Width = 80,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Detalle",
                HeaderText = "Detalle de errores",
                Width = 260,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        private void CargarErrores()
        {
            if (this.errores == null || this.errores.Count == 0)
            {
                this.Text = "Errores de importación desde Excel";
                return;
            }

            this.Text = $"Errores de importación desde Excel ({this.errores.Count})";
            this.dataGridView1.Rows.Clear();

            foreach (var error in this.errores)
            {
                var fila = new object[]
                {
                    error.Articulo?.Nombre ?? string.Empty,
                    error.Articulo?.Descripcion ?? string.Empty,
                    error.Articulo?.IdMarca.ToString() ?? string.Empty,
                    error.Articulo?.IdTipoArticulo.ToString() ?? string.Empty,
                    error.Articulo?.IdImpuesto.ToString() ?? string.Empty,
                    error.Articulo?.IdPorcentajeGanancia?.ToString() ?? string.Empty,
                    error.Articulo?.IdUnidad.ToString() ?? string.Empty,
                    error.Articulo?.UnidadValor.ToString(CultureInfo.InvariantCulture) ?? string.Empty,
                    error.Articulo?.ValorCompra.ToString(CultureInfo.InvariantCulture) ?? string.Empty,
                    error.Articulo?.ValorVenta.ToString(CultureInfo.InvariantCulture) ?? string.Empty,
                    error.Fila,
                    string.Join(Environment.NewLine, error.Errores)
                };

                var rowIndex = this.dataGridView1.Rows.Add(fila);
                this.dataGridView1.Rows[rowIndex].Tag = error;
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = this.dataGridView1.Rows[e.RowIndex];
            if (row.Tag is not ArticuloErrorExcelDTO error) return;

            var nombreColumna = this.dataGridView1.Columns[e.ColumnIndex].Name;
            if (error.CamposInvalidos.Any(c => string.Equals(c, nombreColumna, StringComparison.OrdinalIgnoreCase)))
            {
                e.CellStyle.BackColor = Color.MistyRose;
                e.CellStyle.ForeColor = Color.DarkRed;
                e.CellStyle.SelectionBackColor = Color.LightCoral;
                e.CellStyle.SelectionForeColor = Color.Black;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
        }
    }
}



























































































































































































































































































































































































































































































