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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnImie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btKierwonikZaloguj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.columnRanga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnImie,
            this.columnNazwisko,
            this.columnRanga});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 301);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnImie
            // 
            this.columnImie.Text = "Imię";
            this.columnImie.Width = 194;
            // 
            // columnNazwisko
            // 
            this.columnNazwisko.Text = "Nazwisko";
            this.columnNazwisko.Width = 341;
            // 
            // btKierwonikZaloguj
            // 
            this.btKierwonikZaloguj.Location = new System.Drawing.Point(12, 398);
            this.btKierwonikZaloguj.Name = "btKierwonikZaloguj";
            this.btKierwonikZaloguj.Size = new System.Drawing.Size(97, 40);
            this.btKierwonikZaloguj.TabIndex = 4;
            this.btKierwonikZaloguj.Text = "Zaloguj";
            this.btKierwonikZaloguj.UseVisualStyleBackColor = true;
            this.btKierwonikZaloguj.Click += new System.EventHandler(this.btKierwonikZaloguj_Click);
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
            this.label1.Text = "Proszę wybrać kierownika, wpisać PIN i nacisnąć przycisk zaloguj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 9);
            this.label2.MaximumSize = new System.Drawing.Size(250, 0);
            this.label2.MinimumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Na potrzeby zadania PIN do logowania to 1234";
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(115, 416);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(122, 22);
            this.tbPIN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proszę podać PIN";
            // 
            // columnRanga
            // 
            this.columnRanga.Text = "Ranga";
            this.columnRanga.Width = 231;
            // 
            // KierownikZaloguj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btKierwonikZaloguj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.KierowZalogujCofnij);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KierownikZaloguj";
            this.Text = "Logowanie dla kierownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KierowZalogujCofnij;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnImie;
        private System.Windows.Forms.ColumnHeader columnNazwisko;
        private System.Windows.Forms.Button btKierwonikZaloguj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnRanga;
    }
}