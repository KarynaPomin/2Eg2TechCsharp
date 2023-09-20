//Przed diagnozą

// Algorytmy:

// 1) Napisz i przetestuj algorytm Euklidesa odejmowanie.

int EuklidesOdejmowanie(int a, int b)
{
    while (a != b)
    {
        if (a > b) a -= b;
        if (b > a) b -= a;
    }
    return a;
}

int x1, y1;
Console.Write("X: ");
x1 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
y1 = int.Parse(Console.ReadLine());
Console.WriteLine(EuklidesOdejmowanie(x1, y1));

// 2) Napisz i przetestuj algorytm Euklidesa modulo.
int EuklidesModulo(int a, int b)
{
    int pom;
    while (b > 0)
    {
        pom = b;
        b = a % b;
        a = pom;
    }
    return a;
}

int x2, y2;
Console.Write("X: ");
x2 = int.Parse(Console.ReadLine());
Console.Write("Y: ");
y2 = int.Parse(Console.ReadLine());
Console.WriteLine(EuklidesModulo(x2, y2));

// 3) Napisz i przetestój algorytm sortowania bombelkowego na tablicy.
void SortBambelkowe(int[] T)
{
    int n = T.Length;
    int pom;
    for (int i = n - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (T[j] > T[j + 1])
            {
                pom = T[j];
                T[j] = T[j + 1];
                T[j + 1] = pom;
            }
        }
    }
}

Random r = new Random();
int n = 20;
int[] T = new int[20];
for (int i = 0; i < n; i++)
    T[i] = r.Next(1, 100);
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
Console.WriteLine("\n");
SortBambelkowe(T);
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");

// 4) Wypisz wszystkie pary liczb zaprzyjaźnionych z przedziłu 1-10.000.

int sumaDzielnikowWlasciwych(int n)
{
    int suma = 0;
    for (int i = 1; i < n/2; i++)
    {
        if (n % i == 0)
            suma += i;
    }
    return suma;
}

int pom;
for (int i = 0; i <= 10000; i++)
{
    pom = sumaDzielnikowWlasciwych(i);
    if (i == sumaDzielnikowWlasciwych(pom) && i != pom)
        Console.WriteLine(i + " " + pom);
}

// 5) Listy - Tablice - w tablicy 30 losowych liczb trzycyfrowych.
// Znajdź ilość wielokrotności liczby 17 (zapisz te liczby do listy wynikowej)

using System.Collections;

Random r = new Random();
int n = 30;
int[] T = new int[n];
for (int i = 0; i < n; i++)
    T[i] = r.Next(100, 1000);
for (int i = 0; i < n; i++)
    Console.Write(T[i] + " ");
Console.WriteLine("\n");
List<int> list = new List<int>();
//ArrayList al = new ArrayList();
foreach (var t in T)
    if (t % 17 == 0) list.Add(t);
foreach (var l in list)
    Console.Write(l + " ");

// 6) Macierz - wypisz sumy kolejnych ramek w macierzy kwadratowej o n parzystych.

using System.Collections;

Random r = new Random();
int n = 8;
int[,] M = new int[n, n];

for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        M[i, j] = r.Next(1, 10);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(M[i, j] + " ");
    Console.WriteLine();
}


// Sposób 1 - prze sumy podmacierzy

List<int> S = new List<int>(); // tablica sum
int suma;
for (int i = 1; i <= n / 2; i++)
{
    suma = 0;
    for (int j = n/2 - i; j < n/2 + i; j++)
    {
        for (int k = n / 2 - i; k < n / 2 + i; k++)
            suma += M[j, k];
    }
    S.Add(suma);
}

Console.WriteLine("\n");
foreach (var s in S)
    Console.WriteLine(s);

// Nie działa - sprawdz

int[] T = S.ToArray();
Console.WriteLine("\n" + T[0]);
for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i] - T[i - 1]);
}
