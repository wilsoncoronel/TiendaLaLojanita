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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoggin));
            btbIngresar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtUsurio = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btbIngresar
            // 
            btbIngresar.BackColor = Color.DarkMagenta;
            btbIngresar.FlatStyle = FlatStyle.Flat;
            btbIngresar.Font = new Font("Roboto", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbIngresar.ForeColor = SystemColors.ControlLightLight;
            btbIngresar.Location = new Point(20, 244);
            btbIngresar.Name = "btbIngresar";
            btbIngresar.Size = new Size(320, 62);
            btbIngresar.TabIndex = 0;
            btbIngresar.Text = "INGRESAR";
            btbIngresar.UseVisualStyleBackColor = false;
            btbIngresar.Click += btbIngresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsurio);
            panel1.Controls.Add(btbIngresar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 332);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 84);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(20, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(320, 29);
            txtPassword.TabIndex = 1;
            // 
            // txtUsurio
            // 
            txtUsurio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsurio.Location = new Point(20, 143);
            txtUsurio.Name = "txtUsurio";
            txtUsurio.PlaceholderText = "Usuario";
            txtUsurio.Size = new Size(320, 29);
            txtUsurio.TabIndex = 0;
            // 
            // FrmLoggin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 353);
            Controls.Add(panel1);
            Name = "FrmLoggin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loggin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btbIngresar;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsurio;
        private PictureBox pictureBox1;
    }
}
