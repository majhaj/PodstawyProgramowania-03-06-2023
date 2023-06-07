//Zadanie 4

Console.WriteLine("Podaj liczbę a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj liczbę b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj liczbę c");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj liczbę d");
int d = Convert.ToInt32(Console.ReadLine());

if (b == 0 || d == 0)
{
    Console.WriteLine("Brak rozwiązania");
}
else
{
    int x = (a * d) + (c * b);

    int y = b * d;

    int nwd = NajwiekszyWspolnyDzielnik(x, y);

    x /= nwd;
    y /= nwd;

    Console.WriteLine($"Licznik po skróceniu: {x} mianownik po skróceniu: {y}");
}
static int NajwiekszyWspolnyDzielnik(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}