namespace ProjektKsiegarnia
{
    partial class Start
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
            this.Pracownik = new System.Windows.Forms.Button();
            this.Klient = new System.Windows.Forms.Button();
            this.Zaloguj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pracownik
            // 
            this.Pracownik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pracownik.Location = new System.Drawing.Point(53, 165);
            this.Pracownik.Name = "Pracownik";
            this.Pracownik.Size = new System.Drawing.Size(248, 76);
            this.Pracownik.TabIndex = 0;
            this.Pracownik.Text = "Pracowik";
            this.Pracownik.UseVisualStyleBackColor = true;
            // 
            // Klient
            // 
            this.Klient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Klient.Location = new System.Drawing.Point(53, 247);
            this.Klient.Name = "Klient";
            this.Klient.Size = new System.Drawing.Size(248, 77);
            this.Klient.TabIndex = 1;
            this.Klient.Text = "Klient";
            this.Klient.UseVisualStyleBackColor = true;
            // 
            // Zaloguj
            // 
            this.Zaloguj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zaloguj.Location = new System.Drawing.Point(152, 137);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.ReadOnly = true;
            this.Zaloguj.Size = new System.Drawing.Size(52, 22);
            this.Zaloguj.TabIndex = 2;
            this.Zaloguj.Text = "Zaloguj";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 431);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.Klient);
            this.Controls.Add(this.Pracownik);
            this.Enabled = false;
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pracownik;
        private System.Windows.Forms.Button Klient;
        private System.Windows.Forms.TextBox Zaloguj;
    }
}

