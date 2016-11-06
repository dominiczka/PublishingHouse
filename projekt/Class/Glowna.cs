using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    static class Glowna
    {
        public static Autor dodajAutora()
        {
            string imie;
            string nazwisko;
            Console.Clear();
            Console.WriteLine("Podaj imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();

            Autor autor = new Autor(imie, nazwisko);
            Autor.dodaj(imie, nazwisko);
            return autor;
        }

        public static void dodajKsiazke()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ ksiazki:");
            Console.WriteLine("1. Album.");
            Console.WriteLine("2. Romans.");
            Console.WriteLine("3. Thriller.");
            Console.WriteLine("4. Sensacyjna.");

            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Dodawanie.ksiazka(wybor);
        }

        public static void usunKsiazke()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ ksiazki:");
            Console.WriteLine("1. Album.");
            Console.WriteLine("2. Romans.");
            Console.WriteLine("3. Thriller.");
            Console.WriteLine("4. Sensacyjna.");
            Console.WriteLine("5. Usun wszystkie ksiazki.");

            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Usuwanie.usunKsiazke(wybor);
        }

        public static void dodajCzasopismo()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ Czasopisma:");
            Console.WriteLine("1. Miesiecznik.");
            Console.WriteLine("2. Tygodnik.");
            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Dodawanie.czasopismo(wybor);
        }

        public static void usunCzasopismo()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ Czasopisma:");
            Console.WriteLine("1. Miesiecznik.");
            Console.WriteLine("2. Tygodnik.");
            Console.WriteLine("3. Usun wszystkie czasopisma.");

            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Usuwanie.usunCzasopismo(wybor);
        }


        public static void dodajUmowe()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ umowy:");
            Console.WriteLine("1. Umowa o prace.");
            Console.WriteLine("2. Umowa o dzielo.");
            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Dodawanie.umowa(wybor);
        }

        public static void usunUmowe()
        {
            Console.Clear();
            Console.WriteLine("Podaj typ umowy:");
            Console.WriteLine("1. Umowa o prace.");
            Console.WriteLine("2. Umowa o dzielo.");
            Console.WriteLine("3. Usun wszystkie umowy.");
            int wybor;
            wybor = int.Parse(Console.ReadLine());

            Usuwanie.usunUmowe(wybor);
        }
    }

}
