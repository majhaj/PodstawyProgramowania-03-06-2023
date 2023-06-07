//Zadanie 7

Console.Write("Podaj współrzędną x punktu P: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj współrzędną y punktu P: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj promień koła: ");
double r = Convert.ToDouble(Console.ReadLine());


if (x*x + y*y <= r*r)
{
    Console.WriteLine($"Punkt P({x}, {y}) leży w obrębie koła o środku w punkcie (0, 0) i promieniu r = {r}");
}
else
{
    Console.WriteLine($"Punkt P({x}, {y}) nie leży w obrębie koła o środku w punkcie (0, 0) i promieniu r = {r}");
}