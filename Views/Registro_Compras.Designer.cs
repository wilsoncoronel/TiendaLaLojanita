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
            btbBuscarProveedor = new Button();
            txtTelefono = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtRazonSocial = new TextBox();
            label2 = new Label();
            txtIdentificacion = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblFechaIngreso = new Label();
            lblUsuario = new Label();
            groupBox3 = new GroupBox();
            label12 = new Label();
            txtPrecioVenta = new TextBox();
            label11 = new Label();
            btnBuscar = new Button();
            txtArticulo = new TextBox();
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
            ValorTotal = new DataGridViewTextBoxColumn();
            ImpuestoValor = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            groupBox4 = new GroupBox();
            txtDocumento = new TextBox();
            label9 = new Label();
            dtpCreacion = new DateTimePicker();
            label8 = new Label();
            dtpCompra = new DateTimePicker();
            label7 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            lblSubIva15 = new Label();
            lblSubSinIva = new Label();
            lblIva15 = new Label();
            lblTotal = new Label();
            groupBox5 = new GroupBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox6 = new GroupBox();
            btnBuscarCompra = new Button();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dgvCompras = new DataGridView();
            IdComp = new DataGridViewTextBoxColumn();
            FechaCompra = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ActivarDesactivar = new DataGridViewImageColumn();
            Editar = new DataGridViewImageColumn();
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
            groupBox1.Controls.Add(btbBuscarProveedor);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIdentificacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Proveedor";
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
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(245, 24);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(246, 23);
            txtIdentificacion.TabIndex = 1;
            txtIdentificacion.Text = " ";
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
            groupBox2.Size = new Size(372, 201);
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
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtPrecioVenta);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Controls.Add(txtArticulo);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(368, 82);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 7;
            label12.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(496, 80);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(162, 23);
            txtPrecioVenta.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 80);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 5;
            label11.Text = "Artículo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(459, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtArticulo
            // 
            txtArticulo.Location = new Point(102, 80);
            txtArticulo.Name = "txtArticulo";
            txtArticulo.Size = new Size(233, 23);
            txtArticulo.TabIndex = 3;
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(102, 40);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.PlaceholderText = "Artículo/Código";
            txtArticuloBusqueda.Size = new Size(325, 23);
            txtArticuloBusqueda.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 36);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 1;
            label10.Text = "Buscar:";
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Columns.AddRange(new DataGridViewColumn[] { Id, IdCompra, IdArticulo, Articulo, Descripcion, Cantidad, ValorCompra, ValorTotal, ImpuestoValor, Eliminar });
            dgvDetalleCompra.Location = new Point(9, 118);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.Size = new Size(882, 565);
            dgvDetalleCompra.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
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
            // 
            // ValorTotal
            // 
            ValorTotal.HeaderText = "ValorTotal";
            ValorTotal.Name = "ValorTotal";
            // 
            // ImpuestoValor
            // 
            ImpuestoValor.HeaderText = "ImpuestoValor";
            ImpuestoValor.Name = "ImpuestoValor";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 60);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 8;
            label13.Text = "Sub. Iva 15:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 96);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 9;
            label14.Text = "Sub. sin Iva:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 130);
            label15.Name = "label15";
            label15.Size = new Size(50, 15);
            label15.TabIndex = 10;
            label15.Text = "Iva 15%:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 165);
            label16.Name = "label16";
            label16.Size = new Size(35, 15);
            label16.TabIndex = 11;
            label16.Text = "Total:";
            // 
            // lblSubIva15
            // 
            lblSubIva15.AutoSize = true;
            lblSubIva15.Location = new Point(118, 60);
            lblSubIva15.Name = "lblSubIva15";
            lblSubIva15.Size = new Size(44, 15);
            lblSubIva15.TabIndex = 12;
            lblSubIva15.Text = "label17";
            // 
            // lblSubSinIva
            // 
            lblSubSinIva.AutoSize = true;
            lblSubSinIva.Location = new Point(118, 97);
            lblSubSinIva.Name = "lblSubSinIva";
            lblSubSinIva.Size = new Size(44, 15);
            lblSubSinIva.TabIndex = 13;
            lblSubSinIva.Text = "label18";
            // 
            // lblIva15
            // 
            lblIva15.AutoSize = true;
            lblIva15.Location = new Point(118, 131);
            lblIva15.Name = "lblIva15";
            lblIva15.Size = new Size(44, 15);
            lblIva15.TabIndex = 14;
            lblIva15.Text = "label19";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(118, 165);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "label20";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(lblTotal);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(lblSubIva15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(lblIva15);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(lblSubSinIva);
            groupBox5.Location = new Point(923, 211);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 237);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Totales";
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
            groupBox6.Controls.Add(dateTimePicker2);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(dateTimePicker1);
            groupBox6.Controls.Add(dgvCompras);
            groupBox6.Location = new Point(1041, 211);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(850, 689);
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
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(367, 36);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(158, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 40);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(87, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // dgvCompras
            // 
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdComp, FechaCompra, Proveedor, Total, Estado, ActivarDesactivar, Editar });
            dgvCompras.Location = new Point(8, 80);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.Size = new Size(836, 603);
            dgvCompras.TabIndex = 0;
            // 
            // IdComp
            // 
            IdComp.HeaderText = "Id";
            IdComp.Name = "IdComp";
            // 
            // FechaCompra
            // 
            FechaCompra.HeaderText = "FechaCompra";
            FechaCompra.Name = "FechaCompra";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Proveedor";
            Proveedor.Name = "Proveedor";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // ActivarDesactivar
            // 
            ActivarDesactivar.HeaderText = "Act/Desac";
            ActivarDesactivar.Name = "ActivarDesactivar";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
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
        private TextBox txtIdentificacion;
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
        private TextBox txtArticulo;
        private Label label12;
        private TextBox txtPrecioVenta;
        private Label label11;
        private Label lblTotal;
        private Label lblIva15;
        private Label lblSubSinIva;
        private Label lblSubIva15;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private GroupBox groupBox5;
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox groupBox6;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgvCompras;
        private DateTimePicker dateTimePicker2;
        private Button btnBuscarCompra;
        private DataGridViewTextBoxColumn IdComp;
        private DataGridViewTextBoxColumn FechaCompra;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCompra;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn ImpuestoValor;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewImageColumn ActivarDesactivar;
        private DataGridViewImageColumn Editar;
        private Button btbBuscarProveedor;
    }
}