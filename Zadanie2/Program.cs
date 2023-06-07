//Zadanie 2

Console.WriteLine("Podaj pole koła");
double p = Convert.ToDouble(Console.ReadLine());
double r = Math.Sqrt(p / Math.PI);
double ob = 2 * Math.PI * r;
Console.WriteLine($"Obwód koła o danym polu ({p}) wynosi {ob}");