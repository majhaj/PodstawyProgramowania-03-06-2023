//Zadanie 6

Console.WriteLine("Podaj długość boku 'a' trójkąta: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj długość boku 'b' trójkąta: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj długość boku 'c' trójkąta: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && a == c)
{
    Console.WriteLine("Trójkąt jest równoboczny");
}
else
{
    Console.WriteLine("Trójkąt nie jest równoboczny");
}