using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Pracownik : Listy, IOsoba
        {
            public string imie;
            public string nazwisko;
            public string PrzedstawSie()
            {
                return $"Jestem pracownikiem księgarni. Nazywam się {this.imie} {this.nazwisko}";
            }
            public override string ToString()
            {
                return $"{this.imie} {this.nazwisko}";
            }
    }
    
}

