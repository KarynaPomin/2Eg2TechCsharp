//1.Napisz program, który pomnoży dwie macierze losowych liczb. 
//Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
//tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.

// !!!np. 5x4 i 4X1

int a = 4;
int b = 5;
int c = 2;
int d = 4;

int[,] P = new int[ a, b];
int[,] D = new int[ c, d];
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

for (int i = 0; i < ; i++)
{

}




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
