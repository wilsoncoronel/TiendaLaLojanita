using FluentValidation.Results;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;
using TiendaLaLojanita.Validaciones;

namespace TiendaLaLojanita.Views
{
    public class AplicarCreditoCompra : Form
    {
        private readonly ICreditoProveedorService _creditoService;
        private readonly ICompraService _compraService;
        private readonly CreditoProveedorDTO _credito;
        private readonly TextBox _txtBuscarCompra = new();
        private readonly Button _btnBuscar = new();
        private readonly DataGridView _dgvCompras = new();
        private readonly NumericUpDown _nudValor = new();
        private readonly Label _lblSaldo = new();
        private readonly Button _btnAplicar = new();
        private List<CompraMinDTO> _compras = new();
        private int _idCompraSeleccionada;

        public AplicarCreditoCompra(
            ICreditoProveedorService creditoService,
            ICompraService compraService,
            CreditoProveedorDTO credito)
        {
            _creditoService = creditoService;
            _compraService = compraService;
            _credito = credito;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Aplicar crédito a compra";
            Width = 1000;
            Height = 600;
            StartPosition = FormStartPosition.CenterParent;
            Padding = new Padding(12);

            var panelBusqueda = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 42,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };
            panelBusqueda.Controls.Add(new Label { Text = "Id o documento:", AutoSize = true, Margin = new Padding(0, 8, 8, 0) });
            _txtBuscarCompra.Width = 220;
            _txtBuscarCompra.KeyDown += async (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    await BuscarCompras();
                }
            };
            panelBusqueda.Controls.Add(_txtBuscarCompra);
            _btnBuscar.Text = "Buscar compra";
            _btnBuscar.AutoSize = true;
            _btnBuscar.Click += async (_, _) => await BuscarCompras();
            panelBusqueda.Controls.Add(_btnBuscar);
            panelBusqueda.Controls.Add(new Label { Text = "Saldo disponible:", AutoSize = true, Margin = new Padding(20, 8, 8, 0) });
            _lblSaldo.AutoSize = true;
            _lblSaldo.Margin = new Padding(0, 8, 0, 0);
            panelBusqueda.Controls.Add(_lblSaldo);
            Controls.Add(panelBusqueda);

            ConfigurarGrid();
            Controls.Add(_dgvCompras);

            var panelAplicacion = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 52,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };
            panelAplicacion.Controls.Add(new Label { Text = "Valor a aplicar:", AutoSize = true, Margin = new Padding(0, 10, 8, 0) });
            _nudValor.DecimalPlaces = 2;
            _nudValor.ThousandsSeparator = true;
            _nudValor.Minimum = 0.01m;
            _nudValor.Maximum = _credito.ValorDisponible > 0 ? _credito.ValorDisponible : 0.01m;
            _nudValor.Width = 140;
            panelAplicacion.Controls.Add(_nudValor);
            _btnAplicar.Text = "Aplicar crédito";
            _btnAplicar.AutoSize = true;
            _btnAplicar.Click += async (_, _) => await Aplicar();
            panelAplicacion.Controls.Add(_btnAplicar);
            Controls.Add(panelAplicacion);

            _lblSaldo.Text = _credito.ValorDisponible.ToString("N2");
        }

        private void ConfigurarGrid()
        {
            _dgvCompras.Dock = DockStyle.Fill;
            _dgvCompras.AutoGenerateColumns = false;
            _dgvCompras.AllowUserToAddRows = false;
            _dgvCompras.ReadOnly = true;
            _dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvCompras.MultiSelect = false;
            _dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", DataPropertyName = "Id", Width = 80 });
            _dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "Documento", HeaderText = "Documento", DataPropertyName = "Documento", Width = 180 });
            _dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaCompra", HeaderText = "Fecha", DataPropertyName = "FechaCompra", Width = 140, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            _dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "Proveedor", HeaderText = "Proveedor", DataPropertyName = "ProveedorMinDto.RazonSocial", Width = 240 });
            _dgvCompras.Columns.Add(new DataGridViewTextBoxColumn { Name = "Total", HeaderText = "Total", DataPropertyName = "Total", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
            _dgvCompras.SelectionChanged += (_, _) =>
            {
                if (_dgvCompras.CurrentRow?.DataBoundItem is CompraMinDTO compra)
                    _idCompraSeleccionada = compra.Id;
            };
        }

        private async Task BuscarCompras()
        {
            if (string.IsNullOrWhiteSpace(_txtBuscarCompra.Text))
            {
                MessageBox.Show("Ingrese el Id o documento de la compra.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CambiarEstado(true);
                _compras = await _compraService.ListaCompraDevolucion(_txtBuscarCompra.Text.Trim());
                _dgvCompras.DataSource = _compras;
                if (_compras.Count == 0)
                    MessageBox.Show("No se encontraron compras con el criterio indicado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            finally
            {
                CambiarEstado(false);
            }
        }

        private async Task Aplicar()
        {
            var solicitud = new AplicarCreditoCompraDTO
            {
                IdCreditoProveedor = _credito.Id,
                IdCompra = _idCompraSeleccionada,
                Valor = _nudValor.Value
            };

            ValidationResult resultado = new AplicarCreditoCompraValidator().Validate(solicitud);
            if (!resultado.IsValid)
            {
                MessageBox.Show(
                    string.Join(Environment.NewLine, resultado.Errors.Select(error => error.ErrorMessage)),
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (solicitud.Valor > _credito.ValorDisponible)
            {
                MessageBox.Show("El valor no puede superar el saldo disponible mostrado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(
                    $"¿Desea aplicar {solicitud.Valor:N2} del crédito a la compra {solicitud.IdCompra}?",
                    "Confirmar aplicación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                CambiarEstado(true);
                var aplicada = await _creditoService.AplicarCreditoCompra(solicitud);
                if (!aplicada)
                {
                    MessageBox.Show("La API no confirmó la aplicación del crédito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Crédito aplicado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ApiException ex)
            {
                ApiErrorHandler.Mostrar(ex);
            }
            finally
            {
                CambiarEstado(false);
            }
        }

        private void CambiarEstado(bool ocupado)
        {
            _btnBuscar.Enabled = !ocupado;
            _btnAplicar.Enabled = !ocupado;
            _txtBuscarCompra.Enabled = !ocupado;
            _dgvCompras.Enabled = !ocupado;
            UseWaitCursor = ocupado;
        }
    }
}
