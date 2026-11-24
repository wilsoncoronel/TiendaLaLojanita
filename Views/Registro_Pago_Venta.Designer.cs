namespace TiendaLaLojanita.Views
{
    partial class Registro_Pago_Venta
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
            btnCancelar = new Button();
            btnPagar = new Button();
            label7 = new Label();
            cbxTipoPago = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtNroComprobante = new TextBox();
            txtValorPago = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dtpCreacion = new DateTimePicker();
            txtNota = new TextBox();
            cbxEstadoPago = new ComboBox();
            txtSaldoPendiente = new TextBox();
            txtTotalPagar = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlText;
            btnCancelar.Location = new Point(179, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 43);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.GreenYellow;
            btnPagar.Location = new Point(444, 337);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(143, 43);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 15;
            label7.Text = "Tipo pago:";
            // 
            // cbxTipoPago
            // 
            cbxTipoPago.FormattingEnabled = true;
            cbxTipoPago.Location = new Point(125, 16);
            cbxTipoPago.Name = "cbxTipoPago";
            cbxTipoPago.Size = new Size(167, 23);
            cbxTipoPago.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 19);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 17;
            label8.Text = "Nro. Comprobante:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNroComprobante);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbxTipoPago);
            groupBox1.Controls.Add(txtValorPago);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 83);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de pago";
            // 
            // txtNroComprobante
            // 
            txtNroComprobante.Enabled = false;
            txtNroComprobante.Location = new Point(483, 16);
            txtNroComprobante.Name = "txtNroComprobante";
            txtNroComprobante.Size = new Size(258, 23);
            txtNroComprobante.TabIndex = 18;
            // 
            // txtValorPago
            // 
            txtValorPago.Location = new Point(125, 46);
            txtValorPago.Name = "txtValorPago";
            txtValorPago.Size = new Size(167, 23);
            txtValorPago.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 14;
            label2.Text = "Valor de pago:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpCreacion);
            groupBox2.Controls.Add(txtNota);
            groupBox2.Controls.Add(cbxEstadoPago);
            groupBox2.Controls.Add(txtSaldoPendiente);
            groupBox2.Controls.Add(txtTotalPagar);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 230);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de pago";
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Location = new Point(117, 189);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(247, 23);
            dtpCreacion.TabIndex = 24;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(117, 100);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(622, 74);
            txtNota.TabIndex = 23;
            // 
            // cbxEstadoPago
            // 
            cbxEstadoPago.FormattingEnabled = true;
            cbxEstadoPago.Location = new Point(481, 19);
            cbxEstadoPago.Name = "cbxEstadoPago";
            cbxEstadoPago.Size = new Size(148, 23);
            cbxEstadoPago.TabIndex = 22;
            // 
            // txtSaldoPendiente
            // 
            txtSaldoPendiente.Enabled = false;
            txtSaldoPendiente.Location = new Point(117, 60);
            txtSaldoPendiente.Name = "txtSaldoPendiente";
            txtSaldoPendiente.Size = new Size(148, 23);
            txtSaldoPendiente.TabIndex = 21;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Enabled = false;
            txtTotalPagar.Location = new Point(117, 19);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(148, 23);
            txtTotalPagar.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 189);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 18;
            label6.Text = "Fecha Creacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 102);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 17;
            label5.Text = "Nota:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 22);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 16;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 63);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 15;
            label3.Text = "Saldo pendiente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 13;
            label1.Text = "Total a pagar:";
            // 
            // Registro_Pago_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 387);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnPagar);
            Controls.Add(btnCancelar);
            Name = "Registro_Pago_Venta";
            Text = "Registro_Pago_Venta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCancelar;
        private Button btnPagar;
        private Label label7;
        private ComboBox cbxTipoPago;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtNroComprobante;
        private GroupBox groupBox2;
        private DateTimePicker dtpCreacion;
        private TextBox txtNota;
        private ComboBox cbxEstadoPago;
        private TextBox txtSaldoPendiente;
        private TextBox txtValorPago;
        private TextBox txtTotalPagar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}