using TiendaLaLojanita.Models.DTO;

namespace TiendaLaLojanita.Views
{
    public partial class ArticuloInventarioLote : Form
    {
        private readonly List<ArticuloLoteInventarioDTO> _articulosLote;
        public ArticuloLoteInventarioDTO? ArticuloSeleccionado { get; private set; }

        public ArticuloInventarioLote(List<ArticuloLoteInventarioDTO> articulosLote)
        {
            InitializeComponent();
            _articulosLote = articulosLote ?? new List<ArticuloLoteInventarioDTO>();

            this.Load += ArticuloInventarioLote_Load;
            this.dgvArticulosLote.CellContentClick += dgvArticulosLote_CellContentClick;
            this.btnAgregar.Click += btnAgregar_Click;
            this.btnCancelar.Click += btnCancelar_Click;
        }

        private void ArticuloInventarioLote_Load(object? sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            this.dgvArticulosLote.Rows.Clear();
            foreach (var item in _articulosLote)
            {
                this.dgvArticulosLote.Rows.Add(
                    item.IdLote,
                    item.IdArticulo,
                    item.NombreArticulo,
                    item.Marca,
                    item.Unidad,
                    item.UnidadMedida,
                    item.NumeroLote,
                    item.Codigo ?? string.Empty,
                    item.FechaExpiracion.HasValue ? item.FechaExpiracion.Value.ToString("dd/MM/yyyy") : "N/A",
                    false);
            }
        }

        private void dgvArticulosLote_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (this.dgvArticulosLote.Columns[e.ColumnIndex].Name != "Seleccionar")
            {
                return;
            }

            foreach (DataGridViewRow row in this.dgvArticulosLote.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.Cells["Seleccionar"].Value = false;
                }
            }

            this.dgvArticulosLote.Rows[e.RowIndex].Cells["Seleccionar"].Value = true;
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            var fila = this.dgvArticulosLote.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(row => Convert.ToBoolean(row.Cells["Seleccionar"].Value ?? false));

            if (fila == null)
            {
                MessageBox.Show("Seleccione un lote para agregar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(fila.Cells["IdLote"].Value?.ToString(), out int idLote))
            {
                MessageBox.Show("No se pudo obtener el lote seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.ArticuloSeleccionado = _articulosLote.FirstOrDefault(item => item.IdLote == idLote);
            if (this.ArticuloSeleccionado == null)
            {
                MessageBox.Show("No se pudo resolver el lote seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
