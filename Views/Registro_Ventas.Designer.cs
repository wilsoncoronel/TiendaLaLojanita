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
            ImpuestoValor = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            txtArticuloBusqueda = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dgvTotales = new DataGridView();
            Impuesto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            label10 = new Label();
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
            groupBox5 = new GroupBox();
            btnBuscarVenta = new Button();
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
            Editar = new DataGridViewImageColumn();
            dtpFechaFin = new DateTimePicker();
            label13 = new Label();
            dtpFechaInicio = new DateTimePicker();
            label12 = new Label();
            groupBox6 = new GroupBox();
            btnRecargarConfiguraciones = new Button();
            lblFechaIngreso = new Label();
            lblUsuario = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
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
            groupBox1.Size = new Size(846, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Image = (Image)resources.GetObject("btnAgregarCliente.Image");
            btnAgregarCliente.Location = new Point(443, 15);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(47, 34);
            btnAgregarCliente.TabIndex = 17;
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Enabled = false;
            txtDireccionCliente.Location = new Point(177, 126);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.Size = new Size(656, 23);
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
            txtIdVenta.Location = new Point(731, 20);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(100, 23);
            txtIdVenta.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(533, 26);
            label16.Name = "label16";
            label16.Size = new Size(49, 15);
            label16.TabIndex = 13;
            label16.Text = "IdVenta:";
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(648, 84);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "090000000";
            txtTelefono.Size = new Size(185, 23);
            txtTelefono.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(533, 87);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Telefono:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(648, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 58);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Venta:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(177, 84);
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
            txtNombreCliente.Location = new Point(177, 51);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(211, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(397, 15);
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
            txtIdentificaconCliente.Location = new Point(177, 20);
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
            groupBox2.Controls.Add(btnBusquedaArticulo);
            groupBox2.Controls.Add(dgvDetallesVenta);
            groupBox2.Controls.Add(txtArticuloBusqueda);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(16, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 492);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Articulos";
            // 
            // btnBusquedaArticulo
            // 
            btnBusquedaArticulo.Image = (Image)resources.GetObject("btnBusquedaArticulo.Image");
            btnBusquedaArticulo.Location = new Point(391, 28);
            btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            btnBusquedaArticulo.Size = new Size(83, 38);
            btnBusquedaArticulo.TabIndex = 11;
            btnBusquedaArticulo.UseVisualStyleBackColor = true;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Columns.AddRange(new DataGridViewColumn[] { Id, IdVentaDet, IdArticulo, Articulo, Descripcion, Cantidad, ValorCompra, ValorVenta, ImpuestoValor, ValorTotal, Eliminar });
            dgvDetallesVenta.Location = new Point(6, 84);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.Size = new Size(877, 402);
            dgvDetallesVenta.TabIndex = 2;
            dgvDetallesVenta.CellClick += dgvDetallesVenta_CellClick;
            dgvDetallesVenta.CellValueChanged += dgvDetallesVenta_CellValueChanged;
            dgvDetallesVenta.EditingControlShowing += dgvDetallesVenta_EditingControlShowing;
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
            // ImpuestoValor
            // 
            ImpuestoValor.HeaderText = "ImpuestoValor";
            ImpuestoValor.Name = "ImpuestoValor";
            ImpuestoValor.Visible = false;
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
            txtArticuloBusqueda.Location = new Point(121, 37);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(249, 23);
            txtArticuloBusqueda.TabIndex = 11;
            txtArticuloBusqueda.KeyDown += txtArticuloBusqueda_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 40);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Artículo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTotales);
            groupBox3.Controls.Add(txtTotal);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(920, 185);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 330);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // dgvTotales
            // 
            dgvTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotales.Columns.AddRange(new DataGridViewColumn[] { Impuesto, Valor });
            dgvTotales.Location = new Point(10, 23);
            dgvTotales.Name = "dgvTotales";
            dgvTotales.Size = new Size(240, 221);
            dgvTotales.TabIndex = 8;
            // 
            // Impuesto
            // 
            Impuesto.Frozen = true;
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.Frozen = true;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(151, 263);
            txtTotal.Name = "txtTotal";
            txtTotal.PlaceholderText = "000";
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 266);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top;
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
            groupBox4.Location = new Point(868, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(865, 162);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Venta";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(555, 52);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(297, 23);
            txtDocumento.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(439, 58);
            label15.Name = "label15";
            label15.Size = new Size(73, 15);
            label15.TabIndex = 8;
            label15.Text = "Documento:";
            // 
            // cbxEstadosVenta
            // 
            cbxEstadosVenta.FormattingEnabled = true;
            cbxEstadosVenta.Location = new Point(555, 20);
            cbxEstadosVenta.Name = "cbxEstadosVenta";
            cbxEstadosVenta.Size = new Size(121, 23);
            cbxEstadosVenta.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(439, 23);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 6;
            label14.Text = "Estado:";
            // 
            // dtpModificacion
            // 
            dtpModificacion.Enabled = false;
            dtpModificacion.Format = DateTimePickerFormat.Short;
            dtpModificacion.Location = new Point(224, 86);
            dtpModificacion.Name = "dtpModificacion";
            dtpModificacion.Size = new Size(187, 23);
            dtpModificacion.TabIndex = 5;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(224, 53);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(187, 23);
            dtpCreacion.TabIndex = 4;
            // 
            // dtpVenta
            // 
            dtpVenta.Format = DateTimePickerFormat.Short;
            dtpVenta.Location = new Point(224, 20);
            dtpVenta.Name = "dtpVenta";
            dtpVenta.Size = new Size(187, 23);
            dtpVenta.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 86);
            label11.Name = "label11";
            label11.Size = new Size(114, 15);
            label11.TabIndex = 2;
            label11.Text = "Fecha Modificación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 57);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 1;
            label9.Text = "Fecha Creación:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 23);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 0;
            label8.Text = "Fecha Venta:";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(921, 530);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(250, 64);
            btnGuardar.TabIndex = 5;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(921, 600);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(250, 64);
            btnCancelar.TabIndex = 6;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox5.Controls.Add(btnBuscarVenta);
            groupBox5.Controls.Add(dgvVentas);
            groupBox5.Controls.Add(dtpFechaFin);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(dtpFechaInicio);
            groupBox5.Controls.Add(label12);
            groupBox5.Location = new Point(1183, 185);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(759, 497);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ventas";
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Image = (Image)resources.GetObject("btnBuscarVenta.Image");
            btnBuscarVenta.Location = new Point(492, 18);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(115, 40);
            btnBuscarVenta.TabIndex = 5;
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { IdVenta, FechaVenta, IdClienteVenta, Cliente, FechaModificacion, IdEstado, Estado, Documento, Usuario, Editar });
            dgvVentas.Location = new Point(12, 73);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(741, 418);
            dgvVentas.TabIndex = 4;
            dgvVentas.CellClick += dgvVentas_CellClick;
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
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(284, 28);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 3;
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(249, 33);
            label13.Name = "label13";
            label13.Size = new Size(26, 15);
            label13.TabIndex = 2;
            label13.Text = "Fin:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(67, 29);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(148, 23);
            dtpFechaInicio.TabIndex = 1;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 34);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 0;
            label12.Text = "Inicio:";
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Controls.Add(btnRecargarConfiguraciones);
            groupBox6.Controls.Add(lblFechaIngreso);
            groupBox6.Controls.Add(lblUsuario);
            groupBox6.Location = new Point(1547, 16);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(395, 162);
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
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1954, 694);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            Load += Registro_Ventas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox5;
        private DateTimePicker dtpFechaInicio;
        private Label label12;
        private DataGridView dgvVentas;
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdVentaDet;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn ImpuestoValor;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewTextBoxColumn FechaVenta;
        private DataGridViewTextBoxColumn IdClienteVenta;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn FechaModificacion;
        private DataGridViewTextBoxColumn IdEstado;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewImageColumn Editar;
        private Button btnRecargarConfiguraciones;
        private Button btnAgregarCliente;
    }
}