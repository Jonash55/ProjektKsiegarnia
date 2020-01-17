using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Sprzedawca : Pracownik, IOsoba
    {
        public string imie;
        public string nazwisko;
        public Sprzedawca(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public string PrzedstawSie()
        {
            return $"Jestem sprzedawcą w księgarni. Nazywam się {this.imie} {this.nazwisko}";
        }
    }
}
}
