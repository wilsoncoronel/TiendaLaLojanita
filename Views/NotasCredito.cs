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
    public partial class NotasCredito : Form
    {
        public CreditoProveedorListaDTO? NotaSeleccionada { get; private set; }

        public NotasCredito(IEnumerable<CreditoProveedorListaDTO> notasCredito)
        {
            InitializeComponent();

            foreach (var nota in notasCredito
                .OrderBy(nota => nota.FechaCreacion)
                .ThenBy(nota => nota.Id))
            {
                dataGridView1.Rows.Add(
                    nota.Id,
                    nota.ValorOriginal,
                    nota.ValorDisponible,
                    nota.FechaCreacion,
                    nota.Estado ? "Activa" : "Inactiva",
                    false);
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != Seleccionar.Index)
            {
                return;
            }

            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[Seleccionar.Index].Value))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex)
                    {
                        row.Cells[Seleccionar.Index].Value = false;
                    }
                }
            }
        }

        private void btnAceptar_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? filaSeleccionada = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(fila =>
                    !fila.IsNewRow &&
                    Convert.ToBoolean(fila.Cells[Seleccionar.Index].Value));

            if (filaSeleccionada is null)
            {
                MessageBox.Show(
                    "Debe seleccionar una nota de crédito.",
                    "Nota de crédito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(filaSeleccionada.Cells[Id.Index].Value);
            NotaSeleccionada = new CreditoProveedorListaDTO
            {
                Id = id,
                ValorOriginal = Convert.ToDecimal(filaSeleccionada.Cells[ValorOriginal.Index].Value),
                ValorDisponible = Convert.ToDecimal(filaSeleccionada.Cells[ValorDisponible.Index].Value),
                FechaCreacion = Convert.ToDateTime(filaSeleccionada.Cells[FechaCreacion.Index].Value),
                Estado = true
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            NotaSeleccionada = null;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
