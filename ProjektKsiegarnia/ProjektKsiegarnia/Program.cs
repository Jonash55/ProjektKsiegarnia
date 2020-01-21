using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektKsiegarnia
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Kierownik kierownik = new Kierownik("Jan", "Kowalski");
            Listy.kierownicy.Add(kierownik);
            Listy.pracownicy.Add(kierownik);
            Listy.wlasciciel = kierownik;
            Sprzedawca pracownik1 = new Sprzedawca("Roman", "Bąk");
            pracownik1.iloscSprzedazy = 2;
            Sprzedawca pracownik2 = new Sprzedawca("Anna", "Pszczoła");
            pracownik1.iloscSprzedazy = 3;
            Sprzedawca pracownik3 = new Sprzedawca("Ignacy", "Trzmiel");
            pracownik1.iloscSprzedazy = 2;
            for (int i = 0; i < 51; i++)
            {
                Ksiazka ksiazka1 = new Ksiazka("WładcaPierścieni", "J.R.R.Tolkien", 2010, 22);
            }
            for (int i = 0; i < 38; i++)
            {
                Ksiazka ksiazka2 = new Ksiazka("PilotCiTegoNiePowie", "PatrickSmith", 2018, 25);
            }
            for (int i = 0; i<17; i++)
            {
                Ksiazka ksiazka3 = new Ksiazka("PanTadeusz", "AdamMickiewicz", 2000, 20);
            }
            for (int i = 0; i < 5; i++)
            {
                Ksiazka ksiazka4 = new Ksiazka("Wiedźmin", "AndrzejSapkowski", 2012, 27);
            }
            Listy.pracownicy.Add(pracownik1);
            Listy.pracownicy.Add(pracownik2);
            Listy.pracownicy.Add(pracownik3);
            Listy.sprzedawcy.Add(pracownik1);
            Listy.sprzedawcy.Add(pracownik2);
            Listy.sprzedawcy.Add(pracownik3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());
            
        }
    }
}
