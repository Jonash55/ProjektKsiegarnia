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
    public partial class KierownikZaloguj : Form
    {
        
        public KierownikZaloguj()
        {
            InitializeComponent();
            //Wypisanie listy kierowników

            foreach (var k in Listy.kierownicy)
            {
                if(!listBox1.Items.Contains(k))
                    listBox1.Items.Add(k.ToString());
            }

        }

        private void KierowZalogujCofnij_Click(object sender, EventArgs e)
        {
            //Cofnięcie do poprzedniego panelu

            this.Hide();
            Start PowrotDoStartu = new Start();
            PowrotDoStartu.ShowDialog();
        }
        private void btZaloguj_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                tbPIN.Text = "";
                MessageBox.Show("Proszę wybrać kierownika do logowania");
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
            if(tbPIN.Text == "1234")
            {
                this.Hide();
                KierownikForm PanelZarządzania = new KierownikForm();
                PanelZarządzania.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPINAdministratora.Text == "")
            {
                MessageBox.Show("Proszę podać PIN administratora");
            }
            if (tbPINAdministratora.Text != "9966" && tbPINAdministratora.Text != "")
            {
                tbPINAdministratora.Text = "";
                MessageBox.Show("Nieprawidłowy PIN administratora, proszę spróbować jeszcze raz");
            }
            if (tbNowyKierownik.Text == "")
            {
                MessageBox.Show("Proszę wpisać dane nowego kierownika");
            }
            if (tbPINAdministratora.Text == "9966" && tbNowyKierownik.Text != "")
            {
                //Dodawanie nowego kierownika

                var nowyKierownikS = tbNowyKierownik.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var nowyKierownik = new Kierownik("", "");
                Listy.kierownicy[0].DodajPracownika(nowyKierownikS[0], nowyKierownikS[1], nowyKierownik);
                listBox1.Items.Add(tbNowyKierownik.Text);
                tbNowyKierownik.Text = "";
                tbPINAdministratora.Text = "";
                MessageBox.Show("Pomyślnie dodano nowego kierownika");
            }
        }

        private void ZwolnijKierownika_Click(object sender, EventArgs e)
        {
            //Zwalnianie kierownika po uprzedniej weryfikacji tożsamości

            if (tbPINAdministratora.Text == "")
            {
                MessageBox.Show("Proszę podać PIN administratora");
            }
            if (tbPINAdministratora.Text != "9966" && tbPINAdministratora.Text != "")
            {
                tbPINAdministratora.Text = "";
                MessageBox.Show("Nieprawidłowy PIN administratora, proszę spróbować jeszcze raz");
            }
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać kierownika do zwolnienia");
                return;
            }
            if(listBox1.SelectedItem.ToString() == Listy.wlasciciel.ToString() && tbPINAdministratora.Text == "9966")
            {
                MessageBox.Show("Nie można zwolnić właściciela");
            }
            if (tbPINAdministratora.Text == "9966" && listBox1.SelectedItem.ToString() != Listy.wlasciciel.ToString())
            {
                var ZwolnionyKierownikS = listBox1.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var k in Listy.kierownicy)
                {
                    if (k.imie == ZwolnionyKierownikS[0] && k.nazwisko == ZwolnionyKierownikS[1])
                    {
                        Listy.kierownicy.Remove(k);
                        listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                        MessageBox.Show("Pomyślnie zwolniono kierowika");
                        break;
                    }
                }
            }
        }
    }
}
