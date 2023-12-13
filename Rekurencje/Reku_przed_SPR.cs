using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
            Console.WriteLine("\nZADANIE 1.\n");

            Console.Write("Podaj słowo: ");
            string slowo = Console.ReadLine();

            // INTR.
            Console.WriteLine("Iterakcyjnie: ");
            int sumaASCII = 0;

            for (int i = 0; i < slowo.Length; i++)
            {
                int litera = slowo[i];
                Console.WriteLine(litera);
                sumaASCII += slowo[i];
            }
            Console.WriteLine("Suma wynosi: {0}", sumaASCII);
            Console.WriteLine();

            /// REKU
            
            // M.
            Console.WriteLine("Rekurencyjnie: ");
            Console.WriteLine(reku1(slowo));
            int reku1(string text)
            {
                int suma = 0;
                int n1 = text.Length - 1;
                if (n1 < 0) return suma;
                else
                    suma += text[n1];
                return suma + reku1(text.Remove(text.Length - 1));
            }
            Console.WriteLine();

            // N.

            Console.WriteLine(reku1n(slowo));
            int reku1n(string napis)
            {
                if (napis == "") return 0;
                return reku1n(napis.Substring(1)) + napis[0];
            }

            //2.Napisz iteracyjnie i rekurencyjnie obliczenie x ^ n(x do potęgi n)
            Console.WriteLine("\nZADANIE 2.\n");

            int n2 = 5;

            // INTR.
            Console.WriteLine("Iteracyjnie: ");

            // ...

            // REKU
            Console.WriteLine(reku2(2, 6)); // 64
            int reku2(int x, int n)
            {
                if (n == 0) return 1;
                return reku2(x, n - 1) * x;
            }
            //3.Napisz algorytmy NWD modulo i odejmowanie w wersji reku.

            int eukOdej(int a, int b)
            {
                while (a != b)
                {
                    if (a > b) a -= b;
                    if (b > a) b -= a;
                }
                return a;
            }

            int rekuOdej(int x, int y)
            {
                if (x > y)
                    return rekuOdej(x - y, y);
                if (y > x)
                    return rekuOdej(x, y - x);
                return x; // bez różnicy x czy y
            }

            Console.WriteLine("REKU_3: " + rekuOdej(16, 20));

            // *4. Wypisz retyracyjnie wszystkie ...

            Console.ReadKey();
        }
    }
}
