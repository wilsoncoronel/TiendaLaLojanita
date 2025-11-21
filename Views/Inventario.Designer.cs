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
            txtDocumento = new TextBox();
            label8 = new Label();
            cbxProveedor = new ComboBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btbBuscarInv = new Button();
            dgvInventario = new DataGridView();
            IdInventario = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Modificacion = new DataGridViewTextBoxColumn();
            Reversion = new DataGridViewTextBoxColumn();
            Transaccion = new DataGridViewTextBoxColumn();
            Reversar = new DataGridViewImageColumn();
            btnBusquedaArticulo = new Button();
            txtArticuloBusqueda = new TextBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dgvDetallesInventario = new DataGridView();
            IdArticulo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            Papeleria = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            label1 = new Label();
            ofdArchivos = new OpenFileDialog();
            groupBox4 = new GroupBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox5 = new GroupBox();
            comboBox1 = new ComboBox();
            btnReportes = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesInventario).BeginInit();
            groupBox5.SuspendLayout();
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
            groupBox1.Size = new Size(453, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(69, 132);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(81, 15);
            lblArchivo.TabIndex = 15;
            lblArchivo.Text = "Abrir archivo..";
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.Image = (Image)resources.GetObject("btnAbrirArchivo.Image");
            btnAbrirArchivo.Location = new Point(11, 123);
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
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbxProveedor);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(466, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 81);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Compra";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(90, 50);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(480, 23);
            txtDocumento.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 52);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 2;
            label8.Text = "Documento:";
            // 
            // cbxProveedor
            // 
            cbxProveedor.FormattingEnabled = true;
            cbxProveedor.Location = new Point(90, 16);
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.Size = new Size(320, 23);
            cbxProveedor.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 0;
            label7.Text = "Proveedor:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btbBuscarInv);
            groupBox3.Controls.Add(dgvInventario);
            groupBox3.Controls.Add(btnBusquedaArticulo);
            groupBox3.Controls.Add(txtArticuloBusqueda);
            groupBox3.Controls.Add(dtpFechaFin);
            groupBox3.Controls.Add(dtpFechaInicio);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dgvDetallesInventario);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(7, 185);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1821, 533);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ingresos Inventario";
            // 
            // btbBuscarInv
            // 
            btbBuscarInv.Image = (Image)resources.GetObject("btbBuscarInv.Image");
            btbBuscarInv.Location = new Point(810, 13);
            btbBuscarInv.Name = "btbBuscarInv";
            btbBuscarInv.Size = new Size(100, 38);
            btbBuscarInv.TabIndex = 10;
            btbBuscarInv.UseVisualStyleBackColor = true;
            btbBuscarInv.Click += btbBuscarInv_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { IdInventario, Creacion, Modificacion, Reversion, Transaccion, Reversar });
            dgvInventario.Location = new Point(9, 70);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(648, 450);
            dgvInventario.TabIndex = 9;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // IdInventario
            // 
            IdInventario.HeaderText = "Id";
            IdInventario.Name = "IdInventario";
            IdInventario.ReadOnly = true;
            // 
            // Creacion
            // 
            Creacion.HeaderText = "Creación";
            Creacion.Name = "Creacion";
            Creacion.ReadOnly = true;
            // 
            // Modificacion
            // 
            Modificacion.HeaderText = "Modificación";
            Modificacion.Name = "Modificacion";
            Modificacion.ReadOnly = true;
            // 
            // Reversion
            // 
            Reversion.HeaderText = "Reversión";
            Reversion.Name = "Reversion";
            Reversion.ReadOnly = true;
            // 
            // Transaccion
            // 
            Transaccion.HeaderText = "Transacción";
            Transaccion.Name = "Transaccion";
            Transaccion.ReadOnly = true;
            // 
            // Reversar
            // 
            Reversar.HeaderText = "Reversar";
            Reversar.Image = Properties.Resources.resize;
            Reversar.Name = "Reversar";
            // 
            // btnBusquedaArticulo
            // 
            btnBusquedaArticulo.Image = (Image)resources.GetObject("btnBusquedaArticulo.Image");
            btnBusquedaArticulo.Location = new Point(1545, 13);
            btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            btnBusquedaArticulo.Size = new Size(100, 38);
            btnBusquedaArticulo.TabIndex = 8;
            btnBusquedaArticulo.UseVisualStyleBackColor = true;
            btnBusquedaArticulo.Click += btnBusquedaArticulo_Click;
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(1032, 19);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(477, 23);
            txtArticuloBusqueda.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(506, 22);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(285, 23);
            dtpFechaFin.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(102, 24);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(238, 23);
            dtpFechaInicio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 25);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha Inicio:";
            // 
            // dgvDetallesInventario
            // 
            dgvDetallesInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesInventario.Columns.AddRange(new DataGridViewColumn[] { IdArticulo, Articulo, Descripcion, Impuesto, Cantidad, ValorCompra, ValorVenta, Papeleria, Eliminar });
            dgvDetallesInventario.Location = new Point(669, 70);
            dgvDetallesInventario.Name = "dgvDetallesInventario";
            dgvDetallesInventario.Size = new Size(1138, 450);
            dgvDetallesInventario.TabIndex = 2;
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Impuesto
            // 
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // ValorCompra
            // 
            ValorCompra.HeaderText = "Valor Compra";
            ValorCompra.Name = "ValorCompra";
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "Valor Venta";
            ValorVenta.Name = "ValorVenta";
            // 
            // Papeleria
            // 
            Papeleria.HeaderText = "Papeleria";
            Papeleria.Name = "Papeleria";
            Papeleria.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
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
            // groupBox4
            // 
            groupBox4.Location = new Point(466, 93);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(576, 86);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Ajustes";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._4856668_resize;
            btnGuardar.Location = new Point(1604, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 68);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar_resize;
            btnCancelar.Location = new Point(1604, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(224, 68);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnReportes);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Location = new Point(1053, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(463, 82);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Reportes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Resumen Ventas al Día", "Resumen Mes" });
            comboBox1.Location = new Point(19, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.Location = new Point(292, 20);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(154, 48);
            btnReportes.TabIndex = 1;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1833, 781);
            Controls.Add(groupBox5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inventario";
            Text = "Inventario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesInventario).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private DataGridView dgvDetallesInventario;
        private Label label1;
        private Button btnBusquedaArticulo;
        private TextBox txtArticuloBusqueda;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private ComboBox cbxTransaccion;
        private Label label6;
        private DateTimePicker dtpFechaIngreso;
        private Label label5;
        private DateTimePicker dtpFechaCreacion;
        private Label label4;
        private Button btnAbrirArchivo;
        private Label lblArchivo;
        private OpenFileDialog ofdArchivos;
        private GroupBox groupBox4;
        private Label label8;
        private ComboBox cbxProveedor;
        private Label label7;
        private TextBox txtDocumento;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn Papeleria;
        private DataGridViewImageColumn Eliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btbBuscarInv;
        private DataGridViewTextBoxColumn IdInventario;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Modificacion;
        private DataGridViewTextBoxColumn Reversion;
        private DataGridViewTextBoxColumn Transaccion;
        private DataGridViewImageColumn Reversar;
        private Button btnExistenciasInventario;
        private GroupBox groupBox5;
        private Button btnReportes;
        private ComboBox comboBox1;
    }
}