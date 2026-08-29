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
            Descrip = new DataGridViewTextBoxColumn();
            Visualizacion = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            btnCancelarMarca = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            cbxEstadoVisual = new ComboBox();
            lblEstadoVisual = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIdMarca = new TextBox();
            txtNombreMarca = new TextBox();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            dgvTiposArticulos = new DataGridView();
            IdTipoArticulo = new DataGridViewTextBoxColumn();
            NombreTipo = new DataGridViewTextBoxColumn();
            DescripcionTipo = new DataGridViewTextBoxColumn();
            EstadoVisual = new DataGridViewTextBoxColumn();
            EditarTipo = new DataGridViewImageColumn();
            btnCancelarTipo = new Button();
            btnGuardarTipo = new Button();
            groupBox5 = new GroupBox();
            cbxEstadoTipo = new ComboBox();
            txtDescripcionTipo = new TextBox();
            txtNombreTipo = new TextBox();
            txtIdTipo = new TextBox();
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
            IdEstadoImp = new DataGridViewTextBoxColumn();
            EstadoImpuesto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EditarImpuesto = new DataGridViewImageColumn();
            groupBox3 = new GroupBox();
            txtDescripcionImpuesto = new TextBox();
            label9 = new Label();
            nudValorImpuesto = new NumericUpDown();
            label8 = new Label();
            txtNombreImpuesto = new TextBox();
            label7 = new Label();
            cbxEstadoImpuesto = new ComboBox();
            label6 = new Label();
            txtIdImpuesto = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            btnLimpiarPorcentaje = new Button();
            btnGuardarPorcentaje = new Button();
            groupBox8 = new GroupBox();
            cbxEstadoPor = new ComboBox();
            label16 = new Label();
            label4 = new Label();
            label14 = new Label();
            txtPorcentajeValor = new TextBox();
            label15 = new Label();
            txtPorcentaje = new TextBox();
            txtIdPorcentaje = new TextBox();
            groupBox7 = new GroupBox();
            dgvPorcentajes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Porcentaje = new DataGridViewTextBoxColumn();
            ValorPorcen = new DataGridViewTextBoxColumn();
            EstadoPor = new DataGridViewTextBoxColumn();
            EditarPor = new DataGridViewImageColumn();
            tabPage5 = new TabPage();
            groupBox10 = new GroupBox();
            dgvUnidadesMedida = new DataGridView();
            IdUni = new DataGridViewTextBoxColumn();
            NombreUni = new DataGridViewTextBoxColumn();
            EstadoUni = new DataGridViewTextBoxColumn();
            EstadoVisualUni = new DataGridViewTextBoxColumn();
            EditarUni = new DataGridViewImageColumn();
            btnLimpiarUni = new Button();
            btnGuardarUni = new Button();
            groupBox9 = new GroupBox();
            cbxEstadoVisualUnidad = new ComboBox();
            label20 = new Label();
            label17 = new Label();
            cbxEstadoUnidad = new ComboBox();
            label18 = new Label();
            txtNombreUnidad = new TextBox();
            label19 = new Label();
            txtIdUnidad = new TextBox();
            btnCerrarDatosConf = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTiposArticulos).BeginInit();
            groupBox5.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImpuestos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorImpuesto).BeginInit();
            tabPage4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPorcentajes).BeginInit();
            tabPage5.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnidadesMedida).BeginInit();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(1, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1206, 416);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(btnCancelarMarca);
            tabPage1.Controls.Add(btnGuardar);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1198, 388);
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
            dgvMarcas.Columns.AddRange(new DataGridViewColumn[] { IdMarca, Marca, Descrip, Visualizacion, Editar });
            dgvMarcas.Location = new Point(6, 25);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new Size(675, 352);
            dgvMarcas.TabIndex = 0;
            dgvMarcas.CellClick += dgvMarcas_CellClick;
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
            // Descrip
            // 
            Descrip.HeaderText = "Descripción";
            Descrip.Name = "Descrip";
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
            // btnCancelarMarca
            // 
            btnCancelarMarca.Image = Properties.Resources.clear;
            btnCancelarMarca.Location = new Point(270, 340);
            btnCancelarMarca.Name = "btnCancelarMarca";
            btnCancelarMarca.Size = new Size(113, 36);
            btnCancelarMarca.TabIndex = 8;
            btnCancelarMarca.UseVisualStyleBackColor = true;
            btnCancelarMarca.Click += btnCancelarMarca_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(79, 341);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 7;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxEstadoVisual);
            groupBox1.Controls.Add(lblEstadoVisual);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIdMarca);
            groupBox1.Controls.Add(txtNombreMarca);
            groupBox1.Location = new Point(6, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 333);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Marca";
            // 
            // cbxEstadoVisual
            // 
            cbxEstadoVisual.FormattingEnabled = true;
            cbxEstadoVisual.Items.AddRange(new object[] { "Visible", "No Visible" });
            cbxEstadoVisual.Location = new Point(115, 148);
            cbxEstadoVisual.Name = "cbxEstadoVisual";
            cbxEstadoVisual.Size = new Size(176, 23);
            cbxEstadoVisual.TabIndex = 7;
            // 
            // lblEstadoVisual
            // 
            lblEstadoVisual.AutoSize = true;
            lblEstadoVisual.Location = new Point(20, 151);
            lblEstadoVisual.Name = "lblEstadoVisual";
            lblEstadoVisual.Size = new Size(79, 15);
            lblEstadoVisual.TabIndex = 6;
            lblEstadoVisual.Text = "Estado Visual:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(115, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(337, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "IdMarca:";
            // 
            // txtIdMarca
            // 
            txtIdMarca.Enabled = false;
            txtIdMarca.Location = new Point(116, 21);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(100, 23);
            txtIdMarca.TabIndex = 1;
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
            tabPage2.Size = new Size(1198, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tipos Artículos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvTiposArticulos);
            groupBox6.Location = new Point(493, 11);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(696, 388);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Listado Tipos Artículos";
            // 
            // dgvTiposArticulos
            // 
            dgvTiposArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposArticulos.Columns.AddRange(new DataGridViewColumn[] { IdTipoArticulo, NombreTipo, DescripcionTipo, EstadoVisual, EditarTipo });
            dgvTiposArticulos.Location = new Point(6, 20);
            dgvTiposArticulos.Name = "dgvTiposArticulos";
            dgvTiposArticulos.Size = new Size(670, 351);
            dgvTiposArticulos.TabIndex = 0;
            dgvTiposArticulos.CellClick += dgvTiposArticulos_CellClick;
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
            btnCancelarTipo.Image = Properties.Resources.clear;
            btnCancelarTipo.Location = new Point(299, 341);
            btnCancelarTipo.Name = "btnCancelarTipo";
            btnCancelarTipo.Size = new Size(117, 41);
            btnCancelarTipo.TabIndex = 2;
            btnCancelarTipo.UseVisualStyleBackColor = true;
            btnCancelarTipo.Click += btnCancelarTipo_Click;
            // 
            // btnGuardarTipo
            // 
            btnGuardarTipo.Image = Properties.Resources._4856668_resize;
            btnGuardarTipo.Location = new Point(90, 341);
            btnGuardarTipo.Name = "btnGuardarTipo";
            btnGuardarTipo.Size = new Size(119, 41);
            btnGuardarTipo.TabIndex = 1;
            btnGuardarTipo.UseVisualStyleBackColor = true;
            btnGuardarTipo.Click += btnGuardarTipo_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbxEstadoTipo);
            groupBox5.Controls.Add(txtDescripcionTipo);
            groupBox5.Controls.Add(txtNombreTipo);
            groupBox5.Controls.Add(txtIdTipo);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(6, 6);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(481, 329);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tipos Artículos";
            // 
            // cbxEstadoTipo
            // 
            cbxEstadoTipo.FormattingEnabled = true;
            cbxEstadoTipo.Items.AddRange(new object[] { "VISIBLE", "NO VISIBLE" });
            cbxEstadoTipo.Location = new Point(115, 143);
            cbxEstadoTipo.Name = "cbxEstadoTipo";
            cbxEstadoTipo.Size = new Size(155, 23);
            cbxEstadoTipo.TabIndex = 7;
            // 
            // txtDescripcionTipo
            // 
            txtDescripcionTipo.Location = new Point(115, 104);
            txtDescripcionTipo.Name = "txtDescripcionTipo";
            txtDescripcionTipo.Size = new Size(345, 23);
            txtDescripcionTipo.TabIndex = 6;
            // 
            // txtNombreTipo
            // 
            txtNombreTipo.Location = new Point(115, 63);
            txtNombreTipo.Name = "txtNombreTipo";
            txtNombreTipo.Size = new Size(209, 23);
            txtNombreTipo.TabIndex = 5;
            // 
            // txtIdTipo
            // 
            txtIdTipo.Enabled = false;
            txtIdTipo.Location = new Point(119, 22);
            txtIdTipo.Name = "txtIdTipo";
            txtIdTipo.Size = new Size(100, 23);
            txtIdTipo.TabIndex = 4;
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
            label10.Size = new Size(43, 15);
            label10.TabIndex = 0;
            label10.Text = "IdTipo:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnCancelar);
            tabPage3.Controls.Add(btbGuardarImpuesto);
            tabPage3.Controls.Add(groupBox4);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1198, 388);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Impuestos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.clear;
            btnCancelar.Location = new Point(303, 334);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 42);
            btnCancelar.TabIndex = 3;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btbGuardarImpuesto
            // 
            btbGuardarImpuesto.Image = Properties.Resources._4856668_resize;
            btbGuardarImpuesto.Location = new Point(84, 334);
            btbGuardarImpuesto.Name = "btbGuardarImpuesto";
            btbGuardarImpuesto.Size = new Size(126, 42);
            btbGuardarImpuesto.TabIndex = 2;
            btbGuardarImpuesto.UseVisualStyleBackColor = true;
            btbGuardarImpuesto.Click += btbGuardarImpuesto_Click;
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
            dgvImpuestos.Columns.AddRange(new DataGridViewColumn[] { IdImpuesto, IdEstadoImp, EstadoImpuesto, Nombre, Valor, Descripcion, EditarImpuesto });
            dgvImpuestos.Location = new Point(6, 19);
            dgvImpuestos.Name = "dgvImpuestos";
            dgvImpuestos.Size = new Size(677, 351);
            dgvImpuestos.TabIndex = 0;
            dgvImpuestos.CellClick += dgvImpuestos_CellClick;
            // 
            // IdImpuesto
            // 
            IdImpuesto.HeaderText = "Id";
            IdImpuesto.Name = "IdImpuesto";
            IdImpuesto.ReadOnly = true;
            // 
            // IdEstadoImp
            // 
            IdEstadoImp.HeaderText = "IdEstado";
            IdEstadoImp.Name = "IdEstadoImp";
            IdEstadoImp.ReadOnly = true;
            IdEstadoImp.Visible = false;
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
            groupBox3.Controls.Add(txtDescripcionImpuesto);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(nudValorImpuesto);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtNombreImpuesto);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cbxEstadoImpuesto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtIdImpuesto);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(4, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(493, 322);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Impuestos";
            // 
            // txtDescripcionImpuesto
            // 
            txtDescripcionImpuesto.Location = new Point(129, 174);
            txtDescripcionImpuesto.Name = "txtDescripcionImpuesto";
            txtDescripcionImpuesto.Size = new Size(334, 23);
            txtDescripcionImpuesto.TabIndex = 9;
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
            // nudValorImpuesto
            // 
            nudValorImpuesto.DecimalPlaces = 2;
            nudValorImpuesto.Location = new Point(129, 133);
            nudValorImpuesto.Name = "nudValorImpuesto";
            nudValorImpuesto.Size = new Size(178, 23);
            nudValorImpuesto.TabIndex = 7;
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
            // cbxEstadoImpuesto
            // 
            cbxEstadoImpuesto.FormattingEnabled = true;
            cbxEstadoImpuesto.Location = new Point(129, 56);
            cbxEstadoImpuesto.Name = "cbxEstadoImpuesto";
            cbxEstadoImpuesto.Size = new Size(178, 23);
            cbxEstadoImpuesto.TabIndex = 3;
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
            // txtIdImpuesto
            // 
            txtIdImpuesto.Enabled = false;
            txtIdImpuesto.Location = new Point(129, 22);
            txtIdImpuesto.Name = "txtIdImpuesto";
            txtIdImpuesto.Size = new Size(100, 23);
            txtIdImpuesto.TabIndex = 1;
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
            // tabPage4
            // 
            tabPage4.Controls.Add(btnLimpiarPorcentaje);
            tabPage4.Controls.Add(btnGuardarPorcentaje);
            tabPage4.Controls.Add(groupBox8);
            tabPage4.Controls.Add(groupBox7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1198, 388);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Porcentaje Ganancia";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPorcentaje
            // 
            btnLimpiarPorcentaje.Image = Properties.Resources.clear;
            btnLimpiarPorcentaje.Location = new Point(253, 319);
            btnLimpiarPorcentaje.Name = "btnLimpiarPorcentaje";
            btnLimpiarPorcentaje.Size = new Size(129, 54);
            btnLimpiarPorcentaje.TabIndex = 9;
            btnLimpiarPorcentaje.UseVisualStyleBackColor = true;
            btnLimpiarPorcentaje.Click += btnLimpiarPorcentaje_Click;
            // 
            // btnGuardarPorcentaje
            // 
            btnGuardarPorcentaje.Image = Properties.Resources._4856668_resize;
            btnGuardarPorcentaje.Location = new Point(47, 319);
            btnGuardarPorcentaje.Name = "btnGuardarPorcentaje";
            btnGuardarPorcentaje.Size = new Size(129, 54);
            btnGuardarPorcentaje.TabIndex = 8;
            btnGuardarPorcentaje.UseVisualStyleBackColor = true;
            btnGuardarPorcentaje.Click += btnGuardarPorcentaje_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cbxEstadoPor);
            groupBox8.Controls.Add(label16);
            groupBox8.Controls.Add(label4);
            groupBox8.Controls.Add(label14);
            groupBox8.Controls.Add(txtPorcentajeValor);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(txtPorcentaje);
            groupBox8.Controls.Add(txtIdPorcentaje);
            groupBox8.Location = new Point(16, 14);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(431, 299);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "Datos Porcentajes";
            // 
            // cbxEstadoPor
            // 
            cbxEstadoPor.FormattingEnabled = true;
            cbxEstadoPor.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstadoPor.Location = new Point(99, 155);
            cbxEstadoPor.Name = "cbxEstadoPor";
            cbxEstadoPor.Size = new Size(217, 23);
            cbxEstadoPor.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 42);
            label16.Name = "label16";
            label16.Size = new Size(20, 15);
            label16.TabIndex = 6;
            label16.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 81);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Porcentaje:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 119);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 1;
            label14.Text = "Valor:";
            // 
            // txtPorcentajeValor
            // 
            txtPorcentajeValor.Location = new Point(99, 116);
            txtPorcentajeValor.Name = "txtPorcentajeValor";
            txtPorcentajeValor.Size = new Size(217, 23);
            txtPorcentajeValor.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 158);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 2;
            label15.Text = "Estado:";
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(99, 78);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(217, 23);
            txtPorcentaje.TabIndex = 4;
            // 
            // txtIdPorcentaje
            // 
            txtIdPorcentaje.Enabled = false;
            txtIdPorcentaje.Location = new Point(99, 39);
            txtIdPorcentaje.Name = "txtIdPorcentaje";
            txtIdPorcentaje.Size = new Size(78, 23);
            txtIdPorcentaje.TabIndex = 3;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dgvPorcentajes);
            groupBox7.Location = new Point(462, 14);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(720, 359);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Lista Porcentajes";
            // 
            // dgvPorcentajes
            // 
            dgvPorcentajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorcentajes.Columns.AddRange(new DataGridViewColumn[] { Id, Porcentaje, ValorPorcen, EstadoPor, EditarPor });
            dgvPorcentajes.Location = new Point(12, 24);
            dgvPorcentajes.Name = "dgvPorcentajes";
            dgvPorcentajes.Size = new Size(698, 319);
            dgvPorcentajes.TabIndex = 0;
            dgvPorcentajes.CellClick += dgvPorcentajes_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Porcentaje
            // 
            Porcentaje.HeaderText = "Porcentaje";
            Porcentaje.Name = "Porcentaje";
            // 
            // ValorPorcen
            // 
            ValorPorcen.HeaderText = "Valor";
            ValorPorcen.Name = "ValorPorcen";
            // 
            // EstadoPor
            // 
            EstadoPor.HeaderText = "Estado";
            EstadoPor.Name = "EstadoPor";
            // 
            // EditarPor
            // 
            EditarPor.HeaderText = "Editar";
            EditarPor.Image = Properties.Resources._10336582_edit;
            EditarPor.Name = "EditarPor";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBox10);
            tabPage5.Controls.Add(btnLimpiarUni);
            tabPage5.Controls.Add(btnGuardarUni);
            tabPage5.Controls.Add(groupBox9);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1198, 388);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Unidades de Medida/Peso";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dgvUnidadesMedida);
            groupBox10.Location = new Point(355, 6);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(798, 367);
            groupBox10.TabIndex = 12;
            groupBox10.TabStop = false;
            groupBox10.Text = "Lista Unidades";
            // 
            // dgvUnidadesMedida
            // 
            dgvUnidadesMedida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnidadesMedida.Columns.AddRange(new DataGridViewColumn[] { IdUni, NombreUni, EstadoUni, EstadoVisualUni, EditarUni });
            dgvUnidadesMedida.Location = new Point(15, 24);
            dgvUnidadesMedida.Name = "dgvUnidadesMedida";
            dgvUnidadesMedida.Size = new Size(769, 328);
            dgvUnidadesMedida.TabIndex = 0;
            dgvUnidadesMedida.CellClick += dgvUnidadesMedida_CellClick;
            // 
            // IdUni
            // 
            IdUni.HeaderText = "Id";
            IdUni.Name = "IdUni";
            // 
            // NombreUni
            // 
            NombreUni.HeaderText = "Nombre";
            NombreUni.Name = "NombreUni";
            // 
            // EstadoUni
            // 
            EstadoUni.HeaderText = "Estado";
            EstadoUni.Name = "EstadoUni";
            // 
            // EstadoVisualUni
            // 
            EstadoVisualUni.HeaderText = "EstadoVisual";
            EstadoVisualUni.Name = "EstadoVisualUni";
            // 
            // EditarUni
            // 
            EditarUni.HeaderText = "Editar";
            EditarUni.Image = Properties.Resources._10336582_edit;
            EditarUni.Name = "EditarUni";
            // 
            // btnLimpiarUni
            // 
            btnLimpiarUni.Image = Properties.Resources.clear;
            btnLimpiarUni.Location = new Point(213, 319);
            btnLimpiarUni.Name = "btnLimpiarUni";
            btnLimpiarUni.Size = new Size(129, 54);
            btnLimpiarUni.TabIndex = 11;
            btnLimpiarUni.UseVisualStyleBackColor = true;
            btnLimpiarUni.Click += btnLimpiarUni_Click;
            // 
            // btnGuardarUni
            // 
            btnGuardarUni.Image = Properties.Resources._4856668_resize;
            btnGuardarUni.Location = new Point(7, 319);
            btnGuardarUni.Name = "btnGuardarUni";
            btnGuardarUni.Size = new Size(129, 54);
            btnGuardarUni.TabIndex = 10;
            btnGuardarUni.UseVisualStyleBackColor = true;
            btnGuardarUni.Click += btnGuardarUni_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cbxEstadoVisualUnidad);
            groupBox9.Controls.Add(label20);
            groupBox9.Controls.Add(label17);
            groupBox9.Controls.Add(cbxEstadoUnidad);
            groupBox9.Controls.Add(label18);
            groupBox9.Controls.Add(txtNombreUnidad);
            groupBox9.Controls.Add(label19);
            groupBox9.Controls.Add(txtIdUnidad);
            groupBox9.Location = new Point(7, 6);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(335, 297);
            groupBox9.TabIndex = 6;
            groupBox9.TabStop = false;
            groupBox9.Text = "Datos Unidades Medida";
            // 
            // cbxEstadoVisualUnidad
            // 
            cbxEstadoVisualUnidad.FormattingEnabled = true;
            cbxEstadoVisualUnidad.Items.AddRange(new object[] { "VISIBLE", "NO VISIBLE" });
            cbxEstadoVisualUnidad.Location = new Point(136, 162);
            cbxEstadoVisualUnidad.Name = "cbxEstadoVisualUnidad";
            cbxEstadoVisualUnidad.Size = new Size(121, 23);
            cbxEstadoVisualUnidad.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(45, 165);
            label20.Name = "label20";
            label20.Size = new Size(73, 15);
            label20.TabIndex = 6;
            label20.Text = "EstadoVisual";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(45, 48);
            label17.Name = "label17";
            label17.Size = new Size(20, 15);
            label17.TabIndex = 0;
            label17.Text = "Id:";
            // 
            // cbxEstadoUnidad
            // 
            cbxEstadoUnidad.FormattingEnabled = true;
            cbxEstadoUnidad.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstadoUnidad.Location = new Point(136, 121);
            cbxEstadoUnidad.Name = "cbxEstadoUnidad";
            cbxEstadoUnidad.Size = new Size(121, 23);
            cbxEstadoUnidad.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(45, 87);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 1;
            label18.Text = "Nombre:";
            // 
            // txtNombreUnidad
            // 
            txtNombreUnidad.Location = new Point(157, 84);
            txtNombreUnidad.Name = "txtNombreUnidad";
            txtNombreUnidad.Size = new Size(100, 23);
            txtNombreUnidad.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(45, 124);
            label19.Name = "label19";
            label19.Size = new Size(45, 15);
            label19.TabIndex = 2;
            label19.Text = "Estado:";
            // 
            // txtIdUnidad
            // 
            txtIdUnidad.Enabled = false;
            txtIdUnidad.Location = new Point(157, 48);
            txtIdUnidad.Name = "txtIdUnidad";
            txtIdUnidad.Size = new Size(100, 23);
            txtIdUnidad.TabIndex = 3;
            // 
            // btnCerrarDatosConf
            // 
            btnCerrarDatosConf.Image = Properties.Resources.cancelar_resize;
            btnCerrarDatosConf.Location = new Point(1077, 1);
            btnCerrarDatosConf.Name = "btnCerrarDatosConf";
            btnCerrarDatosConf.Size = new Size(126, 42);
            btnCerrarDatosConf.TabIndex = 4;
            btnCerrarDatosConf.UseVisualStyleBackColor = true;
            btnCerrarDatosConf.Click += btnCerrarDatosConf_Click;
            // 
            // DatosConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 442);
            ControlBox = false;
            Controls.Add(btnCerrarDatosConf);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatosConfiguraciones";
            Text = "DatosConfiguraciones";
            Load += DatosConfiguraciones_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTiposArticulos).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImpuestos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorImpuesto).EndInit();
            tabPage4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPorcentajes).EndInit();
            tabPage5.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnidadesMedida).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
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
        private GroupBox groupBox2;
        private DataGridView dgvMarcas;
        private Button btnCancelarMarca;
        private Button btnGuardar;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dgvImpuestos;
        private Button btnCancelar;
        private Button btbGuardarImpuesto;
        private Label label5;
        private Label label7;
        private ComboBox cbxEstadoImpuesto;
        private Label label6;
        private TextBox txtIdImpuesto;
        private TextBox txtDescripcionImpuesto;
        private Label label9;
        private NumericUpDown nudValorImpuesto;
        private Label label8;
        private TextBox txtNombreImpuesto;
        private GroupBox groupBox5;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnCancelarTipo;
        private Button btnGuardarTipo;
        private ComboBox cbxEstadoTipo;
        private TextBox txtDescripcionTipo;
        private TextBox txtNombreTipo;
        private TextBox txtIdTipo;
        private GroupBox groupBox6;
        private DataGridView dgvTiposArticulos;
        private DataGridViewTextBoxColumn IdTipoArticulo;
        private DataGridViewTextBoxColumn NombreTipo;
        private DataGridViewTextBoxColumn DescripcionTipo;
        private DataGridViewTextBoxColumn EstadoVisual;
        private DataGridViewImageColumn EditarTipo;
        private TextBox txtDescripcion;
        private Label label3;
        private ComboBox cbxEstadoVisual;
        private Label lblEstadoVisual;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Descrip;
        private DataGridViewTextBoxColumn Visualizacion;
        private DataGridViewImageColumn Editar;
        private DataGridViewTextBoxColumn IdImpuesto;
        private DataGridViewTextBoxColumn IdEstadoImp;
        private DataGridViewTextBoxColumn EstadoImpuesto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewImageColumn EditarImpuesto;
        private Button btnCerrarDatosConf;
        private TabPage tabPage4;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private TextBox txtPorcentajeValor;
        private TextBox txtPorcentaje;
        private TextBox txtIdPorcentaje;
        private Label label15;
        private Label label14;
        private Label label4;
        private Button btnLimpiarPorcentaje;
        private Button btnGuardarPorcentaje;
        private ComboBox cbxEstadoPor;
        private Label label16;
        private DataGridView dgvPorcentajes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Porcentaje;
        private DataGridViewTextBoxColumn ValorPorcen;
        private DataGridViewTextBoxColumn EstadoPor;
        private DataGridViewImageColumn EditarPor;
        private TabPage tabPage5;
        private Label label19;
        private Label label18;
        private Label label17;
        private GroupBox groupBox9;
        private ComboBox cbxEstadoUnidad;
        private TextBox txtNombreUnidad;
        private TextBox txtIdUnidad;
        private GroupBox groupBox10;
        private DataGridView dgvUnidadesMedida;
        private Button btnLimpiarUni;
        private Button btnGuardarUni;
        private DataGridViewTextBoxColumn IdUni;
        private DataGridViewTextBoxColumn NombreUni;
        private DataGridViewTextBoxColumn EstadoUni;
        private DataGridViewTextBoxColumn EstadoVisualUni;
        private DataGridViewImageColumn EditarUni;
        private ComboBox cbxEstadoVisualUnidad;
        private Label label20;
    }
}