using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Pracownik : IOsoba
        {
            public string imie;
            public string nazwisko;
            public int wiek;
            public string PrzedstawSie()
            {
                return $"Jestem pracownikiem księgarni. Nazywam się {this.imie} {this.nazwisko} i mam {this.wiek} lat.";
            }
        }
    
}

