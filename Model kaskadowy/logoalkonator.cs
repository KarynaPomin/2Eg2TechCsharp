void OdczytywaniePliku()
{
    // Odczytanie 
    StreamReader sr = new StreamReader(@"C:\Users\Uczen\Desktop\KP_2E\baza.txt");
    int[] T = new int[500];
    while (!sr.EndOfStream)
        Console.WriteLine(sr.ReadLine() + " ");
}

void WczytywanieDoPliku(string tekst)
{
    // Wczytywanie
    string path = @"C:\Users\Uczen\Desktop\KP_2E\baza.txt";
    StreamWriter sw;

    if (!File.Exists(path)) 
    {
        sw = File.CreateText(path);
        Console.WriteLine("Plik został utworzony!");
    }
    else
    {
        sw = new StreamWriter(path, true); 
        Console.WriteLine("Plik został otwarty!");
    }
    // WPISANIE TEKSTU DO PLIKU
    sw.WriteLine(tekst);
    sw.Close();
}

Console.WriteLine("Na początku programu musisz zalogować się do logoalkolatora.");
Console.Write("Podaj swój login: ");
WczytywanieDoPliku(Console.ReadLine());
