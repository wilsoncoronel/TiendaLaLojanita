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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            dgvCompraDevolucion = new DataGridView();
            button1 = new Button();
            Id = new DataGridViewTextBoxColumn();
            Creacion = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewImageColumn();
            Seleccionar = new DataGridViewCheckBoxColumn();
            btnGuardar = new Button();
            btnBorrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDevolucion).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 240);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Devolución";
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
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(5, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1235, 393);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Devolución";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1219, 355);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dgvCompraDevolucion);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(536, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(704, 180);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Compra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 22);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Buscar:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(135, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 23);
            textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(135, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            comboBox1.Location = new Point(135, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 21);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "IdCompra/Documento";
            textBox3.Size = new Size(548, 23);
            textBox3.TabIndex = 1;
            // 
            // dgvCompraDevolucion
            // 
            dgvCompraDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompraDevolucion.Columns.AddRange(new DataGridViewColumn[] { Id, Creacion, Documento, Proveedor, Estado, Ver, Seleccionar });
            dgvCompraDevolucion.Location = new Point(9, 55);
            dgvCompraDevolucion.Name = "dgvCompraDevolucion";
            dgvCompraDevolucion.Size = new Size(688, 111);
            dgvCompraDevolucion.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.ver;
            button1.Location = new Point(617, 14);
            button1.Name = "button1";
            button1.Size = new Size(80, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
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
            Ver.Name = "Ver";
            Ver.Resizable = DataGridViewTriState.True;
            Ver.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Resizable = DataGridViewTriState.True;
            Seleccionar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._4856668_resize;
            btnGuardar.Location = new Point(966, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 45);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Image = Properties.Resources.cancelar_resize;
            btnBorrar.Location = new Point(1106, 195);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(134, 45);
            btnBorrar.TabIndex = 4;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Devolucion_Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 639);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompraDevolucion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private DataGridView dgvCompraDevolucion;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Creacion;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn Ver;
        private DataGridViewCheckBoxColumn Seleccionar;
        private Button btnGuardar;
        private Button btnBorrar;
    }
}