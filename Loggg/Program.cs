Console.WriteLine("Логорифм по натуральному основанию? \n 1: Да \n 2: Нет");
double z = double.Parse(Console.ReadLine());
if (z == 1)
{
    Console.WriteLine("Введите число которое нужно про логарифмировать.");
    double chis = double.Parse(Console.ReadLine());
    Console.WriteLine("До скольки знаков после запятой округлить?");
    int q = int.Parse(Console.ReadLine());
    double r = Math.Log(chis); // Просчёт логорифма с натуральным основанием.
    Console.WriteLine(Math.Round(r, q)); // Округление.
}
else if (z == 2)
{
    Console.WriteLine("Введите число которое нужно про логарифмировать и основание логорифма.");
    double chi = double.Parse(Console.ReadLine());
    double ch = double.Parse(Console.ReadLine());
    Console.WriteLine("До скольки знаков после запятой округлить?");
    int q = int.Parse(Console.ReadLine());
    double r = Math.Log(chi, ch); // Просчёт логорифма с натуральным основанием.
    Console.WriteLine(Math.Round(r, q)); // Округление.
}
else Console.WriteLine("Ошибка ввода!!!");