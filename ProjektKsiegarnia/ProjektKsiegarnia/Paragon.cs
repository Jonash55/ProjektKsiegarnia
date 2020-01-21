using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Paragon: Listy
    {
        public string nazwaKsiegarni = "Ksiagarnia Słodki Pieseczek";
        public List<Ksiazka> kupowaneKsiazki = new List<Ksiazka>();
        public double końcowaCena ;
        public double podatekVAT;
        public Sprzedawca sprzedawca;

        public Paragon(List<Ksiazka> kupowaneKsiazki, Sprzedawca sprzedawca)
        {
            this.kupowaneKsiazki = kupowaneKsiazki;
            this.sprzedawca = sprzedawca;
            foreach (var k in kupowaneKsiazki)
            {
                this.końcowaCena += k.cena_brutto;
                this.podatekVAT += k.cena_brutto - k.cena_netto;
            }
        }
        public string ListaKsiazek(List<Ksiazka> kupowaneKsiazki)
        {
            string wynik = "";
            foreach (var k in kupowaneKsiazki)
            {
                wynik += k.ToString() + "\n" ;
            }
            return wynik;
        }
        public override string ToString()
        {
            return $"PARAGON: \n{this.nazwaKsiegarni} \n{this.ListaKsiazek(kupowaneKsiazki)} \n do zapłaty: {this.końcowaCena.ToString()} zł\n podatek VAT: {this.podatekVAT.ToString()} zł\n sprzedawca: {this.sprzedawca.ToString()}";
        }

    }
}
