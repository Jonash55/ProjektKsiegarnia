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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Pracownik_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracownikZaloguj LogowankoPracownika = new PracownikZaloguj();
            LogowankoPracownika.ShowDialog();
        }

        private void Klient_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlientForm LogowankoKlienta = new KlientForm();
            LogowankoKlienta.ShowDialog();
        }

        private void Kierownik_Click(object sender, EventArgs e)
        {
            this.Hide();
            KierownikZaloguj LogowankoKierownika = new KierownikZaloguj();
            LogowankoKierownika.ShowDialog();
        }
    }
}
