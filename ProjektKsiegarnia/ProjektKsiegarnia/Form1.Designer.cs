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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(145, 128);
            this.label1.MinimumSize = new System.Drawing.Size(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaloguj";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 431);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

