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
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePago).BeginInit();
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
            groupBox2.Location = new Point(12, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(926, 202);
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
            groupBox3.Location = new Point(12, 209);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1208, 297);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle Pago";
            // 
            // dgvDetallePago
            // 
            dgvDetallePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePago.Columns.AddRange(new DataGridViewColumn[] { Id, TipoPago, Valor, NroComprobante, FechaPago, Nota, Estado });
            dgvDetallePago.Location = new Point(8, 27);
            dgvDetallePago.Name = "dgvDetallePago";
            dgvDetallePago.Size = new Size(1193, 264);
            dgvDetallePago.TabIndex = 0;
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
            btnGuardar.Location = new Point(1014, 9);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 73);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar_resize;
            btnCancelar.Location = new Point(1014, 111);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(204, 73);
            btnCancelar.TabIndex = 7;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 518);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Pagos";
            Text = "Pagos";
            Load += Pagos_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallePago).EndInit();
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
    }
}