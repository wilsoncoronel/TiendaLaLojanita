namespace TiendaLaLojanita.Views
{
    partial class Registro_Ventas
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
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNombreCliente = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txtDocumento = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDocumento);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1177, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(557, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 57);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Venta:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 84);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 84);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(128, 51);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(297, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(446, 20);
            button1.Name = "button1";
            button1.Size = new Size(77, 34);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(128, 20);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PlaceholderText = "170000000000";
            txtDocumento.Size = new Size(297, 23);
            txtDocumento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Documento:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(16, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(854, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Articulos";
            // 
            // button2
            // 
            button2.Location = new Point(391, 28);
            button2.Name = "button2";
            button2.Size = new Size(83, 38);
            button2.TabIndex = 11;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 23);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 40);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 0;
            label6.Text = "Artículo:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(900, 247);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(936, 257);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 247);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Totales";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(143, 181);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "000";
            textBox5.Size = new Size(100, 33);
            textBox5.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 184);
            label10.Name = "label10";
            label10.Size = new Size(56, 25);
            label10.TabIndex = 6;
            label10.Text = "Total:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(143, 129);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "000";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(143, 81);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "000";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 129);
            label9.Name = "label9";
            label9.Size = new Size(90, 25);
            label9.TabIndex = 3;
            label9.Text = "Total Iva :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 84);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 2;
            label8.Text = "Total Iva 15%:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(143, 30);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "000";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 33);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 0;
            label7.Text = "SubTotal:";
            // 
            // Registro_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 590);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Registro_Ventas";
            Text = "Registro_Ventas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtNombreCliente;
        private Button button1;
        private Label label2;
        private TextBox txtDocumento;
        private Label label1;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}