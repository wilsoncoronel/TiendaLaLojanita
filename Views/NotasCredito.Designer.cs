namespace TiendaLaLojanita.Views
{
    partial class NotasCredito
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
            ValorOriginal = new DataGridViewTextBoxColumn();
            ValorDisponible = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Seleccionar = new DataGridViewCheckBoxColumn();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, ValorOriginal, ValorDisponible, FechaCreacion, Estado, Seleccionar });
            dataGridView1.Location = new Point(11, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(648, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // ValorOriginal
            // 
            ValorOriginal.HeaderText = "ValorOriginal";
            ValorOriginal.Name = "ValorOriginal";
            ValorOriginal.ReadOnly = true;
            // 
            // ValorDisponible
            // 
            ValorDisponible.HeaderText = "ValorDisponible";
            ValorDisponible.Name = "ValorDisponible";
            ValorDisponible.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Creacion";
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Seleccionar";
            Seleccionar.Name = "Seleccionar";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(411, 280);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 28);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(539, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 28);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NotasCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 320);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dataGridView1);
            Name = "NotasCredito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotasCredito";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ValorOriginal;
        private DataGridViewTextBoxColumn ValorDisponible;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewCheckBoxColumn Seleccionar;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}