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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btZaloguj = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proszę wybrać pracownika i wpisać PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.MinimumSize = new System.Drawing.Size(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Na potrzeby zadania PIN to 1234";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lista sprzedawców";
            // 
            // btZaloguj
            // 
            this.btZaloguj.Location = new System.Drawing.Point(15, 398);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Size = new System.Drawing.Size(97, 40);
            this.btZaloguj.TabIndex = 13;
            this.btZaloguj.Text = "Zaloguj";
            this.btZaloguj.UseVisualStyleBackColor = true;
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(15, 80);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(776, 292);
            this.listBox3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "PIN do logowania";
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(118, 416);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(121, 22);
            this.tbPIN.TabIndex = 16;
            // 
            // PracownikZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PracZalogujCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracownikZaloguj";
            this.Text = "Logowanie dla pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PracZalogujCofnij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btZaloguj;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPIN;
    }
}