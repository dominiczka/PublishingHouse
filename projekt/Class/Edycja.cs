using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Edycja
    {
        public static void edytujUmowe(int a)
        {
            Wypisywanie.wypiszUmowy(a);
            Console.WriteLine("Podaj nazwisko autora, ktorego umowe chcesz edytowac:");
            string nazwisko; string imie;
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj imie autora:");
            imie = Console.ReadLine();

            Console.WriteLine("Ktora z danych chcesz edytowac?");
            int wybor;

            Console.WriteLine("1. Autor.");
            Console.WriteLine("2. Ilosc miesiecy.");
            Console.WriteLine("3. Pensja.");
            wybor = int.Parse(Console.ReadLine());

            string noweimie = null;
            string nowenazwisko = null;
            string nowe = null;

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj nowe nazwisko:");
                    nowenazwisko = Console.ReadLine();
                    Console.WriteLine("Podaj nowe imie:");
                    noweimie = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Podaj ilosc miesiecy:");
                    nowe = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Podaj pensje:");
                    nowe = Console.ReadLine();
                    break;
            }

            switch (a)
            {
                case 1:
                    UmowaOprace.edytujUmoweoPrace(imie, nazwisko, wybor, noweimie, nowe);
                    break;

                case 2:
                    UmowaOdzielo.edytujUmoweoDzielo(imie, nazwisko, wybor, noweimie, nowe);
                    break;
            }
        }

        public static void edytujCzasopismo(int a)
        {
            Wypisywanie.wypiszCzasopismo(a);
            Console.WriteLine("Podaj tytul czasopisma, ktore chcesz edytowac:");
            string tytul;
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj numer czasopisma:");
            int numer;
            numer = int.Parse(Console.ReadLine());
            Console.WriteLine("Ktora z danych chcesz edytowac?");
            int wybor;
            Console.WriteLine("1. Tytul.");
            Console.WriteLine("2. Numer.");
            Console.WriteLine("3. Ilosc stron.");
            Console.WriteLine("4. Cena.");
            wybor = int.Parse(Console.ReadLine());
            string nowy;

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj nowy tytul:");
                    break;

                case 2:
                    Console.WriteLine("Podaj nowy numer:");
                    break;

                case 3:
                    Console.WriteLine("Podaj ilosc stron:");
                    break;

                case 4:
                    Console.WriteLine("Podaj nowa cene:");
                    break;
            }

            nowy = Console.ReadLine();

            switch (a)
            {
                case 1:
                    Tygodnik.edytujTygodnik(tytul, numer, wybor, nowy);
                    break;

                case 2:
                    Miesiecznik.edytujMiesiecznik(tytul, numer, wybor, nowy);
                    break;
            }
        }

        public static void edytujAutora()
        {
            Autor.wypiszAutorow();
            Console.WriteLine("Podaj nazwisko autora ktorego chcesz edytowac:");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Console.WriteLine("Dane do edycji:");
            Console.WriteLine("1. Imie.");
            Console.WriteLine("2. Nazwisko.");

            int wybor;
            string noweimie = null;
            string nowenazwisko = null;

            wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
            {
                Console.WriteLine("Podaj nowe imie:");
                noweimie = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Podaj nowe nazwisko:");
                nowenazwisko = Console.ReadLine();
            }
            Autor.edytujAutora(wybor, nazwisko, noweimie, nowenazwisko);
        }

        public static void edytujKsiazke(int a)
        {
            Wypisywanie.wypiszKsiazke(a);
            Console.WriteLine("Podaj tytul ksiazki, ktora chcesz edytowac:");
            string tytul;
            tytul = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko autora:");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Console.WriteLine("Ktora z danych chcesz edytowac?");
            int wybor;
            Console.WriteLine("1. Tytul.");
            Console.WriteLine("2. Autor.");
            Console.WriteLine("3. Rok wydania.");
            Console.WriteLine("4. Ilosc stron.");
            Console.WriteLine("5. Cena.");
            wybor = int.Parse(Console.ReadLine());
            string nowy;

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj nowy tytul:");
                    break;

                case 2:
                    Console.WriteLine("1. Edycja imienia.");
                    Console.WriteLine("2. Edycja nazwiska.");
                    int wybor2;
                    wybor2 = int.Parse(Console.ReadLine());
                    if (wybor2 == 2)
                        wybor = 6;
                    break;

                case 3:
                    Console.WriteLine("Podaj nowy rok wydania:");
                    break;

                case 4:
                    Console.WriteLine("Podaj ilosc stron:");
                    break;

                case 5:
                    Console.WriteLine("Podaj nowa cene:");
                    break;
            }

            nowy = Console.ReadLine();

            switch (a)
            {
                case 1:
                    Album.edytujAlbum(tytul, nazwisko, wybor, a, nowy);
                    break;

                case 2:
                    Romans.edytujRomans(tytul, nazwisko, wybor, a, nowy);
                    break;

                case 3:
                    Thriller.edytujThriller(tytul, nazwisko, wybor, a, nowy);
                    break;

                case 4:
                    Sensacyjna.edytujSensacyjna(tytul, nazwisko, wybor, a, nowy);
                    break;
            }
        }
    }

}
