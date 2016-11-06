using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Sensacyjna : Ksiazka
    {
        private static List<Sensacyjna> listaSensacyjna = new List<Sensacyjna>();
        private static int iloscSensacyjnych;

        public Sensacyjna()
            : base()
        { }

        public Sensacyjna(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
            : base(tytul, rokWydania, iloscStron, cena, autor)
        { }

        public static void dodajSensacyjna(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
        {
            Sensacyjna s = new Sensacyjna(tytul, rokWydania, iloscStron, cena, autor);
            listaSensacyjna.Add(s);
            iloscSensacyjnych++;
            iloscWszystkichKsiazek++;
        }

        public static void wypiszSensacyjna()
        {
            foreach (Sensacyjna sensacyjna in Sensacyjna.listaSensacyjna)
                Console.WriteLine(" Tytul: " + sensacyjna.tytul + " Rok wydania: " +
                  sensacyjna.rokWydania + " Ilosc stron: " + sensacyjna.iloscStron + " Cena: "
                  + sensacyjna.cena + " Autor: Imie: " + sensacyjna.autor.imie + " Nazwisko: " + sensacyjna.autor.nazwisko);
        }

        public static Sensacyjna wyszukajSensacyjna(string tytul, string nazwisko)
        {
            Sensacyjna sensacyjna = null;
            for (int i = 0; i < iloscSensacyjnych;)

                if (listaSensacyjna[i].tytul == tytul && listaSensacyjna[i].autor.nazwisko == nazwisko)
                    sensacyjna = listaSensacyjna[i];
            return sensacyjna;
        }

        public static void edytujSensacyjna(string tytul, string nazwisko,
            int wybor, int a, string nowy)
        {
            int nowy1; float nowy2;
            Sensacyjna sensacyjna = wyszukajSensacyjna(tytul, nazwisko);

            switch (wybor)
            {
                case 1:
                    sensacyjna.tytul = nowy;
                    break;

                case 2:
                    sensacyjna.autor.imie = nowy;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    sensacyjna.rokWydania = nowy1;
                    break;

                case 4:
                    nowy1 = Convert.ToInt32(nowy);
                    sensacyjna.iloscStron = nowy1;
                    break;

                case 5:
                    nowy2 = Convert.ToSingle(nowy);
                    sensacyjna.cena = nowy2;
                    break;

                case 6:
                    sensacyjna.autor.nazwisko = nowy;
                    break;
            }
        }

        public static void usunSensacyjna(string t, string n)
        {
            for (int i = 0; i < iloscSensacyjnych;)
            {
                if (listaSensacyjna[i].tytul == t && listaSensacyjna[i].autor.nazwisko == n)
                {
                    listaSensacyjna.RemoveAt(i);
                    iloscWszystkichKsiazek--;
                    iloscSensacyjnych--;
                    break;
                }
                else ++i;
            }
        }
    }

}
