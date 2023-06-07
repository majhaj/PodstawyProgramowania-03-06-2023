//Zadanie 5

int[] liczby = new int[2];
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Podaj liczbę: ");
    liczby[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Większa liczba: {liczby.Max()}");