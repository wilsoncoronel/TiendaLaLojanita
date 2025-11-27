namespace TiendaLaLojanita.Views
{
    partial class FormularioResumenVentas
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
            txtGanancia = new TextBox();
            label2 = new Label();
            txtTotalVentas = new TextBox();
            label1 = new Label();
            dgvResumenDiario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            Ganancia = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenDiario).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGanancia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTotalVentas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvResumenDiario);
            groupBox1.Location = new Point(8, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 434);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas Resumen";
            // 
            // txtGanancia
            // 
            txtGanancia.Enabled = false;
            txtGanancia.Location = new Point(559, 369);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(215, 23);
            txtGanancia.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 372);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Ganancia Total:";
            // 
            // txtTotalVentas
            // 
            txtTotalVentas.Enabled = false;
            txtTotalVentas.Location = new Point(559, 325);
            txtTotalVentas.Name = "txtTotalVentas";
            txtTotalVentas.Size = new Size(215, 23);
            txtTotalVentas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 328);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Total Ventas:";
            // 
            // dgvResumenDiario
            // 
            dgvResumenDiario.AllowUserToDeleteRows = false;
            dgvResumenDiario.AllowUserToOrderColumns = true;
            dgvResumenDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenDiario.Columns.AddRange(new DataGridViewColumn[] { Id, Articulo, Cantidad, ValorCompra, ValorVenta, Ganancia });
            dgvResumenDiario.Location = new Point(9, 28);
            dgvResumenDiario.Name = "dgvResumenDiario";
            dgvResumenDiario.Size = new Size(765, 291);
            dgvResumenDiario.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // ValorCompra
            // 
            ValorCompra.HeaderText = "Valor Compra";
            ValorCompra.Name = "ValorCompra";
            ValorCompra.ReadOnly = true;
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "Valor Venta";
            ValorVenta.Name = "ValorVenta";
            ValorVenta.ReadOnly = true;
            // 
            // Ganancia
            // 
            Ganancia.HeaderText = "Ganancia";
            Ganancia.Name = "Ganancia";
            Ganancia.ReadOnly = true;
            // 
            // FormularioResumenVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FormularioResumenVentas";
            Text = "FormularioResumenVentas";
            Load += FormularioResumenVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumenDiario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvResumenDiario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn Ganancia;
        private TextBox txtGanancia;
        private Label label2;
        private TextBox txtTotalVentas;
        private Label label1;
    }
}