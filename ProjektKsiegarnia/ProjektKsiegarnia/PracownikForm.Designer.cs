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
            this.Tytul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rokWydania = new System.Windows.Forms.TextBox();
            this.cenaNetto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dodajKsiazke = new System.Windows.Forms.Button();
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
            // Tytul
            // 
            this.Tytul.Location = new System.Drawing.Point(12, 167);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(130, 22);
            this.Tytul.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Narzędzie dodawania nowej książki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tytuł (bez odstępu)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Autor (bez odstępu)";
            // 
            // Autor
            // 
            this.Autor.Location = new System.Drawing.Point(161, 167);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(130, 22);
            this.Autor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rok wydania";
            // 
            // rokWydania
            // 
            this.rokWydania.Location = new System.Drawing.Point(306, 167);
            this.rokWydania.Name = "rokWydania";
            this.rokWydania.Size = new System.Drawing.Size(130, 22);
            this.rokWydania.TabIndex = 15;
            // 
            // cenaNetto
            // 
            this.cenaNetto.Location = new System.Drawing.Point(450, 167);
            this.cenaNetto.Name = "cenaNetto";
            this.cenaNetto.Size = new System.Drawing.Size(130, 22);
            this.cenaNetto.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cena Netto";
            // 
            // dodajKsiazke
            // 
            this.dodajKsiazke.Location = new System.Drawing.Point(12, 219);
            this.dodajKsiazke.Name = "dodajKsiazke";
            this.dodajKsiazke.Size = new System.Drawing.Size(130, 46);
            this.dodajKsiazke.TabIndex = 18;
            this.dodajKsiazke.Text = "Dodaj nową książkę";
            this.dodajKsiazke.UseVisualStyleBackColor = true;
            this.dodajKsiazke.Click += new System.EventHandler(this.dodajKsiazke_Click);
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodajKsiazke);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cenaNetto);
            this.Controls.Add(this.rokWydania);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tytul);
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
        private System.Windows.Forms.TextBox Tytul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rokWydania;
        private System.Windows.Forms.TextBox cenaNetto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodajKsiazke;
    }
}