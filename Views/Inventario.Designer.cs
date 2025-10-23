namespace TiendaLaLojanita.Views
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            groupBox1 = new GroupBox();
            lblArchivo = new Label();
            btnAbrirArchivo = new Button();
            cbxTransaccion = new ComboBox();
            label6 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label5 = new Label();
            dtpFechaCreacion = new DateTimePicker();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnBusquedaArticulo = new Button();
            txtArticuloBusqueda = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dgvDetalles = new DataGridView();
            label1 = new Label();
            ofdArchivos = new OpenFileDialog();
            IdArticulo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblArchivo);
            groupBox1.Controls.Add(btnAbrirArchivo);
            groupBox1.Controls.Add(cbxTransaccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaIngreso);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFechaCreacion);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(519, 26);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(81, 15);
            lblArchivo.TabIndex = 15;
            lblArchivo.Text = "Abrir archivo..";
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.Image = (Image)resources.GetObject("btnAbrirArchivo.Image");
            btnAbrirArchivo.Location = new Point(459, 17);
            btnAbrirArchivo.Name = "btnAbrirArchivo";
            btnAbrirArchivo.Size = new Size(36, 32);
            btnAbrirArchivo.TabIndex = 14;
            btnAbrirArchivo.UseVisualStyleBackColor = true;
            btnAbrirArchivo.Click += btnAbrirArchivo_Click;
            // 
            // cbxTransaccion
            // 
            cbxTransaccion.FormattingEnabled = true;
            cbxTransaccion.Location = new Point(165, 97);
            cbxTransaccion.Name = "cbxTransaccion";
            cbxTransaccion.Size = new Size(239, 23);
            cbxTransaccion.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 100);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 12;
            label6.Text = "Transacción:";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(165, 58);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(238, 23);
            dtpFechaIngreso.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 64);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 10;
            label5.Text = "Fecha Ingreso:";
            // 
            // dtpFechaCreacion
            // 
            dtpFechaCreacion.Format = DateTimePickerFormat.Short;
            dtpFechaCreacion.Location = new Point(165, 20);
            dtpFechaCreacion.Name = "dtpFechaCreacion";
            dtpFechaCreacion.Size = new Size(238, 23);
            dtpFechaCreacion.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 26);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha Creación:";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(1056, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1040, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBusquedaArticulo);
            groupBox3.Controls.Add(txtArticuloBusqueda);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dgvDetalles);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(7, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2089, 529);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ingresos Inventario";
            // 
            // btnBusquedaArticulo
            // 
            btnBusquedaArticulo.Image = (Image)resources.GetObject("btnBusquedaArticulo.Image");
            btnBusquedaArticulo.Location = new Point(1545, 13);
            btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            btnBusquedaArticulo.Size = new Size(100, 38);
            btnBusquedaArticulo.TabIndex = 8;
            btnBusquedaArticulo.UseVisualStyleBackColor = true;
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(1032, 19);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(477, 23);
            txtArticuloBusqueda.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(564, 22);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(285, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(165, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 25);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Inicio:";
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { IdArticulo, Articulo, Cantidad, ValorCompra, ValorVenta });
            dgvDetalles.Location = new Point(11, 67);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.Size = new Size(2069, 453);
            dgvDetalles.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(962, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Artículo:";
            // 
            // ofdArchivos
            // 
            ofdArchivos.FileName = "Inventario";
            ofdArchivos.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "Id";
            IdArticulo.Name = "IdArticulo";
            IdArticulo.ReadOnly = true;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Artículo";
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
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2099, 693);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inventario";
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private DataGridView dgvDetalles;
        private Label label1;
        private Button btnBusquedaArticulo;
        private TextBox txtArticuloBusqueda;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbxTransaccion;
        private Label label6;
        private DateTimePicker dtpFechaIngreso;
        private Label label5;
        private DateTimePicker dtpFechaCreacion;
        private Label label4;
        private Button btnAbrirArchivo;
        private Label lblArchivo;
        private OpenFileDialog ofdArchivos;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
    }
}