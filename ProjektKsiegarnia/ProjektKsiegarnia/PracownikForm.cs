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
    public partial class PracownikForm : Form
    {
        public PracownikForm()
        {
            InitializeComponent();
            sumaZamowienia.Text = Listy.sumaKoszyka.ToString();
            label3.Text = Listy.wybranyPracownik.PrzedstawSie();
            if (sumaZamowienia.Text == "0")
                btWystawParagon.Enabled = false;
        }
        
        private void PracFormCofnij_Click_1(object sender, EventArgs e)
        {
            //Cofnięcie do poprzedniego panelu
            
            this.Hide();
            PracownikZaloguj PracownikFormCofka = new PracownikZaloguj();
            PracownikFormCofka.ShowDialog();
        }

        private void btWystawParagon_Click(object sender, EventArgs e)
        {
            //Wystawianie paragonu

            Paragon Paragon1 = new Paragon(Listy.ksiazkiWKoszyku, Listy.wybranyPracownik);
            Paragon1.ListaKsiazek(Listy.ksiazkiWKoszyku);
            MessageBox.Show(Paragon1.ToString());           
            //Dodawanie ilości sprzedanych książek do pracownika

            var pracownik = Listy.wybranyPracownik.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in Listy.sprzedawcy)
            {
                if (s.imie == pracownik[0] && s.nazwisko == pracownik[1])
                {
                    s.iloscSprzedazy += Listy.sprzedaneKsiazki.Count;
                    break;
                }
            }
        }
        private void dodajKsiazke_Click(object sender, EventArgs e)
        {
            //Dodawanie nowej książki

            if (Tytul.Text == "" || Autor.Text == "" || rokWydania.Text == "" || cenaNetto.Text == "")
                MessageBox.Show("Należy podać wszystkie dane o nowej książce");
            else
            {
                var tytul = Tytul.Text;
                var autor = Autor.Text;
                var RokWydania = int.Parse(rokWydania.Text);
                var CenaNetto = double.Parse(cenaNetto.Text);
                var NowaKsiazka = new Ksiazka(tytul, autor, RokWydania, CenaNetto);
                MessageBox.Show("Pomyślnie dodano nową książkę");
            }           
        }
    }
}
