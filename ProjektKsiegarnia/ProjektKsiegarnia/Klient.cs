﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    abstract class Klient : Listy, IOsoba
    {
        public string imie;
        public string nazwisko;
        public string PrzedstawSie()
        {
            return $"Jestem klientem księgarni. Nazywam się {imie} {nazwisko}.";
        }
        public override string ToString()
        {
            return $"{this.imie} {this.nazwisko}";
        }
    }
}

