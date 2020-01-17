namespace ProjektKsiegarnia
{
    partial class KierownikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KierownikForm));
            this.KierowFormCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KierowFormCofnij
            // 
            this.KierowFormCofnij.Location = new System.Drawing.Point(691, 398);
            this.KierowFormCofnij.Name = "KierowFormCofnij";
            this.KierowFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.KierowFormCofnij.TabIndex = 2;
            this.KierowFormCofnij.Text = "Wyloguj";
            this.KierowFormCofnij.UseVisualStyleBackColor = true;
            this.KierowFormCofnij.Click += new System.EventHandler(this.KierowFormCofnij_Click);
            // 
            // KierownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KierowFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KierownikForm";
            this.Text = "Panel zarządzania";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KierowFormCofnij;
    }
}