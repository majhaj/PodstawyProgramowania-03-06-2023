// Zadanie 11
Console.Write("Podaj wartość x: ");
double x = double.Parse(Console.ReadLine());

double wynik;


if(x > -2)
{
    if(x >= -1 )
    {
        if(x > 1)
        {
            if(x >= 2)
            {
                wynik = 1;
            }
            else
            {
                wynik = x - 1;
            }
        }
        else
        {
            wynik = 0;
        }
    }
    else
    {
        wynik = x + 1;
    }
}
else
{
    wynik = -1;
}

Console.WriteLine("Wynik f(x): " + wynik);
    