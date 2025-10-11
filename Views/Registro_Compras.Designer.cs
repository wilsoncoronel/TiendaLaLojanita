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
            txtIdentificacionProveedor = new TextBox();
            btbBuscarProveedor = new Button();
            txtTelefono = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtRazonSocial = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblFechaIngreso = new Label();
            lblUsuario = new Label();
            groupBox3 = new GroupBox();
            btnBuscar = new Button();
            txtArticuloBusqueda = new TextBox();
            label10 = new Label();
            dgvDetalleCompra = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdCompra = new DataGridViewTextBoxColumn();
            IdArticulo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            ImpuestoValor = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            groupBox4 = new GroupBox();
            cbxEstadoCompra = new ComboBox();
            label11 = new Label();
            txtDocumento = new TextBox();
            label9 = new Label();
            dtpCreacion = new DateTimePicker();
            label8 = new Label();
            dtpCompra = new DateTimePicker();
            label7 = new Label();
            label16 = new Label();
            lblSubIva15 = new Label();
            lblSubSinIva = new Label();
            lblIva15 = new Label();
            lblTotal = new Label();
            groupBox5 = new GroupBox();
            lblIncluidoIva15 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox6 = new GroupBox();
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
            ActivarDesactivar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
            txtIdCompra = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtIdCompra);
            groupBox1.Controls.Add(txtIdentificacionProveedor);
            groupBox1.Controls.Add(btbBuscarProveedor);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedor";
            // 
            // txtIdentificacionProveedor
            // 
            txtIdentificacionProveedor.Location = new Point(245, 24);
            txtIdentificacionProveedor.Name = "txtIdentificacionProveedor";
            txtIdentificacionProveedor.PlaceholderText = "1700000000";
            txtIdentificacionProveedor.Size = new Size(247, 23);
            txtIdentificacionProveedor.TabIndex = 9;
            txtIdentificacionProveedor.KeyDown += txtIdentificacionProveedor_KeyDown;
            // 
            // btbBuscarProveedor
            // 
            btbBuscarProveedor.Image = (Image)resources.GetObject("btbBuscarProveedor.Image");
            btbBuscarProveedor.Location = new Point(512, 17);
            btbBuscarProveedor.Name = "btbBuscarProveedor";
            btbBuscarProveedor.Size = new Size(38, 34);
            btbBuscarProveedor.TabIndex = 8;
            btbBuscarProveedor.UseVisualStyleBackColor = true;
            btbBuscarProveedor.Click += btbBuscarProveedor_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(245, 144);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(156, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 147);
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
            txtDireccion.Location = new Point(245, 101);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(377, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(245, 59);
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
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "CI/ RUC:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(lblFechaIngreso);
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Location = new Point(1519, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 192);
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtArticuloBusqueda);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(dgvDetalleCompra);
            groupBox3.Location = new Point(12, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(905, 689);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Artículos";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(459, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(102, 40);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.PlaceholderText = "Artículo/Código";
            txtArticuloBusqueda.Size = new Size(325, 23);
            txtArticuloBusqueda.TabIndex = 2;
            txtArticuloBusqueda.KeyDown += txtArticuloBusqueda_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 43);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 1;
            label10.Text = "Buscar:";
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { Id, IdCompra, IdArticulo, Articulo, Descripcion, Cantidad, ValorCompra, ValorVenta, ImpuestoValor, ValorTotal, Eliminar });
            dgvDetalleCompra.Location = new Point(9, 78);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.Size = new Size(882, 565);
            dgvDetalleCompra.TabIndex = 0;
            dgvDetalleCompra.CellClick += dgvDetalleCompra_CellClick;
            dgvDetalleCompra.CellValueChanged += dgvDetalleCompra_CellValueChanged;
            dgvDetalleCompra.EditingControlShowing += dgvDetalleCompra_EditingControlShowing;
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
            ValorCompra.Visible = false;
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "ValorVenta";
            ValorVenta.Name = "ValorVenta";
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
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = (Image)resources.GetObject("Eliminar.Image");
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(cbxEstadoCompra);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txtDocumento);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(dtpCreacion);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(dtpCompra);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(820, 9);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(667, 192);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Compra";
            // 
            // cbxEstadoCompra
            // 
            cbxEstadoCompra.FormattingEnabled = true;
            cbxEstadoCompra.Location = new Point(241, 141);
            cbxEstadoCompra.Name = "cbxEstadoCompra";
            cbxEstadoCompra.Size = new Size(205, 23);
            cbxEstadoCompra.TabIndex = 7;
            cbxEstadoCompra.Text = "Seleccione";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 144);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 6;
            label11.Text = "Estado Compra:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(141, 104);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(520, 23);
            txtDocumento.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 107);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 4;
            label9.Text = "Documento:";
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(241, 63);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(420, 23);
            dtpCreacion.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 62);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 2;
            label8.Text = "Fecha Creación:";
            // 
            // dtpCompra
            // 
            dtpCompra.Format = DateTimePickerFormat.Short;
            dtpCompra.Location = new Point(241, 21);
            dtpCompra.Name = "dtpCompra";
            dtpCompra.Size = new Size(420, 23);
            dtpCompra.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 30);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 0;
            label7.Text = "Fecha Compra:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(6, 413);
            label16.Name = "label16";
            label16.Size = new Size(70, 32);
            label16.TabIndex = 11;
            label16.Text = "Total:";
            // 
            // lblSubIva15
            // 
            lblSubIva15.AutoSize = true;
            lblSubIva15.Location = new Point(19, 53);
            lblSubIva15.Name = "lblSubIva15";
            lblSubIva15.Size = new Size(0, 15);
            lblSubIva15.TabIndex = 12;
            // 
            // lblSubSinIva
            // 
            lblSubSinIva.AutoSize = true;
            lblSubSinIva.Location = new Point(19, 101);
            lblSubSinIva.Name = "lblSubSinIva";
            lblSubSinIva.Size = new Size(0, 15);
            lblSubSinIva.TabIndex = 13;
            // 
            // lblIva15
            // 
            lblIva15.AutoSize = true;
            lblIva15.Location = new Point(19, 146);
            lblIva15.Name = "lblIva15";
            lblIva15.Size = new Size(0, 15);
            lblIva15.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(111, 413);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 15;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblIncluidoIva15);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(lblTotal);
            groupBox5.Controls.Add(lblSubIva15);
            groupBox5.Controls.Add(lblIva15);
            groupBox5.Controls.Add(lblSubSinIva);
            groupBox5.Location = new Point(923, 211);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(343, 473);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Totales";
            // 
            // lblIncluidoIva15
            // 
            lblIncluidoIva15.AutoSize = true;
            lblIncluidoIva15.Location = new Point(22, 245);
            lblIncluidoIva15.Name = "lblIncluidoIva15";
            lblIncluidoIva15.Size = new Size(0, 15);
            lblIncluidoIva15.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(923, 761);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 61);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(923, 838);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 60);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox6.Controls.Add(btnBuscarCompra);
            groupBox6.Controls.Add(dtpFechaFinal);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(dtpFechaInicial);
            groupBox6.Controls.Add(dgvCompras);
            groupBox6.Location = new Point(1114, 211);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(777, 689);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "Compras";
            // 
            // btnBuscarCompra
            // 
            btnBuscarCompra.Image = (Image)resources.GetObject("btnBuscarCompra.Image");
            btnBuscarCompra.Location = new Point(540, 30);
            btnBuscarCompra.Name = "btnBuscarCompra";
            btnBuscarCompra.Size = new Size(75, 34);
            btnBuscarCompra.TabIndex = 5;
            btnBuscarCompra.UseVisualStyleBackColor = true;
            btnBuscarCompra.Click += btnBuscarCompra_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(367, 36);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(158, 23);
            dtpFechaFinal.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 40);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 3;
            label6.Text = "Final:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 40);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Inicio:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(87, 37);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(141, 23);
            dtpFechaInicial.TabIndex = 1;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdComp, FechaCompra, ProveedorId, Proveedor, EstadoId, Estado, Documento, CreadorId, Creador, ActivarDesactivar, Editar });
            dgvCompras.Location = new Point(6, 78);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new Size(765, 603);
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
            // ActivarDesactivar
            // 
            ActivarDesactivar.HeaderText = "Act/Desac";
            ActivarDesactivar.Image = (Image)resources.GetObject("ActivarDesactivar.Image");
            ActivarDesactivar.Name = "ActivarDesactivar";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            // 
            // txtIdCompra
            // 
            txtIdCompra.Enabled = false;
            txtIdCompra.Location = new Point(698, 24);
            txtIdCompra.Name = "txtIdCompra";
            txtIdCompra.Size = new Size(99, 23);
            txtIdCompra.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(564, 28);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 11;
            label12.Text = "IdCompra:";
            // 
            // Registro_Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1903, 912);
            Controls.Add(groupBox6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
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
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DateTimePicker dtpCreacion;
        private Label label8;
        private DateTimePicker dtpCompra;
        private Label label7;
        private DataGridView dgvDetalleCompra;
        private TextBox txtDocumento;
        private Label label9;
        private TextBox txtArticuloBusqueda;
        private Label label10;
        private Button btnBuscar;
        private Label lblTotal;
        private Label lblIva15;
        private Label lblSubSinIva;
        private Label lblSubIva15;
        private Label label16;
        private GroupBox groupBox5;
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox groupBox6;
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
        private Label lblIncluidoIva15;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn ImpuestoValor;
        private DataGridViewTextBoxColumn ValorTotal;
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
        private DataGridViewImageColumn ActivarDesactivar;
        private DataGridViewImageColumn Editar;
        private Label label12;
        private TextBox txtIdCompra;
    }
}