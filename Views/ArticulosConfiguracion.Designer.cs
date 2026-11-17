namespace TiendaLaLojanita.Views
{
    partial class ArticulosConfiguracion
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
            dgvArticulos = new DataGridView();
            Nro = new DataGridViewTextBoxColumn();
            Articulo = new DataGridViewTextBoxColumn();
            IdMarca = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewComboBoxColumn();
            IdTipoArticulo = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewComboBoxColumn();
            IdPorcentajeGanancia = new DataGridViewTextBoxColumn();
            PorcentajeGanancia = new DataGridViewComboBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdUnidad = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewComboBoxColumn();
            UnidadValor = new DataGridViewTextBoxColumn();
            ValorCompra = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            Quitar = new DataGridViewButtonColumn();
            label1 = new Label();
            txtArticuloBusqueda = new TextBox();
            btnBuscarArticulo = new Button();
            label2 = new Label();
            lblTotArticulos = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Columns.AddRange(new DataGridViewColumn[] { Nro, Articulo, IdMarca, Marca, IdTipoArticulo, Tipo, IdPorcentajeGanancia, PorcentajeGanancia, Descripcion, IdUnidad, Unidad, UnidadValor, ValorCompra, ValorVenta, Quitar });
            dgvArticulos.Location = new Point(8, 41);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(1232, 408);
            dgvArticulos.TabIndex = 0;
            // 
            // Nro
            // 
            Nro.HeaderText = "Nro.";
            Nro.Name = "Nro";
            // 
            // Articulo
            // 
            Articulo.HeaderText = "Articulo";
            Articulo.Name = "Articulo";
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
            Marca.Visible = false;
            // 
            // IdTipoArticulo
            // 
            IdTipoArticulo.HeaderText = "IdTipoArticulo";
            IdTipoArticulo.Name = "IdTipoArticulo";
            IdTipoArticulo.Visible = false;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            // 
            // IdPorcentajeGanancia
            // 
            IdPorcentajeGanancia.HeaderText = "IdPorcentajeGanancia";
            IdPorcentajeGanancia.Name = "IdPorcentajeGanancia";
            IdPorcentajeGanancia.Visible = false;
            // 
            // PorcentajeGanancia
            // 
            PorcentajeGanancia.HeaderText = "PorcentajeGanancia";
            PorcentajeGanancia.Name = "PorcentajeGanancia";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // IdUnidad
            // 
            IdUnidad.HeaderText = "IdUnidad";
            IdUnidad.Name = "IdUnidad";
            IdUnidad.Visible = false;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            // 
            // UnidadValor
            // 
            UnidadValor.HeaderText = "UnidadValor";
            UnidadValor.Name = "UnidadValor";
            UnidadValor.Resizable = DataGridViewTriState.True;
            UnidadValor.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ValorCompra
            // 
            ValorCompra.HeaderText = "ValorCompra";
            ValorCompra.Name = "ValorCompra";
            // 
            // ValorVenta
            // 
            ValorVenta.HeaderText = "ValorVenta";
            ValorVenta.Name = "ValorVenta";
            // 
            // Quitar
            // 
            Quitar.HeaderText = "Quitar";
            Quitar.Name = "Quitar";
            Quitar.Text = "Quitar";
            Quitar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar:";
            // 
            // txtArticuloBusqueda
            // 
            txtArticuloBusqueda.Location = new Point(67, 10);
            txtArticuloBusqueda.Name = "txtArticuloBusqueda";
            txtArticuloBusqueda.Size = new Size(515, 23);
            txtArticuloBusqueda.TabIndex = 2;
            // 
            // btnBuscarArticulo
            // 
            btnBuscarArticulo.Image = Properties.Resources.lupa_min;
            btnBuscarArticulo.Location = new Point(588, 4);
            btnBuscarArticulo.Name = "btnBuscarArticulo";
            btnBuscarArticulo.Size = new Size(89, 32);
            btnBuscarArticulo.TabIndex = 3;
            btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1069, 9);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 4;
            label2.Text = "Total Artículos:";
            // 
            // lblTotArticulos
            // 
            lblTotArticulos.AutoSize = true;
            lblTotArticulos.Font = new Font("Segoe UI", 12F);
            lblTotArticulos.Location = new Point(1185, 9);
            lblTotArticulos.Name = "lblTotArticulos";
            lblTotArticulos.Size = new Size(19, 21);
            lblTotArticulos.TabIndex = 5;
            lblTotArticulos.Text = "0";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(881, 455);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(162, 38);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1074, 455);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 38);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ArticulosConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 500);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTotArticulos);
            Controls.Add(label2);
            Controls.Add(btnBuscarArticulo);
            Controls.Add(txtArticuloBusqueda);
            Controls.Add(label1);
            Controls.Add(dgvArticulos);
            Name = "ArticulosConfiguracion";
            Text = "ArticulosConfiguracion";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticulos;
        private Label label1;
        private TextBox txtArticuloBusqueda;
        private Button btnBuscarArticulo;
        private Label label2;
        private Label lblTotArticulos;
        private DataGridViewTextBoxColumn Nro;
        private DataGridViewTextBoxColumn Articulo;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewComboBoxColumn Marca;
        private DataGridViewTextBoxColumn IdTipoArticulo;
        private DataGridViewComboBoxColumn Tipo;
        private DataGridViewTextBoxColumn IdPorcentajeGanancia;
        private DataGridViewComboBoxColumn PorcentajeGanancia;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdUnidad;
        private DataGridViewComboBoxColumn Unidad;
        private DataGridViewTextBoxColumn UnidadValor;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewButtonColumn Quitar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}