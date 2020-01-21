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
                var wybranaksiazkaS = wyborKsiazek.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Ksiazka pierwszaZPolki = null;
                double zaplata = double.Parse(doZaplaty.Text);
                List<Ksiazka> polkaZTytulem = new List<Ksiazka>();
                for (int i = 0; i < wybranaksiazkaS.Length; i++)
                {
                    polkaZTytulem = Listy.ksiazki.Where(k => k.tytul == wybranaksiazkaS[i]).ToList();
                    if (polkaZTytulem.Count != 0)
                        break;
                }
                pierwszaZPolki = polkaZTytulem.First();
                Listy.ksiazkiWKoszyku.Add(pierwszaZPolki);
                wyborKsiazek.Items.Remove(wyborKsiazek.SelectedItem);
                Listy.ksiazki.Remove(pierwszaZPolki);
                koszyk.Items.Add(pierwszaZPolki.ToString());
                zaplata += pierwszaZPolki.cena_brutto;
                doZaplaty.Text = zaplata.ToString();
            }
            
        }

        private void usunZKoszyka_Click(object sender, EventArgs e)
        {
            if (koszyk.SelectedItems.Count == 0)
                MessageBox.Show("Proszę wybrać ksiązkę");
            else
            {
                var wybranaksiazkaS = koszyk.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Ksiazka pierwszaZKoszyka = null;
                double zaplata = double.Parse(doZaplaty.Text);
                List<Ksiazka> tytulyWKoszyku = new List<Ksiazka>();
                for (int i = 0; i < wybranaksiazkaS.Length; i++)
                {
                    tytulyWKoszyku = Listy.ksiazkiWKoszyku.Where(k => k.tytul == wybranaksiazkaS[i]).ToList();
                    if (tytulyWKoszyku.Count != 0)
                        break;
                }
                pierwszaZKoszyka = tytulyWKoszyku.First();
                Listy.ksiazkiWKoszyku.Remove(pierwszaZKoszyka);
                koszyk.Items.Remove(koszyk.SelectedItem);
                wyborKsiazek.Items.Add(pierwszaZKoszyka.ToString());
                Listy.ksiazki.Add(pierwszaZKoszyka);
                zaplata -= pierwszaZKoszyka.cena_brutto;
                doZaplaty.Text = zaplata.ToString();
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
