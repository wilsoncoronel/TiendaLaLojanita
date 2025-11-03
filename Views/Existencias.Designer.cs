namespace TiendaLaLojanita.Views
{
    partial class Existencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Existencias));
            groupBox1 = new GroupBox();
            dgvExistencias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombreArticulo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtArticuloBusqueda = new TextBox();
            btnBusqueda = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBusqueda);
            groupBox1.Controls.Add(txtArticuloBusqueda);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvExistencias);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Artículos en Inventario";
            // 
            // dgvExistencias
            // 
            dgvExistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistencias.Columns.AddRange(new DataGridViewColumn[] { Id, NombreArticulo, Cantidad });
            dgvExistencias.Location = new Point(5, 79);
            dgvExistencias.Name = "dgvExistencias";
            dgvExistencias.Size = new Size(759, 346);
            dgvExistencias.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NombreArticulo
            // 
            NombreArticulo.HeaderText = "Articulo";
            NombreArticulo.Name = "NombreArticulo";
            NombreArticulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Artículo:";
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(82, 32);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(311, 23);
            txtArticuloBusqueda.TabIndex = 2;
            txtArticuloBusqueda.KeyDown += txtArticuloBusqueda_KeyDown;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Image = (Image)resources.GetObject("btnBusqueda.Image");
            btnBusqueda.Location = new Point(417, 21);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(86, 43);
            btnBusqueda.TabIndex = 3;
            btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // Existencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Existencias";
            Text = "Existencias";
            Load += Existencias_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvExistencias;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreArticulo;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btnBusqueda;
        private TextBox txtArticuloBusqueda;
        private Label label1;
    }
}