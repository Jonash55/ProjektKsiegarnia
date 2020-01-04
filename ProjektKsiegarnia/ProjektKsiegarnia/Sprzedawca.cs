using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Sprzedawca : Pracownik, IOsoba
    {
        public Sprzedawca(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
    }
}
