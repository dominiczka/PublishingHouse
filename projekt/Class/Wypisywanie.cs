using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Wypisywanie
    {
        public static void wypiszKsiazke(int a)
        {
            switch (a)
            {
                case 1:
                    Album.wypiszAlbum();
                    if (a == 5) goto case 2;
                    break;

                case 2:
                    Romans.wypiszRomans();
                    if (a == 5) goto case 3;
                    break;

                case 3:
                    Thriller.wypiszThriller();
                    if (a == 5) goto case 4;
                    break;

                case 4:
                    Sensacyjna.wypiszSensacyjna();
                    break;

                case 5:
                    goto case 1;
            }
            Console.ReadKey();
        }

        public static void wypiszCzasopismo(int a)
        {
            switch (a)
            {
                case 1:
                    Tygodnik.wypiszTygodnik();
                    if (a == 3) goto case 2;
                    break;

                case 2:
                    Miesiecznik.wypiszMiesiecznik();
                    break;

                case 3:
                    goto case 1;

                default:
                    break;
            }
            Console.ReadKey();
        }

        public static void wypiszUmowy(int a)
        {
            switch (a)
            {
                case 1:
                    UmowaOprace.wypiszUmoweoPrace();
                    if (a == 3) goto case 2;
                    break;

                case 2:
                    UmowaOdzielo.wypiszUmoweoDzielo();
                    break;

                case 3:
                    goto case 1;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }

}
