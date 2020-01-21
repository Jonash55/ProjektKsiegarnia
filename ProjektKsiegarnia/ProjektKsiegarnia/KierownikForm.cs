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
    public partial class KierownikForm : Form
    {
        public KierownikForm()
        {
            InitializeComponent();
            //Podsumowanie pracowników
            
            sprzedaneKsiazki.Text = Listy.sprzedaneKsiazki.Count.ToString();
            double lacznaKwotaD = 0;
            foreach (var p in Listy.paragony)
            {
                lacznaKwotaD += p.końcowaCena;
            }
            lacznaKwota.Text = lacznaKwotaD.ToString();
            int najlepszy = 0;
            for (int i = 0; i < Listy.sprzedawcy.Count; i++)
            {
                if (Listy.sprzedawcy[i].iloscSprzedazy > najlepszy)
                    najlepszy = Listy.sprzedawcy[i].iloscSprzedazy;
            }
            foreach (var s in Listy.sprzedawcy)
            {
                if (!listBox2.Items.Contains(s))
                    listBox2.Items.Add(s.ToString());
                if (s.iloscSprzedazy == najlepszy)
                    najlepszySprzedawca.Text = s.ToString();
            }
        }

        private void KierowFormCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            KierownikZaloguj KierownikZalogujCofka = new KierownikZaloguj();
            KierownikZalogujCofka.ShowDialog();
        }

        private void zatrudnij_Click(object sender, EventArgs e)
        {
            //Dodawanie nowego pracownika
            
            var nowyPracownikS = imiePracownika.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var nowyPracownik = new Sprzedawca("", "");
            Listy.kierownicy[0].DodajPracownika(nowyPracownikS[0], nowyPracownikS[1], nowyPracownik);
            listBox2.Items.Add(imiePracownika.Text);
            imiePracownika.Text = "";
            MessageBox.Show("Pomyślnie dodano nowego sprzedawcę");
        }

        private void zwolnij_Click(object sender, EventArgs e)
        {
            //Zwalnianie pracownika

            var nowyPracownikS = listBox2.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać sprzedawcę do zwolnienia");
                return;
            }
            foreach (var s in Listy.sprzedawcy)
            {
                if (!Listy.kierownicy.Contains(s))
                {
                    if (s.imie == nowyPracownikS[0] && s.nazwisko == nowyPracownikS[1])
                    {
                        Listy.sprzedawcy.Remove(s);
                        Listy.pracownicy.Remove(s);
                        listBox2.Items.Remove(listBox2.SelectedItem.ToString());
                        MessageBox.Show("Pomyślnie zwolniono sprzedawcę");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Nie można zwolnić kierownika");
                }
            }       
        }
    }
}
