//Zadanie 3
//Napisz algorytm do wyznaczania współczynnika BMI (Body Mass Index).

Console.Write("Podaj masę ciała w [kg]: ");
double m = Convert.ToDouble(Console.ReadLine());

Console.Write("Podaj wzrost  w [m]: ");
double h = Convert.ToDouble(Console.ReadLine());

double bmi = m / (h * h);

Console.WriteLine($"Współczynnik BMI wynosi: {bmi}");