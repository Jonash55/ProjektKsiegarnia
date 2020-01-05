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
        }

        private void KierowZalogujCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start PowrotDoStartu = new Start();
            PowrotDoStartu.ShowDialog();
        }
    }
}
