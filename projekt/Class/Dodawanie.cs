using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Dodawanie
    {
        public static void ksiazka(int a)
        {
            int w;
            string tytul; int rokWydania; double iloscStron; float cena; Autor autor = new Autor();

            Console.Clear();
            Console.WriteLine("Podaj tytuł:");
            tytul = Console.ReadLine();

            Console.WriteLine("Podaj rok wydania:");
            rokWydania = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj ilosc stron:");
            iloscStron = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj cene:");
            cena = float.Parse(Console.ReadLine());

            Console.WriteLine("Chcesz dodać nowego autora, czy wybrac z istniejacych?");
            Autor.wypiszAutorow();
            Console.WriteLine("1. Istniejacy");
            Console.WriteLine("2. Dodaj nowego autora.");
            string nazwisko;

            w = int.Parse(Console.ReadLine());

            if (w == 1)
            {
                Autor.wypiszAutorow();
                Console.WriteLine("Podaj nazwisko autora:");
                nazwisko = Console.ReadLine();

                autor = Autor.wyszukajAutora(nazwisko);
            }

            else if (w == 2)
                autor = Glowna.dodajAutora();
            switch (a)
            {
                case 1:
                    Album album = new Album(tytul, rokWydania, iloscStron, cena, autor);
                    Album.dodajAlbum(tytul, rokWydania, iloscStron, cena, autor);
                    break;

                case 2:
                    Romans romans = new Romans(tytul, rokWydania, iloscStron, cena, autor);
                    Romans.dodajRomans(tytul, rokWydania, iloscStron, cena, autor);
                    break;

                case 3:
                    Thriller thriller = new Thriller(tytul, rokWydania, iloscStron, cena, autor);
                    Thriller.dodajThriller(tytul, rokWydania, iloscStron, cena, autor);
                    break;

                case 4:
                    Sensacyjna sensacyjna = new Sensacyjna(tytul, rokWydania, iloscStron, cena, autor);
                    Sensacyjna.dodajSensacyjna(tytul, rokWydania, iloscStron, cena, autor);
                    break;
            }
        }

        public static void umowa(int a)
        {
            Console.Clear();
            Autor autor = null; int iloscMiesiecy; float pensja;
            Console.WriteLine("Wybieranie autora:");
            Console.WriteLine("1. Dodanie nowego.");
            Console.WriteLine("2. Wybor istniejacego.");
            int wybor; string nazwisko;
            wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    autor = Glowna.dodajAutora();
                    break;
                case 2:
                    Autor.wypiszAutorow();
                    Console.WriteLine("Podaj nazwisko autora:");
                    nazwisko = Console.ReadLine();
                    Autor.wyszukajAutora(nazwisko);

                    break;
            }

            Console.WriteLine("Podaj pensje:");
            pensja = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilosc miesiecy:");
            iloscMiesiecy = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    UmowaOprace umowaOprace = new UmowaOprace(autor, iloscMiesiecy, pensja);
                    UmowaOprace.dodajUmoweoPrace(autor, iloscMiesiecy, pensja);
                    break;
                case 2:
                    UmowaOdzielo umowaOdzielo = new UmowaOdzielo(autor, iloscMiesiecy, pensja);
                    UmowaOdzielo.dodajUmoweoDzielo(autor, iloscMiesiecy, pensja);
                    break;
            }
        }

        public static void czasopismo(int a)
        {
            Console.Clear();
            string tytul; float cena; int numer; double iloscStron;
            Console.WriteLine("Podaj tytuł:");
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj cene:");
            cena = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer:");
            numer = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ilosc stron:");
            iloscStron = double.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Miesiecznik miesiecznik = new Miesiecznik(tytul, cena, numer, iloscStron);
                    Miesiecznik.dodajMiesiecznik(tytul, cena, numer, iloscStron);
                    break;

                case 2:
                    Tygodnik tygodnik = new Tygodnik(tytul, cena, numer, iloscStron);
                    Tygodnik.dodajTygodnik(tytul, cena, numer, iloscStron);
                    break;
            }
        }
    }

}
