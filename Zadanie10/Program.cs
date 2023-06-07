// Zadanie 10

Console.Write("Podaj liczbę: ");
long liczba = Convert.ToInt64(Console.ReadLine());

int ostatniaCyfra = Convert.ToInt32(liczba % 10);
Console.WriteLine("Ostatnia cyfra: " + ostatniaCyfra);