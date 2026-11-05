namespace TiendaLaLojanita.Views
{
    partial class Registro_Ajustes_Inventario
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIdAjuste = new TextBox();
            cbxTransaccionAjuste = new ComboBox();
            txtMotivoAjuste = new TextBox();
            dtpFechaCreacion = new DateTimePicker();
            cbxEstadoAjuste = new ComboBox();
            dtpFechaReversion = new DateTimePicker();
            groupBox2 = new GroupBox();
            button1 = new Button();
            dgvDetallesAjuste = new DataGridView();
            label7 = new Label();
            txtArticuloBusqueda = new TextBox();
            btnBuscarArticulo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesAjuste).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaReversion);
            groupBox1.Controls.Add(cbxEstadoAjuste);
            groupBox1.Controls.Add(dtpFechaCreacion);
            groupBox1.Controls.Add(txtMotivoAjuste);
            groupBox1.Controls.Add(cbxTransaccionAjuste);
            groupBox1.Controls.Add(txtIdAjuste);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 199);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Ajustes Inventario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Transacción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 81);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Motivo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 108);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Creación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 133);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 163);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 5;
            label6.Text = "Reversión:";
            // 
            // txtIdAjuste
            // 
            txtIdAjuste.Location = new Point(94, 20);
            txtIdAjuste.Name = "txtIdAjuste";
            txtIdAjuste.Size = new Size(100, 23);
            txtIdAjuste.TabIndex = 6;
            // 
            // cbxTransaccionAjuste
            // 
            cbxTransaccionAjuste.FormattingEnabled = true;
            cbxTransaccionAjuste.Location = new Point(93, 48);
            cbxTransaccionAjuste.Name = "cbxTransaccionAjuste";
            cbxTransaccionAjuste.Size = new Size(199, 23);
            cbxTransaccionAjuste.TabIndex = 7;
            // 
            // txtMotivoAjuste
            // 
            txtMotivoAjuste.Location = new Point(92, 73);
            txtMotivoAjuste.Name = "txtMotivoAjuste";
            txtMotivoAjuste.Size = new Size(427, 23);
            txtMotivoAjuste.TabIndex = 8;
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Location = new Point(90, 102);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(235, 23);
            dtpFechaCreacion.TabIndex = 9;
            // 
            // cbxEstadoAjuste
            // 
            cbxEstadoAjuste.FormattingEnabled = true;
            cbxEstadoAjuste.Location = new Point(91, 130);
            cbxEstadoAjuste.Name = "cbxEstadoAjuste";
            cbxEstadoAjuste.Size = new Size(201, 23);
            cbxEstadoAjuste.TabIndex = 10;
            // 
            // dtpFechaReversion
            // 
            dtpFechaReversion.Location = new Point(92, 157);
            dtpFechaReversion.Name = "dtpFechaReversion";
            dtpFechaReversion.Size = new Size(233, 23);
            dtpFechaReversion.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarArticulo);
            groupBox2.Controls.Add(txtArticuloBusqueda);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dgvDetallesAjuste);
            groupBox2.Location = new Point(18, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1156, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Ajustes";
            // 
            // button1
            // 
            button1.Location = new Point(1042, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvDetallesAjuste
            // 
            dgvDetallesAjuste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesAjuste.Location = new Point(6, 55);
            dgvDetallesAjuste.Name = "dgvDetallesAjuste";
            dgvDetallesAjuste.Size = new Size(966, 222);
            dgvDetallesAjuste.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 1;
            label7.Text = "Artículo:";
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(64, 20);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.PlaceholderText = "Artículo/Código/Lote/Id";
            txtArticuloBusqueda.Size = new Size(520, 23);
            txtArticuloBusqueda.TabIndex = 2;
            // 
            // btnBuscarArticulo
            // 
            btnBuscarArticulo.Image = Properties.Resources.lupa_min;
            btnBuscarArticulo.Location = new Point(617, 14);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(85, 33);
            btnBuscarArticulo.TabIndex = 3;
            btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // Registro_Ajustes_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 512);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Ajustes_Inventario";
            Text = "Registro_Ajustes_Inventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesAjuste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaReversion;
        private ComboBox cbxEstadoAjuste;
        private DateTimePicker dtpFechaCreacion;
        private TextBox txtMotivoAjuste;
        private ComboBox cbxTransaccionAjuste;
        private TextBox txtIdAjuste;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private Button btnBuscarArticulo;
        private TextBox txtArticuloBusqueda;
        private Label label7;
        private DataGridView dgvDetallesAjuste;
    }
}