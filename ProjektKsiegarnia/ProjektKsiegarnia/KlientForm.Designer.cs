namespace ProjektKsiegarnia
{
    partial class KlientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientForm));
            this.KlientFormCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KlientFormCofnij
            // 
            this.KlientFormCofnij.Location = new System.Drawing.Point(691, 398);
            this.KlientFormCofnij.Name = "KlientFormCofnij";
            this.KlientFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.KlientFormCofnij.TabIndex = 1;
            this.KlientFormCofnij.Text = "Cofnij";
            this.KlientFormCofnij.UseVisualStyleBackColor = true;
            this.KlientFormCofnij.Click += new System.EventHandler(this.KlientFormCofnij_Click);
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KlientFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientForm";
            this.Text = "Panel dla klienta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KlientFormCofnij;
    }
}