// Idea 

for (int i = 1; i <= 5; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");
void re1(int n)
{
    if (n > 6) return;
    Console.Write(n + " ");
    re1(n + 1);
}
void re1_odw(int n)
{
    if (n > 6) return;
    re1_odw(n + 1);
    Console.Write(n + " ");
}

re1(1);
Console.WriteLine();

re1_odw(1);

void re2(int n)
{
    if (n == 0) return;
    Console.Write(n + " ");
    re2(n - 1);
    Console.Write(n + " ");
}
re2(4);
