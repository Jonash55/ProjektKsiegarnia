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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KierownikZaloguj));
            this.KierowZalogujCofnij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btZaloguj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.btDodajKierownika = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNowyKierownik = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPINAdministratora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ZwolnijKierownika = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.MinimumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proszę wybrać kierownika i wpisać PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.MinimumSize = new System.Drawing.Size(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Na potrzeby zadania PIN to 1234";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 100);
            this.listBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista kierowników do wybrania";
            // 
            // btZaloguj
            // 
            this.btZaloguj.Location = new System.Drawing.Point(12, 398);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Size = new System.Drawing.Size(97, 40);
            this.btZaloguj.TabIndex = 11;
            this.btZaloguj.Text = "Zaloguj";
            this.btZaloguj.UseVisualStyleBackColor = true;
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "PIN do logowania";
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(115, 416);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(121, 22);
            this.tbPIN.TabIndex = 13;
            // 
            // btDodajKierownika
            // 
            this.btDodajKierownika.Location = new System.Drawing.Point(12, 269);
            this.btDodajKierownika.Name = "btDodajKierownika";
            this.btDodajKierownika.Size = new System.Drawing.Size(97, 46);
            this.btDodajKierownika.TabIndex = 14;
            this.btDodajKierownika.Text = "Dodaj kierownika";
            this.btDodajKierownika.UseVisualStyleBackColor = true;
            this.btDodajKierownika.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Okienko do wpisywania nowego kierownika";
            // 
            // tbNowyKierownik
            // 
            this.tbNowyKierownik.Location = new System.Drawing.Point(12, 241);
            this.tbNowyKierownik.Name = "tbNowyKierownik";
            this.tbNowyKierownik.Size = new System.Drawing.Size(776, 22);
            this.tbNowyKierownik.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "PIN administratora";
            // 
            // tbPINAdministratora
            // 
            this.tbPINAdministratora.Location = new System.Drawing.Point(121, 290);
            this.tbPINAdministratora.Name = "tbPINAdministratora";
            this.tbPINAdministratora.Size = new System.Drawing.Size(115, 22);
            this.tbPINAdministratora.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "PIN administratora to 9966";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(554, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Na potrzeby zadania PIN dla wszystkich nowych kierowników jest taki sam jak norma" +
    "lny";
            // 
            // ZwolnijKierownika
            // 
            this.ZwolnijKierownika.Location = new System.Drawing.Point(248, 269);
            this.ZwolnijKierownika.Name = "ZwolnijKierownika";
            this.ZwolnijKierownika.Size = new System.Drawing.Size(97, 46);
            this.ZwolnijKierownika.TabIndex = 21;
            this.ZwolnijKierownika.Text = "Zwolnij kierownika";
            this.ZwolnijKierownika.UseVisualStyleBackColor = true;
            this.ZwolnijKierownika.Click += new System.EventHandler(this.ZwolnijKierownika_Click);
            // 
            // KierownikZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZwolnijKierownika);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPINAdministratora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNowyKierownik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btDodajKierownika);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KierowZalogujCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KierownikZaloguj";
            this.Text = "Logowanie dla kierownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KierowZalogujCofnij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btZaloguj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Button btDodajKierownika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNowyKierownik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPINAdministratora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ZwolnijKierownika;
    }
}