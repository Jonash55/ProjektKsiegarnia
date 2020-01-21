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
            this.sumaZamowienia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btWystawParagon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxWyszukiwanie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PracFormCofnij
            // 
            this.PracFormCofnij.Location = new System.Drawing.Point(691, 398);
            this.PracFormCofnij.Name = "PracFormCofnij";
            this.PracFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.PracFormCofnij.TabIndex = 1;
            this.PracFormCofnij.Text = "Wyloguj";
            this.PracFormCofnij.UseVisualStyleBackColor = true;
            this.PracFormCofnij.Click += new System.EventHandler(this.PracFormCofnij_Click_1);
            // 
            // sumaZamowienia
            // 
            this.sumaZamowienia.Location = new System.Drawing.Point(12, 33);
            this.sumaZamowienia.Name = "sumaZamowienia";
            this.sumaZamowienia.Size = new System.Drawing.Size(114, 22);
            this.sumaZamowienia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suma do zapłaty";
            // 
            // btWystawParagon
            // 
            this.btWystawParagon.Location = new System.Drawing.Point(132, 13);
            this.btWystawParagon.Name = "btWystawParagon";
            this.btWystawParagon.Size = new System.Drawing.Size(114, 42);
            this.btWystawParagon.TabIndex = 4;
            this.btWystawParagon.Text = "Wystaw paragon";
            this.btWystawParagon.UseVisualStyleBackColor = true;
            this.btWystawParagon.Click += new System.EventHandler(this.btWystawParagon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aktualnie zalogowany pracownik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wyszukiwanie dostępnych książek";
            // 
            // listBoxWyszukiwanie
            // 
            this.listBoxWyszukiwanie.FormattingEnabled = true;
            this.listBoxWyszukiwanie.ItemHeight = 16;
            this.listBoxWyszukiwanie.Location = new System.Drawing.Point(12, 106);
            this.listBoxWyszukiwanie.Name = "listBoxWyszukiwanie";
            this.listBoxWyszukiwanie.Size = new System.Drawing.Size(776, 276);
            this.listBoxWyszukiwanie.TabIndex = 10;
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxWyszukiwanie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btWystawParagon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumaZamowienia);
            this.Controls.Add(this.PracFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PracownikForm";
            this.Text = "Panel dla pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PracFormCofnij;
        private System.Windows.Forms.TextBox sumaZamowienia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWystawParagon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxWyszukiwanie;
    }
}