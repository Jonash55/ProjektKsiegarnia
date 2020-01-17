namespace ProjektKsiegarnia
{
    partial class PracownikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracownikForm));
            this.PracFormCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PracFormCofnij
            // 
            this.PracFormCofnij.Location = new System.Drawing.Point(691, 398);
            this.PracFormCofnij.Name = "PracFormCofnij";
            this.PracFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.PracFormCofnij.TabIndex = 1;
            this.PracFormCofnij.Text = "Cofnij";
            this.PracFormCofnij.UseVisualStyleBackColor = true;
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PracFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracownikForm";
            this.Text = "Panel dla pracownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PracFormCofnij;
    }
}