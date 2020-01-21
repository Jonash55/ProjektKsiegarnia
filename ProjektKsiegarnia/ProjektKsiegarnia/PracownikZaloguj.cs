using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektKsiegarnia
{
    public partial class PracownikZaloguj : Form
    {
        public PracownikZaloguj()
        {
            InitializeComponent();
            foreach (var k in Listy.pracownicy)
            {
                if (!listBox3.Items.Contains(k))
                    listBox3.Items.Add(k.ToString());
            }
        }
        private void PracZalogujCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start PowrotDoStartu = new Start();
            PowrotDoStartu.ShowDialog();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            Listy.wybranyPracownik = listBox3.SelectedItem as Sprzedawca;
            if (listBox3.SelectedItems.Count == 0)
            {
                tbPIN.Text = "";
                MessageBox.Show("Proszę wybrać pracownika do logowania");
                return;
            }
            if (tbPIN.Text == "")
            {
                MessageBox.Show("Proszę podać PIN");
            }
            if (tbPIN.Text != "1234" && tbPIN.Text != "")
            {
                tbPIN.Text = "";
                MessageBox.Show("Nieprawidłowy PIN, proszę spróbować jeszcze raz");
            }
            if (tbPIN.Text == "1234")
            {
                this.Hide();
                PracownikForm PanelZarządzaniaPracownika = new PracownikForm();
                PanelZarządzaniaPracownika.ShowDialog();
                
            }
            
        }
    }
}
