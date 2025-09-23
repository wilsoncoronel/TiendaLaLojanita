namespace TiendaLaLojanita
{
    partial class FrmLoggin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btbIngresar = new Button();
            panel1 = new Panel();
            btnCancelar = new Button();
            txtPassword = new TextBox();
            txtUsurio = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btbIngresar
            // 
            btbIngresar.Location = new Point(339, 3);
            btbIngresar.Name = "btbIngresar";
            btbIngresar.Size = new Size(143, 62);
            btbIngresar.TabIndex = 0;
            btbIngresar.Text = "Ingresar";
            btbIngresar.UseVisualStyleBackColor = true;
            btbIngresar.Click += btbIngresar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsurio);
            panel1.Controls.Add(btbIngresar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 133);
            panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(339, 68);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 62);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(43, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(243, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtUsurio
            // 
            txtUsurio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsurio.Location = new Point(43, 16);
            txtUsurio.Name = "txtUsurio";
            txtUsurio.PlaceholderText = "Usuario";
            txtUsurio.Size = new Size(243, 29);
            txtUsurio.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 156);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Loggin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btbIngresar;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsurio;
        private Button btnCancelar;
    }
}
