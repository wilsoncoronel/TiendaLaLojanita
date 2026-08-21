namespace TiendaLaLojanita.Views
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            groupBox1 = new GroupBox();
            txtIdentificacion = new TextBox();
            label13 = new Label();
            cbxTipIdentificacion = new ComboBox();
            label7 = new Label();
            cbxEstado = new ComboBox();
            label12 = new Label();
            dtpModificacion = new DateTimePicker();
            dtpCreacion = new DateTimePicker();
            txtDescripcion = new TextBox();
            txtRazonSocial = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtIdProveedor = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cbxCiudad = new ComboBox();
            txtDireccion = new TextBox();
            label15 = new Label();
            label14 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox3 = new GroupBox();
            btnCerraProveedor = new Button();
            dgvProveedor = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdTipoIdentitifacion = new DataGridViewTextBoxColumn();
            TipoIdentificacion = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            IdCiudad = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Modificacion = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            txtBusquedaProveedor = new TextBox();
            label1 = new Label();
            btnBuscarProveedor = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdentificacion);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cbxTipIdentificacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbxEstado);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtpModificacion);
            groupBox1.Controls.Add(dtpCreacion);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtIdProveedor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedor";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(133, 90);
            txtIdentificacion.MaxLength = 13;
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(199, 23);
            txtIdentificacion.TabIndex = 25;
            txtIdentificacion.KeyDown += txtIdentificacion_KeyDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 93);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 24;
            label13.Text = "Identificación:";
            // 
            // cbxTipIdentificacion
            // 
            cbxTipIdentificacion.FormattingEnabled = true;
            cbxTipIdentificacion.Location = new Point(133, 55);
            cbxTipIdentificacion.Name = "cbxTipIdentificacion";
            cbxTipIdentificacion.Size = new Size(199, 23);
            cbxTipIdentificacion.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 58);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 22;
            label7.Text = "Tip. Identificación:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxEstado.Location = new Point(450, 22);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(199, 23);
            cbxEstado.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(340, 22);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 20;
            label12.Text = "Estado:";
            // 
            // dtpModificacion
            // 
            dtpModificacion.Enabled = false;
            dtpModificacion.Format = DateTimePickerFormat.Short;
            dtpModificacion.Location = new Point(448, 90);
            dtpModificacion.Name = "dtpModificacion";
            dtpModificacion.Size = new Size(200, 23);
            dtpModificacion.TabIndex = 19;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Format = DateTimePickerFormat.Short;
            dtpCreacion.Location = new Point(449, 55);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(200, 23);
            dtpCreacion.TabIndex = 18;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(102, 329);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 23);
            txtDescripcion.TabIndex = 17;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(104, 285);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(224, 23);
            txtRazonSocial.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(341, 94);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 15;
            label10.Text = "Modificación:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(342, 61);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 14;
            label11.Text = "Creación:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(102, 207);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(226, 23);
            txtTelefono.TabIndex = 11;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(103, 164);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(226, 23);
            txtApellidos.TabIndex = 10;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(104, 129);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(226, 23);
            txtNombres.TabIndex = 9;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Enabled = false;
            txtIdProveedor.Location = new Point(106, 22);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(226, 23);
            txtIdProveedor.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 329);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 7;
            label9.Text = "Descripción:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 285);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 6;
            label8.Text = "Razón Social:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 250);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 4;
            label6.Text = "E-Mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 207);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 3;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 167);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Id Proveedor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxCiudad);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(8, 403);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(655, 98);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Dirección";
            // 
            // cbxCiudad
            // 
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(96, 54);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(234, 23);
            cbxCiudad.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 24);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(235, 23);
            txtDireccion.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 56);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 1;
            label15.Text = "Ciudad:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 23);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 0;
            label14.Text = "Dirección:";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(90, 507);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 39);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.clear;
            btnCancelar.Location = new Point(418, 507);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 39);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCerraProveedor);
            groupBox3.Controls.Add(dgvProveedor);
            groupBox3.Controls.Add(txtBusquedaProveedor);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnBuscarProveedor);
            groupBox3.Location = new Point(680, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(755, 538);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado Proveedores";
            // 
            // btnCerraProveedor
            // 
            btnCerraProveedor.Image = (Image)resources.GetObject("btnCerraProveedor.Image");
            btnCerraProveedor.Location = new Point(617, 13);
            btnCerraProveedor.Name = "btnCerraProveedor";
            btnCerraProveedor.Size = new Size(127, 39);
            btnCerraProveedor.TabIndex = 5;
            btnCerraProveedor.UseVisualStyleBackColor = true;
            btnCerraProveedor.Click += btnCerraProveedor_Click;
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Id, IdTipoIdentitifacion, TipoIdentificacion, Identificacion, Nombres, Apellidos, RazonSocial, Telefono, Email, Direccion, IdCiudad, Ciudad, Estado, Creacion, Modificacion, Editar });
            dgvProveedor.Location = new Point(16, 61);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.Size = new Size(728, 460);
            dgvProveedor.TabIndex = 3;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdTipoIdentitifacion
            // 
            IdTipoIdentitifacion.HeaderText = "IdTipoIdentificacion";
            IdTipoIdentitifacion.Name = "IdTipoIdentitifacion";
            IdTipoIdentitifacion.ReadOnly = true;
            IdTipoIdentitifacion.Resizable = DataGridViewTriState.True;
            IdTipoIdentitifacion.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdTipoIdentitifacion.Visible = false;
            // 
            // TipoIdentificacion
            // 
            TipoIdentificacion.HeaderText = "Tipo Identificación";
            TipoIdentificacion.Name = "TipoIdentificacion";
            TipoIdentificacion.ReadOnly = true;
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificación";
            Identificacion.Name = "Identificacion";
            Identificacion.ReadOnly = true;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razón Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // IdCiudad
            // 
            IdCiudad.HeaderText = "IdCiudad";
            IdCiudad.Name = "IdCiudad";
            IdCiudad.ReadOnly = true;
            IdCiudad.Resizable = DataGridViewTriState.True;
            IdCiudad.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdCiudad.Visible = false;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
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
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._10336582_edit;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // txtBusquedaProveedor
            // 
            txtBusquedaProveedor.Location = new Point(88, 22);
            txtBusquedaProveedor.Name = "txtBusquedaProveedor";
            txtBusquedaProveedor.Size = new Size(349, 23);
            txtBusquedaProveedor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Proveedor:";
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Image = (Image)resources.GetObject("btnBuscarProveedor.Image");
            btnBuscarProveedor.Location = new Point(454, 13);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(39, 38);
            btnBuscarProveedor.TabIndex = 0;
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 558);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox3);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Proveedor";
            Text = "Proveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox groupBox3;
        private TextBox txtBusquedaProveedor;
        private Label label1;
        private Button btnBuscarProveedor;
        private DataGridView dgvProveedor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtIdProveedor;
        private Label label9;
        private Label label8;
        private Label label12;
        private DateTimePicker dtpModificacion;
        private DateTimePicker dtpCreacion;
        private TextBox txtDescripcion;
        private TextBox txtRazonSocial;
        private Label label10;
        private Label label11;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private ComboBox cbxTipIdentificacion;
        private Label label7;
        private ComboBox cbxEstado;
        private TextBox txtIdentificacion;
        private Label label13;
        private ComboBox cbxCiudad;
        private TextBox txtDireccion;
        private Label label15;
        private Label label14;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdTipoIdentitifacion;
        private DataGridViewTextBoxColumn TipoIdentificacion;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn IdCiudad;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Modificacion;
        private DataGridViewImageColumn Editar;
        private Button btnCerraProveedor;
    }
}