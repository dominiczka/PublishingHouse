using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Miesiecznik : Czasopismo
    {
        private static List<Miesiecznik> listaMiesiecznik = new List<Miesiecznik>();
        private static int iloscMiesiecznikow;

        public Miesiecznik()
           : base()
        {
        }

        public Miesiecznik(string tytul, float cena, int numer, double iloscStron)
        : base(tytul, cena, numer, iloscStron)
        {
        }

        public static Miesiecznik wyszukajMiesiecznik(string tytul, int numer)
        {
            Miesiecznik miesiecznik = null;
            for (int i = 0; i < Miesiecznik.iloscMiesiecznikow;)

                if (Miesiecznik.listaMiesiecznik[i].tytul == tytul && Miesiecznik.listaMiesiecznik[i].numer == numer)
                    miesiecznik = listaMiesiecznik[i];

            return miesiecznik;

        }

        public static void edytujMiesiecznik(string tytul, int numer, int wybor, string nowy)
        {
            int nowy1; float nowy2;
            Miesiecznik miesiecznik = wyszukajMiesiecznik(tytul, numer);

            switch (wybor)
            {
                case 1:
                    miesiecznik.tytul = nowy;
                    break;

                case 2:
                    nowy1 = Convert.ToInt32(nowy);
                    miesiecznik.numer = nowy1;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    miesiecznik.iloscStron = nowy1;
                    break;

                case 4:
                    nowy2 = Convert.ToSingle(nowy);
                    miesiecznik.cena = nowy2;
                    break;
            }
        }

        public static void wypiszMiesiecznik()
        {
            foreach (Miesiecznik miesiecznik in Miesiecznik.listaMiesiecznik)
                Console.WriteLine("\n Tytul: " + miesiecznik.tytul + " Numer: " + miesiecznik.numer +
                    " Ilosc stron: " + miesiecznik.iloscStron + " Cena: " + miesiecznik.cena);
        }

        public static void dodajMiesiecznik(string tytul, float cena, int numer, double iloscStron)
        {
            Miesiecznik m = new Miesiecznik(tytul, cena, numer, iloscStron);
            listaMiesiecznik.Add(m);
            iloscMiesiecznikow++;
            iloscWszystkichCzasopism++;
        }

        public static void usunMiesiecznik(string t, int n)
        {
            for (int i = 0; i < iloscMiesiecznikow;)
            {
                if (listaMiesiecznik[i].tytul == t && listaMiesiecznik[i].numer == n)
                {
                    listaMiesiecznik.RemoveAt(i);
                    iloscWszystkichCzasopism--;
                    iloscMiesiecznikow--;
                    break;
                }
                else ++i;
            }
        }
    }
}
