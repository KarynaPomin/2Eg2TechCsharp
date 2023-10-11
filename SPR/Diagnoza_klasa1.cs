
bool CzyPierwsza(int p)
{
	bool czyPierwsza = true;
	for (int i = 2; i < (p / 2) + 1; i++)
	{
		if (p % i == 0)
		{
			czyPierwsza = false;
			break;
		}		
	}

	return czyPierwsza;
}

int NWD(int a, int b)
{
	while(a != b)
	{
		if (a > b)
			a -= b;
		if (b > a)
			b -= a;
	}
	return a;
}


// ZAD. -1

// Sprawdź czy podane jest parą ...
int pierwsza_liczba = int.Parse(Console.ReadLine());
int druga_liczba = int.Parse(Console.ReadLine());

if (CzyPierwsza(NWD(pierwsza_liczba, druga_liczba)) == false)
    Console.WriteLine("Tak.");
else
    Console.WriteLine("Nie.");

// ZAD. 0

for (int i = 20; i < 51; i++)
{
	for (int j = 20; j < 51; j++)
	{
		if (CzyPierwsza(NWD(i, j)) == false)
            Console.WriteLine(i + " " + j);
    }
}

// Sprawdź
// ZAD. 1

int macierz_i = 20;
int macierz_j = 20;

int[,] M = new int[macierz_i + 1, macierz_j + 1];
Random rand = new Random();

// Stworzenie macierzy
for (int i = 0; i < M.GetLength(0); i++)
{
	for (int j = 0; j < M.GetLength(1); j++)
	{
		M[i, j] = rand.Next(0, 10);
		if (i == 0 || j == 0 || i == M.GetLength(0) - 1 || j == M.GetLength(1) - 1)
			M[i, j] = 0;
		else if(M[i, j] >= 0 && M[i, j] <= 4)
			M[i, j] = 0;
		else if (M[i, j] == 6 || M[i, j] <= 5)
			M[i, j] = 1;
		else if (M[i, j] == 7 || M[i, j] == 8)
			M[i, j] = 2;
		else if (M[i, j] == 9)
			M[i, j] = rand.Next(3, 5);
		Console.Write(M[i, j] + " ");
    }
    Console.WriteLine();
}


int srodek;
int suma = 0;
int ile_komorek = 0;

for (int i = 1; i < M.GetLength(0) - 1; i++)
{
	for (int j = 1; j < M.GetLength(1) - 1; j++)
	{
		srodek = M[i, j];
		suma += M[i - 1, j - 1] + M[i, j - 1] + M[i + 1, j - 1] + M[i - 1, j] + M[i + 1, j] + M[i - 1, j + 1] + M[i, j + 1] + M[i + 1, j + 1];
		if (srodek == suma)
			ile_komorek++;
	}
	suma = 0;
}

Console.WriteLine();
Console.WriteLine(ile_komorek);



// ZAD. 2

string KodBuraka = "1 3 4 3 1 1";
string[]  Burak = KodBuraka.Split(" ");
List<int> B = new List<int>();

for (int i = 1; i < Burak.Length; i++)
	B[i] = int.Parse(Burak[i]);


B.Sort();

int lider;
int ile = 0;
for (int i = 0; i < B.Count - 1; i++)
{
	for (int j = 0; j < B.Count - 1; j++)
	{
		if (B[i] == B[i + 1])
		{
			ile++;
		}

	}
}



// ZAD. 4
// Robiłam zadania od pana Nowaka i uczyłam się z innych lekcji zawodowych. A także z internetu.


