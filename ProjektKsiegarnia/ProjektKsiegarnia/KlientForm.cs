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
    public partial class KlientForm : Form
    {
        public KlientForm()
        {
            InitializeComponent();
            foreach (var k in Listy.ksiazki)
            {
                wyborKsiazek.Items.Add(k.ToString());
            }
            double zaplata = 0;
            foreach (var k in Listy.ksiazkiWKoszyku)
            {
                koszyk.Items.Add(k.ToString());
                zaplata += k.cena_brutto;
            }
            doZaplaty.Text = zaplata.ToString();
        }

        private void KlientFormCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start LogowankoKlienta = new Start();
            LogowankoKlienta.ShowDialog();
        }

        private void dodajDoKoszyka_Click(object sender, EventArgs e)
        {
            if (wyborKsiazek.SelectedItems.Count == 0)
                MessageBox.Show("Proszę wybrać ksiązkę");
            else
            {
                var zaplataS = doZaplaty.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var wybranaKsiazkaS = wyborKsiazek.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double zaplata = double.Parse(zaplataS[0]);
                List<Ksiazka> doUsuniecia = new List<Ksiazka>();
                foreach (var k in Listy.ksiazki)
                {
                    for (int i = 0; i < wybranaKsiazkaS.Length; i++)
                    {
                        if (k.tytul == wybranaKsiazkaS[i])
                        {
                            if (k.ilosc - 1 > 0)
                            {
                                k.ilosc--;
                                zaplata += k.cena_brutto;
                                Listy.ksiazkiWKoszyku.Add(k);
                                koszyk.Items.Add(k.ToString());
                                wyborKsiazek.Refresh();
                            }
                            else if(k.ilosc-1<0)
                            {
                                doUsuniecia.Add(k);
                                MessageBox.Show("Ksiazka nie jest juz dostepna");
                            }
                            else
                            {
                                k.ilosc--;
                                zaplata += k.cena_brutto;
                                Listy.ksiazkiWKoszyku.Add(k);
                                koszyk.Items.Add(k.ToString());
                                wyborKsiazek.Items.Remove(wyborKsiazek.SelectedItem);
                                wyborKsiazek.Refresh();
                                doUsuniecia.Add(k);
                                MessageBox.Show("To była ostatnia dostępna książka");
                            }
                                       
                            doZaplaty.Text = zaplata.ToString();
                        }
                    }
                }
                foreach (var k in doUsuniecia)
                {
                    if (Listy.ksiazki.Contains(k))
                        Listy.ksiazki.Remove(k);
                }
            }

        }

        private void usunZKoszyka_Click(object sender, EventArgs e)
        {
            if (koszyk.SelectedItems.Count == 0)
                MessageBox.Show("Proszę wybrać ksiązkę");
            else
            {
                var wybranaKsiazkaS = koszyk.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                koszyk.Items.Remove(koszyk.SelectedItem);
                var zaplataS = doZaplaty.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double zaplata = double.Parse(zaplataS[0]);
                List<Ksiazka> doDodania = new List<Ksiazka>();
                List<Ksiazka> doUsuniecia = new List<Ksiazka>();
                List<Ksiazka> czyJest = null;
                for (int i = 0; i < wybranaKsiazkaS.Length; i++)
                {
                    czyJest = Listy.ksiazki.Where(l => l.tytul == wybranaKsiazkaS[i]).ToList();
                }
                if (czyJest.Count != 0)
                {
                    foreach (var k in Listy.ksiazki)
                    {
                        for (int i = 0; i < wybranaKsiazkaS.Length; i++)
                        {
                            if (k.ilosc > 0)
                            {
                                if (k.tytul == wybranaKsiazkaS[i])
                                {
                                    k.ilosc++;
                                    Listy.ksiazkiWKoszyku.Remove(k);
                                    zaplata -= k.cena_brutto;
                                    wyborKsiazek.Refresh();
                                }
                            }
                            else
                            {
                                doDodania.Add(k);
                                k.ilosc++;
                                Listy.ksiazkiWKoszyku.Remove(k);
                                wyborKsiazek.Items.Add(k.ToString());
                                wyborKsiazek.Refresh();
                                zaplata -= k.cena_brutto;
                            }
                        }
                        doZaplaty.Text = zaplata.ToString();
                    }
                }
                else
                {
                    foreach (var k in Listy.ksiazkiWKoszyku)
                    {
                        for (int i = 0; i < wybranaKsiazkaS.Length; i++)
                        {
                            if (k.tytul == wybranaKsiazkaS[i] && k.ilosc == int.Parse(wybranaKsiazkaS[8]))
                            {
                                k.ilosc++;
                                doUsuniecia.Add(k);
                                wyborKsiazek.Items.Add(k.ToString());
                                wyborKsiazek.Refresh();
                                Listy.ksiazki.Add(k);
                                zaplata -= k.cena_brutto;
                            }
                        }
                        doZaplaty.Text = zaplata.ToString();
                    }
                }
                foreach (var k in doDodania)
                {
                    if (!Listy.ksiazki.Contains(k))
                        Listy.ksiazki.Add(k);
                }
                foreach (var k in doUsuniecia)
                {
                    if (Listy.ksiazkiWKoszyku.Contains(k))
                        Listy.ksiazkiWKoszyku.Remove(k);
                }
            }
        }

        private void doKasy_Click(object sender, EventArgs e)
        {
            double doZaplatyDouble = double.Parse(doZaplaty.Text);
            Listy.sumaKoszyka = doZaplatyDouble;
            this.Hide();
            PracownikZaloguj LogowankoPracownika = new PracownikZaloguj();
            LogowankoPracownika.ShowDialog();
        }
    }
}
