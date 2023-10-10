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


//2. Napisz algorytm, który sprawdzi czy gdzieś w macierzy 10x10 losowych liczb dwucyfrowych
//doszło do sytuacji, że obok siebie są dwie liczby pierwsze.

//NIE DOKOŃCZONE!
//bool CzyPierwsza(int a)
//{
//	bool pierwsza = true;
//	for (int i = 2; i < a; i++)
//	{
//		if (a % i == 0)
//		{
//			pierwsza = false;
//			break;
//		}
//	}
//	if (pierwsza == true)
//		return true;
//	else return false;	
//}

//int[,] M = new int[10, 10];
//List<int> ListaPierwszych = new List<int>();
//Random rand = new Random();

//for (int i = 1; i < 11; i++)
//{
//	for (int j = 1; j < 11; j++)
//	{
//		M[i, j] = rand.Next(10, 100);
//        if (CzyPierwsza(M[i, j]) == true && ((CzyPierwsza(M[i - 1, j]) == true && i - 1 > 0) || (CzyPierwsza(M[i + 1, j]) == true && i + 1 < 11)))
//			ListaPierwszych.Add(M[i, j]);
//		Console.Write(M[i, j] + " ");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine();

//Console.WriteLine($"W macierzy jest {ListaPierwszych.Count}:");
//foreach (var p in ListaPierwszych)
//    Console.WriteLine(p);

//3. Napisz program, który sprawdzi, czy dwa słowa wpisane przez usera są anagramami

//4. Napisz program, który znajdzie w podanej n-elementowej tablicy najdłuższy spójny podciąg niemalejący
//oraz obliczy jego długość i sumę jego elementów

//5. Wygeneruj macierz n x n z losowymi cyframi. Znajdź sumę tych elementów tej macierzy,
//które należą do którejkolwiek osi symetrii.
