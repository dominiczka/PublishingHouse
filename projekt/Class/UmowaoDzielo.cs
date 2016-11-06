using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class UmowaOdzielo : Umowy
    {
        static protected int iloscWszystkichUmow;
        private static List<UmowaOdzielo> listaUmowoDzielo = new List<UmowaOdzielo>();
        private static int iloscUmowoDzielo;

        public UmowaOdzielo()
            : base()
        { }

        public UmowaOdzielo(Autor autor, int iloscMiesiecy, float pensja)
            : base(autor, iloscMiesiecy, pensja)
        { }

        public static void dodajUmoweoDzielo(Autor autor, int iloscMiesiecy, float pensja)
        {
            UmowaOdzielo uod = new UmowaOdzielo(autor, iloscMiesiecy, pensja);
            listaUmowoDzielo.Add(uod);
            iloscUmowoDzielo++;
            iloscWszystkichUmow++;
        }

        public static void wypiszUmoweoDzielo()
        {
            foreach (UmowaOdzielo umowaOdzielo in UmowaOdzielo.listaUmowoDzielo)
                Console.WriteLine("\n Autor: Imie:" + umowaOdzielo.autor.imie + " Nazwisko: " + umowaOdzielo.autor.nazwisko +
                    "Ilosc miesiecy: " + umowaOdzielo.iloscMiesiecy + " Pensja: " + umowaOdzielo.pensja);
        }

        public static UmowaOdzielo wyszukajUmoweoDzielo(string imie, string nazwisko)
        {
            UmowaOdzielo umowa = null;
            for (int i = 0; i < UmowaOdzielo.iloscUmowoDzielo;)

                if (UmowaOdzielo.listaUmowoDzielo[i].autor.imie == imie && UmowaOdzielo.listaUmowoDzielo[i].autor.nazwisko == nazwisko)
                    umowa = listaUmowoDzielo[i];
            return umowa;
        }

        public static void edytujUmoweoDzielo(string imie, string nazwisko,
            int wybor, string noweimie, string nowe)
        {
            int nowe1; float nowe2;
            UmowaOdzielo umowa = wyszukajUmoweoDzielo(imie, nazwisko);

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

        public static void usunUmoweoDzielo(string n)
        {
            for (int i = 0; i < iloscUmowoDzielo;)
            {
                if (listaUmowoDzielo[i].autor.nazwisko == n)
                {
                    listaUmowoDzielo.RemoveAt(i);
                    iloscUmowoDzielo--;
                    iloscWszystkichUmow--;
                    break;
                }
                else ++i;
            }
        }
    }

}
