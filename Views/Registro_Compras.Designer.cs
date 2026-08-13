namespace TiendaLaLojanita.Views
{
    partial class Registro_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Compras));
            groupBox1 = new GroupBox();
            btnProveedor = new Button();
            txtIdentificacionProveedor = new TextBox();
            btbBuscarProveedor = new Button();
            txtTelefono = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtRazonSocial = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            txtIdCompra = new TextBox();
            groupBox2 = new GroupBox();
            lblFechaIngreso = new Label();
            lblUsuario = new Label();
            groupBox4 = new GroupBox();
            cbxEstadoCompra = new ComboBox();
            label11 = new Label();
            txtDocumento = new TextBox();
            label9 = new Label();
            dtpCreacion = new DateTimePicker();
            label8 = new Label();
            dtpCompra = new DateTimePicker();
            label7 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBuscarCompra = new Button();
            dtpFechaFinal = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dtpFechaInicial = new DateTimePicker();
            dgvCompras = new DataGridView();
            IdComp = new DataGridViewTextBoxColumn();
            FechaCompra = new DataGridViewTextBoxColumn();
            ProveedorId = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            EstadoId = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            CreadorId = new DataGridViewTextBoxColumn();
            Creador = new DataGridViewTextBoxColumn();
            Imprimir = new DataGridViewImageColumn();
            Reversar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRecargarArticulos = new Button();
            groupBox5 = new GroupBox();
            dgvTotales = new DataGridView();
            Impuestos = new DataGridViewTextBoxColumn();
            Valores = new DataGridViewTextBoxColumn();
            label16 = new Label();
            lblTotal = new Label();
            btnBuscar = new Button();
            txtArticuloBusqueda = new TextBox();
            label10 = new Label();
            dgvDetalleCompra = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdCompra = new DataGridViewTextBoxColumn();
            IdArticulo = new DataGridViewTextBoxColumn();
            Lote = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            ImpuestoValor = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            FechaExpiracion = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProveedor);
            groupBox1.Controls.Add(txtIdentificacionProveedor);
            groupBox1.Controls.Add(btbBuscarProveedor);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedor";
            // 
            // btnProveedor
            // 
            btnProveedor.Image = (Image)resources.GetObject("btnProveedor.Image");
            btnProveedor.Location = new Point(431, 15);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(39, 33);
            btnProveedor.TabIndex = 10;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // txtIdentificacionProveedor
            // 
            txtIdentificacionProveedor.Location = new Point(124, 16);
            txtIdentificacionProveedor.MaxLength = 13;
            txtIdentificacionProveedor.Name = "txtIdentificacionProveedor";
            txtIdentificacionProveedor.PlaceholderText = "1700000000";
            txtIdentificacionProveedor.Size = new Size(247, 23);
            txtIdentificacionProveedor.TabIndex = 9;
            txtIdentificacionProveedor.KeyDown += txtIdentificacionProveedor_KeyDown;
            // 
            // btbBuscarProveedor
            // 
            btbBuscarProveedor.Image = (Image)resources.GetObject("btbBuscarProveedor.Image");
            btbBuscarProveedor.Location = new Point(388, 14);
            btbBuscarProveedor.Name = "btbBuscarProveedor";
            btbBuscarProveedor.Size = new Size(38, 34);
            btbBuscarProveedor.TabIndex = 8;
            btbBuscarProveedor.UseVisualStyleBackColor = true;
            btbBuscarProveedor.Click += btbBuscarProveedor_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(124, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(124, 104);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(377, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Location = new Point(124, 56);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(247, 23);
            txtRazonSocial.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Razón Social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "CI/ RUC:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(449, 29);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 11;
            label12.Text = "IdCompra:";
            // 
            // txtIdCompra
            // 
            txtIdCompra.Enabled = false;
            txtIdCompra.Location = new Point(518, 23);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.Size = new Size(99, 23);
            txtIdCompra.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFechaIngreso);
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Location = new Point(1163, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 127);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(21, 84);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(0, 15);
            lblFechaIngreso.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(21, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtIdCompra);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(cbxEstadoCompra);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtDocumento);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(dtpCreacion);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(dtpCompra);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(525, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(628, 189);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Compra";
            // 
            // cbxEstadoCompra
            // 
            cbxEstadoCompra.FormattingEnabled = true;
            cbxEstadoCompra.Location = new Point(133, 141);
            cbxEstadoCompra.Name = "cbxEstadoCompra";
            cbxEstadoCompra.Size = new Size(205, 23);
            cbxEstadoCompra.TabIndex = 7;
            cbxEstadoCompra.Text = "Seleccione";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 144);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 6;
            label11.Text = "Estado Compra:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(133, 104);
            txtDocumento.MaxLength = 50;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(332, 23);
            txtDocumento.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 104);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 4;
            label9.Text = "Documento:";
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(133, 61);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(301, 23);
            dtpCreacion.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 61);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 2;
            label8.Text = "Fecha Creación:";
            // 
            // dtpCompra
            // 
            dtpCompra.Format = DateTimePickerFormat.Short;
            dtpCompra.Location = new Point(133, 23);
            dtpCompra.Name = "dtpCompra";
            dtpCompra.Size = new Size(301, 23);
            dtpCompra.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 29);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Fecha Compra:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(1184, 153);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(255, 61);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1184, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(255, 63);
            btnCancelar.TabIndex = 6;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscarCompra
            // 
            btnBuscarCompra.Image = (Image)resources.GetObject("btnBuscarCompra.Image");
            btnBuscarCompra.Location = new Point(543, 6);
            btnBuscarCompra.Name = "btnBuscarCompra";
            btnBuscarCompra.Size = new Size(75, 34);
            btnBuscarCompra.TabIndex = 5;
            btnBuscarCompra.UseVisualStyleBackColor = true;
            btnBuscarCompra.Click += btnBuscarCompra_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(370, 12);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(158, 23);
            dtpFechaFinal.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 16);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 3;
            label6.Text = "Final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 16);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Inicio:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(90, 13);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(141, 23);
            dtpFechaInicial.TabIndex = 1;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdComp, FechaCompra, ProveedorId, Proveedor, EstadoId, Estado, Documento, CreadorId, Creador, Imprimir, Reversar, Editar });
            dgvCompras.Location = new Point(3, 42);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new Size(1124, 277);
            dgvCompras.TabIndex = 0;
            dgvCompras.CellClick += dgvCompras_CellClick;
            // 
            // IdComp
            // 
            IdComp.HeaderText = "Id";
            IdComp.Name = "IdComp";
            IdComp.ReadOnly = true;
            // 
            // FechaCompra
            // 
            FechaCompra.HeaderText = "FechaCompra";
            FechaCompra.Name = "FechaCompra";
            FechaCompra.ReadOnly = true;
            // 
            // ProveedorId
            // 
            ProveedorId.HeaderText = "ProveedorId";
            ProveedorId.Name = "ProveedorId";
            ProveedorId.Resizable = DataGridViewTriState.True;
            ProveedorId.SortMode = DataGridViewColumnSortMode.NotSortable;
            ProveedorId.Visible = false;
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            // 
            // EstadoId
            // 
            EstadoId.HeaderText = "EstadoId";
            EstadoId.Name = "EstadoId";
            EstadoId.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // CreadorId
            // 
            CreadorId.HeaderText = "CreadorId";
            CreadorId.Name = "CreadorId";
            CreadorId.Visible = false;
            // 
            // Creador
            // 
            Creador.HeaderText = "Creador";
            Creador.Name = "Creador";
            Creador.ReadOnly = true;
            // 
            // Imprimir
            // 
            Imprimir.HeaderText = "Imprimir";
            Imprimir.Image = Properties.Resources.imprimir_peque;
            Imprimir.Name = "Imprimir";
            // 
            // Reversar
            // 
            Reversar.HeaderText = "Reversar";
            Reversar.Image = (Image)resources.GetObject("Reversar.Image");
            Reversar.Name = "Reversar";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(tabControl1);
            groupBox3.Location = new Point(12, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1160, 494);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Artículos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1151, 465);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRecargarArticulos);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(txtArticuloBusqueda);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(dgvDetalleCompra);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1143, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detalle Compra";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRecargarArticulos
            // 
            btnRecargarArticulos.Image = (Image)resources.GetObject("btnRecargarArticulos.Image");
            btnRecargarArticulos.Location = new Point(549, 21);
            btnRecargarArticulos.Name = "btnRecargarArticulos";
            btnRecargarArticulos.Size = new Size(77, 33);
            btnRecargarArticulos.TabIndex = 10;
            btnRecargarArticulos.UseVisualStyleBackColor = true;
            btnRecargarArticulos.Click += btnRecargarArticulos_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvTotales);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(lblTotal);
            groupBox5.Location = new Point(794, 46);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(343, 267);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Totales";
            // 
            // dgvTotales
            // 
            dgvTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotales.Columns.AddRange(new DataGridViewColumn[] { Impuestos, Valores });
            dgvTotales.Location = new Point(7, 23);
            dgvTotales.Name = "dgvTotales";
            dgvTotales.Size = new Size(330, 197);
            dgvTotales.TabIndex = 16;
            // 
            // Impuestos
            // 
            Impuestos.HeaderText = "Impuestos";
            Impuestos.Name = "Impuestos";
            Impuestos.ReadOnly = true;
            // 
            // Valores
            // 
            Valores.HeaderText = "Valores";
            Valores.Name = "Valores";
            Valores.ReadOnly = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(7, 223);
            label16.Name = "label16";
            label16.Size = new Size(70, 32);
            label16.TabIndex = 11;
            label16.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(176, 226);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(465, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 34);
            btnBuscar.TabIndex = 8;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(108, 26);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.PlaceholderText = "Artículo/Código";
            txtArticuloBusqueda.Size = new Size(325, 23);
            txtArticuloBusqueda.TabIndex = 7;
            txtArticuloBusqueda.KeyDown += txtArticuloBusqueda_KeyDown_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 29);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 6;
            label10.Text = "Buscar:";
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { Id, IdCompra, IdArticulo, Lote, Codigo, Articulo, Descripcion, Cantidad, ValorCompra, ValorVenta, ImpuestoValor, ValorTotal, FechaExpiracion, Eliminar });
            dgvDetalleCompra.Location = new Point(6, 55);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.Size = new Size(779, 258);
            dgvDetalleCompra.TabIndex = 5;
            dgvDetalleCompra.CellClick += dgvDetalleCompra_CellClick_1;
            dgvDetalleCompra.CellValueChanged += dgvDetalleCompra_CellValueChanged_1;
            dgvDetalleCompra.EditingControlShowing += dgvDetalleCompra_EditingControlShowing_1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdCompra
            // 
            IdCompra.HeaderText = "IdCompra";
            IdCompra.Name = "IdCompra";
            IdCompra.Visible = false;
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "IdArticulo";
            IdArticulo.Name = "IdArticulo";
            IdArticulo.Visible = false;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // ValorCompra
            // 
            ValorCompra.HeaderText = "ValorCompra";
            ValorCompra.Name = "ValorCompra";
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "ValorVenta";
            ValorVenta.Name = "ValorVenta";
            ValorVenta.Visible = false;
            // 
            // ImpuestoValor
            // 
            ImpuestoValor.HeaderText = "ImpuestoValor";
            ImpuestoValor.Name = "ImpuestoValor";
            ImpuestoValor.ReadOnly = true;
            ImpuestoValor.Visible = false;
            // 
            // ValorTotal
            // 
            ValorTotal.HeaderText = "ValorTotal";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            // 
            // FechaExpiracion
            // 
            FechaExpiracion.HeaderText = "Expiracion";
            FechaExpiracion.Name = "FechaExpiracion";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCompras);
            tabPage2.Controls.Add(btnBuscarCompra);
            tabPage2.Controls.Add(dtpFechaFinal);
            tabPage2.Controls.Add(dtpFechaInicial);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1143, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Compras";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Registro_Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 902);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox4);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Compras";
            Text = "Registro_Compras";
            Load += Registro_Compras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtRazonSocial;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private Label label4;
        private Label label3;
        private TextBox txtDireccion;
        private GroupBox groupBox2;
        private Label lblFechaIngreso;
        private Label lblUsuario;
        private GroupBox groupBox4;
        private DateTimePicker dtpCreacion;
        private Label label8;
        private DateTimePicker dtpCompra;
        private Label label7;
        private TextBox txtDocumento;
        private Label label9;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFechaInicial;
        private DataGridView dgvCompras;
        private DateTimePicker dtpFechaFinal;
        private Button btnBuscarCompra;
        private Button btbBuscarProveedor;
        private TextBox txtIdentificacionProveedor;
        private ComboBox cbxEstadoCompra;
        private Label label11;
        private Label label12;
        private TextBox txtIdCompra;
        private Label lblTotal;
        private Label label16;
        private GroupBox groupBox5;
        private DataGridView dgvTotales;
        private DataGridViewTextBoxColumn Impuestos;
        private DataGridViewTextBoxColumn Valores;
        private GroupBox groupBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnBuscar;
        private TextBox txtArticuloBusqueda;
        private Label label10;
        private DataGridView dgvDetalleCompra;
        private TabPage tabPage2;
        private Button btnProveedor;
        private Button btnRecargarArticulos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn ImpuestoValor;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn FechaExpiracion;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn IdComp;
        private DataGridViewTextBoxColumn FechaCompra;
        private DataGridViewTextBoxColumn ProveedorId;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn EstadoId;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn CreadorId;
        private DataGridViewTextBoxColumn Creador;
        private DataGridViewImageColumn Imprimir;
        private DataGridViewImageColumn Reversar;
        private DataGridViewImageColumn Editar;
    }
}