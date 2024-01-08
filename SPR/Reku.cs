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
            // 1.
            int suma1 = 0;
            for (int i = 1; i < 8; i++)
                suma1 += Reku1(1);
            Console.WriteLine(suma1);
            Console.WriteLine(Reku1(10));
            int Reku1(int n)
            {
                if (n == 1) return -5;
                if (n == 2) return 2;
                if (n == 3) return 4;
                return Reku1(n - 3) * 2 + (Reku1(n - 2) + Reku1(n - 1));
            }

            // 2.
            Console.WriteLine(NWDmod(12, 20));
            int NWDmod(int a, int b)
            {
                if (b <= 0) return a;
                return NWDmod(b, a % b);
            }
            Console.WriteLine();

            int suma = 0;
            for (int i = 0; i < 7; i++)
                suma += Fibo(i);
            Console.WriteLine(suma);
            Console.WriteLine();
            Console.WriteLine(Fibo(11));
            int Fibo(int n)
            {
                if (n == 0) return 1;
                if (n == 1) return 1;
                return Fibo(n - 2) + Fibo(n - 1);
            }

            // 3.
            string napis = "kar";
            Console.WriteLine(Reku3(napis, napis.Length));
            string Reku3(string tekst, int l)
            {
                if (l == 0) return tekst;
                for (int i = 0; i < l; i++)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
