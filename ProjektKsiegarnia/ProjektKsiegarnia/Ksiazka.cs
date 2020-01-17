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
        public double cena_netto;
        public int rok_wydania;
        public double cena_brutto;
        public Ksiazka(string tytul,string autor, int rok_wydania,double cena_netto)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rok_wydania = rok_wydania;
            this.cena_netto = cena_netto;
            this.cena_brutto = cena_netto * 0.05 + cena_netto;
            ksiazki.Add(this);
        }

        public override string ToString()
        {
            return $"{this.tytul} {this.autor} {this.rok_wydania} {this.cena_brutto}zł ";
        }
    }
}
