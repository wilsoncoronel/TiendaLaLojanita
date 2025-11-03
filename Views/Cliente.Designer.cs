namespace TiendaLaLojanita.Views
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            groupBox1 = new GroupBox();
            txtTelefono = new TextBox();
            label10 = new Label();
            cbxEstado = new ComboBox();
            label9 = new Label();
            cbxTipoIdentificacion = new ComboBox();
            label7 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtIdentificacion = new TextBox();
            txtEmail = new TextBox();
            txtIdCLiente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            groupBox2 = new GroupBox();
            cbxCiudad = new ComboBox();
            label8 = new Label();
            btnGuardar = new Button();
            btnCerrar = new Button();
            groupBox3 = new GroupBox();
            dgvClientes = new DataGridView();
            textBox1 = new TextBox();
            label11 = new Label();
            btnBuscarCliente = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            IdTipoIdentificacion = new DataGridViewTextBoxColumn();
            TipoIdentificacion = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            ActivarDesactivar = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbxEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbxTipoIdentificacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtIdentificacion);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtIdCLiente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(472, 15);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 23);
            txtTelefono.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(392, 18);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 16;
            label10.Text = "Telefono:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstado.Location = new Point(199, 242);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(171, 23);
            cbxEstado.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 250);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 14;
            label9.Text = "Estado";
            // 
            // cbxTipoIdentificacion
            // 
            cbxTipoIdentificacion.FormattingEnabled = true;
            cbxTipoIdentificacion.Location = new Point(150, 114);
            cbxTipoIdentificacion.Name = "cbxTipoIdentificacion";
            cbxTipoIdentificacion.Size = new Size(220, 23);
            cbxTipoIdentificacion.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 114);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 12;
            label7.Text = "Tipo Identificación:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(149, 44);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(221, 23);
            txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(149, 73);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(221, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(149, 153);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(221, 23);
            txtIdentificacion.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtIdCLiente
            // 
            txtIdCLiente.Enabled = false;
            txtIdCLiente.Location = new Point(149, 15);
            txtIdCLiente.Name = "txtIdCLiente";
            txtIdCLiente.Size = new Size(221, 23);
            txtIdCLiente.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 43);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 76);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 156);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Identificación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 203);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(147, 22);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(221, 23);
            txtDireccion.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxCiudad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Location = new Point(7, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(654, 105);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Dirección";
            // 
            // cbxCiudad
            // 
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(147, 62);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(220, 23);
            cbxCiudad.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 65);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 14;
            label8.Text = "Ciudad:";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(177, 418);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 37);
            btnGuardar.TabIndex = 13;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(357, 418);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(109, 37);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvClientes);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btnBuscarCliente);
            groupBox3.Location = new Point(673, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(830, 450);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lista Clientes";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombres, Apellidos, IdTipoIdentificacion, TipoIdentificacion, Identificacion, Email, Telefono, Direccion, Ciudad, Estado, Editar, ActivarDesactivar });
            dgvClientes.Location = new Point(12, 73);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(803, 371);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 29);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 1;
            label11.Text = "Cliente / CI:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(470, 17);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(43, 40);
            btnBuscarCliente.TabIndex = 0;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
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
            // IdTipoIdentificacion
            // 
            IdTipoIdentificacion.HeaderText = "IdTipoIdentificacion";
            IdTipoIdentificacion.Name = "IdTipoIdentificacion";
            IdTipoIdentificacion.ReadOnly = true;
            IdTipoIdentificacion.Visible = false;
            // 
            // TipoIdentificacion
            // 
            TipoIdentificacion.HeaderText = "Tipo Identificacion";
            TipoIdentificacion.Name = "TipoIdentificacion";
            TipoIdentificacion.ReadOnly = true;
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificacion";
            Identificacion.Name = "Identificacion";
            Identificacion.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "E-mail";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado Cliente";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = (Image)resources.GetObject("Editar.Image");
            Editar.Name = "Editar";
            // 
            // ActivarDesactivar
            // 
            ActivarDesactivar.HeaderText = "Activar/Desactivar";
            ActivarDesactivar.Image = (Image)resources.GetObject("ActivarDesactivar.Image");
            ActivarDesactivar.Name = "ActivarDesactivar";
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 465);
            Controls.Add(groupBox3);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtIdentificacion;
        private TextBox txtEmail;
        private TextBox txtIdCLiente;
        private ComboBox cbxTipoIdentificacion;
        private Label label7;
        private TextBox txtDireccion;
        private Label label6;
        private GroupBox groupBox2;
        private ComboBox cbxCiudad;
        private Label label8;
        private ComboBox cbxEstado;
        private Label label9;
        private TextBox txtTelefono;
        private Label label10;
        private Button btnGuardar;
        private Button btnCerrar;
        private GroupBox groupBox3;
        private DataGridView dgvClientes;
        private TextBox textBox1;
        private Label label11;
        private Button btnBuscarCliente;
        private DataGridViewTextBoxColumn IdPersona;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn IdTipoIdentificacion;
        private DataGridViewTextBoxColumn TipoIdentificacion;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn ActivarDesactivar;
    }
}