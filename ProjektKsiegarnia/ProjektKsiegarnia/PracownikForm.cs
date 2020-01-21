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
            label3.Text = Listy.wybranyPracownik;
        }
        
        private void PracFormCofnij_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PracownikZaloguj PracownikFormCofka = new PracownikZaloguj();
            PracownikFormCofka.ShowDialog();
        }

        private void btWystawParagon_Click(object sender, EventArgs e)
        {

        }

    }
}
