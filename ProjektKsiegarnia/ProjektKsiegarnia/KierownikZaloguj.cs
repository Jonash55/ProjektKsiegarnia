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
            ListViewItem Kierownik = new ListViewItem("Jan");
            Kierownik.SubItems.Add("Kowalski");
            Kierownik.SubItems.Add("Właściciel");
            listView1.Items.Add(Kierownik);
        }

        private void KierowZalogujCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start PowrotDoStartu = new Start();
            PowrotDoStartu.ShowDialog();
        }

        private void btKierwonikZaloguj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Proszę wybrać kierownika");
                return;
            }
            if(tbPIN.Text == "")
            {
                MessageBox.Show("Proszę podać PIN do logowania");
            }         
            if(tbPIN.Text != "1234" && tbPIN.Text != "")
            {
                MessageBox.Show("PIN nieprawidłowy, proszę spróbować ponownie");
            }
            if(tbPIN.Text == "1234")
            {
                this.Hide();
                KierownikForm PanelZarządzania = new KierownikForm();
                PanelZarządzania.ShowDialog();
            }
            
        }
    }
}
