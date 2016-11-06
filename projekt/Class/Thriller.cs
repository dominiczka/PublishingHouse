using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{

    class Thriller : Ksiazka
    {
        public Thriller()
            : base()
        { }

        public Thriller(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
            : base(tytul, rokWydania, iloscStron, cena, autor)
        { }

        private static List<Thriller> listaThrillerow = new List<Thriller>();
        private static int iloscThrillerow;

        public static void dodajThriller(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
        {
            Thriller t = new Thriller(tytul, rokWydania, iloscStron, cena, autor);
            listaThrillerow.Add(t);
            iloscThrillerow++;
            iloscWszystkichKsiazek++;
        }

        public static void wypiszThriller()
        {
            foreach (Thriller thriller in Thriller.listaThrillerow)
                Console.WriteLine(" Tytul: " + thriller.tytul + " Rok wydania: " +
                  thriller.rokWydania + " Ilosc stron: " + thriller.iloscStron + " Cena: "
                  + thriller.cena + " Autor: Imie: " + thriller.autor.imie + " Nazwisko: " + thriller.autor.nazwisko);
        }

        public static Thriller wyszukajThriller(string tytul, string nazwisko)
        {
            Thriller thriller = null;
            for (int i = 0; i < iloscThrillerow;)

                if (listaThrillerow[i].tytul == tytul && listaThrillerow[i].autor.nazwisko == nazwisko)
                    thriller = listaThrillerow[i];
            return thriller;
        }

        public static void edytujThriller(string tytul, string nazwisko,
            int wybor, int a, string nowy)
        {
            int nowy1; float nowy2;
            Thriller thriller = wyszukajThriller(tytul, nazwisko);

            switch (wybor)
            {
                case 1:
                    thriller.tytul = nowy;
                    break;

                case 2:
                    thriller.autor.imie = nowy;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    thriller.rokWydania = nowy1;
                    break;

                case 4:
                    nowy1 = Convert.ToInt32(nowy);
                    thriller.iloscStron = nowy1;
                    break;

                case 5:
                    nowy2 = Convert.ToSingle(nowy);
                    thriller.cena = nowy2;
                    break;

                case 6:
                    thriller.autor.nazwisko = nowy;
                    break;
            }
        }

        public static void usunThriller(string t, string n)
        {
            for (int i = 0; i < iloscThrillerow;)
            {
                if (listaThrillerow[i].tytul == t && listaThrillerow[i].autor.nazwisko == n)
                {
                    listaThrillerow.RemoveAt(i);
                    iloscThrillerow--;
                    iloscWszystkichKsiazek--;
                    break;
                }
                else ++i;
            }
        }
    }

}
