namespace TiendaLaLojanita.Views
{
    partial class Devolucion_Compra
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
            groupBox1 = new GroupBox();
            cbxTipoDevolucion = new ComboBox();
            label7 = new Label();
            cbxEstado = new ComboBox();
            dtpCreacion = new DateTimePicker();
            txtMotivo = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            txtTotales = new TextBox();
            dgvTotales = new DataGridView();
            Impuestos = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            dgvDetalleDevolucion = new DataGridView();
            IdDetalle = new DataGridViewTextBoxColumn();
            Lote = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Quitar = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            dgvMovimientosCredito = new DataGridView();
            IdMov = new DataGridViewTextBoxColumn();
            TipoMov = new DataGridViewTextBoxColumn();
            ValorMov = new DataGridViewTextBoxColumn();
            FechaCreacionMov = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewTextBoxColumn();
            EstadoMov = new DataGridViewTextBoxColumn();
            dgvCreditosDevolucion = new DataGridView();
            IdCredito = new DataGridViewTextBoxColumn();
            ValorOriginal = new DataGridViewTextBoxColumn();
            ValorDisponible = new DataGridViewTextBoxColumn();
            CreacionCred = new DataGridViewTextBoxColumn();
            EstadoCred = new DataGridViewTextBoxColumn();
            btnBuscarDevoluciones = new Button();
            dgvDevoluciones = new DataGridView();
            IdDev = new DataGridViewTextBoxColumn();
            IdCom = new DataGridViewTextBoxColumn();
            ProveedorName = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            EstadoDev = new DataGridViewTextBoxColumn();
            Cargar = new DataGridViewImageColumn();
            Reversar = new DataGridViewImageColumn();
            dtpFechaFinal = new DateTimePicker();
            dtpFechaInicial = new DateTimePicker();
            label6 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            btnBuscarCompra = new Button();
            txtBuscarCompra = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            btnBuscarCompraArticulo = new Button();
            txtCodigoArticulo = new TextBox();
            label12 = new Label();
            txtLoteArticulo = new TextBox();
            label11 = new Label();
            txtIdArticulo = new TextBox();
            label10 = new Label();
            dgvCompraDevolucion = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewImageColumn();
            Seleccionar = new DataGridViewImageColumn();
            btnGuardar = new Button();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleDevolucion).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientosCredito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCreditosDevolucion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            groupBox3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDevolucion).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxTipoDevolucion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbxEstado);
            groupBox1.Controls.Add(dtpCreacion);
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Devolución";
            // 
            // cbxTipoDevolucion
            // 
            cbxTipoDevolucion.FormattingEnabled = true;
            cbxTipoDevolucion.Location = new Point(135, 141);
            cbxTipoDevolucion.Name = "cbxTipoDevolucion";
            cbxTipoDevolucion.Size = new Size(133, 23);
            cbxTipoDevolucion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 144);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 10;
            label7.Text = "Tipo Devolución:";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbxEstado.Location = new Point(135, 107);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(133, 23);
            cbxEstado.TabIndex = 7;
            // 
            // dtpCreacion
            // 
            dtpCreacion.Enabled = false;
            dtpCreacion.Location = new Point(135, 77);
            dtpCreacion.Name = "dtpCreacion";
            dtpCreacion.Size = new Size(271, 23);
            dtpCreacion.TabIndex = 6;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(135, 48);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(384, 23);
            txtMotivo.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(135, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 81);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Creación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 50);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Motivo Devolución:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Location = new Point(5, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1332, 393);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Devolución";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1321, 365);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(txtTotales);
            tabPage1.Controls.Add(dgvTotales);
            tabPage1.Controls.Add(dgvDetalleDevolucion);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1313, 337);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Detalle devolución";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(798, 226);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 4;
            label8.Text = "TOTAL:";
            // 
            // txtTotales
            // 
            txtTotales.Enabled = false;
            txtTotales.Location = new Point(846, 223);
            txtTotales.Name = "txtTotales";
            txtTotales.PlaceholderText = "0.00";
            txtTotales.Size = new Size(152, 23);
            txtTotales.TabIndex = 3;
            // 
            // dgvTotales
            // 
            dgvTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotales.Columns.AddRange(new DataGridViewColumn[] { Impuestos, Valor });
            dgvTotales.Location = new Point(676, 17);
            dgvTotales.Name = "dgvTotales";
            dgvTotales.Size = new Size(322, 188);
            dgvTotales.TabIndex = 2;
            // 
            // Impuestos
            // 
            Impuestos.HeaderText = "Impuestos";
            Impuestos.Name = "Impuestos";
            Impuestos.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // dgvDetalleDevolucion
            // 
            dgvDetalleDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleDevolucion.Columns.AddRange(new DataGridViewColumn[] { IdDetalle, Lote, Articulo, ValorCompra, Cantidad, Quitar });
            dgvDetalleDevolucion.Location = new Point(8, 17);
            dgvDetalleDevolucion.Name = "dgvDetalleDevolucion";
            dgvDetalleDevolucion.Size = new Size(649, 314);
            dgvDetalleDevolucion.TabIndex = 1;
            dgvDetalleDevolucion.CellClick += dgvDetalleDevolucion_CellClick_1;
            // 
            // IdDetalle
            // 
            IdDetalle.HeaderText = "Id";
            IdDetalle.Name = "IdDetalle";
            IdDetalle.ReadOnly = true;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.ReadOnly = true;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // ValorCompra
            // 
            ValorCompra.HeaderText = "ValorCompra";
            ValorCompra.Name = "ValorCompra";
            ValorCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Quitar
            // 
            Quitar.HeaderText = "Quitar";
            Quitar.Image = Properties.Resources._3687412_edit;
            Quitar.Name = "Quitar";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvMovimientosCredito);
            tabPage2.Controls.Add(dgvCreditosDevolucion);
            tabPage2.Controls.Add(btnBuscarDevoluciones);
            tabPage2.Controls.Add(dgvDevoluciones);
            tabPage2.Controls.Add(dtpFechaFinal);
            tabPage2.Controls.Add(dtpFechaInicial);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1313, 337);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Devoluciones";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMovimientosCredito
            // 
            dgvMovimientosCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientosCredito.Columns.AddRange(new DataGridViewColumn[] { IdMov, TipoMov, ValorMov, FechaCreacionMov, Observacion, EstadoMov });
            dgvMovimientosCredito.Location = new Point(761, 161);
            dgvMovimientosCredito.Name = "dgvMovimientosCredito";
            dgvMovimientosCredito.Size = new Size(546, 153);
            dgvMovimientosCredito.TabIndex = 7;
            // 
            // IdMov
            // 
            IdMov.HeaderText = "Id";
            IdMov.Name = "IdMov";
            IdMov.ReadOnly = true;
            // 
            // TipoMov
            // 
            TipoMov.HeaderText = "Movmiento";
            TipoMov.Name = "TipoMov";
            TipoMov.ReadOnly = true;
            // 
            // ValorMov
            // 
            ValorMov.HeaderText = "Valor";
            ValorMov.Name = "ValorMov";
            ValorMov.ReadOnly = true;
            // 
            // FechaCreacionMov
            // 
            FechaCreacionMov.HeaderText = "Fecha Creación";
            FechaCreacionMov.Name = "FechaCreacionMov";
            FechaCreacionMov.ReadOnly = true;
            // 
            // Observacion
            // 
            Observacion.HeaderText = "Observacion";
            Observacion.Name = "Observacion";
            Observacion.ReadOnly = true;
            // 
            // EstadoMov
            // 
            EstadoMov.HeaderText = "Estado";
            EstadoMov.Name = "EstadoMov";
            EstadoMov.ReadOnly = true;
            // 
            // dgvCreditosDevolucion
            // 
            dgvCreditosDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreditosDevolucion.Columns.AddRange(new DataGridViewColumn[] { IdCredito, ValorOriginal, ValorDisponible, CreacionCred, EstadoCred });
            dgvCreditosDevolucion.Location = new Point(761, 45);
            dgvCreditosDevolucion.Name = "dgvCreditosDevolucion";
            dgvCreditosDevolucion.Size = new Size(546, 109);
            dgvCreditosDevolucion.TabIndex = 6;
            // 
            // IdCredito
            // 
            IdCredito.HeaderText = "Id";
            IdCredito.Name = "IdCredito";
            IdCredito.ReadOnly = true;
            // 
            // ValorOriginal
            // 
            ValorOriginal.HeaderText = "ValorOriginal";
            ValorOriginal.Name = "ValorOriginal";
            ValorOriginal.ReadOnly = true;
            // 
            // ValorDisponible
            // 
            ValorDisponible.HeaderText = "Valor Disponible";
            ValorDisponible.Name = "ValorDisponible";
            ValorDisponible.ReadOnly = true;
            // 
            // CreacionCred
            // 
            CreacionCred.HeaderText = "Creación";
            CreacionCred.Name = "CreacionCred";
            CreacionCred.ReadOnly = true;
            // 
            // EstadoCred
            // 
            EstadoCred.HeaderText = "Estado";
            EstadoCred.Name = "EstadoCred";
            EstadoCred.ReadOnly = true;
            // 
            // btnBuscarDevoluciones
            // 
            btnBuscarDevoluciones.Image = Properties.Resources.lupa_min;
            btnBuscarDevoluciones.Location = new Point(571, 6);
            btnBuscarDevoluciones.Name = "btnBuscarDevoluciones";
            btnBuscarDevoluciones.Size = new Size(82, 34);
            btnBuscarDevoluciones.TabIndex = 5;
            btnBuscarDevoluciones.UseVisualStyleBackColor = true;
            btnBuscarDevoluciones.Click += btnBuscarDevoluciones_Click;
            // 
            // dgvDevoluciones
            // 
            dgvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevoluciones.Columns.AddRange(new DataGridViewColumn[] { IdDev, IdCom, ProveedorName, FechaCreacion, EstadoDev, Cargar, Reversar });
            dgvDevoluciones.Location = new Point(11, 45);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.Size = new Size(744, 269);
            dgvDevoluciones.TabIndex = 4;
            dgvDevoluciones.CellClick += dgvDevolucion_CellClick;
            // 
            // IdDev
            // 
            IdDev.HeaderText = "Id";
            IdDev.Name = "IdDev";
            IdDev.ReadOnly = true;
            // 
            // IdCom
            // 
            IdCom.HeaderText = "Compra Nro.";
            IdCom.Name = "IdCom";
            IdCom.ReadOnly = true;
            // 
            // ProveedorName
            // 
            ProveedorName.HeaderText = "Proveedor";
            ProveedorName.Name = "ProveedorName";
            ProveedorName.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Creacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // EstadoDev
            // 
            EstadoDev.HeaderText = "Estado";
            EstadoDev.Name = "EstadoDev";
            // 
            // Cargar
            // 
            Cargar.HeaderText = "Cargar";
            Cargar.Image = Properties.Resources.ver;
            Cargar.Name = "Cargar";
            // 
            // Reversar
            // 
            Reversar.HeaderText = "Reversar";
            Reversar.Image = Properties.Resources.resize;
            Reversar.Name = "Reversar";
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Format = DateTimePickerFormat.Short;
            dtpFechaFinal.Location = new Point(343, 14);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(200, 23);
            dtpFechaFinal.TabIndex = 3;
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Format = DateTimePickerFormat.Short;
            dtpFechaInicial.Location = new Point(65, 14);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(200, 23);
            dtpFechaInicial.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 20);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 1;
            label6.Text = "Fin:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 20);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 0;
            label9.Text = "Inicio:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl2);
            groupBox3.Controls.Add(dgvCompraDevolucion);
            groupBox3.Location = new Point(536, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(801, 188);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Compra:";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(12, 18);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(772, 68);
            tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnBuscarCompra);
            tabPage3.Controls.Add(txtBuscarCompra);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(764, 40);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Buscar Compra";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCompra
            // 
            btnBuscarCompra.Image = Properties.Resources.ver;
            btnBuscarCompra.Location = new Point(465, 2);
            btnBuscarCompra.Name = "btnBuscarCompra";
            btnBuscarCompra.Size = new Size(80, 35);
            btnBuscarCompra.TabIndex = 3;
            btnBuscarCompra.UseVisualStyleBackColor = true;
            btnBuscarCompra.Click += btnBuscarCompra_Click;
            // 
            // txtBuscarCompra
            // 
            txtBuscarCompra.Location = new Point(62, 8);
            txtBuscarCompra.Name = "txtBuscarCompra";
            txtBuscarCompra.PlaceholderText = "IdCompra/Documento";
            txtBuscarCompra.Size = new Size(397, 23);
            txtBuscarCompra.TabIndex = 1;
            txtBuscarCompra.KeyDown += txtBuscarCompra_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Buscar:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnBuscarCompraArticulo);
            tabPage4.Controls.Add(txtCodigoArticulo);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(txtLoteArticulo);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(txtIdArticulo);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(764, 40);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Buscar Artículo";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCompraArticulo
            // 
            btnBuscarCompraArticulo.Image = Properties.Resources.ver;
            btnBuscarCompraArticulo.Location = new Point(598, 3);
            btnBuscarCompraArticulo.Name = "btnBuscarCompraArticulo";
            btnBuscarCompraArticulo.Size = new Size(80, 35);
            btnBuscarCompraArticulo.TabIndex = 6;
            btnBuscarCompraArticulo.UseVisualStyleBackColor = true;
            btnBuscarCompraArticulo.Click += btnBuscarCompraArticulo_Click;
            // 
            // txtCodigoArticulo
            // 
            txtCodigoArticulo.Location = new Point(428, 8);
            txtCodigoArticulo.Name = "txtCodigoArticulo";
            txtCodigoArticulo.PlaceholderText = "C0000000";
            txtCodigoArticulo.Size = new Size(143, 23);
            txtCodigoArticulo.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(373, 11);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 4;
            label12.Text = "Codigo:";
            // 
            // txtLoteArticulo
            // 
            txtLoteArticulo.Location = new Point(214, 8);
            txtLoteArticulo.Name = "txtLoteArticulo";
            txtLoteArticulo.PlaceholderText = "L0000000";
            txtLoteArticulo.Size = new Size(153, 23);
            txtLoteArticulo.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(175, 10);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 2;
            label11.Text = "Lote:";
            // 
            // txtIdArticulo
            // 
            txtIdArticulo.Location = new Point(64, 8);
            txtIdArticulo.Name = "txtIdArticulo";
            txtIdArticulo.PlaceholderText = "Id";
            txtIdArticulo.Size = new Size(100, 23);
            txtIdArticulo.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 11);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 0;
            label10.Text = "Artículo:";
            // 
            // dgvCompraDevolucion
            // 
            dgvCompraDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDevolucion.Columns.AddRange(new DataGridViewColumn[] { Id, Creacion, Documento, Proveedor, Estado, Ver, Seleccionar });
            dgvCompraDevolucion.Location = new Point(9, 92);
            dgvCompraDevolucion.Name = "dgvCompraDevolucion";
            dgvCompraDevolucion.Size = new Size(775, 90);
            dgvCompraDevolucion.TabIndex = 2;
            dgvCompraDevolucion.CellClick += dgvCompraDevolucion_CellClick;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Creacion
            // 
            Creacion.Frozen = true;
            Creacion.HeaderText = "Creacion";
            Creacion.Name = "Creacion";
            Creacion.ReadOnly = true;
            // 
            // Documento
            // 
            Documento.Frozen = true;
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.Frozen = true;
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Ver
            // 
            Ver.HeaderText = "Ver";
            Ver.Image = Properties.Resources.ver;
            Ver.Name = "Ver";
            Ver.Resizable = DataGridViewTriState.True;
            Ver.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Image = Properties.Resources.full_selection_icon_;
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Resizable = DataGridViewTriState.True;
            Seleccionar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._4856668_resize;
            btnGuardar.Location = new Point(1053, 198);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Image = Properties.Resources.cancelar_resize;
            btnBorrar.Location = new Point(1203, 199);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(134, 45);
            btnBorrar.TabIndex = 4;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Devolucion_Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 639);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Devolucion_Compra";
            Text = "Devolucion_Compra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleDevolucion).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientosCredito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCreditosDevolucion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            groupBox3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDevolucion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDetalleDevolucion;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label5;
        private ComboBox cbxEstado;
        private DateTimePicker dtpCreacion;
        private TextBox txtMotivo;
        private TextBox txtId;
        private TextBox txtBuscarCompra;
        private DataGridView dgvCompraDevolucion;
        private Button btnBuscarCompra;
        private Button btnGuardar;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn IdDetalle;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewImageColumn Quitar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn Ver;
        private DataGridViewImageColumn Seleccionar;
        private ComboBox cbxTransaccionesInventario;
        private Label label6;
        private ComboBox cbxTipoDevolucion;
        private Label label7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private TextBox txtTotales;
        private DataGridView dgvTotales;
        private DataGridViewTextBoxColumn Impuestos;
        private DataGridViewTextBoxColumn Valor;
        private Label label9;
        private Button btnBuscarDevoluciones;
        private DataGridView dgvDevoluciones;
        private DateTimePicker dtpFechaFinal;
        private DateTimePicker dtpFechaInicial;
        private DataGridView dgvCreditosDevolucion;
        private DataGridViewTextBoxColumn IdCredito;
        private DataGridViewTextBoxColumn ValorOriginal;
        private DataGridViewTextBoxColumn ValorDisponible;
        private DataGridViewTextBoxColumn CreacionCred;
        private DataGridViewTextBoxColumn EstadoCred;
        private DataGridViewTextBoxColumn IdDev;
        private DataGridViewTextBoxColumn IdCom;
        private DataGridViewTextBoxColumn ProveedorName;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn EstadoDev;
        private DataGridViewImageColumn Cargar;
        private DataGridViewImageColumn Reversar;
        private DataGridView dgvMovimientosCredito;
        private DataGridViewTextBoxColumn IdMov;
        private DataGridViewTextBoxColumn TipoMov;
        private DataGridViewTextBoxColumn ValorMov;
        private DataGridViewTextBoxColumn FechaCreacionMov;
        private DataGridViewTextBoxColumn Observacion;
        private DataGridViewTextBoxColumn EstadoMov;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnBuscarCompraArticulo;
        private TextBox txtCodigoArticulo;
        private Label label12;
        private TextBox txtLoteArticulo;
        private Label label11;
        private TextBox txtIdArticulo;
        private Label label10;
    }
}