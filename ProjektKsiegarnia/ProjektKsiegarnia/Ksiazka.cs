using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Ksiazka: Listy
    {
        public string tytul;
        public string autor;
        public double cena;
        public int rok_wydania;
        public Ksiazka(string tytul,string autor, int rok_wydania,double cena)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rok_wydania = rok_wydania;
            this.cena = cena;
            ksiazki.Add(this);
        }
    }
}
