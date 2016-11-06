using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    class Album : Ksiazka
    {
        private static List<Album> listaAlbumow = new List<Album>();
        private static int iloscAlbumow;

        public Album()
            : base()
        { }

        public Album(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
            : base(tytul, rokWydania, iloscStron, cena, autor)
        { }

        public static void dodajAlbum(string tytul, int rokWydania, double iloscStron, float cena, Autor autor)
        {
            Album a = new Album(tytul, rokWydania, iloscStron, cena, autor);
            listaAlbumow.Add(a);
            iloscAlbumow++;
            iloscWszystkichKsiazek++;
        }
        public static void wypiszAlbum()
        {
            foreach (Album album in Album.listaAlbumow)
                Console.WriteLine(" Tytul: " + album.tytul + " Rok wydania: " +
                  album.rokWydania + " Ilosc stron: " + album.iloscStron + " Cena: "
                  + album.cena + " Autor: Imie: " + album.autor.imie + " Nazwisko: " + album.autor.nazwisko);
        }

        public static Album wyszukajAlbum(string tytul, string nazwisko)
        {
            Album album = null;
            for (int i = 0; i < iloscAlbumow;)

                if (listaAlbumow[i].tytul == tytul && listaAlbumow[i].autor.nazwisko == nazwisko)
                    album = listaAlbumow[i];
            return album;
        }

        public static void edytujAlbum(string tytul, string nazwisko,
            int wybor, int a, string nowy)
        {
            int nowy1; float nowy2;
            Album album = wyszukajAlbum(tytul, nazwisko);

            switch (wybor)
            {
                case 1:
                    album.tytul = nowy;
                    break;

                case 2:
                    album.autor.imie = nowy;
                    break;

                case 3:
                    nowy1 = Convert.ToInt32(nowy);
                    album.rokWydania = nowy1;
                    break;

                case 4:
                    nowy1 = Convert.ToInt32(nowy);
                    album.iloscStron = nowy1;
                    break;

                case 5:
                    nowy2 = Convert.ToSingle(nowy);
                    album.cena = nowy2;
                    break;

                case 6:
                    album.autor.nazwisko = nowy;
                    break;
            }
        }

        public static void usunAlbum(string t, string n)
        {
            for (int i = 0; i < iloscAlbumow;)
            {
                if (listaAlbumow[i].tytul == t && listaAlbumow[i].autor.nazwisko == n)
                {
                    listaAlbumow.RemoveAt(i);
                    iloscAlbumow--;
                    iloscWszystkichKsiazek--;
                    break;
                }
                else ++i;
            }
        }
    }

}
