namespace ProjektKsiegarnia
{
    partial class PracownikZaloguj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracownikZaloguj));
            this.PracZalogujCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PracZalogujCofnij
            // 
            this.PracZalogujCofnij.Location = new System.Drawing.Point(691, 398);
            this.PracZalogujCofnij.Name = "PracZalogujCofnij";
            this.PracZalogujCofnij.Size = new System.Drawing.Size(97, 40);
            this.PracZalogujCofnij.TabIndex = 0;
            this.PracZalogujCofnij.Text = "Cofnij";
            this.PracZalogujCofnij.UseVisualStyleBackColor = true;
            this.PracZalogujCofnij.Click += new System.EventHandler(this.PracZalogujCofnij_Click);
            // 
            // PracownikZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracZalogujCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracownikZaloguj";
            this.Text = "Logowanie dla pracownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PracZalogujCofnij;
    }
}