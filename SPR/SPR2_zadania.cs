using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaPrzeSPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1.
            // Wpisz do tablicy T 5 losowych liczb dwucyfrowych.
            // Stwórz tablicę W liczb parzystych znajdujących się między
            // minimalną a maksymalną wartością z tablicy T.

            Console.WriteLine("Zadanie 1");
            Console.WriteLine();

            int[] T = new int[5];
            Random rand = new Random();
            for (int i = 0; i < T.Length; i++) 
                T[i] = rand.Next(10, 100);

            int min = T.Min();
            int maks = T.Max();

            int[] W = new int[(maks - min) / 2 + 1];
            int j = 0;
            for (int i = min; i < maks + 1; i++)
            {
                if (i % 2 == 0)
                {
                    W[j] = i;
                    j++;
                }
            }

            foreach (var item in W)
                Console.Write(item + " ");
            Console.WriteLine("\n\n\n");

            // Zadanie 2.
            // Utwórz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
            // Wypisz słowo o najwiekszej sumie kodów ASCII jego liter

            Console.WriteLine("Zadanie 2");
            Console.WriteLine();

            ArrayList A = new ArrayList();
            List<int> Amax = new List<int>();
            
            string s;
            int suma;
            int r;

            for (int i = 0; i < 10; i++)
            {
                suma = 0;
                s = "";
                for (int k = 0; k < 3; k++)
                {
                    r = rand.Next(65, 91);
                    s += (char)r;
                    suma += r;
                }
                Amax.Add(suma);
                A.Add(s);
            }

            for (int i = 0; i < A.Count; i++)
                Console.WriteLine(A[i] + " --> " + Amax[i]);

            // sposób II
            // char[] Litery = new char[3];
            // for (int i = 0; i < 10; i++)
            // {
            //      litery[0] = (char)r.Next(65, 91);
            //      litery[1] = (char)r.Next(65, 91);
            //      litery[3] = (char)r.Next(65, 91);
            // }

            Console.WriteLine($"Największe to slowo: {A[Amax.IndexOf(Amax.Max())]} ma sumę {Amax.Max()}");
            Console.WriteLine("\n\n\n");

            // Zadanie 3.
            // Stwórz listę L składającą się z 10 list 10 losowych cyfr.
            // Oblicz sumę największych cyfr w listach listy L oraz
            // sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.

            Console.WriteLine("Zadanie 3");

            List<List<int>> L = new List<List<int>>();
            for (int i = 0;i < 10; i++)
            {
                L.Add(new List<int>());
                for (int k = 0; k < 10; k++)
                    L[i].Add(rand.Next(0, 10));
            }

            int sumaList = 0;
            foreach (var list in L)
                sumaList += list.Max();

            Console.WriteLine($"Suma największych cyfr z list wyniosi: {sumaList}");
            Console.WriteLine("\n\n\ns");

            // Zadanie 4.
            // Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami 
            // maksmalnie i-cyfrowych dzielników liczby 10 do potęgi i dla każdego z kluczy.

            Console.WriteLine("Zadanie 4");

            //int n = 5;
            //Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();
            //for (int i = 1; i < n + 1; i++)
            //{
            //    List<int> listD = new List<int>();
            //    int x = 0;
            //    int liczbaP = (int)Math.Pow(10, i - 1);
            //    while (x > liczbaP)
            //    {
            //        if ()
            //    }

            //    D.Add(i, listD);
            //}

            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<int>> D = new();

            List<int> TL;
            for (int i = 1; i <= n; i++)
            {
                TL = new();
                for (int j = 1; j < Math.Pow(10, i - 1); j++)
                {
                    if (Math.Pow(10, i) % j == 0)
                    {
                        TL.Add(j);
                    }
                }
                D.Add(i, TL);
            }
            foreach (var item in D)
            {
                Console.Write(item.Key + " => ");
                foreach (var item1 in item.Value)
                    Console.Write(item1 + " ");
                Console.WriteLine();
            }

            // Zadanie 5.
            // Korzystając ze słownika utwórz graf G zbudowany z n wierzchołków i k krawędzi.
            // Policz wierzchołki nie mające żadnych sąsiadów.

            Console.ReadKey();
        }
    }
}
