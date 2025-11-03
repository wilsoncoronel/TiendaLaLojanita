namespace TiendaLaLojanita.Views
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            loading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loading).BeginInit();
            SuspendLayout();
            // 
            // loading
            // 
            loading.Image = (Image)resources.GetObject("loading.Image");
            loading.Location = new Point(12, 12);
            loading.Name = "loading";
            loading.Size = new Size(516, 471);
            loading.TabIndex = 0;
            loading.TabStop = false;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 493);
            Controls.Add(loading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressBar";
            Opacity = 0.7D;
            Text = "Procesando";
            WindowState = FormWindowState.Maximized;
            Load += ProgressBar_Load;
            ((System.ComponentModel.ISupportInitialize)loading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox loading;
    }
}