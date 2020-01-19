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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imiePracownika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zatrudnij = new System.Windows.Forms.Button();
            this.zwolnij = new System.Windows.Forms.Button();
            this.sprzedaneKsiazki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lacznaKwota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.najlepszySprzedawca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KierowFormCofnij
            // 
            this.KierowFormCofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KierowFormCofnij.Location = new System.Drawing.Point(703, 369);
            this.KierowFormCofnij.Name = "KierowFormCofnij";
            this.KierowFormCofnij.Size = new System.Drawing.Size(97, 40);
            this.KierowFormCofnij.TabIndex = 2;
            this.KierowFormCofnij.Text = "Wyloguj";
            this.KierowFormCofnij.UseVisualStyleBackColor = true;
            this.KierowFormCofnij.Click += new System.EventHandler(this.KierowFormCofnij_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(26, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(403, 180);
            this.listBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lista sprzedawcow";
            // 
            // imiePracownika
            // 
            this.imiePracownika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imiePracownika.Location = new System.Drawing.Point(26, 258);
            this.imiePracownika.Name = "imiePracownika";
            this.imiePracownika.Size = new System.Drawing.Size(403, 22);
            this.imiePracownika.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wpisz imie i nazwisko sprzedawcy";
            // 
            // zatrudnij
            // 
            this.zatrudnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zatrudnij.Location = new System.Drawing.Point(26, 286);
            this.zatrudnij.Name = "zatrudnij";
            this.zatrudnij.Size = new System.Drawing.Size(78, 34);
            this.zatrudnij.TabIndex = 19;
            this.zatrudnij.Text = "Zatrudnij";
            this.zatrudnij.UseVisualStyleBackColor = true;
            this.zatrudnij.Click += new System.EventHandler(this.zatrudnij_Click);
            // 
            // zwolnij
            // 
            this.zwolnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zwolnij.Location = new System.Drawing.Point(26, 326);
            this.zwolnij.Name = "zwolnij";
            this.zwolnij.Size = new System.Drawing.Size(78, 34);
            this.zwolnij.TabIndex = 20;
            this.zwolnij.Text = "Zwolnij";
            this.zwolnij.UseVisualStyleBackColor = true;
            this.zwolnij.Click += new System.EventHandler(this.zwolnij_Click);
            // 
            // sprzedaneKsiazki
            // 
            this.sprzedaneKsiazki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sprzedaneKsiazki.Location = new System.Drawing.Point(700, 41);
            this.sprzedaneKsiazki.Name = "sprzedaneKsiazki";
            this.sprzedaneKsiazki.Size = new System.Drawing.Size(100, 22);
            this.sprzedaneKsiazki.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ilość sprzedanych książek";
            // 
            // lacznaKwota
            // 
            this.lacznaKwota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lacznaKwota.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lacznaKwota.Location = new System.Drawing.Point(700, 86);
            this.lacznaKwota.Name = "lacznaKwota";
            this.lacznaKwota.Size = new System.Drawing.Size(100, 22);
            this.lacznaKwota.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Łączny przychód";
            // 
            // najlepszySprzedawca
            // 
            this.najlepszySprzedawca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.najlepszySprzedawca.Location = new System.Drawing.Point(615, 153);
            this.najlepszySprzedawca.Name = "najlepszySprzedawca";
            this.najlepszySprzedawca.Size = new System.Drawing.Size(185, 22);
            this.najlepszySprzedawca.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Najlepszy sprzedawca";
            // 
            // KierownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.najlepszySprzedawca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lacznaKwota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sprzedaneKsiazki);
            this.Controls.Add(this.zwolnij);
            this.Controls.Add(this.zatrudnij);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imiePracownika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.KierowFormCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KierownikForm";
            this.Text = "Panel zarządzania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KierowFormCofnij;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imiePracownika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button zatrudnij;
        private System.Windows.Forms.Button zwolnij;
        private System.Windows.Forms.TextBox sprzedaneKsiazki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lacznaKwota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox najlepszySprzedawca;
        private System.Windows.Forms.Label label4;
    }
}