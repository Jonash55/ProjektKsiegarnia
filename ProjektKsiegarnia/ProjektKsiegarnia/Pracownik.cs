﻿using System;
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
        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
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

