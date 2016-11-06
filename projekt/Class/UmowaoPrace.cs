using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class UmowaOprace : Umowy
    {
        private static List<UmowaOprace> listaUmowoPrace = new List<UmowaOprace>();
        private static int iloscUmowoPrace;

        public UmowaOprace()
            : base()
        { }

        public UmowaOprace(Autor autor, int iloscMiesiecy, float pensja)
            : base(autor, iloscMiesiecy, pensja)
        { }


        public static void dodajUmoweoPrace(Autor autor, int iloscMiesiecy, float pensja)
        {
            UmowaOprace uop = new UmowaOprace(autor, iloscMiesiecy, pensja);
            listaUmowoPrace.Add(uop);
            iloscUmowoPrace++;
            //  iloscWszystkichUmow++;
        }

        public static void wypiszUmoweoPrace()
        {
            UmowaOprace.wypiszUmoweoPrace();
            foreach (UmowaOprace umowaOprace in UmowaOprace.listaUmowoPrace)
                Console.WriteLine("\n Autor: Imie:" + umowaOprace.autor.imie + " Nazwisko: " + umowaOprace.autor.nazwisko +
                    "Ilosc miesiecy: " + umowaOprace.iloscMiesiecy + " Pensja: " + umowaOprace.pensja);
        }

        public static UmowaOprace wyszukajUmoweoPrace(string imie, string nazwisko)
        {
            UmowaOprace umowa = null;
            for (int i = 0; i < UmowaOprace.iloscUmowoPrace;)

                if (UmowaOprace.listaUmowoPrace[i].autor.imie == imie && UmowaOprace.listaUmowoPrace[i].autor.nazwisko == nazwisko)
                    umowa = listaUmowoPrace[i];
            return umowa;
        }

        public static void edytujUmoweoPrace(string imie, string nazwisko,
            int wybor, string noweimie, string nowe)
        {
            int nowe1; float nowe2;
            UmowaOprace umowa = wyszukajUmoweoPrace(imie, nazwisko);

            if (umowa.autor.imie == imie && umowa.autor.nazwisko == nazwisko)
            {
                switch (wybor)
                {
                    case 1:
                        umowa.autor.imie = noweimie;
                        break;

                    case 2:
                        nowe1 = Convert.ToInt32(nowe);
                        umowa.iloscMiesiecy = nowe1;
                        break;

                    case 3:
                        nowe2 = Convert.ToSingle(nowe);
                        umowa.pensja = nowe2;
                        break;
                }
            }
        }

        public static void usunUmoweoPrace(string n)
        {
            for (int i = 0; i < iloscUmowoPrace;)
            {
                if (listaUmowoPrace[i].autor.nazwisko == n)
                {
                    listaUmowoPrace.RemoveAt(i);
                    iloscUmowoPrace--;
                    //   iloscWszystkichUmow--;
                    break;
                }
                else ++i;
            }
        }
    }

}
