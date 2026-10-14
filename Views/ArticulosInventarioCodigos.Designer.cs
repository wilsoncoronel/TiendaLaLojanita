namespace TiendaLaLojanita.Views
{
    partial class ArticulosInventarioCodigos
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Lote = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Imprimir = new DataGridViewImageColumn();
            btnBuscar = new Button();
            label1 = new Label();
            txtArticuloBusqueda = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Articulo, Lote, Codigo, Imprimir });
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(680, 261);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Imprimir
            // 
            Imprimir.HeaderText = "Imprimir";
            Imprimir.Image = Properties.Resources.imprimir_peque;
            Imprimir.Name = "Imprimir";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.lupa_min;
            btnBuscar.Location = new Point(605, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(87, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Artículo:";
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(70, 16);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(529, 23);
            txtArticuloBusqueda.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(560, 316);
            button2.Name = "button2";
            button2.Size = new Size(132, 37);
            button2.TabIndex = 5;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ArticulosInventarioCodigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 364);
            Controls.Add(button2);
            Controls.Add(txtArticuloBusqueda);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "ArticulosInventarioCodigos";
            Text = "ArticulosInventarioCodigos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtArticuloBusqueda;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewImageColumn Imprimir;
    }
}