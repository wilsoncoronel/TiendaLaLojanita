namespace TiendaLaLojanita.Views
{
    partial class DatosConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosConfiguraciones));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            dgvMarcas = new DataGridView();
            IdMarca = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Visualizacion = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            button2 = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            cbxEstadoVisual = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            cbxEstadoMarca = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            txtIdMarca = new TextBox();
            txtNombreMarca = new TextBox();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            dataGridView1 = new DataGridView();
            IdTipoArticulo = new DataGridViewTextBoxColumn();
            NombreTipo = new DataGridViewTextBoxColumn();
            DescripcionTipo = new DataGridViewTextBoxColumn();
            EstadoVisual = new DataGridViewTextBoxColumn();
            EditarTipo = new DataGridViewImageColumn();
            btnCancelarTipo = new Button();
            btnGuardarTipo = new Button();
            groupBox5 = new GroupBox();
            comboBox2 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            btnCancelar = new Button();
            btbGuardarImpuesto = new Button();
            groupBox4 = new GroupBox();
            dgvImpuestos = new DataGridView();
            IdImpuesto = new DataGridViewTextBoxColumn();
            EstadoImpuesto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EditarImpuesto = new DataGridViewImageColumn();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            txtNombreImpuesto = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImpuestos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1203, 433);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1195, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Marcas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMarcas);
            groupBox2.Location = new Point(491, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(690, 389);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado Marcas Artículos";
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Columns.AddRange(new DataGridViewColumn[] { IdMarca, Marca, Estado, Visualizacion, Editar });
            dgvMarcas.Location = new Point(6, 25);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new Size(675, 352);
            dgvMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            IdMarca.HeaderText = "Id";
            IdMarca.Name = "IdMarca";
            IdMarca.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Visualizacion
            // 
            Visualizacion.HeaderText = "Visualización";
            Visualizacion.Name = "Visualizacion";
            Visualizacion.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources._10336582_edit;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(268, 353);
            button2.Name = "button2";
            button2.Size = new Size(113, 36);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(77, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 7;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxEstadoVisual);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbxEstadoMarca);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtIdMarca);
            groupBox1.Controls.Add(txtNombreMarca);
            groupBox1.Location = new Point(6, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 347);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Marca";
            // 
            // cbxEstadoVisual
            // 
            cbxEstadoVisual.FormattingEnabled = true;
            cbxEstadoVisual.Items.AddRange(new object[] { "VISIBLE", "NO VISIBLE" });
            cbxEstadoVisual.Location = new Point(115, 150);
            cbxEstadoVisual.Name = "cbxEstadoVisual";
            cbxEstadoVisual.Size = new Size(168, 23);
            cbxEstadoVisual.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 153);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Estado Visual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // cbxEstadoMarca
            // 
            cbxEstadoMarca.FormattingEnabled = true;
            cbxEstadoMarca.Location = new Point(115, 108);
            cbxEstadoMarca.Name = "cbxEstadoMarca";
            cbxEstadoMarca.Size = new Size(168, 23);
            cbxEstadoMarca.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "IdMarca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 111);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Estado:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.Location = new Point(116, 21);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(100, 23);
            txtIdMarca.TabIndex = 1;
            txtIdMarca.Text = "0";
            // 
            // txtNombreMarca
            // 
            txtNombreMarca.Location = new Point(115, 64);
            txtNombreMarca.Name = "txtNombreMarca";
            txtNombreMarca.Size = new Size(337, 23);
            txtNombreMarca.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(btnCancelarTipo);
            tabPage2.Controls.Add(btnGuardarTipo);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1195, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tipos Artículos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Location = new Point(493, 11);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(696, 388);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Listado Tipos Artículos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdTipoArticulo, NombreTipo, DescripcionTipo, EstadoVisual, EditarTipo });
            dataGridView1.Location = new Point(6, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 360);
            dataGridView1.TabIndex = 0;
            // 
            // IdTipoArticulo
            // 
            IdTipoArticulo.HeaderText = "Id";
            IdTipoArticulo.Name = "IdTipoArticulo";
            IdTipoArticulo.ReadOnly = true;
            // 
            // NombreTipo
            // 
            NombreTipo.HeaderText = "Nombre:";
            NombreTipo.Name = "NombreTipo";
            NombreTipo.ReadOnly = true;
            // 
            // DescripcionTipo
            // 
            DescripcionTipo.HeaderText = "Descripción:";
            DescripcionTipo.Name = "DescripcionTipo";
            DescripcionTipo.ReadOnly = true;
            // 
            // EstadoVisual
            // 
            EstadoVisual.HeaderText = "Estado Visual";
            EstadoVisual.Name = "EstadoVisual";
            EstadoVisual.ReadOnly = true;
            // 
            // EditarTipo
            // 
            EditarTipo.HeaderText = "Editar";
            EditarTipo.Image = Properties.Resources._10336582_edit;
            EditarTipo.Name = "EditarTipo";
            // 
            // btnCancelarTipo
            // 
            btnCancelarTipo.Image = Properties.Resources.cancelar_resize;
            btnCancelarTipo.Location = new Point(286, 350);
            btnCancelarTipo.Name = "btnCancelarTipo";
            btnCancelarTipo.Size = new Size(117, 41);
            btnCancelarTipo.TabIndex = 2;
            btnCancelarTipo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTipo
            // 
            btnGuardarTipo.Image = Properties.Resources._4856668_resize;
            btnGuardarTipo.Location = new Point(87, 350);
            btnGuardarTipo.Name = "btnGuardarTipo";
            btnGuardarTipo.Size = new Size(119, 41);
            btnGuardarTipo.TabIndex = 1;
            btnGuardarTipo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox2);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(6, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(481, 338);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tipos Artículos";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(115, 143);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 23);
            comboBox2.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(115, 104);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(345, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(115, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 143);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 3;
            label13.Text = "Visible:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 102);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 2;
            label12.Text = "Descripción:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 66);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 1;
            label11.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 28);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 0;
            label10.Text = "IdImpuesto:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnCancelar);
            tabPage3.Controls.Add(btbGuardarImpuesto);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1195, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Impuestos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancelar_resize;
            btnCancelar.Location = new Point(305, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 42);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btbGuardarImpuesto
            // 
            btbGuardarImpuesto.Image = Properties.Resources._4856668_resize;
            btbGuardarImpuesto.Location = new Point(84, 349);
            btbGuardarImpuesto.Name = "btbGuardarImpuesto";
            btbGuardarImpuesto.Size = new Size(126, 42);
            btbGuardarImpuesto.TabIndex = 2;
            btbGuardarImpuesto.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvImpuestos);
            groupBox4.Location = new Point(503, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(689, 395);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Listado Impuestos";
            // 
            // dgvImpuestos
            // 
            dgvImpuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImpuestos.Columns.AddRange(new DataGridViewColumn[] { IdImpuesto, EstadoImpuesto, Nombre, Valor, Descripcion, EditarImpuesto });
            dgvImpuestos.Location = new Point(6, 19);
            dgvImpuestos.Name = "dgvImpuestos";
            dgvImpuestos.Size = new Size(677, 370);
            dgvImpuestos.TabIndex = 0;
            // 
            // IdImpuesto
            // 
            IdImpuesto.HeaderText = "Id";
            IdImpuesto.Name = "IdImpuesto";
            IdImpuesto.ReadOnly = true;
            // 
            // EstadoImpuesto
            // 
            EstadoImpuesto.HeaderText = "Estado Impuesto";
            EstadoImpuesto.Name = "EstadoImpuesto";
            EstadoImpuesto.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // EditarImpuesto
            // 
            EditarImpuesto.HeaderText = "Editar";
            EditarImpuesto.Image = Properties.Resources._10336582_edit;
            EditarImpuesto.Name = "EditarImpuesto";
            EditarImpuesto.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtNombreImpuesto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(4, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(493, 337);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Impuestos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 23);
            textBox2.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 174);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 8;
            label9.Text = "Descripción:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 133);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(178, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 135);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 6;
            label8.Text = "Valor:";
            // 
            // txtNombreImpuesto
            // 
            txtNombreImpuesto.Location = new Point(129, 97);
            txtNombreImpuesto.Name = "txtNombreImpuesto";
            txtNombreImpuesto.Size = new Size(334, 23);
            txtNombreImpuesto.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 100);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 4;
            label7.Text = "Nombre:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(129, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 59);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 2;
            label6.Text = "Estado Impuesto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 26);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 0;
            label5.Text = "IdImpuesto:";
            // 
            // DatosConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 442);
            Controls.Add(tabControl1);
            Name = "DatosConfiguraciones";
            Text = "DatosConfiguraciones";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImpuestos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtNombreMarca;
        private Label label2;
        private TextBox txtIdMarca;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cbxEstadoMarca;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dgvMarcas;
        private Button button2;
        private Button btnGuardar;
        private ComboBox cbxEstadoVisual;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Visualizacion;
        private DataGridViewImageColumn Editar;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvImpuestos;
        private Button btnCancelar;
        private Button btbGuardarImpuesto;
        private Label label5;
        private Label label7;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private TextBox txtNombreImpuesto;
        private DataGridViewTextBoxColumn IdImpuesto;
        private DataGridViewTextBoxColumn EstadoImpuesto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewImageColumn EditarImpuesto;
        private GroupBox groupBox5;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnCancelarTipo;
        private Button btnGuardarTipo;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdTipoArticulo;
        private DataGridViewTextBoxColumn NombreTipo;
        private DataGridViewTextBoxColumn DescripcionTipo;
        private DataGridViewTextBoxColumn EstadoVisual;
        private DataGridViewImageColumn EditarTipo;
    }
}