using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    class Kierownik : Sprzedawca, IOsoba
    {
        public Kierownik(string imie, string nazwisko): base(imie, nazwisko)
        {
            Listy.sprzedawcy.Add(this);
        }
        
            
        public string PrzedstawSie()
        {
            return $"{this.imie} {this.nazwisko}";
        }

        public void DodajPracownika(string imie, string nazwisko, Pracownik stanowisko)
        {
            stanowisko.imie = imie;
            stanowisko.nazwisko = nazwisko;
            pracownicy.Add(stanowisko);
        }
        public void DodajPracownika(string imie, string nazwisko, Sprzedawca stanowisko)
        {
            stanowisko.imie = imie;
            stanowisko.nazwisko = nazwisko;
            pracownicy.Add(stanowisko);
            sprzedawcy.Add(stanowisko);
        }
        public void DodajPracownika(string imie, string nazwisko, Kierownik stanowisko)
        {
            stanowisko.imie = imie;
            stanowisko.nazwisko = nazwisko;
            pracownicy.Add(stanowisko);
            kierownicy.Add(stanowisko);
        }
        public override string ToString()
        {
            return $"{this.imie} {this.nazwisko}";
        }
    }
}
