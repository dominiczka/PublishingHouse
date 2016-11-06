using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Umowy
    {
        protected Autor autor;
        protected int iloscMiesiecy;
        protected float pensja;

        public Umowy()
        {
            autor = null;
            iloscMiesiecy = 0;
            pensja = 0;
        }

        public Umowy(Autor autor, int iloscMiesiecy, float pensja)
        {
            this.autor = autor;
            this.iloscMiesiecy = iloscMiesiecy;
            this.pensja = pensja;
        }
    }

}
