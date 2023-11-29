// idea rekurencji
// reku utożsamiaj z pętlą
// 3 elem pętli: start, stop, step

/*int reku1(int n)
{
    if (n == 0) return 1;
    return reku1(n-1);
}
Console.WriteLine(reku1(5));*/

//reku1(5) ...... 
//reku1(4)   => 6 * 4
//reku1(3)   => 2 * 3
//reku1(2)   => 1*2
//reku1(1)   => 1*1
//reku1(0)   => 1


/*void reku2(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    reku2(n - 1);
    Console.WriteLine(n);
}

reku2(5);*/

//reku2(5) .....
//reku2(4) .....
//reku2(3) .....
//reku2(2) .....
//reku2(1) .....
//reku2(0) .....

int n = 5;
// Zad 3. Napisz alg sumujący cyfry iter i reku
int s = 0;
for (int i = 0; i < 10; i++)
    s += i;
Console.WriteLine(s);
int r3(int n)
{
    if (n == 0) return 0;
    return r3(n - 1) + n;
}
Console.WriteLine(r3(9));
// r3(9) --> r3(8) + 9 = 45
//.....................++
// r3(3) --> r3(2) + 3 = 5
// r3(2) --> r3(1) + 2 = 3
// r3(1) --> r3(0) + 1 = 1
// r3(0) --> 0

// 4. Napisz alg sumujący liczby dwucyfrowe parzyste iter i reku

int s4 = 0;
for (int i = 0; i < 100; i++)
    s4 += i;
Console.WriteLine(s4);

int r4(int t)
{
    if (t < 10) return 0;
    return r4(t - 2) + t;
}
Console.WriteLine(r4(96));

// 5. Oblicz sumę n pierwszych wyrazów ciągów:
// a) 3, 6, 9, 12, 15, 18, 21 ... <=> 3+6+9+12 = 3(1+2+3+4)

// Sposób 1 od razu policzę sumę rekurencji

int r5a1(int n)
{
    if (n == 1) return 3;
    return r5a1(n - 1) + 3 * n;
}
Console.WriteLine(r5a1(n));

// Sposób 2
int r5a2(int n)
{
    if (n == 1) return 3;
    return r5a2(n - 1) + 3;
}
int s5a2 = 0;
for (int i = 1; i <= n; i++)
{
    s5a2 += r5a2(i);
}
Console.WriteLine(s5a2);

// b) 12, 23, 34, 45, 54 ...

int r5b(int n)
{
    if (n == 1) return 12;
    return r5b(n - 1) + 11;
}

int s5b = 0;
for (int i = 1; i <= n; i++)
    s5b += r5b(i);
Console.WriteLine(s5b);

// c) 2, 6, 18, 54 ...


// d) 1, 2, 4, 9, 16 ...

int r5d(int n)
{
    if (n == 1) return 1;
    return r5d(n - 1) + 2 * (n - 1) + 1;
}

int s5d = 0;
for (int i = 1; i <= n; i++)
    s5d += r5d(i);
Console.WriteLine(s5d);

// 6. Wypisz n pierwszych wyrazów ciągu:

// a) 1,5  1  0,5  -0,5  -2  -4,5  -8,5  -15 

double r6a(int n)
{
    if (n == 1) return 1.5;
    if (n == 2) return 1;
    if (n == 3) return 0.5;
    // przepisaćskrin

}

// b) -2  2,5  3  -5  7,5  -4,5  -0,5  8  -12,5


// c) 0  1  -1  2  -2  3  -3  4  -4

// 7. Inne ciągi kosmiczne - rakieta USA

// 1  3  4   8  15   27

// 4    5    -3    2   14   22    48   

// 1    1    1    3   5   9   

// 2   3    4     -1    -8    -11   -2  

// 1   4    3    16     5     64     7    256   9   1024    
