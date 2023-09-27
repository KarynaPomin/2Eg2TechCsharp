// emmet abriviators - skróty

// HORNER 
Console.Write("System: ");
int system = int.Parse(Console.ReadLine());
Console.Write("Liczba: ");
string a = Console.ReadLine();

// int wynik = (int)a[0] - 48; -- zamiast tego jest inne sposób -> (int)char.GetNumericValue(a[0])
int wynik = 0;
int liczba;

for (int i = 0; i < a.Length; i++)
    wynik = system * wynik + (int)char.GetNumericValue(a[i]);

Console.WriteLine(wynik);

// KONWERSJA BIN -> DEC oraz DEC -> BIN

Console.Write("BIN: ");
string l_bin = Console.ReadLine();
int wynik_1 = 0;
string wynik_bin = "";

for (int i = l_bin.Length - 1; i >= 0; i--)
{
    wynik_1 = wynik_1 + (l_bin[i] - 48) * (int) Math.Pow(2, l_bin.Length - i - 1);
}
Console.WriteLine(wynik_1);

while (wynik_1 > 0)
{
    wynik_bin += wynik_1 % 2;
    wynik_1 /= 2;
}
Console.WriteLine(wynik_bin);


// Sposób rekurencja
void d2p(int p)
{
    if (p == 0) return;
    d2p(p / 2);
    Console.Write(p % 2);
}

d2p(11);
