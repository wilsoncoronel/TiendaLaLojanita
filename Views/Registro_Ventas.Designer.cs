namespace TiendaLaLojanita.Views
{
    partial class Registro_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Ventas));
            groupBox1 = new GroupBox();
            btnAgregarCliente = new Button();
            txtDireccionCliente = new TextBox();
            label17 = new Label();
            txtIdVenta = new TextBox();
            label16 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNombreCliente = new TextBox();
            btnBuscarCliente = new Button();
            label2 = new Label();
            txtIdentificaconCliente = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRecargarArticulos = new Button();
            btnBusquedaArticulo = new Button();
            dgvDetallesVenta = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdVentaDet = new DataGridViewTextBoxColumn();
            IdArticulo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            txtArticuloBusqueda = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            txtTotal = new TextBox();
            label10 = new Label();
            tabPage2 = new TabPage();
            dgvVentas = new DataGridView();
            IdVenta = new DataGridViewTextBoxColumn();
            FechaVenta = new DataGridViewTextBoxColumn();
            IdClienteVenta = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            FechaModificacion = new DataGridViewTextBoxColumn();
            IdEstado = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Imprimir = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            btnBuscarVenta = new Button();
            dtpFechaInicio = new DateTimePicker();
            label12 = new Label();
            dtpFechaFin = new DateTimePicker();
            label13 = new Label();
            groupBox4 = new GroupBox();
            txtDocumento = new TextBox();
            label15 = new Label();
            cbxEstadosVenta = new ComboBox();
            label14 = new Label();
            dtpModificacion = new DateTimePicker();
            dtpCreacion = new DateTimePicker();
            dtpVenta = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox6 = new GroupBox();
            btnRecargarConfiguraciones = new Button();
            lblFechaIngreso = new Label();
            lblUsuario = new Label();
            btnInventario = new Button();
            label18 = new Label();
            txtCambio = new TextBox();
            txtPago = new TextBox();
            label19 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            groupBox3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Controls.Add(txtDireccionCliente);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(txtIdVenta);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdentificaconCliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Image = (Image)resources.GetObject("btnAgregarCliente.Image");
            btnAgregarCliente.Location = new Point(442, 13);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(47, 34);
            btnAgregarCliente.TabIndex = 17;
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Enabled = false;
            txtDireccionCliente.Location = new Point(146, 126);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(518, 23);
            txtDireccionCliente.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 126);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 15;
            label17.Text = "Dirección:";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Enabled = false;
            txtIdVenta.Location = new Point(595, 20);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(512, 23);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 13;
            label16.Text = "IdVenta:";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(512, 81);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "090000000";
            txtTelefono.Size = new Size(185, 23);
            txtTelefono.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 86);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Telefono:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(512, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 56);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Venta:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(146, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "pruebas@mail.com";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 84);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 84);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(146, 55);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(211, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(385, 13);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(40, 34);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtIdentificaconCliente
            // 
            txtIdentificaconCliente.Location = new Point(146, 15);
            txtIdentificaconCliente.MaxLength = 13;
            txtIdentificaconCliente.Name = "txtIdentificaconCliente";
            txtIdentificaconCliente.PlaceholderText = "170000000000";
            txtIdentificaconCliente.Size = new Size(211, 23);
            txtIdentificaconCliente.TabIndex = 1;
            txtIdentificaconCliente.KeyDown += txtIdentificaconCliente_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Identifiación/Ruc:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(16, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1188, 471);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Articulos / Ventas";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(10, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1168, 417);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRecargarArticulos);
            tabPage1.Controls.Add(btnBusquedaArticulo);
            tabPage1.Controls.Add(dgvDetallesVenta);
            tabPage1.Controls.Add(txtArticuloBusqueda);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1160, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detalle Venta";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRecargarArticulos
            // 
            btnRecargarArticulos.Image = (Image)resources.GetObject("btnRecargarArticulos.Image");
            btnRecargarArticulos.Location = new Point(677, 13);
            btnRecargarArticulos.Name = "btnRecargarArticulos";
            btnRecargarArticulos.Size = new Size(49, 39);
            btnRecargarArticulos.TabIndex = 16;
            btnRecargarArticulos.UseVisualStyleBackColor = true;
            btnRecargarArticulos.Click += btnRecargarArticulos_Click_1;
            // 
            // btnBusquedaArticulo
            // 
            btnBusquedaArticulo.Image = (Image)resources.GetObject("btnBusquedaArticulo.Image");
            btnBusquedaArticulo.Location = new Point(581, 13);
            btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            btnBusquedaArticulo.Size = new Size(83, 38);
            btnBusquedaArticulo.TabIndex = 14;
            btnBusquedaArticulo.UseVisualStyleBackColor = true;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Columns.AddRange(new DataGridViewColumn[] { Id, IdVentaDet, IdArticulo, Articulo, Descripcion, Cantidad, ValorCompra, ValorVenta, ValorTotal, Eliminar });
            dgvDetallesVenta.Location = new Point(17, 58);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.Size = new Size(856, 305);
            dgvDetallesVenta.TabIndex = 13;
            dgvDetallesVenta.CellClick += dgvDetallesVenta_CellClick;
            dgvDetallesVenta.CellValueChanged += dgvDetallesVenta_CellValueChanged_1;
            dgvDetallesVenta.EditingControlShowing += dgvDetallesVenta_EditingControlShowing_1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdVentaDet
            // 
            IdVentaDet.HeaderText = "IdVentaDet";
            IdVentaDet.Name = "IdVentaDet";
            IdVentaDet.Visible = false;
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "IdArticulo";
            IdArticulo.Name = "IdArticulo";
            IdArticulo.ReadOnly = true;
            IdArticulo.Visible = false;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
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
            ValorCompra.Visible = false;
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "Valor Venta";
            ValorVenta.Name = "ValorVenta";
            // 
            // ValorTotal
            // 
            ValorTotal.HeaderText = "Valor Total";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(132, 22);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(443, 23);
            txtArticuloBusqueda.TabIndex = 15;
            txtArticuloBusqueda.KeyDown += txtArticuloBusqueda_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 25);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "Artículo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(890, 58);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 73);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(131, 22);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "000";
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 25);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvVentas);
            tabPage2.Controls.Add(btnBuscarVenta);
            tabPage2.Controls.Add(dtpFechaInicio);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(dtpFechaFin);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1160, 389);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Listado Ventas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { IdVenta, FechaVenta, IdClienteVenta, Cliente, FechaModificacion, IdEstado, Estado, Documento, Usuario, Imprimir, Editar });
            dgvVentas.Location = new Point(6, 54);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(1133, 307);
            dgvVentas.TabIndex = 6;
            dgvVentas.CellClick += dgvVentas_CellClick_1;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "Id";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            // 
            // FechaVenta
            // 
            FechaVenta.HeaderText = "Venta";
            FechaVenta.Name = "FechaVenta";
            FechaVenta.ReadOnly = true;
            // 
            // IdClienteVenta
            // 
            IdClienteVenta.HeaderText = "IdCliente";
            IdClienteVenta.Name = "IdClienteVenta";
            IdClienteVenta.Visible = false;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // FechaModificacion
            // 
            FechaModificacion.HeaderText = "Modificación";
            FechaModificacion.Name = "FechaModificacion";
            FechaModificacion.ReadOnly = true;
            // 
            // IdEstado
            // 
            IdEstado.HeaderText = "IdEstado";
            IdEstado.Name = "IdEstado";
            IdEstado.Visible = false;
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
            Documento.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Imprimir
            // 
            Imprimir.HeaderText = "Imprimir";
            Imprimir.Image = Properties.Resources.imprimir_peque;
            Imprimir.Name = "Imprimir";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Image = (Image)resources.GetObject("btnBuscarVenta.Image");
            btnBuscarVenta.Location = new Point(498, 8);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(115, 40);
            btnBuscarVenta.TabIndex = 5;
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(73, 19);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(148, 23);
            dtpFechaInicio.TabIndex = 1;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 24);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 0;
            label12.Text = "Inicio:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(290, 18);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 3;
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(255, 23);
            label13.Name = "label13";
            label13.Size = new Size(26, 15);
            label13.TabIndex = 2;
            label13.Text = "Fin:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDocumento);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(cbxEstadosVenta);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(dtpModificacion);
            groupBox4.Controls.Add(dtpCreacion);
            groupBox4.Controls.Add(dtpVenta);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(745, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(393, 169);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Venta";
            // 
            // txtDocumento
            // 
            txtDocumento.Enabled = false;
            txtDocumento.Location = new Point(94, 111);
            txtDocumento.MaxLength = 45;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(282, 23);
            txtDocumento.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 116);
            label15.Name = "label15";
            label15.Size = new Size(73, 15);
            label15.TabIndex = 8;
            label15.Text = "Documento:";
            // 
            // cbxEstadosVenta
            // 
            cbxEstadosVenta.FormattingEnabled = true;
            cbxEstadosVenta.Location = new Point(255, 139);
            cbxEstadosVenta.Name = "cbxEstadosVenta";
            cbxEstadosVenta.Size = new Size(121, 23);
            cbxEstadosVenta.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 143);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 6;
            label14.Text = "Estado:";
            // 
            // dtpModificacion
            // 
            dtpModificacion.Enabled = false;
            dtpModificacion.Format = DateTimePickerFormat.Short;
            dtpModificacion.Location = new Point(188, 81);
            dtpModificacion.Name = "dtpModificacion";
            dtpModificacion.Size = new Size(187, 23);
            dtpModificacion.TabIndex = 5;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(188, 48);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(187, 23);
            dtpCreacion.TabIndex = 4;
            // 
            // dtpVenta
            // 
            dtpVenta.Format = DateTimePickerFormat.Short;
            dtpVenta.Location = new Point(188, 15);
            dtpVenta.Name = "dtpVenta";
            dtpVenta.Size = new Size(187, 23);
            dtpVenta.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 86);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 2;
            label11.Text = "Fecha Modificación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 57);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 1;
            label9.Text = "Fecha Creación:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 23);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 0;
            label8.Text = "Fecha Venta:";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(1210, 446);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(250, 64);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1210, 516);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(250, 64);
            btnCancelar.TabIndex = 6;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnRecargarConfiguraciones);
            groupBox6.Controls.Add(lblFechaIngreso);
            groupBox6.Controls.Add(lblUsuario);
            groupBox6.Location = new Point(1153, 16);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(309, 169);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Usuario";
            // 
            // btnRecargarConfiguraciones
            // 
            btnRecargarConfiguraciones.Image = (Image)resources.GetObject("btnRecargarConfiguraciones.Image");
            btnRecargarConfiguraciones.Location = new Point(348, 15);
            btnRecargarConfiguraciones.Name = "btnRecargarConfiguraciones";
            btnRecargarConfiguraciones.Size = new Size(41, 34);
            btnRecargarConfiguraciones.TabIndex = 2;
            btnRecargarConfiguraciones.UseVisualStyleBackColor = true;
            btnRecargarConfiguraciones.Click += btnRecargarConfiguraciones_Click;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(17, 70);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(0, 15);
            lblFechaIngreso.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(15, 32);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 15);
            lblUsuario.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(1210, 193);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(252, 71);
            btnInventario.TabIndex = 9;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1218, 357);
            label18.Name = "label18";
            label18.Size = new Size(52, 15);
            label18.TabIndex = 10;
            label18.Text = "Cambio:";
            // 
            // txtCambio
            // 
            txtCambio.Enabled = false;
            txtCambio.Location = new Point(1276, 354);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(186, 23);
            txtCambio.TabIndex = 11;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(1276, 299);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(186, 23);
            txtPago.TabIndex = 13;
            txtPago.KeyDown += txtPago_KeyDown;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1216, 307);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 12;
            label19.Text = "Pago";
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 694);
            Controls.Add(txtPago);
            Controls.Add(label19);
            Controls.Add(txtCambio);
            Controls.Add(label18);
            Controls.Add(btnInventario);
            Controls.Add(groupBox6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            Load += Registro_Ventas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtNombreCliente;
        private Button btnBuscarCliente;
        private Label label2;
        private TextBox txtIdentificaconCliente;
        private Label label1;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Button btnBusquedaArticulo;
        private TextBox txtArticuloBusqueda;
        private Label label6;
        private DataGridView dgvDetallesVenta;
        private GroupBox groupBox3;
        private TextBox txtTotal;
        private Label label10;
        private DataGridView dgvTotales;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Valor;
        private TextBox txtTelefono;
        private Label label7;
        private GroupBox groupBox4;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpModificacion;
        private DateTimePicker dtpCreacion;
        private DateTimePicker dtpVenta;
        private Label label11;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaInicio;
        private Label label12;
        private DateTimePicker dtpFechaFin;
        private Label label13;
        private Button btnBuscarVenta;
        private TextBox txtDocumento;
        private Label label15;
        private ComboBox cbxEstadosVenta;
        private Label label14;
        private GroupBox groupBox6;
        private Label lblFechaIngreso;
        private Label lblUsuario;
        private TextBox txtIdVenta;
        private Label label16;
        private TextBox txtDireccionCliente;
        private Label label17;
        private DataGridViewTextBoxColumn IdImpuesto;
        private Button btnRecargarConfiguraciones;
        private Button btnAgregarCliente;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvVentas;
        private Button btnInventario;
        private Label label18;
        private TextBox txtCambio;
        private TextBox txtPago;
        private Label label19;
        private Button btnRecargarArticulos;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn IdClienteVenta;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn FechaModificacion;
        private DataGridViewTextBoxColumn IdEstado;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewImageColumn Imprimir;
        private DataGridViewImageColumn Editar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdVentaDet;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewImageColumn Eliminar;
    }
}