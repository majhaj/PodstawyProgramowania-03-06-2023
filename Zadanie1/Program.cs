// Zadanie 1
List<int> liczby = new List<int>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Podaj liczbę");
    liczby.Add(Int32.Parse(Console.ReadLine()));
}
Console.WriteLine($"średnia podanych liczb: {liczby.Average()}");