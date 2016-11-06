using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Autor
    {// nie smiga wyswietlanie autorow
            public string imie;
            public string nazwisko;
            private static int iloscAutorow;
            static private List<Autor> listaAutorow = new List<Autor>();

            public Autor()
            {
                imie = null;
                nazwisko = null;
            }

            public Autor(string imie, string nazwisko)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
            }

            public static Autor wyszukajAutora(string nazwisko)
            {
                Autor autor = null;
                for (int i = 0; i < iloscAutorow;)

                    if (listaAutorow[i].nazwisko == nazwisko)
                        autor = listaAutorow[i];

                return autor;
            }

            public static void edytujAutora(int wybor, string nazwisko, string noweimie, string nowenazwisko)
            {
                Autor autor = wyszukajAutora(nazwisko);
                if (wybor == 1)
                    autor.imie = noweimie;

                else
                    autor.nazwisko = nowenazwisko;
            }

            public static void wypiszAutorow()
            {
                foreach (Autor autor in Autor.listaAutorow)
                    Console.WriteLine(" Imie: " + autor.imie + "  Nazwisko: " + autor.nazwisko);
            }

            public static void dodaj(string imie, string nazwisko)
            {
                Autor a = new Autor(imie, nazwisko);
                listaAutorow.Add(a);
                iloscAutorow++;
            }

            public static void usunAutora(string n)
            {
                Autor autor = wyszukajAutora(n);
                for (int i = 0; i < iloscAutorow;)
                {
                    if (listaAutorow[i].nazwisko == n)
                    {
                        listaAutorow.RemoveAt(i);
                        break;
                    }
                    else ++i;
                }
            }
        }
    }


