using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKsiegarnia
{
    abstract class Listy
    {
        public static List<Pracownik> pracownicy = new List<Pracownik>();
        public static List<Kierownik> kierownicy = new List<Kierownik>();
        public static List<Sprzedawca> sprzedawcy = new List<Sprzedawca>();
        public static List<Ksiazka> ksiazki = new List<Ksiazka>();
        public static List<Paragon> paragony = new List<Paragon>();
        public static List<Ksiazka> sprzedaneKsiazki = new List<Ksiazka>();
        public static List<Ksiazka> ksiazkiWKoszyku = new List<Ksiazka>();
        public static Kierownik wlasciciel = null;
    }
}
