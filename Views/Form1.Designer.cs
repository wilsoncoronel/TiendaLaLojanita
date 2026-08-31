namespace TiendaLaLojanita.Views
{
    partial class Formulario_Personas
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
            groupBox2 = new GroupBox();
            cbxCiudad = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
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
            label11 = new Label();
            groupBox3 = new GroupBox();
            cbxEstadoVisualCliente = new ComboBox();
            label12 = new Label();
            cbxEstadoCliente = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            comboBox2 = new ComboBox();
            label16 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            groupBox5 = new GroupBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            txtUsuario = new TextBox();
            cbxRol = new ComboBox();
            label17 = new Label();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxCiudad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDireccion);
            groupBox2.Location = new Point(14, 431);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(654, 114);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Dirección";
            // 
            // cbxCiudad
            // 
            cbxCiudad.FormattingEnabled = true;
            cbxCiudad.Location = new Point(147, 66);
            cbxCiudad.Name = "cbxCiudad";
            cbxCiudad.Size = new Size(220, 23);
            cbxCiudad.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 69);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 14;
            label8.Text = "Ciudad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 29);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(147, 26);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(501, 23);
            txtDireccion.TabIndex = 11;
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
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 372);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(191, 288);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(178, 23);
            txtTelefono.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 296);
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
            cbxTipoIdentificacion.Location = new Point(150, 57);
            cbxTipoIdentificacion.Name = "cbxTipoIdentificacion";
            cbxTipoIdentificacion.Size = new Size(220, 23);
            cbxTipoIdentificacion.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 57);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 12;
            label7.Text = "Tipo Identificación:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(149, 128);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(221, 23);
            txtNombres.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(149, 161);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(221, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(149, 96);
            txtIdentificacion.MaxLength = 13;
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
            label5.Location = new Point(11, 131);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 164);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 99);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 18);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 0;
            label11.Text = "Id:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbxEstadoVisualCliente);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cbxEstadoCliente);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(674, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(516, 119);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Cliente";
            // 
            // cbxEstadoVisualCliente
            // 
            cbxEstadoVisualCliente.FormattingEnabled = true;
            cbxEstadoVisualCliente.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstadoVisualCliente.Location = new Point(111, 74);
            cbxEstadoVisualCliente.Name = "cbxEstadoVisualCliente";
            cbxEstadoVisualCliente.Size = new Size(171, 23);
            cbxEstadoVisualCliente.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 77);
            label12.Name = "label12";
            label12.Size = new Size(79, 15);
            label12.TabIndex = 19;
            label12.Text = "Estado Visual:";
            // 
            // cbxEstadoCliente
            // 
            cbxEstadoCliente.FormattingEnabled = true;
            cbxEstadoCliente.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstadoCliente.Location = new Point(111, 29);
            cbxEstadoCliente.Name = "cbxEstadoCliente";
            cbxEstadoCliente.Size = new Size(171, 23);
            cbxEstadoCliente.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Estado:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(674, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(515, 176);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Proveedor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            comboBox1.Location = new Point(108, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(401, 23);
            textBox2.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 142);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 23;
            label15.Text = "Estado Visual:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 57);
            label14.Name = "label14";
            label14.Size = new Size(72, 15);
            label14.TabIndex = 2;
            label14.Text = "Descripción:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            comboBox2.Location = new Point(108, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 23);
            comboBox2.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 99);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 21;
            label16.Text = "Estado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 23);
            textBox1.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 22);
            label13.Name = "label13";
            label13.Size = new Size(76, 15);
            label13.TabIndex = 0;
            label13.Text = "Razon Social:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox3);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(txtUsuario);
            groupBox5.Controls.Add(cbxRol);
            groupBox5.Controls.Add(label17);
            groupBox5.Location = new Point(673, 360);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(517, 185);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Datos Usuario";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(109, 147);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(174, 23);
            comboBox3.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 23);
            textBox3.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 147);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 5;
            label20.Text = "Estado:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 110);
            label19.Name = "label19";
            label19.Size = new Size(60, 15);
            label19.TabIndex = 4;
            label19.Text = "Password:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 69);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 3;
            label18.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(112, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(168, 23);
            txtUsuario.TabIndex = 2;
            // 
            // cbxRol
            // 
            cbxRol.FormattingEnabled = true;
            cbxRol.Location = new Point(109, 26);
            cbxRol.Name = "cbxRol";
            cbxRol.Size = new Size(171, 23);
            cbxRol.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 29);
            label17.Name = "label17";
            label17.Size = new Size(27, 15);
            label17.TabIndex = 0;
            label17.Text = "Rol:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(349, 19);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(66, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Usuario";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(539, 19);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "Cliente";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(729, 19);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(80, 19);
            checkBox4.TabIndex = 21;
            checkBox4.Text = "Proveedor";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._4856668_resize;
            btnGuardar.Location = new Point(349, 551);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 46);
            btnGuardar.TabIndex = 22;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar_resize;
            btnCancelar.Location = new Point(644, 551);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 46);
            btnCancelar.TabIndex = 23;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Formulario_Personas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 609);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Formulario_Personas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos Personas";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cbxCiudad;
        private Label label8;
        private Label label6;
        private TextBox txtDireccion;
        private GroupBox groupBox1;
        private TextBox txtTelefono;
        private Label label10;
        private ComboBox cbxEstado;
        private Label label9;
        private ComboBox cbxTipoIdentificacion;
        private Label label7;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtIdentificacion;
        private TextBox txtEmail;
        private TextBox txtIdCLiente;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private GroupBox groupBox3;
        private ComboBox cbxEstadoVisualCliente;
        private Label label12;
        private ComboBox cbxEstadoCliente;
        private Label label1;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label15;
        private Label label14;
        private ComboBox comboBox2;
        private Label label16;
        private TextBox textBox1;
        private Label label13;
        private GroupBox groupBox5;
        private TextBox txtUsuario;
        private ComboBox cbxRol;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label19;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}