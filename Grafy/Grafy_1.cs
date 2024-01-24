using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy
{
    class Wierzcholek {

        List<int> Polaczenia = new List<int>();

        // dodajPolaczenia(int w)
        // Powaczenie.Add(w)

        public void DodajPolaczenia(int w)
        {
            Polaczenia.Add(w);
        }

        public void WypiszPolaczenia()
        {
            foreach(int item in Polaczenia)
                Console.Write(item + " ");         
        }

    }

    class Graf
    {

        List<Wierzcholek> Wierzcholki = new List<Wierzcholek>();

        public Graf(int n) // Konstruktor (o tej samej nazwie)
        {
            for (int i = 0; i < n; i++)
            {
                Wierzcholki.Add(new Wierzcholek()); // Opis 2 l.d.
                //Wierzcholek w = new Wierzcholek();
                //Wierzcholki.Add(w); 

            }
        }

        // dodajKrawędź(0,1)
        // dodajKrawędź(0,2)
        // dodajKrawędź(0, [1,2])
        
        public void DodajKrawedz(int w, params int[] polacz) // params --> powoduje rozbijanie listy na elementy dla podanie argumentów do listy
        {
            foreach (var item in polacz)
            {
                Wierzcholki[w].DodajPolaczenia(item);
            }
        }

        public void WypiszKrawedzi(int w)
        {
            Console.WriteLine();
            Console.Write($"Krawęź {w}: ");
            Wierzcholki[w].WypiszPolaczenia();
        }

        //public void WypiszKrawedzie(int w)
        //{
        //    foreach (var item in Wierzcholki[w].WypiszPolaczenia())
        //    {
        //        Console.WriteLine("{0}--{1}", w, item);
        //    }
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // klasa wierzchołek (lista połączeń)
            // klasa graf (lista wierzchołków)

            Graf g = new Graf(6);

            // params 
            g.DodajKrawedz(0, 1, 2 );
            g.DodajKrawedz(1, 0, 3 );
            g.DodajKrawedz(2, 0, 3, 5);
            g.DodajKrawedz(3, 1, 2, 5);
            g.DodajKrawedz(5, 2, 3 );
            // bez params
            //g.DodajKrawedz(0, new int[] { 1, 2 });
            //g.DodajKrawedz(1, new int[] { 0, 3 });

            for (int i = 0; i < 6; i++)
            {
                g.WypiszKrawedzi(i);
            }

            // Wypisz krawędzie, których danny wierzchołek nie ma.

            for (int i = 0; i < 6; i++)
            {
                g.WypiszKrawedzi(i);
            }

            Console.ReadKey();
        }
    }

}
