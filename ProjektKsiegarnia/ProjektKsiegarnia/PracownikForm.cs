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
            this.Hide();
            PracownikZaloguj PracownikFormCofka = new PracownikZaloguj();
            PracownikFormCofka.ShowDialog();
        }

        private void btWystawParagon_Click(object sender, EventArgs e)
        {
            Paragon Paragon1 = new Paragon(Listy.ksiazkiWKoszyku, Listy.wybranyPracownik);
            Paragon1.ListaKsiazek(Listy.ksiazkiWKoszyku);
            MessageBox.Show(Paragon1.ToString());
        }

    }
}
