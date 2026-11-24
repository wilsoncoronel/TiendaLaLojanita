using SistemaTienda.DTO;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public partial class Pagos : Form
    {
        private int idVenta;
        private readonly IVentaService _ventaService;
        private readonly IPagoVentaService _pagoService;
        private List<TipoPagoDTO> _tiposPagos;
        private List<EstadosPagoDTO> _estadosPagos;
        private PagosVentasDTO _pagoVenta;
        private bool cargando;
        public Pagos(int idVenta, IVentaService ventaService, IPagoVentaService pagoService)
        {
            InitializeComponent();
            this.idVenta = idVenta;
            this._ventaService = ventaService;
            this._pagoService = pagoService;
            this._tiposPagos = new List<TipoPagoDTO>();
            this._estadosPagos = new List<EstadosPagoDTO>();
            dgvDetallePago.DefaultValuesNeeded += dgvDetallePago_DefaultValuesNeeded;
            dgvDetallePago.CellBeginEdit += dgvDetallePago_CellBeginEdit;
            dgvDetallePago.EditingControlShowing += dgvDetallePago_EditingControlShowing;
            dgvDetallePago.CellValueChanged += dgvDetallePago_CellValueChanged;
            dgvDetallePago.RowsRemoved += dgvDetallePago_RowsRemoved;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private async void Pagos_Load(object sender, EventArgs e)
        {
            try
            {
                this._pagoVenta = await CargarPago();
                this._tiposPagos = await _pagoService.ListarTiposPagos();
                this._estadosPagos = await _pagoService.ListarEstadosPagos();
                CargarPagoView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar los datos del pago: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<PagosVentasDTO> CargarPago()
        {
            return await this._pagoService.PagoVenta(this.idVenta);
        }

        private void CargarPagoView()
        {
            if (_pagoVenta is null)
            {
                return;
            }

            txtTotalVenta.Text = _pagoVenta.TotalVenta.ToString("N2");
            txtTotalPagado.Text = _pagoVenta.TotalPagado.ToString("N2");
            txtSaldoPendiente.Text = _pagoVenta.SaldoPendiente.ToString("N2");
            txtNota.Text = _pagoVenta.Nota ?? string.Empty;
            dtpFechaCreacion.Value = _pagoVenta.FechaCreacion == default
                ? DateTime.Now
                : _pagoVenta.FechaCreacion;
            dtpFechaPago.Value = _pagoVenta.FechaPago ?? DateTime.Now;

            cbxEstadoPago.DataSource = _estadosPagos ?? new List<EstadosPagoDTO>();
            cbxEstadoPago.DisplayMember = nameof(EstadosPagoDTO.Nombre);
            cbxEstadoPago.ValueMember = nameof(EstadosPagoDTO.Id);
            cbxEstadoPago.SelectedValue = _pagoVenta.IdEstadoPago;

            TipoPago.DataSource = _tiposPagos ?? new List<TipoPagoDTO>();
            TipoPago.DisplayMember = nameof(TipoPagoDTO.Nombre);
            TipoPago.ValueMember = nameof(TipoPagoDTO.Id);

            Estado.DataSource = new[]
            {
                new { Id = true, Nombre = "ACTIVO" },
                new { Id = false, Nombre = "ANULADO" }
            };
            Estado.DisplayMember = "Nombre";
            Estado.ValueMember = "Id";

            cargando = true;
            dgvDetallePago.Rows.Clear();
            foreach (var detalle in _pagoVenta.DetallesPago ?? new List<DetallePagoCreacionDTO>())
            {
                int rowIndex = dgvDetallePago.Rows.Add();
                DataGridViewRow row = dgvDetallePago.Rows[rowIndex];
                row.Tag = false;
                row.Cells[nameof(Id)].Value = detalle.IdPagoVenta;
                row.Cells[nameof(TipoPago)].Value = detalle.IdTipoPago;
                row.Cells[nameof(Valor)].Value = detalle.Valor;
                row.Cells[nameof(NroComprobante)].Value = detalle.NumeroComprobante ?? string.Empty;
                row.Cells[nameof(FechaPago)].Value = detalle.FechaPago;
                row.Cells[nameof(Nota)].Value = detalle.Nota ?? string.Empty;
                row.Cells[nameof(Estado)].Value = detalle.Estado;
            }

            txtTotalVenta.ReadOnly = true;
            txtTotalPagado.ReadOnly = true;
            txtSaldoPendiente.ReadOnly = true;
            txtNota.ReadOnly = true;
            cbxEstadoPago.Enabled = false;
            dtpFechaCreacion.Enabled = false;
            dtpFechaPago.Enabled = false;
            dgvDetallePago.ReadOnly = false;
            dgvDetallePago.AllowUserToAddRows = _pagoVenta.SaldoPendiente > 0;
            dgvDetallePago.AllowUserToDeleteRows = false;
            cargando = false;
            ActualizarResumenVisual();
        }

        private void dgvDetallePago_DefaultValuesNeeded(object? sender, DataGridViewRowEventArgs e)
        {
            e.Row.Tag = true;
            e.Row.Cells[nameof(FechaPago)].Value = DateTime.Now;
            e.Row.Cells[nameof(Estado)].Value = true;
        }

        private void dgvDetallePago_CellBeginEdit(object? sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetallePago.Rows[e.RowIndex].Tag is not true)
            {
                e.Cancel = true;
            }
        }

        private void dgvDetallePago_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetallePago.CurrentCell?.OwningColumn?.Name == nameof(Valor)
                && e.Control is TextBox textBox)
            {
                ValidacionesDecimales.Aplicar(textBox, 2);
            }
        }

        private void dgvDetallePago_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (!cargando)
            {
                ActualizarResumenVisual();
            }
        }

        private void dgvDetallePago_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!cargando)
            {
                ActualizarResumenVisual();
            }
        }

        private void ActualizarResumenVisual()
        {
            if (_pagoVenta is null)
            {
                return;
            }

            decimal totalPagado = 0m;
            foreach (DataGridViewRow row in dgvDetallePago.Rows)
            {
                if (row.IsNewRow || row.Cells[nameof(Estado)].Value is not true)
                {
                    continue;
                }

                if (decimal.TryParse(Convert.ToString(row.Cells[nameof(Valor)].Value), out decimal valor))
                {
                    totalPagado += valor;
                }
            }

            decimal saldo = Math.Max(0m, _pagoVenta.TotalVenta - totalPagado);
            txtTotalPagado.Text = totalPagado.ToString("N2");
            txtSaldoPendiente.Text = saldo.ToString("N2");

            int estadoId = totalPagado == 0m
                ? _estadosPagos.FirstOrDefault(x => x.Nombre.Equals("PENDIENTE", StringComparison.OrdinalIgnoreCase))?.Id ?? 0
                : saldo == 0m
                    ? _estadosPagos.FirstOrDefault(x => x.Nombre.Equals("PAGADO", StringComparison.OrdinalIgnoreCase))?.Id ?? 0
                    : _estadosPagos.FirstOrDefault(x => x.Nombre.Equals("PARCIAL", StringComparison.OrdinalIgnoreCase))?.Id ?? 0;
            cbxEstadoPago.SelectedValue = estadoId;
            dgvDetallePago.AllowUserToAddRows = saldo > 0m;
        }

        private async void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (_pagoVenta is null || _pagoVenta.SaldoPendiente == 0m)
            {
                MessageBox.Show("No existe saldo pendiente para registrar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filasNuevas = dgvDetallePago.Rows
                .Cast<DataGridViewRow>()
                .Where(x => !x.IsNewRow && x.Tag is true)
                .ToList();
            decimal saldoDisponible = _pagoVenta.TotalVenta - _pagoVenta.TotalPagado;

            foreach (DataGridViewRow fila in filasNuevas)
            {
                if (!decimal.TryParse(Convert.ToString(fila.Cells[nameof(Valor)].Value), out decimal valor))
                {
                    MessageBox.Show("El valor del pago no es válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var detalle = new DetallePagoCreacionDTO
                {
                    IdPagoVenta = _pagoVenta.Id,
                    IdTipoPago = Convert.ToInt32(fila.Cells[nameof(TipoPago)].Value ?? 0),
                    Valor = valor,
                    NumeroComprobante = Convert.ToString(fila.Cells[nameof(NroComprobante)].Value),
                    FechaPago = Convert.ToDateTime(fila.Cells[nameof(FechaPago)].Value ?? DateTime.Now),
                    Nota = Convert.ToString(fila.Cells[nameof(Nota)].Value),
                    Estado = true
                };

                ValidationResult resultado = new DetallePagoValidator().Validate(detalle);
                if (!resultado.IsValid || valor > saldoDisponible)
                {
                    string errores = string.Join(Environment.NewLine, resultado.Errors.Select(x => x.ErrorMessage));
                    if (valor > saldoDisponible)
                    {
                        errores += $"{Environment.NewLine}El valor no puede superar el saldo pendiente.";
                    }
                    MessageBox.Show(errores, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idDetalle = await _pagoService.CrearDetallePago(detalle);
                if (idDetalle <= 0)
                {
                    MessageBox.Show("No se pudo guardar el detalle de pago.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                saldoDisponible -= valor;
            }

            _pagoVenta = await CargarPago();
            CargarPagoView();
            MessageBox.Show("Detalle de pago guardado correctamente.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
