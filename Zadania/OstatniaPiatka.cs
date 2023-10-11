//1.Napisz program, który pomnoży dwie macierze losowych liczb. 
//Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
//tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.

Console.Write("Podaj 4 liczby po spacji: ");
string liczby = Console.ReadLine();
string[] L = liczby.Split(" ");
bool flaga = true;

int a = Convert.ToInt32(L[0]);
int b = Convert.ToInt32(L[1]);
int c = Convert.ToInt32(L[2]);
int d = Convert.ToInt32(L[3]);

if (b != c)
{
    Console.WriteLine("Podano niepopawne dane. Proszę aby druga i trzecia liczba byli sobie równe!");
    flaga = false;
}

while (flaga == false)
{
    Console.Write("Podaj ponownie 4 liczby po spacji: ");
    liczby = Console.ReadLine();
    L = liczby.Split(" ");

    a = Convert.ToInt32(L[0]);
    b = Convert.ToInt32(L[1]);
    c = Convert.ToInt32(L[2]);
    d = Convert.ToInt32(L[3]);

    if (b != c)
    {
        Console.WriteLine("Podano niepopawne dane. Proszę aby druga i trzecia liczba byli sobie równe!");
        flaga = false;
    }
    else
        flaga = true;
}

int[,] P = new int[a, b];
int[,] D = new int[c, d];
int[,] MACIERZ = new int[a, d];
Random r = new Random();

// Pierwsza macierz
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        P[i, j] = r.Next(1, 10);
        Console.Write(P[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Druga macierz
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < d; j++)
    {
        D[i, j] = r.Next(1, 10);
        Console.Write(D[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Mnożenie macierzy

int wynik = 0;

for (int i = 0; i < a; i++)
{
    for (int k = 0; k < d; k++)
    {
        for (int j = 0; j < b; j++)
        {                   
            wynik += P[i, j] * D[j, k];
        }
        MACIERZ[i, k] = wynik;
        wynik = 0;
    }
}

// Wymnożona macierz
for (int i = 0; i < MACIERZ.GetLength(0); i++)
{
    for (int j = 0; j < MACIERZ.GetLength(1); j++)
    {
        Console.Write(MACIERZ[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

// POPRAWIĆ ZADANIE!!!
//2. Napisz algorytm, który sprawdzi czy gdzieś w macierzy 10x10 losowych liczb dwucyfrowych
//doszło do sytuacji, że obok siebie są dwie liczby pierwsze.

bool CzyLiczbaPierwsza(int liczba)
{
    bool CzyPierwsza = true;
    for (int i = 2; i < 0.5 * liczba; i++)
    {
        if (liczba % i == 0)
        {          
            CzyPierwsza = false;
            break;
        }
    }

    return CzyPierwsza;
}

int[,] P = new int[10, 10];
List<int> SimilarNumber = new List<int>();
Random rand = new Random();

for (int i = 0; i < P.GetLength(0); i++)
{
    for (int j = 0; j < P.GetLength(1); j++)
    {
        P[i, j] = rand.Next(10, 100);
        Console.Write(P[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 1; i < P.GetLength(0) - 1; i++)
{
    for (int j = 1; j < P.GetLength(1) - 1; j++)
    {
        if ((P[i, j] == P[i - 1, j] || P[i, j] == P[i, j - 1] || P[i, j] == P[i + 1, j] || P[i, j] == P[i, j + 1]) && SimilarNumber.Contains(P[i, j]) == false)
            if (CzyLiczbaPierwsza(P[i, j]) == true)
                SimilarNumber.Add(P[i, j]);
    }
}

if (SimilarNumber.Count == 0)
    Console.WriteLine("Nie ma w macierzy powtarzających się liczb pierwszych.");
else
{
    Console.Write($"Powtarzają się te {SimilarNumber.Count} liczby pierwsze: ");
    foreach (var item in SimilarNumber)
        Console.Write(item + " ");
}

//3. Napisz program, który sprawdzi, czy dwa słowa wpisane przez usera są anagramami

Console.Write("Podaj pierwszy napis: ");
string napis1 = Console.ReadLine();
Console.Write("Podaj drugi napis: ");
string napis2 = Console.ReadLine();

List<int> Pierwszy_napis = new List<int>();
List<int> Drugi_napis = new List<int>();

foreach (var pierwsza in napis1)
    Pierwszy_napis.Add((int)pierwsza);
foreach (var druga in napis2)
    Drugi_napis.Add((int)druga);

Pierwszy_napis.Sort();
Drugi_napis.Sort();

bool flaga = false;
if (Pierwszy_napis.Count == Drugi_napis.Count)
{
    for (int i = 0; i < Pierwszy_napis.Count; i++)
    {
        if (Pierwszy_napis[i] != Drugi_napis[i])
        {
            flaga = false;
            break;
        }
        else flaga = true;
    }
}
if (flaga == true)
    Console.WriteLine("Zgadza się. Dwa podanych nopisy są anagramami.");
else
    Console.WriteLine("Podane napisy nie są anagramami.");

//4. Napisz program, który znajdzie w podanej n-elementowej tablicy najdłuższy spójny podciąg niemalejący
//oraz obliczy jego długość i sumę jego elementów

//5. Wygeneruj macierz n x n z losowymi cyframi. Znajdź sumę tych elementów tej macierzy,
//które należą do którejkolwiek osi symetrii.
