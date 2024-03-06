using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Kolekcje_2
{
    internal class Program
    {
        // Do zadania 2
        struct Osoba
        {
            public string imie;
            public string nazwisko;
            public int wiek;
        }


        static void Main(string[] args)
        {
            // 1.Stwórzcie tablicę 115 pierwszych liczb,
            // które w repreznetacji binarnej kończą się na 11
            // 11, 111, 1011, 1111, .....

            int[] P = new int[115];
            P[0] = 3;

            for (int i = 1; i < P.Length; i++)
                P[i] = P[i - 1] + 4;

            for (int i = 0; i < P.Length; i++)
                Console.WriteLine(P[i]);


            // 2.Stwórzcie plik o nazwie osoby z zawartością 5 osob:

            // imie; nazwisko; wiek
            // Bartosz; Nowak; 43
            // Paweł; Kowal; 19
            // Krystyna; Zrybnika; 21

            // i wstawcie do tablicy obiekty(struktury) typu osoba
            // z właściwościami / polami z pliku, czyli imie, nazwisko, wiek

            StreamReader sr = new StreamReader(@"C:\T19\Nowak\Kolekcje_2\Kolekcje_2\tekst.txt");
            Osoba[] Osoby = new Osoba[4];
            int licznik = 0;
            string[] line = new string[3];
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Split(';');
                Osoba os;
                os.imie = line[0];
                os.nazwisko = line[1];
                os.wiek = int.Parse(line[2]);
                //Console.WriteLine($"{os.imie} {os.nazwisko} {os.wiek}");
                Osoby[licznik++] = os;
            }
            sr.Close();

            foreach (var item in Osoby)
            {
                Console.WriteLine($"{item.imie} {item.nazwisko} {item.wiek}");
            }


            //3.Stwórz listę 6 losowych słów składających się z 3 różnych samogłsek(List, ArrayList)

            List<char> LS = new List<char> { 'a', 'e', 'i', 'o', 'u', 'y' };
            List<string> S = new List<string>();
            List<char> LSC = new List<char>();

            Random r = new Random();
            string słowo;
            int numer;
            for (int i = 0; i < 6; i++)
            {
                LSC = LS.ToList();
                słowo = "";
                for (int j = 0; j < 3; j++)
                {
                    numer = r.Next(0, LSC.Count);
                    słowo = słowo + LSC[numer];
                    LSC.RemoveAt(numer);
                }
                S.Add(słowo);
            }
            foreach (var item in S)
            {
                Console.Write(item + "\n");
            }

            //4.Stwórz kolejkę(queue) 4 losowych liczb fibonacciego < 100(mogą się powtarzać).
            //Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2

            int fibo(int n)
            {
                if (n == 1) return 1;
                if (n == 2) return 1;
                return fibo(n - 1) + fibo(n - 2);
            }

            ArrayList FIBO = new ArrayList();
            int i = 1;
            while (fibo(i) < 100)
            {
                FIBO.Add(fibo(i));
                i++;
            }

            foreach (var item in FIBO)
                Console.WriteLine(item);

            Random r = new Random();
            Queue q = new Queue();

            for (int j = 0; j < 4; j++)
            {
                q.Enqueue(FIBO[r.Next(FIBO.Count)]);
            }

            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            q.Dequeue();
            q.Dequeue();

            foreach (var item in q)
            {
                Console.Write(item + " ");
            }

            //5.Stwórz stos(stack) 5 kolejnych dwucyfrowych liczb pierwszych.
            //Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.

            int[] T = new int[] { 11, 13, 17, 19, 23 };

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 5; i++)
                stack.Push(T[i]);

            foreach (var item in stack)
                Console.Write(item + " ");
            Console.WriteLine("\n");

            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write(stack.ElementAt(i) + " ");
            }

            stack.Pop();
            stack.Pop();
            stack.Pop();

            foreach (var item in stack)
                Console.Write(item + " ");

            //Przykłady Dictionary


            Dictionary<string, List<int>> D1 = new Dictionary<string, List<int>>();
            
            D1["Bartek"] = new List<int> { 2, 5, 20, 50};
            D1["Radek"] = new List<int> { 10, 20, 50, 100, 200, 500 };
            D1["Andrzej"] = new List<int> { 100, 200 };
            
            foreach (var item in D1)
            {
                Console.Write(item.Key + " ");
            }
            Console.WriteLine("\n");
            
            foreach (var item in D1)
            {
                Console.Write(item.Key + " - ");
                foreach (var item1 in item.Value)
                {
                    Console.Write(item1 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            
            
            Dictionary<int, List<string>> D2 = new Dictionary<int, List<string>>()
                {
                    { 1 , ["styczeń", "luty"] },
                    { 2 , ["maj", "czerwiec", "lipiec"] }
                };*/
            
            // Zad 6
            
            Dictionary<int, List<int>> G = new ();
            
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                G.Add(i + 1, new List<int>());
            }
            
            int k = int.Parse(Console.ReadLine());
            
            string[] liczby = new string[2];
            for (int i = 0; i < k; i++)
            {
                liczby = Console.ReadLine().Split();
                G[int.Parse(liczby[0])].Add(int.Parse(liczby[1]));
                G[int.Parse(liczby[1])].Add(int.Parse(liczby[0]));
            }
            
            foreach (var item in G)
            {
                Console.Write(item.Key + " - ");
                foreach (var item1 in item.Value)
                {
                    Console.Write(item1 + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }    
        
    }
}
