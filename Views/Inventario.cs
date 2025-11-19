using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;

namespace TiendaLaLojanita.Views
{
    public partial class Inventario : Form
    {
        private List<TransaccionInventarioDTO> ListaTranInv;
        private readonly IInventarioService inventarioService;
        private List<InventarioDTO> ListaInventario;
        private List<DetalleInventarioDTO> ListaDetallesInventario;

        public Inventario(IInventarioService inventarioService)
        {
            InitializeComponent();
            ListaTranInv = new List<TransaccionInventarioDTO>();
            ListaInventario = new List<InventarioDTO>();
            ListaDetallesInventario = new List<DetalleInventarioDTO>();
            this.inventarioService = inventarioService;
            this.CargarDatosIniciales();
            this.CargarListaInventario();
        }

        private async void CargarDatosIniciales()
        {
            this.ListaTranInv = await this.inventarioService.ListaTransaccionesInventario();
            this.cbxTransaccion.Items.Clear();
            this.cbxTransaccion.DataSource = this.ListaTranInv;
            this.cbxTransaccion.DisplayMember = "Nombre";
            this.cbxTransaccion.ValueMember = "Id";
        }
        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (ofdArchivos.ShowDialog() == DialogResult.OK)
            {
                lblArchivo.Text = ofdArchivos.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private async void CargarListaInventario()
        {
            DateOnly fechaIni = DateOnly.FromDateTime(this.dtpFechaInicio.Value);
            DateOnly fechaFin = DateOnly.FromDateTime(this.dtpFechaFin.Value);
            this.ListaInventario = await this.inventarioService.ListaInventario(fechaIni, fechaFin);
            this.CargarTablaInv();
        }

        private void CargarTablaInv()
        {
            this.dgvInventario.Rows.Clear();
            foreach (var inv in ListaInventario)
            {
                int index = this.dgvInventario.Rows.Add(new object[]
                {
                    inv.Id,
                    inv.FechaCreacion,
                    Convert.ToString(inv.FechaActualizacion)?? "",
                    Convert.ToString(inv.FechaReversion)?? "",
                    inv.CompraDTO != null ? $"Compra Id: {inv.CompraDTO.Id}, Documento: {inv.CompraDTO.Documento}" : $"Venta Id: {inv.VentaDTO.Id}, Documento: {inv.VentaDTO.Documento}",
                });
            }
        }

        private async void CargarDetalles(int idInventario)
        {
            this.ListaDetallesInventario.Clear();
            this.ListaDetallesInventario = await this.inventarioService.ListaDetallesInventario(idInventario);
            if (this.ListaDetallesInventario.Count > 0)
            {
                this.CargarTablaDetallesInventario();
            }
        }
        private void CargarTablaDetallesInventario()
        {
            this.dgvDetallesInventario.Rows.Clear();
            foreach (var detalle in ListaDetallesInventario)
            {
                int index = this.dgvDetallesInventario.Rows.Add(new object[]
                {
                    detalle.Id,
                    detalle.ArticuloDTO.Nombre,
                    detalle.ArticuloDTO.Descripcion,
                    detalle.ArticuloDTO.ImpuestoArticuloDto.ValorImpuesto,
                    detalle.Cantidad,
                    detalle.PrecioCompra,
                    detalle.PrecioVenta,
                    detalle.ArticuloDTO.Papeleria == true ? "SI" : "NO"
                });
            }
        }
        private void btnBusquedaArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btbBuscarInv_Click(object sender, EventArgs e)
        {
            this.CargarListaInventario();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Evita clics en el encabezado
                if (e.RowIndex < 0)
                    return;

                // Obtén el ID siempre, sin importar dónde haya hecho clic
                int id = Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["IdInventario"].Value);
                // Llama al método que necesites
                this.CargarDetalles(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el Id: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
