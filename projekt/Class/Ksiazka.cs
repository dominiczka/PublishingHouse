using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Ksiazka
    {
        static protected int iloscWszystkichKsiazek;
        protected string tytul;
        protected Autor autor;
        protected int rokWydania;
        protected double iloscStron;
        protected float cena;

        public Ksiazka()
        {
            tytul = null;
            autor = null;
            rokWydania = 0;
            iloscStron = 0;
            cena = 0;
        }

        public Ksiazka(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.rokWydania = rokWydania;
            this.iloscStron = iloscStron;
            this.cena = cena;
        }
    }
}
