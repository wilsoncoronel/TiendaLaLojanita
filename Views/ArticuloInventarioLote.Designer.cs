namespace TiendaLaLojanita.Views
{
    partial class ArticuloInventarioLote
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
            dgvArticulosLote = new DataGridView();
            IdLote = new DataGridViewTextBoxColumn();
            IdArticulo = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            Medida = new DataGridViewTextBoxColumn();
            Lote = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            FechaCaducidad = new DataGridViewTextBoxColumn();
            Seleccionar = new DataGridViewCheckBoxColumn();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulosLote).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulosLote
            // 
            dgvArticulosLote.AllowUserToAddRows = false;
            dgvArticulosLote.AllowUserToDeleteRows = false;
            dgvArticulosLote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulosLote.Columns.AddRange(new DataGridViewColumn[] { IdLote, IdArticulo, Articulo, Marca, Unidad, Medida, Lote, Codigo, FechaCaducidad, Seleccionar });
            dgvArticulosLote.Location = new Point(5, 6);
            dgvArticulosLote.Name = "dgvArticulosLote";
            dgvArticulosLote.Size = new Size(971, 299);
            dgvArticulosLote.TabIndex = 0;
            // 
            // IdLote
            // 
            IdLote.HeaderText = "IdLote";
            IdLote.Name = "IdLote";
            IdLote.ReadOnly = true;
            IdLote.Visible = false;
            // 
            // IdArticulo
            // 
            IdArticulo.HeaderText = "IdArtículo";
            IdArticulo.Name = "IdArticulo";
            IdArticulo.ReadOnly = true;
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Artículo";
            Articulo.Name = "Articulo";
            Articulo.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            Unidad.ReadOnly = true;
            // 
            // Medida
            // 
            Medida.HeaderText = "Medida";
            Medida.Name = "Medida";
            Medida.ReadOnly = true;
            // 
            // Lote
            // 
            Lote.HeaderText = "Lote";
            Lote.Name = "Lote";
            Lote.ReadOnly = true;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // FechaCaducidad
            // 
            FechaCaducidad.HeaderText = "Caducidad";
            FechaCaducidad.Name = "FechaCaducidad";
            FechaCaducidad.ReadOnly = true;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Name = "Seleccionar";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(701, 313);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 37);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(844, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 37);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ArticuloInventarioLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 358);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvArticulosLote);
            Name = "ArticuloInventarioLote";
            Text = "Seleccionar lote de inventario";
            ((System.ComponentModel.ISupportInitialize)dgvArticulosLote).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArticulosLote;
        private DataGridViewTextBoxColumn IdLote;
        private DataGridViewTextBoxColumn IdArticulo;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn Medida;
        private DataGridViewTextBoxColumn Lote;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn FechaCaducidad;
        private DataGridViewCheckBoxColumn Seleccionar;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}
