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
        private void btZaloguj_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                tbPIN.Text = "";
                MessageBox.Show("Proszę wybrać kierownika do logowania");
                return;
            }
            if (tbPIN.Text == "")
            {
                 MessageBox.Show("Proszę podać PIN");
            }
            if (tbPIN.Text != "1234" && tbPIN.Text != "")
            {
                tbPIN.Text = "";
                MessageBox.Show("Nieprawidłowy PIN, proszę spróbować jeszcze raz");
            }
            if(tbPIN.Text == "1234")
            {
                this.Hide();
                KierownikForm PanelZarządzania = new KierownikForm();
                PanelZarządzania.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPINAdministratora.Text == "")
            {
                MessageBox.Show("Proszę podać PIN administratora");
            }
            if (tbPINAdministratora.Text != "9966" && tbPINAdministratora.Text != "")
            {
                tbPINAdministratora.Text = "";
                MessageBox.Show("Nieprawidłowy PIN administratora, proszę spróbować jeszcze raz");
            }
            if (tbNowyKierownik.Text == "")
            {
                MessageBox.Show("Proszę wpisać dane nowego kierownika");
            }
            if (tbPINAdministratora.Text == "9966" && tbNowyKierownik.Text != "")
            {
                listBox1.Items.Add(tbNowyKierownik.Text);
                tbNowyKierownik.Text = "";
                tbPINAdministratora.Text = "";
                MessageBox.Show("Pomyślnie dodano nowego kierownika");
            }
        }
    }
}
