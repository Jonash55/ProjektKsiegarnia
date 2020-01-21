using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Sprzedawca : Pracownik, IOsoba
    {
        public Sprzedawca(string imie, string nazwisko): base(imie, nazwisko)
        {

        }
        public int iloscSprzedazy;
        public string PrzedstawSie()
        {
            return $"{this.imie} {this.nazwisko}";
        }
        public override string ToString()
        {
            return $"{this.imie} {this.nazwisko}";
        }
    }
}

