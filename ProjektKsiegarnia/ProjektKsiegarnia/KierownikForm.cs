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
        }

        private void KierowFormCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            KierownikZaloguj KierownikZalogujCofka = new KierownikZaloguj();
            KierownikZalogujCofka.ShowDialog();
        }
    }
}
