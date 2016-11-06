using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Usuwanie
    {
        static public string tytul;
        static public string nazwisko;
        static public int numer;

        public static void usunAutora()
        {
            Autor.wypiszAutorow();
            Console.WriteLine("Podaj nazwisko autora do usuniecia:");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Autor.usunAutora(nazwisko);
        }

        public static void usunCzasopismo(int a)
        {
            Console.WriteLine("Podaj tytul:");
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj numer:");
            numer = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Miesiecznik.usunMiesiecznik(tytul, numer);
                    break;

                case 2:
                    Tygodnik.usunTygodnik(tytul, numer);
                    break;

                default:
                    break;
            }
        }

        public static void usunUmowe(int a)
        {
            Console.WriteLine("Podaj nazwisko autora:");
            nazwisko = Console.ReadLine();

            switch (a)
            {
                case 1:
                    UmowaOprace.usunUmoweoPrace(nazwisko);
                    break;

                case 2:
                    UmowaOdzielo.usunUmoweoDzielo(nazwisko);
                    break;
            }
        }

        public static void usunKsiazke(int a)
        {
            Wypisywanie.wypiszKsiazke(a);
            Console.WriteLine("Podaj tytul:");
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko autora:");
            nazwisko = Console.ReadLine();
            switch (a)
            {
                case 1:
                    Album.usunAlbum(tytul, nazwisko);
                    if (a == 5) goto case 2;
                    break;

                case 2:
                    Romans.usunRomans(tytul, nazwisko);
                    if (a == 5) goto case 3;
                    break;

                case 3:
                    Thriller.usunThriller(tytul, nazwisko);
                    if (a == 5) goto case 4;
                    break;

                case 4:
                    Sensacyjna.usunSensacyjna(tytul, nazwisko);
                    break;

                case 5:
                    goto case 1;
            }
        }
    }

}
