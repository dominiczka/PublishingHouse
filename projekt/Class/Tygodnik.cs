using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Tygodnik : Czasopismo
    {
        private static List<Tygodnik> listaTygodnik = new List<Tygodnik>();
        private static int iloscTygodnikow;

        public Tygodnik()
            : base()
        {
        }

        public Tygodnik(string tytul, float cena, int numer, double iloscStron)
        : base(tytul, cena, numer, iloscStron)
        {
        }

        public static void wypiszTygodnik()
        {
            foreach (Tygodnik tygodnik in Tygodnik.listaTygodnik)
                Console.WriteLine("\n Tytul: " + tygodnik.tytul + " Numer: " + tygodnik.numer +
                    " Ilosc stron: " + tygodnik.iloscStron + " Cena: " + tygodnik.cena);
        }

        public static void dodajTygodnik(string tytul, float cena, int numer, double iloscStron)
        {
            Tygodnik t = new Tygodnik(tytul, cena, numer, iloscStron);
            listaTygodnik.Add(t);
            iloscTygodnikow++;
            iloscWszystkichCzasopism++;
        }

        public static Tygodnik wyszukajTygodnik(string tytul, int numer)
        {
            Tygodnik tygodnik = null;
            for (int i = 0; i < Tygodnik.iloscTygodnikow;)

                if (Tygodnik.listaTygodnik[i].tytul == tytul && Tygodnik.listaTygodnik[i].numer == numer)
                    tygodnik = listaTygodnik[i];
            return tygodnik;
        }

        public static void edytujTygodnik(string tytul, int numer, int wybor, string nowy)
        {
            int nowy1; float nowy2;
            Tygodnik tygodnik = wyszukajTygodnik(tytul, numer);

            switch (wybor)
            {
                case 1:
                    tygodnik.tytul = nowy;
                    break;

                case 2:
                    nowy1 = Convert.ToInt32(nowy);
                    tygodnik.numer = nowy1;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    tygodnik.iloscStron = nowy1;
                    break;

                case 4:
                    nowy2 = Convert.ToSingle(nowy);
                    tygodnik.cena = nowy2;
                    break;
            }
        }

        public static void usunTygodnik(string t, int n)
        {
            for (int i = 0; i < iloscTygodnikow;)
            {
                if (listaTygodnik[i].tytul == t && listaTygodnik[i].numer == n)
                {
                    listaTygodnik.RemoveAt(i);
                    iloscTygodnikow--;
                    iloscWszystkichCzasopism--;
                    break;
                }
                else ++i;
            }
        }
    }
}
