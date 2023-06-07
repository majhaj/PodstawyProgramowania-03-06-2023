//Zadanie 8
Console.WriteLine("Podaj pierwszą liczbę: ");
double liczba1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę: ");
double liczba2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wybierz numer działania:");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
Console.Write("Twój wybór: ");
int numerDzialania = Convert.ToInt32(Console.ReadLine());

double wynik = 0;

switch (numerDzialania)
{
    case 1:
        wynik = liczba1 + liczba2;
        break;
    case 2:
        wynik = liczba1 - liczba2;
        break;
    case 3:
        wynik = liczba1 * liczba2;
        break;
    case 4:
        if (liczba2 == 0)
        {
            Console.WriteLine("Błąd: Dzielenie przez zero!");
            Console.WriteLine("Wynik: {0}/0", liczba1);
            Console.ReadLine();
        }
        wynik = liczba1 / liczba2;
        break;
    default:
        Console.WriteLine("Błąd: Nieprawidłowy numer działania!");
        break;
}

Console.WriteLine($"Wynik: {wynik}");