int[] mas = new int[7]
{ 5000, 1000, 500, 200, 100, 10, 1};

Console.WriteLine("Введите сумму,которую необходимо представить в количестве купюр n номинала.");

int n = Convert.ToInt32(Console.ReadLine());
int a = n - (n / mas[0]) * mas[0];
int b = n - (n / mas[1]) * mas[1];
int c = n - (n / mas[2]) * mas[2];
int d = n - (n / mas[3]) * mas[3];
int e = n - (n / mas[4]) * mas[4];
int f = n - (n / mas[5]) * mas[5];

if (n >= mas[0])
    Console.WriteLine($"{n / mas[0]} Купюры номиналом {mas[0]}");
if (a >= mas[1])
    Console.WriteLine($"{a / mas[1]} Купюры номиналом {mas[1]}");
if (b >= mas[2])
    Console.WriteLine($"{b / mas[2]} Купюры номиналом {mas[2]}");
if (c >= mas[3])
    Console.WriteLine($"{c / mas[3]} Купюры номиналом {mas[3]}");
if (d >= mas[4])
    Console.WriteLine($"{d / mas[4]} Купюры номиналом {mas[4]}");
if (e >= mas[5])
    Console.WriteLine($"{e / mas[5]} Купюры номиналом {mas[5]}");
if (f >= mas[6])
    Console.WriteLine($"{f / mas[6]} Купюры номиналом {mas[6]}");