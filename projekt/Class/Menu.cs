using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{

    class Menu
    {
        public static int start()
        {
            Console.WriteLine("Witaj w Wydawnictwie ePress!");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Dodawanie.");
                Console.WriteLine("2. Wyswietlanie.");
                Console.WriteLine("3. Edycja.");
                Console.WriteLine("4. Usuwanie.");

                int wybor;
                wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        dodawanie();
                        break;
                    case 2:
                        wyswietlanie();
                        break;
                    case 3:
                        edycja();
                        break;
                    case 4:
                        usuwanie();
                        break;

                    default:
                        return 0;
                }
            }
        }


        public static void edycja()
        {
            Console.WriteLine("Opcje edytowania:");
            Console.WriteLine("1. Edytuj ksiazke.");
            Console.WriteLine("2. Edytuj czasopismo.");
            Console.WriteLine("3. Edytuj autora.");
            Console.WriteLine("4. Edytuj umowe.");
            int wybor; int wybor1;
            wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Podaj typ ksiazki:");
                    Console.WriteLine("1. Album.");
                    Console.WriteLine("2. Romans.");
                    Console.WriteLine("3. Thriller.");
                    Console.WriteLine("4. Sensacyjna.");

                    wybor1 = int.Parse(Console.ReadLine());
                    Edycja.edytujKsiazke(wybor1);
                    break;

                case 2:
                    Console.WriteLine("Podaj typ Czasopisma:");
                    Console.WriteLine("1. Tygodnik.");
                    Console.WriteLine("2. Miesiecznik.");

                    wybor1 = int.Parse(Console.ReadLine());
                    Edycja.edytujCzasopismo(wybor1);
                    break;

                case 3:
                    Edycja.edytujAutora();
                    break;

                case 4:
                    Console.WriteLine("Podaj typ umowy:");
                    Console.WriteLine("1. Umowa o prace.");
                    Console.WriteLine("2. Umowa o dzielo.");

                    wybor1 = int.Parse(Console.ReadLine());
                    Edycja.edytujUmowe(wybor1);
                    break;
            }
        }

        public static void usuwanie()
        {
            Console.WriteLine("Opcje usuwania:");
            Console.WriteLine("1. Usun ksiazke.");
            Console.WriteLine("2. Usun czasopismo.");
            Console.WriteLine("3. Usun autora.");
            Console.WriteLine("4. Usun umowe.");
            int wybor;
            wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Glowna.usunKsiazke();
                    break;

                case 2:
                    Glowna.usunCzasopismo();
                    break;

                case 3:
                    Usuwanie.usunAutora();
                    break;

                case 4:
                    Glowna.usunUmowe();
                    break;

                default:
                    break;
            }
        }

        public static void wyswietlanie()
        {
            Console.Clear();
            Console.WriteLine("Opcje wyswietlania:");
            Console.WriteLine("1. Wyswietl ksiazke.");
            Console.WriteLine("2. Wyswietl czasopismo.");
            Console.WriteLine("3. Wyswietl autora.");
            Console.WriteLine("4. Wyswietl umowe.");

            int wybor;
            wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Podaj typ ksiazki:");
                    Console.WriteLine("1. Album.");
                    Console.WriteLine("2. Romans.");
                    Console.WriteLine("3. Thriller.");
                    Console.WriteLine("4. Sensacyjna.");
                    Console.WriteLine("5. Wszystkie ksiazki.");

                    int wybork;
                    wybork = int.Parse(Console.ReadLine());

                    Wypisywanie.wypiszKsiazke(wybork);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Podaj typ czasopisma:");
                    Console.WriteLine("1. Tygodnik.");
                    Console.WriteLine("2. Miesiecznik.");
                    Console.WriteLine("3. Wszystkie.");

                    int wyborcz;
                    wyborcz = int.Parse(Console.ReadLine());

                    Wypisywanie.wypiszCzasopismo(wyborcz);
                    break;

                case 3:
                    Autor.wypiszAutorow();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Podaj typ umowy:");
                    Console.WriteLine("1. Umowa o prace.");
                    Console.WriteLine("2. Umowa o dzielo.");
                    Console.WriteLine("3. Wszystkie.");

                    int wyboru;
                    wyboru = int.Parse(Console.ReadLine());

                    Wypisywanie.wypiszUmowy(wyboru);
                    break;

                default:
                    break;
            }
        }

        public static void dodawanie()
        {
            Console.Clear();
            Console.WriteLine("Opcje dodawania:");
            Console.WriteLine("1. Dodaj ksiazke.");
            Console.WriteLine("2. Dodaj czasopismo.");
            Console.WriteLine("3. Dodaj autora.");
            Console.WriteLine("4. Dodaj umowe.");
            int wybor;
            wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Glowna.dodajKsiazke();
                    break;
                case 2:
                    Glowna.dodajCzasopismo();
                    break;
                case 3:
                    Glowna.dodajAutora();
                    break;
                case 4:
                    Glowna.dodajUmowe();
                    break;
                default:
                    break;
            }
        }
    }

}
