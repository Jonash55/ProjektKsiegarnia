namespace ProjektKsiegarnia
{
    partial class KierownikZaloguj
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
            this.KierowZalogujCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KierowZalogujCofnij
            // 
            this.KierowZalogujCofnij.Location = new System.Drawing.Point(691, 398);
            this.KierowZalogujCofnij.Name = "KierowZalogujCofnij";
            this.KierowZalogujCofnij.Size = new System.Drawing.Size(97, 40);
            this.KierowZalogujCofnij.TabIndex = 2;
            this.KierowZalogujCofnij.Text = "Cofnij";
            this.KierowZalogujCofnij.UseVisualStyleBackColor = true;
            this.KierowZalogujCofnij.Click += new System.EventHandler(this.KierowZalogujCofnij_Click);
            // 
            // KierownikZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KierowZalogujCofnij);
            this.Name = "KierownikZaloguj";
            this.Text = "KierownikZaloguj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KierowZalogujCofnij;
    }
}