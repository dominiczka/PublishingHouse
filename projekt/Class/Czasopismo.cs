using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Czasopismo
    {
        static protected int iloscWszystkichCzasopism;
        protected string tytul;
        protected float cena;
        protected int numer;
        protected double iloscStron;

        public Czasopismo()
        {
            tytul = null;
            cena = 0;
            numer = 0;
            iloscStron = 0;
        }

        public Czasopismo(string tytul, float cena, int numer, double iloscStron)
        {
            this.tytul = tytul;
            this.cena = cena;
            this.numer = numer;
            this.iloscStron = iloscStron;
        }
    }
}
