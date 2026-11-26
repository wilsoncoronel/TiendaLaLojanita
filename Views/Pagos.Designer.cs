namespace TiendaLaLojanita.Views
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            helpProvider1 = new HelpProvider();
            groupBox2 = new GroupBox();
            dtpFechaPago = new DateTimePicker();
            label7 = new Label();
            dtpFechaCreacion = new DateTimePicker();
            txtNota = new TextBox();
            cbxEstadoPago = new ComboBox();
            txtSaldoPendiente = new TextBox();
            txtTotalPagado = new TextBox();
            txtTotalVenta = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvDetallePago = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewComboBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            NroComprobante = new DataGridViewTextBoxColumn();
            FechaPago = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewComboBoxColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtTotalPagos = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            dtpFinal = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            cbxCliente = new ComboBox();
            dgvDetallesPagos = new DataGridView();
            IdDet = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ValorPago = new DataGridViewTextBoxColumn();
            NumComprobante = new DataGridViewTextBoxColumn();
            FechaPagoDet = new DataGridViewTextBoxColumn();
            NotaDet = new DataGridViewTextBoxColumn();
            EstadoDet = new DataGridViewTextBoxColumn();
            dgvPagos = new DataGridView();
            IdPag = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            TotalVenta = new DataGridViewTextBoxColumn();
            TotalPagado = new DataGridViewTextBoxColumn();
            SaldoPendiente = new DataGridViewTextBoxColumn();
            IdEstadoPago = new DataGridViewTextBoxColumn();
            EstadoPago = new DataGridViewTextBoxColumn();
            NotaPago = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            FechaCierre = new DataGridViewTextBoxColumn();
            btnBuscarPago = new Button();
            label8 = new Label();
            btnExportarExcel = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePago).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesPagos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFechaPago);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dtpFechaCreacion);
            groupBox2.Controls.Add(txtNota);
            groupBox2.Controls.Add(cbxEstadoPago);
            groupBox2.Controls.Add(txtSaldoPendiente);
            groupBox2.Controls.Add(txtTotalPagado);
            groupBox2.Controls.Add(txtTotalVenta);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1008, 202);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(491, 160);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(268, 23);
            dtpFechaPago.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 164);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha pago:";
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Location = new Point(121, 160);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(268, 23);
            dtpFechaCreacion.TabIndex = 11;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(121, 105);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(546, 42);
            txtNota.TabIndex = 10;
            // 
            // cbxEstadoPago
            // 
            cbxEstadoPago.FormattingEnabled = true;
            cbxEstadoPago.Location = new Point(471, 63);
            cbxEstadoPago.Name = "cbxEstadoPago";
            cbxEstadoPago.Size = new Size(195, 23);
            cbxEstadoPago.TabIndex = 9;
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Location = new Point(119, 62);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(196, 23);
            txtSaldoPendiente.TabIndex = 8;
            // 
            // txtTotalPagado
            // 
            txtTotalPagado.Location = new Point(471, 23);
            txtTotalPagado.Name = "txtTotalPagado";
            txtTotalPagado.Size = new Size(196, 23);
            txtTotalPagado.TabIndex = 7;
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(121, 23);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(196, 23);
            txtTotalVenta.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 166);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha creación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 108);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Nota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 66);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 66);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Saldo pendiente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 26);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Total pagado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Total venta:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvDetallePago);
            groupBox3.Location = new Point(6, 214);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1367, 344);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle Pago";
            // 
            // dgvDetallePago
            // 
            dgvDetallePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePago.Columns.AddRange(new DataGridViewColumn[] { Id, TipoPago, Valor, NroComprobante, FechaPago, Nota, Estado });
            dgvDetallePago.Location = new Point(0, 22);
            dgvDetallePago.Name = "dgvDetallePago";
            dgvDetallePago.Size = new Size(1361, 316);
            dgvDetallePago.TabIndex = 0;
            dgvDetallePago.CellBeginEdit += dgvDetallePago_CellBeginEdit_1;
            dgvDetallePago.CellValueChanged += dgvDetallePago_CellValueChanged_1;
            dgvDetallePago.DefaultValuesNeeded += dgvDetallePago_DefaultValuesNeeded_1;
            dgvDetallePago.EditingControlShowing += dgvDetallePago_EditingControlShowing_1;
            dgvDetallePago.RowsRemoved += dgvDetallePago_RowsRemoved_1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // TipoPago
            // 
            TipoPago.HeaderText = "Tipo Pago";
            TipoPago.Name = "TipoPago";
            TipoPago.Resizable = DataGridViewTriState.True;
            TipoPago.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // NroComprobante
            // 
            NroComprobante.HeaderText = "NroComprobante";
            NroComprobante.Name = "NroComprobante";
            // 
            // FechaPago
            // 
            FechaPago.HeaderText = "Fecha Pago";
            FechaPago.Name = "FechaPago";
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Resizable = DataGridViewTriState.True;
            Estado.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._4856668_resize;
            btnGuardar.Location = new Point(1169, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 73);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar_resize;
            btnCancelar.Location = new Point(1169, 121);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(204, 73);
            btnCancelar.TabIndex = 7;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1413, 599);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnCancelar);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1405, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pagos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnExportarExcel);
            tabPage2.Controls.Add(txtTotalPagos);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(dtpFinal);
            tabPage2.Controls.Add(dtpInicio);
            tabPage2.Controls.Add(cbxCliente);
            tabPage2.Controls.Add(dgvDetallesPagos);
            tabPage2.Controls.Add(dgvPagos);
            tabPage2.Controls.Add(btnBuscarPago);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1405, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado de Pagos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTotalPagos
            // 
            txtTotalPagos.Font = new Font("Segoe UI", 12F);
            txtTotalPagos.Location = new Point(1270, 505);
            txtTotalPagos.Name = "txtTotalPagos";
            txtTotalPagos.Size = new Size(129, 29);
            txtTotalPagos.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(1142, 508);
            label11.Name = "label11";
            label11.Size = new Size(122, 21);
            label11.TabIndex = 10;
            label11.Text = "TOTAL PAGADO:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(786, 18);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 9;
            label10.Text = "Fecha Fin:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(492, 18);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 8;
            label9.Text = "Fecha Inicio:";
            // 
            // dtpFinal
            // 
            dtpFinal.Location = new Point(852, 14);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(200, 23);
            dtpFinal.TabIndex = 7;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(571, 15);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 6;
            // 
            // cbxCliente
            // 
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(50, 15);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(409, 23);
            cbxCliente.TabIndex = 5;
            // 
            // dgvDetallesPagos
            // 
            dgvDetallesPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesPagos.Columns.AddRange(new DataGridViewColumn[] { IdDet, Tipo, ValorPago, NumComprobante, FechaPagoDet, NotaDet, EstadoDet });
            dgvDetallesPagos.Location = new Point(638, 52);
            dgvDetallesPagos.Name = "dgvDetallesPagos";
            dgvDetallesPagos.Size = new Size(761, 433);
            dgvDetallesPagos.TabIndex = 4;
            // 
            // IdDet
            // 
            IdDet.HeaderText = "Id";
            IdDet.Name = "IdDet";
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo Pago";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // ValorPago
            // 
            ValorPago.HeaderText = "Valor";
            ValorPago.Name = "ValorPago";
            ValorPago.ReadOnly = true;
            // 
            // NumComprobante
            // 
            NumComprobante.HeaderText = "Comprobante";
            NumComprobante.Name = "NumComprobante";
            NumComprobante.ReadOnly = true;
            // 
            // FechaPagoDet
            // 
            FechaPagoDet.HeaderText = "Fecha Pago";
            FechaPagoDet.Name = "FechaPagoDet";
            FechaPagoDet.ReadOnly = true;
            // 
            // NotaDet
            // 
            NotaDet.HeaderText = "Nota";
            NotaDet.Name = "NotaDet";
            NotaDet.ReadOnly = true;
            // 
            // EstadoDet
            // 
            EstadoDet.HeaderText = "Estado";
            EstadoDet.Name = "EstadoDet";
            EstadoDet.ReadOnly = true;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Columns.AddRange(new DataGridViewColumn[] { IdPag, Cliente, IdVenta, TotalVenta, TotalPagado, SaldoPendiente, IdEstadoPago, EstadoPago, NotaPago, FechaCreacion, FechaCierre });
            dgvPagos.Location = new Point(9, 52);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(623, 513);
            dgvPagos.TabIndex = 3;
            // 
            // IdPag
            // 
            IdPag.HeaderText = "Id";
            IdPag.Name = "IdPag";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "IdVenta";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            IdVenta.Visible = false;
            // 
            // TotalVenta
            // 
            TotalVenta.HeaderText = "TotalVenta";
            TotalVenta.Name = "TotalVenta";
            TotalVenta.ReadOnly = true;
            // 
            // TotalPagado
            // 
            TotalPagado.HeaderText = "TotalPagado";
            TotalPagado.Name = "TotalPagado";
            TotalPagado.ReadOnly = true;
            // 
            // SaldoPendiente
            // 
            SaldoPendiente.HeaderText = "SaldoPendiente";
            SaldoPendiente.Name = "SaldoPendiente";
            SaldoPendiente.ReadOnly = true;
            // 
            // IdEstadoPago
            // 
            IdEstadoPago.HeaderText = "IdEstadoPago";
            IdEstadoPago.Name = "IdEstadoPago";
            IdEstadoPago.Visible = false;
            // 
            // EstadoPago
            // 
            EstadoPago.HeaderText = "Estado";
            EstadoPago.Name = "EstadoPago";
            EstadoPago.ReadOnly = true;
            // 
            // NotaPago
            // 
            NotaPago.HeaderText = "Nota";
            NotaPago.Name = "NotaPago";
            NotaPago.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Creación";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // FechaCierre
            // 
            FechaCierre.HeaderText = "Cierre";
            FechaCierre.Name = "FechaCierre";
            FechaCierre.ReadOnly = true;
            // 
            // btnBuscarPago
            // 
            btnBuscarPago.Location = new Point(1058, 3);
            btnBuscarPago.Name = "btnBuscarPago";
            btnBuscarPago.Size = new Size(97, 43);
            btnBuscarPago.TabIndex = 2;
            btnBuscarPago.Text = "Buscar";
            btnBuscarPago.UseVisualStyleBackColor = true;
            btnBuscarPago.Click += btnBuscarPago_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 20);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 0;
            label8.Text = "Cliente:";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Image = Properties.Resources.xls_reduce2;
            btnExportarExcel.Location = new Point(1161, 3);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(103, 43);
            btnExportarExcel.TabIndex = 12;
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 614);
            Controls.Add(tabControl1);
            Name = "Pagos";
            Text = "Pagos";
            Load += Pagos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallePago).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesPagos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HelpProvider helpProvider1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDetallePago;
        private TextBox txtTotalVenta;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtNota;
        private ComboBox cbxEstadoPago;
        private TextBox txtSaldoPendiente;
        private TextBox txtTotalPagado;
        private DateTimePicker dtpFechaPago;
        private Label label7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewComboBoxColumn TipoPago;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn NroComprobante;
        private DataGridViewTextBoxColumn FechaPago;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewComboBoxColumn Estado;
        private Button btnGuardar;
        private Button btnCancelar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnBuscarPago;
        private Label label8;
        private DataGridView dgvDetallesPagos;
        private DataGridView dgvPagos;
        private DataGridViewTextBoxColumn IdPag;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn TotalVenta;
        private DataGridViewTextBoxColumn TotalPagado;
        private DataGridViewTextBoxColumn SaldoPendiente;
        private DataGridViewTextBoxColumn IdEstadoPago;
        private DataGridViewTextBoxColumn EstadoPago;
        private DataGridViewTextBoxColumn NotaPago;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn FechaCierre;
        private DataGridViewTextBoxColumn IdDet;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn ValorPago;
        private DataGridViewTextBoxColumn NumComprobante;
        private DataGridViewTextBoxColumn FechaPagoDet;
        private DataGridViewTextBoxColumn NotaDet;
        private DataGridViewTextBoxColumn EstadoDet;
        private Label label10;
        private Label label9;
        private DateTimePicker dtpFinal;
        private DateTimePicker dtpInicio;
        private ComboBox cbxCliente;
        private TextBox txtTotalPagos;
        private Label label11;
        private Button btnExportarExcel;
    }
}