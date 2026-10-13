using System.Net;
using Microsoft.Extensions.DependencyInjection;
using TiendaLaLojanita.Models.DTO;
using TiendaLaLojanita.Models.Interfaces;
using TiendaLaLojanita.Utilidad;

namespace TiendaLaLojanita.Views
{
    public class CreditosProveedor : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly ICreditoProveedorService _creditoService;
        private readonly ICompraService _compraService;
        private readonly IServiceProvider _serviceProvider;
        private readonly ComboBox _cbxProveedor = new();
        private readonly Button _btnBuscar = new();
        private readonly DataGridView _dgvCreditos = new();
        private readonly Label _lblEstado = new();
        private readonly BindingSource _fuenteCreditos = new();
        private List<CreditoProveedorListaDTO> _creditos = new();

        public CreditosProveedor(
            IProveedorService proveedorService,
            ICreditoProveedorService creditoService,
            ICompraService compraService,
            IServiceProvider serviceProvider)
        {
            _proveedorService = proveedorService;
            _creditoService = creditoService;
            _compraService = compraService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Load += CreditosProveedor_Load;
        }

        private async void CreditosProveedor_Load(object? sender, EventArgs e)
        {
            await CargarProveedores();
        }

        private void InitializeComponent()
        {
            Text = "Créditos de proveedor";
            Dock = DockStyle.Fill;
            Padding = new Padding(12);

            var panelBusqueda = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 42,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            panelBusqueda.Controls.Add(new Label
            {
                Text = "Proveedor:",
                AutoSize = true,
                Margin = new Padding(0, 8, 8, 0)
            });

            _cbxProveedor.Width = 300;
            _cbxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            panelBusqueda.Controls.Add(_cbxProveedor);

            _btnBuscar.Text = "Consultar créditos";
            _btnBuscar.AutoSize = true;
            _btnBuscar.Click += async (_, _) => await CargarCreditos();
            panelBusqueda.Controls.Add(_btnBuscar);

            _lblEstado.AutoSize = true;
            _lblEstado.Margin = new Padding(12, 8, 0, 0);
            panelBusqueda.Controls.Add(_lblEstado);

            ConfigurarGrid();
            Controls.Add(_dgvCreditos);
            Controls.Add(panelBusqueda);
        }

        private void ConfigurarGrid()
        {
            _dgvCreditos.Dock = DockStyle.Fill;
            _dgvCreditos.AutoGenerateColumns = false;
            _dgvCreditos.AllowUserToAddRows = false;
            _dgvCreditos.ReadOnly = true;
            _dgvCreditos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvCreditos.MultiSelect = false;
            _dgvCreditos.CellDoubleClick += async (_, e) =>
            {
                if (e.RowIndex >= 0)
                    await AbrirDetalle(e.RowIndex);
            };

            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", DataPropertyName = "Id", Width = 70 });
            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdDevolucion", HeaderText = "Id devolución", DataPropertyName = "IdDevolucionCompra", Width = 100 });
            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Proveedor", HeaderText = "Proveedor", DataPropertyName = "Proveedor", Width = 220 });
            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha", DataPropertyName = "FechaCreacion", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }, Width = 140 });
            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "ValorOriginal", HeaderText = "Valor original", DataPropertyName = "ValorOriginal", DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }, Width = 120 });
            _dgvCreditos.Columns.Add(new DataGridViewTextBoxColumn { Name = "ValorDisponible", HeaderText = "Valor disponible", DataPropertyName = "ValorDisponible", DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }, Width = 120 });
            _dgvCreditos.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Estado", HeaderText = "Activo", DataPropertyName = "Estado", Width = 70 });
            _dgvCreditos.Columns.Add(new DataGridViewButtonColumn { Name = "Detalle", HeaderText = "", Text = "Ver detalle", UseColumnTextForButtonValue = true, Width = 100 });
            _dgvCreditos.CellContentClick += async (_, e) =>
            {
                if (e.RowIndex >= 0 && _dgvCreditos.Columns[e.ColumnIndex].Name == "Detalle")
                    await AbrirDetalle(e.RowIndex);
            };
        }

        private async Task CargarProveedores()
        {
            try
            {
                CambiarEstado("Cargando proveedores...", true);
                var proveedores = await _proveedorService.ListarProveedores();
                _cbxProveedor.DataSource = proveedores;
                _cbxProveedor.DisplayMember = nameof(ProveedorDTO.RazonSocial);
                _cbxProveedor.ValueMember = nameof(ProveedorDTO.Id);
                CambiarEstado(proveedores.Count == 0 ? "No hay proveedores disponibles." : string.Empty, false);
            }
            catch (ApiException ex)
            {
                CambiarEstado(string.Empty, false);
                ApiErrorHandler.Mostrar(ex);
            }
        }

        private async Task CargarCreditos()
        {
            if (_cbxProveedor.SelectedItem is not ProveedorDTO proveedor)
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CambiarEstado("Cargando créditos...", true);
                _creditos = await _creditoService.ListarCreditosProveedor(proveedor.Id);
                _fuenteCreditos.DataSource = _creditos;
                _dgvCreditos.DataSource = _fuenteCreditos;
                CambiarEstado(_creditos.Count == 0 ? "No se encontraron créditos para el proveedor." : $"{_creditos.Count} crédito(s)", false);
            }
            catch (ApiException ex)
            {
                _creditos.Clear();
                _fuenteCreditos.ResetBindings(false);
                CambiarEstado(string.Empty, false);
                ApiErrorHandler.Mostrar(ex);
            }
        }

        private async Task AbrirDetalle(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _dgvCreditos.Rows.Count)
                return;

            if (_dgvCreditos.Rows[rowIndex].DataBoundItem is not CreditoProveedorListaDTO credito)
                return;

            using var detalle = ActivatorUtilities.CreateInstance<CreditoProveedorDetalle>(
                _serviceProvider,
                credito.Id);
            if (detalle.ShowDialog(this) == DialogResult.OK)
                await CargarCreditos();
        }

        private void CambiarEstado(string mensaje, bool ocupado)
        {
            _lblEstado.Text = mensaje;
            _btnBuscar.Enabled = !ocupado;
            _cbxProveedor.Enabled = !ocupado;
            UseWaitCursor = ocupado;
        }
    }
}
