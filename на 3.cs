using System.Xml;

Console.WriteLine("Выберите способ решения: \r\nФормулы - 1 \r\nЦиклы - 2");
int sposob = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\r\nВыберите прогрессию: \r\nГеометрическая - 1 \r\nАрифметическая - 2");
int prog = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\r\nВведите первый член");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\r\nВведите знаменатель/разность  прогрессии");
double qd = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\r\nВведите номер последнего члена");
double n = Convert.ToDouble(Console.ReadLine());

if (sposob == 1 & prog == 1)
{
    double otvet11 = a1 * ((Math.Pow(qd, n)) - 1) / (qd - 1);
    Console.WriteLine($"Сумма геометрической прогрессии равна: {otvet11}");
}
if (sposob == 1 & prog == 2)
{
    double otvet12 = (a1 + (a1 + qd * (n - 1))) * n / 2;
    Console.WriteLine($"Сумма арифметической прогрессии равна: {otvet12}");
}
if (sposob == 2 & prog == 1)
{
    double otvet21 = a1;
    for (double i = 0; i < (n - 1); i++)
    {
        a1 = a1 * qd;
        otvet21 = otvet21 + a1;
    }
    Console.WriteLine($"Сумма геометрической прогрессии равна:");
    Console.WriteLine(otvet21);
}
if (sposob == 2 & prog == 2)
{
    double s = a1;
    double otvet22 = a1;
    for (double i = 0; i < (n - 1); i++)
    {
        s = s + qd;
        otvet22 = otvet22 + s;
    }
    Console.WriteLine($"Сумма арифметической прогрессии равна:");
    Console.WriteLine(otvet22);
}