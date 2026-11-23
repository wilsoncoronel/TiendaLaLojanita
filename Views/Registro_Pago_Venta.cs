using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTienda.DTO;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Utilidad;

namespace TiendaLaLojanita.Views
{
    public partial class Registro_Pago_Venta : Form
    {
        private readonly decimal totalVenta;
        private bool permitirCierre;

        private const int TipoPagoEfectivo = 1;
        private const int TipoPagoTransferencia = 2;
        private const int EstadoPendiente = 1;
        private const int EstadoParcial = 2;
        private const int EstadoPagado = 3;

        public PagoVentaCreacionDTO? PagoVenta { get; private set; }

        public Registro_Pago_Venta(decimal totalVenta)
        {
            InitializeComponent();
            this.totalVenta = totalVenta;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            txtTotalPagar.Text = totalVenta.ToString("0.00");
            txtValorPago.Text = "0";
            txtSaldoPendiente.Text = totalVenta.ToString("0.00");
            dtpCreacion.Value = DateTime.Now;

            cbxTipoPago.DataSource = new List<TipoPagoDTO>
            {
                new() { Id = TipoPagoEfectivo, Nombre = "EFECTIVO" },
                new() { Id = TipoPagoTransferencia, Nombre = "TRANSFERENCIA" }
            };
            cbxTipoPago.DisplayMember = nameof(TipoPagoDTO.Nombre);
            cbxTipoPago.ValueMember = nameof(TipoPagoDTO.Id);

            cbxEstadoPago.DataSource = new List<EstadosPagoDTO>
            {
                new() { Id = EstadoPendiente, Nombre = "PENDIENTE" },
                new() { Id = EstadoParcial, Nombre = "PARCIAL" },
                new() { Id = EstadoPagado, Nombre = "PAGADO" }
            };
            cbxEstadoPago.DisplayMember = nameof(EstadosPagoDTO.Nombre);
            cbxEstadoPago.ValueMember = nameof(EstadosPagoDTO.Id);
            cbxEstadoPago.Enabled = false;

            ValidacionesDecimales.Aplicar(txtValorPago);
            txtValorPago.TextChanged += txtValorPago_TextChanged;
            cbxTipoPago.SelectedIndexChanged += cbxTipoPago_SelectedIndexChanged;
            btnPagar.Click += btnPagar_Click;
            btnCancelar.Click += btnCancelar_Click;
            FormClosing += Registro_Pago_Venta_FormClosing;
            ActualizarDatosPago();
        }

        private void txtValorPago_TextChanged(object? sender, EventArgs e)
        {
            ActualizarDatosPago();
        }

        private void cbxTipoPago_SelectedIndexChanged(object? sender, EventArgs e)
        {
            bool esEfectivo = Convert.ToInt32(cbxTipoPago.SelectedValue) == TipoPagoEfectivo;
            txtNroComprobante.Enabled = !esEfectivo;
            if (esEfectivo)
            {
                txtNroComprobante.Clear();
            }
        }

        private void ActualizarDatosPago()
        {
            if (!decimal.TryParse(txtValorPago.Text, out decimal valorPago))
            {
                valorPago = 0m;
            }

            decimal saldo = Math.Max(0m, totalVenta - valorPago);
            int estado = valorPago == 0m
                ? EstadoPendiente
                : saldo == 0m ? EstadoPagado : EstadoParcial;

            txtSaldoPendiente.Text = saldo.ToString("0.00");
            if (cbxEstadoPago.DataSource != null)
            {
                cbxEstadoPago.SelectedValue = estado;
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar el pago?", "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            permitirCierre = true;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnPagar_Click(object? sender, EventArgs e)
        {
            if (!ValidacionesDecimales.EsDecimalFinalValido(txtValorPago.Text)
                || !decimal.TryParse(txtValorPago.Text, out decimal valorPago))
            {
                MessageBox.Show("Ingrese un valor de pago válido.", "Valor inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorPago.Focus();
                return;
            }

            if (valorPago < 0m || valorPago > totalVenta)
            {
                MessageBox.Show("El valor de pago no puede ser negativo ni superar el total de la venta.",
                    "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorPago.Focus();
                return;
            }

            decimal saldo = totalVenta - valorPago;
            int estadoPago = valorPago == 0m
                ? EstadoPendiente
                : saldo == 0m ? EstadoPagado : EstadoParcial;
            int tipoPago = Convert.ToInt32(cbxTipoPago.SelectedValue);
            string? comprobante = tipoPago == TipoPagoEfectivo
                ? null
                : string.IsNullOrWhiteSpace(txtNroComprobante.Text)
                    ? null
                    : txtNroComprobante.Text.Trim();

            PagoVenta = new PagoVentaCreacionDTO
            {
                TotalVenta = totalVenta,
                TotalPagado = valorPago,
                SaldoPendiente = saldo,
                IdEstadoPago = estadoPago,
                Nota = txtNota.Text.Trim(),
                FechaCreacion = dtpCreacion.Value,
                FechaPago = valorPago > 0m ? DateTime.Now : null,
                DetallesPago = new List<DetallePagoCreacionDTO>
                {
                    new()
                    {
                        IdTipoPago = tipoPago,
                        Valor = valorPago,
                        NumeroComprobante = comprobante,
                        FechaPago = DateTime.Now,
                        Nota = txtNota.Text.Trim(),
                        Estado = valorPago > 0m
                    }
                }
            };

            permitirCierre = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Registro_Pago_Venta_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (permitirCierre || DialogResult == DialogResult.OK)
            {
                return;
            }

            var respuesta = MessageBox.Show("¿Está seguro de cancelar el pago?", "Confirmar cancelación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                permitirCierre = true;
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
