using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Romans : Ksiazka
    {
        private static List<Romans> listaRomansow = new List<Romans>();
        private static int iloscRomansow;

        public Romans()
            : base()
        { }

        public Romans(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
            : base(tytul, rokWydania, iloscStron, cena, autor)
        { }

        public static void dodajRomans(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
        {
            Romans r = new Romans(tytul, rokWydania, iloscStron, cena, autor);
            listaRomansow.Add(r);
            iloscRomansow++;
            iloscWszystkichKsiazek++;
        }

        public static void wypiszRomans()
        {
            foreach (Romans romans in Romans.listaRomansow)
                Console.WriteLine(" Tytul: " + romans.tytul + " Rok wydania: " +
                  romans.rokWydania + " Ilosc stron: " + romans.iloscStron + " Cena: "
                  + romans.cena + " Autor: Imie: " + romans.autor.imie + " Nazwisko: " + romans.autor.nazwisko);
        }

        public static Romans wyszukajRomans(string tytul, string nazwisko)
        {
            Romans romans = null;
            for (int i = 0; i < iloscRomansow;)

                if (listaRomansow[i].tytul == tytul && listaRomansow[i].autor.nazwisko == nazwisko)
                    romans = listaRomansow[i];
            return romans;
        }

        public static void edytujRomans(string tytul, string nazwisko,
            int wybor, int a, string nowy)
        {
            int nowy1; float nowy2;
            Romans romans = wyszukajRomans(tytul, nazwisko);

            switch (wybor)
            {
                case 1:
                    romans.tytul = nowy;
                    break;

                case 2:
                    romans.autor.imie = nowy;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    romans.rokWydania = nowy1;
                    break;

                case 4:
                    nowy1 = Convert.ToInt32(nowy);
                    romans.iloscStron = nowy1;
                    break;

                case 5:
                    nowy2 = Convert.ToSingle(nowy);
                    romans.cena = nowy2;
                    break;

                case 6:
                    romans.autor.nazwisko = nowy;
                    break;
            }
        }

        public static void usunRomans(string t, string n)
        {
            for (int i = 0; i < iloscRomansow;)
            {
                if (listaRomansow[i].tytul == t && listaRomansow[i].autor.nazwisko == n)
                {
                    listaRomansow.RemoveAt(i);
                    iloscRomansow--;
                    iloscWszystkichKsiazek--;
                    break;
                }
                else ++i;
            }
        }
    }
}
