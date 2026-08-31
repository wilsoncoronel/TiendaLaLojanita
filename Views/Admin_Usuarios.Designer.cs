namespace TiendaLaLojanita.Views
{
    partial class Admin_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Usuarios));
            groupBox1 = new GroupBox();
            btnBuscarPersona = new Button();
            txtBusqueda = new TextBox();
            label1 = new Label();
            dgvPersonas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdTipoIdentificacion = new DataGridViewTextBoxColumn();
            TipoIdentificacion = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Modificacion = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewCheckBoxColumn();
            Cliente = new DataGridViewCheckBoxColumn();
            Proveedor = new DataGridViewCheckBoxColumn();
            Ver = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarPersona);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvPersonas);
            groupBox1.Location = new Point(8, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1464, 563);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin Personas";
            // 
            // btnBuscarPersona
            // 
            btnBuscarPersona.DialogResult = DialogResult.Yes;
            btnBuscarPersona.Image = Properties.Resources.buscar_persona;
            btnBuscarPersona.Location = new Point(420, 20);
            btnBuscarPersona.Name = "btnBuscarPersona";
            btnBuscarPersona.Size = new Size(137, 42);
            btnBuscarPersona.TabIndex = 3;
            btnBuscarPersona.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(70, 31);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Apellidos/Nombres/Identificación";
            txtBusqueda.Size = new Size(332, 23);
            txtBusqueda.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // dgvPersonas
            // 
            dgvPersonas.BorderStyle = BorderStyle.Fixed3D;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { Id, IdTipoIdentificacion, TipoIdentificacion, Identificacion, Nombres, Apellidos, Telefono, Email, Direccion, Ciudad, Creacion, Modificacion, Usuario, Cliente, Proveedor, Ver });
            dgvPersonas.Location = new Point(21, 74);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(1427, 472);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellClick += dgvPersonas_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // IdTipoIdentificacion
            // 
            IdTipoIdentificacion.HeaderText = "IdTipoIdentificacion";
            IdTipoIdentificacion.Name = "IdTipoIdentificacion";
            IdTipoIdentificacion.Visible = false;
            // 
            // TipoIdentificacion
            // 
            TipoIdentificacion.HeaderText = "Tipo";
            TipoIdentificacion.Name = "TipoIdentificacion";
            // 
            // Identificacion
            // 
            Identificacion.HeaderText = "Identificacion";
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
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            // 
            // Creacion
            // 
            Creacion.HeaderText = "Creación";
            Creacion.Name = "Creacion";
            // 
            // Modificacion
            // 
            Modificacion.HeaderText = "Modificación";
            Modificacion.Name = "Modificacion";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.Image = (Image)resources.GetObject("Ver.Image");
            Ver.Name = "Ver";
            Ver.Resizable = DataGridViewTriState.True;
            // 
            // Admin_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 577);
            Controls.Add(groupBox1);
            Name = "Admin_Usuarios";
            Text = "Admin_Usuarios";
            Load += Admin_Usuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvPersonas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdTipoIdentificacion;
        private DataGridViewTextBoxColumn TipoIdentificacion;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Modificacion;
        private DataGridViewCheckBoxColumn Usuario;
        private DataGridViewCheckBoxColumn Cliente;
        private DataGridViewCheckBoxColumn Proveedor;
        private DataGridViewImageColumn Ver;
        private Button btnBuscarPersona;
        private TextBox txtBusqueda;
        private Label label1;
    }
}