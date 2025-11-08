namespace TiendaLaLojanita.Views
{
    partial class Registro_Articulos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Articulos));
            groupBox1 = new GroupBox();
            btnAgregarDatosConfiguraciones = new Button();
            chckPapeleria = new CheckBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cbxEstado = new ComboBox();
            label9 = new Label();
            txtDescripcion = new TextBox();
            label8 = new Label();
            dtpCaducidad = new DateTimePicker();
            label7 = new Label();
            dtpCreacion = new DateTimePicker();
            label6 = new Label();
            txtCodigo = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            cbxImpuesto = new ComboBox();
            cbxTipoArticulo = new ComboBox();
            cbxMarca = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            txtUnidad = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            nudUnidadValor = new NumericUpDown();
            groupBox2 = new GroupBox();
            nudValorVenta = new NumericUpDown();
            nudValorCompra = new NumericUpDown();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnBuscar = new Button();
            dtpFechaFinal = new DateTimePicker();
            label16 = new Label();
            dtpFechaInicial = new DateTimePicker();
            label15 = new Label();
            txtArticulo = new TextBox();
            label14 = new Label();
            dgvArticulos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Papeleria = new DataGridViewTextBoxColumn();
            IdMarca = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            IdTipoArticulo = new DataGridViewTextBoxColumn();
            TipoArticulo = new DataGridViewTextBoxColumn();
            IdImpuesto = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            FechaActualizacion = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            ValorUnidad = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewImageColumn();
            ActivarDesactivar = new DataGridViewImageColumn();
            groupBox5 = new GroupBox();
            lblFecha = new Label();
            lblUser = new Label();
            groupBox6 = new GroupBox();
            lblArchivo = new Label();
            btnAbrirArchivo = new Button();
            ofdArticulos = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnidadValor).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValorCompra).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAgregarDatosConfiguraciones);
            groupBox1.Controls.Add(chckPapeleria);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(cbxEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpCaducidad);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpCreacion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cbxImpuesto);
            groupBox1.Controls.Add(cbxTipoArticulo);
            groupBox1.Controls.Add(cbxMarca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1271, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Artículo";
            // 
            // btnAgregarDatosConfiguraciones
            // 
            btnAgregarDatosConfiguraciones.Image = (Image)resources.GetObject("btnAgregarDatosConfiguraciones.Image");
            btnAgregarDatosConfiguraciones.Location = new Point(1048, 143);
            btnAgregarDatosConfiguraciones.Name = "btnAgregarDatosConfiguraciones";
            btnAgregarDatosConfiguraciones.Size = new Size(137, 42);
            btnAgregarDatosConfiguraciones.TabIndex = 23;
            toolTip1.SetToolTip(btnAgregarDatosConfiguraciones, "Agregar Datos de configuracion Marcas, etc..");
            btnAgregarDatosConfiguraciones.UseVisualStyleBackColor = true;
            btnAgregarDatosConfiguraciones.Click += btnAgregarDatosConfiguraciones_Click;
            // 
            // chckPapeleria
            // 
            chckPapeleria.AutoSize = true;
            chckPapeleria.Location = new Point(647, 184);
            chckPapeleria.Name = "chckPapeleria";
            chckPapeleria.Size = new Size(130, 19);
            chckPapeleria.TabIndex = 22;
            chckPapeleria.Text = "Inventario Papelería";
            chckPapeleria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(1049, 86);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 43);
            btnCancelar.TabIndex = 21;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(1049, 22);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 43);
            btnGuardar.TabIndex = 20;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cbxEstado.Location = new Point(648, 146);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(363, 23);
            cbxEstado.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 188);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 18;
            label9.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(161, 186);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(315, 23);
            txtDescripcion.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(555, 146);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 14;
            label8.Text = "Estado:";
            // 
            // dtpCaducidad
            // 
            dtpCaducidad.Location = new Point(648, 103);
            dtpCaducidad.Name = "dtpCaducidad";
            dtpCaducidad.Size = new Size(363, 23);
            dtpCaducidad.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 106);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 12;
            label7.Text = "Caducidad:";
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Location = new Point(648, 65);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(363, 23);
            dtpCreacion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 67);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Creación:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(648, 25);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(128, 23);
            txtCodigo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 31);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "Código:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 23);
            txtNombre.TabIndex = 7;
            // 
            // cbxImpuesto
            // 
            cbxImpuesto.FormattingEnabled = true;
            cbxImpuesto.Location = new Point(162, 106);
            cbxImpuesto.Name = "cbxImpuesto";
            cbxImpuesto.Size = new Size(314, 23);
            cbxImpuesto.TabIndex = 6;
            // 
            // cbxTipoArticulo
            // 
            cbxTipoArticulo.FormattingEnabled = true;
            cbxTipoArticulo.Location = new Point(163, 66);
            cbxTipoArticulo.Name = "cbxTipoArticulo";
            cbxTipoArticulo.Size = new Size(313, 23);
            cbxTipoArticulo.TabIndex = 5;
            // 
            // cbxMarca
            // 
            cbxMarca.FormattingEnabled = true;
            cbxMarca.Location = new Point(161, 25);
            cbxMarca.Name = "cbxMarca";
            cbxMarca.Size = new Size(315, 23);
            cbxMarca.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 146);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 109);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Impuesto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 68);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo Artículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 38);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 19;
            label10.Text = "Unidad:";
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(98, 36);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.PlaceholderText = "ML/GR/UNI";
            txtUnidad.Size = new Size(215, 23);
            txtUnidad.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(345, 36);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 21;
            label11.Text = "Unidad Valor:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 36);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 23;
            label12.Text = "Valor Compra:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(348, 38);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 25;
            label13.Text = "Valor Venta:";
            // 
            // nudUnidadValor
            // 
            nudUnidadValor.Location = new Point(446, 33);
            nudUnidadValor.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudUnidadValor.Name = "nudUnidadValor";
            nudUnidadValor.Size = new Size(120, 23);
            nudUnidadValor.TabIndex = 27;
            nudUnidadValor.KeyPress += nudUnidadValor_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(nudValorVenta);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(nudValorCompra);
            groupBox2.Location = new Point(11, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 76);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Valores Artículo";
            // 
            // nudValorVenta
            // 
            nudValorVenta.DecimalPlaces = 2;
            nudValorVenta.Location = new Point(431, 36);
            nudValorVenta.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudValorVenta.Name = "nudValorVenta";
            nudValorVenta.Size = new Size(169, 23);
            nudValorVenta.TabIndex = 26;
            nudValorVenta.KeyPress += nudValorVenta_KeyPress;
            // 
            // nudValorCompra
            // 
            nudValorCompra.DecimalPlaces = 2;
            nudValorCompra.Location = new Point(131, 34);
            nudValorCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudValorCompra.Name = "nudValorCompra";
            nudValorCompra.Size = new Size(187, 23);
            nudValorCompra.TabIndex = 24;
            nudValorCompra.KeyPress += nudValorCompra_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(nudUnidadValor);
            groupBox3.Controls.Add(txtUnidad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(675, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(607, 76);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Unidad/Peso Artículo";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(btnBuscar);
            groupBox4.Controls.Add(dtpFechaFinal);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(dtpFechaInicial);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(txtArticulo);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(dgvArticulos);
            groupBox4.Location = new Point(10, 332);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1518, 379);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Listado Articulos";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1356, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(149, 45);
            btnBuscar.TabIndex = 7;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(1020, 29);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(295, 23);
            dtpFechaFinal.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(909, 35);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 5;
            label16.Text = "Fecha Fin:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(526, 29);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(337, 23);
            dtpFechaInicial.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(413, 31);
            label15.Name = "label15";
            label15.Size = new Size(73, 15);
            label15.TabIndex = 3;
            label15.Text = "Fecha Inicio:";
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(109, 28);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.PlaceholderText = "Nombre Artículo/Código";
            txtArticulo.Size = new Size(259, 23);
            txtArticulo.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 31);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 1;
            label14.Text = "Artículo:";
            // 
            // dgvArticulos
            // 
            dgvArticulos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Id, Articulo, Descripcion, Papeleria, IdMarca, Marca, IdTipoArticulo, TipoArticulo, IdImpuesto, Impuesto, Estado, FechaCreacion, FechaActualizacion, PrecioCompra, PrecioVenta, Unidad, ValorUnidad, Editar, ActivarDesactivar });
            dgvArticulos.Location = new Point(11, 73);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(1500, 290);
            dgvArticulos.TabIndex = 0;
            dgvArticulos.CellClick += dgvArticulos_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Papeleria
            // 
            Papeleria.HeaderText = "Papelería";
            Papeleria.Name = "Papeleria";
            Papeleria.ReadOnly = true;
            // 
            // IdMarca
            // 
            IdMarca.HeaderText = "IdMarca";
            IdMarca.Name = "IdMarca";
            IdMarca.Visible = false;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // IdTipoArticulo
            // 
            IdTipoArticulo.HeaderText = "IdTipoArticulo";
            IdTipoArticulo.Name = "IdTipoArticulo";
            IdTipoArticulo.Visible = false;
            // 
            // TipoArticulo
            // 
            TipoArticulo.HeaderText = "Tipo Articulo";
            TipoArticulo.Name = "TipoArticulo";
            // 
            // IdImpuesto
            // 
            IdImpuesto.HeaderText = "IdImpuesto";
            IdImpuesto.Name = "IdImpuesto";
            IdImpuesto.Visible = false;
            // 
            // Impuesto
            // 
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Fecha Creacion";
            FechaCreacion.Name = "FechaCreacion";
            // 
            // FechaActualizacion
            // 
            FechaActualizacion.HeaderText = "Fecha Actualizacion";
            FechaActualizacion.Name = "FechaActualizacion";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            // 
            // ValorUnidad
            // 
            ValorUnidad.HeaderText = "Valor Unidad";
            ValorUnidad.Name = "ValorUnidad";
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
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox5.Controls.Add(lblFecha);
            groupBox5.Controls.Add(lblUser);
            groupBox5.Location = new Point(1288, 9);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(233, 100);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Usuario Actual";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(21, 58);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(16, 28);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 15);
            lblUser.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Controls.Add(lblArchivo);
            groupBox6.Controls.Add(btnAbrirArchivo);
            groupBox6.Location = new Point(1290, 114);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(231, 212);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ingreso por Archivo";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(6, 79);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(77, 15);
            lblArchivo.TabIndex = 1;
            lblArchivo.Text = "Abrir Archivo";
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.Image = (Image)resources.GetObject("btnAbrirArchivo.Image");
            btnAbrirArchivo.Location = new Point(6, 22);
            btnAbrirArchivo.Name = "btnAbrirArchivo";
            btnAbrirArchivo.Size = new Size(219, 42);
            btnAbrirArchivo.TabIndex = 0;
            btnAbrirArchivo.UseVisualStyleBackColor = true;
            btnAbrirArchivo.Click += btnAbrirArchivo_Click;
            // 
            // ofdArticulos
            // 
            ofdArticulos.FileName = "archivoArticulos";
            ofdArticulos.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            // 
            // toolTip1
            // 
            toolTip1.Tag = "Agregar Marcas/Tipos/Impuestos";
            // 
            // Registro_Articulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1533, 723);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Articulos";
            Text = "Registro_Articulos";
            Load += Registro_Articulos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnidadValor).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValorCompra).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbxImpuesto;
        private ComboBox cbxTipoArticulo;
        private ComboBox cbxMarca;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private DateTimePicker dtpCaducidad;
        private Label label7;
        private DateTimePicker dtpCreacion;
        private Label label6;
        private TextBox txtCodigo;
        private Label label5;
        private Label label11;
        private TextBox txtUnidad;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label13;
        private NumericUpDown nudUnidadValor;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox cbxEstado;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private NumericUpDown nudValorVenta;
        private NumericUpDown nudValorCompra;
        private GroupBox groupBox4;
        private DateTimePicker dtpFechaInicial;
        private Label label15;
        private TextBox txtArticulo;
        private Label label14;
        private DataGridView dgvArticulos;
        private Button btnBuscar;
        private DateTimePicker dtpFechaFinal;
        private Label label16;
        private GroupBox groupBox5;
        private Label lblUser;
        private Label lblFecha;
        private DataGridViewTextBoxColumn CambioEstado;
        private CheckBox chckPapeleria;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Papeleria;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdTipoArticulo;
        private DataGridViewTextBoxColumn TipoArticulo;
        private DataGridViewTextBoxColumn IdImpuesto;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn FechaActualizacion;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn ValorUnidad;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn ActivarDesactivar;
        private GroupBox groupBox6;
        private Button btnAbrirArchivo;
        private Label lblArchivo;
        private OpenFileDialog ofdArticulos;
        private Button btn;
        private ToolTip toolTip1;
        private Button btnAgregarDatosConfiguraciones;
    }
}