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
            this.wyborKsiazek = new System.Windows.Forms.ListBox();
            this.koszyk = new System.Windows.Forms.ListBox();
            this.dodajDoKoszyka = new System.Windows.Forms.Button();
            this.doKasy = new System.Windows.Forms.Button();
            this.doZaplaty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usunZKoszyka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KlientFormCofnij
            // 
            this.KlientFormCofnij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KlientFormCofnij.Location = new System.Drawing.Point(674, 483);
            this.KlientFormCofnij.Name = "KlientFormCofnij";
            this.KlientFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.KlientFormCofnij.TabIndex = 1;
            this.KlientFormCofnij.Text = "Cofnij";
            this.KlientFormCofnij.UseVisualStyleBackColor = true;
            this.KlientFormCofnij.Click += new System.EventHandler(this.KlientFormCofnij_Click);
            // 
            // wyborKsiazek
            // 
            this.wyborKsiazek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wyborKsiazek.FormattingEnabled = true;
            this.wyborKsiazek.ItemHeight = 16;
            this.wyborKsiazek.Location = new System.Drawing.Point(12, 29);
            this.wyborKsiazek.Name = "wyborKsiazek";
            this.wyborKsiazek.Size = new System.Drawing.Size(759, 164);
            this.wyborKsiazek.TabIndex = 10;
            // 
            // koszyk
            // 
            this.koszyk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.koszyk.FormattingEnabled = true;
            this.koszyk.ItemHeight = 16;
            this.koszyk.Location = new System.Drawing.Point(12, 273);
            this.koszyk.Name = "koszyk";
            this.koszyk.Size = new System.Drawing.Size(759, 164);
            this.koszyk.TabIndex = 11;
            // 
            // dodajDoKoszyka
            // 
            this.dodajDoKoszyka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dodajDoKoszyka.Location = new System.Drawing.Point(609, 199);
            this.dodajDoKoszyka.Name = "dodajDoKoszyka";
            this.dodajDoKoszyka.Size = new System.Drawing.Size(162, 41);
            this.dodajDoKoszyka.TabIndex = 12;
            this.dodajDoKoszyka.Text = "Dodaj do koszyka";
            this.dodajDoKoszyka.UseVisualStyleBackColor = true;
            this.dodajDoKoszyka.Click += new System.EventHandler(this.dodajDoKoszyka_Click);
            // 
            // doKasy
            // 
            this.doKasy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doKasy.Location = new System.Drawing.Point(196, 459);
            this.doKasy.Name = "doKasy";
            this.doKasy.Size = new System.Drawing.Size(75, 41);
            this.doKasy.TabIndex = 13;
            this.doKasy.Text = "Do kasy";
            this.doKasy.UseVisualStyleBackColor = true;
            this.doKasy.Click += new System.EventHandler(this.doKasy_Click);
            // 
            // doZaplaty
            // 
            this.doZaplaty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doZaplaty.Location = new System.Drawing.Point(90, 468);
            this.doZaplaty.Name = "doZaplaty";
            this.doZaplaty.Size = new System.Drawing.Size(100, 22);
            this.doZaplaty.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Do zapłaty";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Wybór towaru";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Koszyk";
            // 
            // usunZKoszyka
            // 
            this.usunZKoszyka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usunZKoszyka.Location = new System.Drawing.Point(609, 440);
            this.usunZKoszyka.Name = "usunZKoszyka";
            this.usunZKoszyka.Size = new System.Drawing.Size(162, 37);
            this.usunZKoszyka.TabIndex = 18;
            this.usunZKoszyka.Text = "Usuń z koszyka";
            this.usunZKoszyka.UseVisualStyleBackColor = true;
            this.usunZKoszyka.Click += new System.EventHandler(this.usunZKoszyka_Click);
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(787, 526);
            this.Controls.Add(this.usunZKoszyka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doZaplaty);
            this.Controls.Add(this.doKasy);
            this.Controls.Add(this.dodajDoKoszyka);
            this.Controls.Add(this.koszyk);
            this.Controls.Add(this.wyborKsiazek);
            this.Controls.Add(this.KlientFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientForm";
            this.Text = "Panel dla klienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KlientFormCofnij;
        private System.Windows.Forms.ListBox wyborKsiazek;
        private System.Windows.Forms.ListBox koszyk;
        private System.Windows.Forms.Button dodajDoKoszyka;
        private System.Windows.Forms.Button doKasy;
        private System.Windows.Forms.TextBox doZaplaty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button usunZKoszyka;
    }
}