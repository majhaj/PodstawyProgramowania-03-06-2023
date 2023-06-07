//Zadanie 9
Console.Write("Podaj liczbę a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj liczbę b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj liczbę c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Przed zamianą: a = {a}, b = {b}, c = {c}");

a = a + b + c;
b = a - (b + c);
c = a - (b + c);
a = a - (b + c);

Console.WriteLine($"Po zamianie: a = {a}, b = {b}, c = {c}");