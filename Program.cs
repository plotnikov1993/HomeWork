void Zadacha41()
{
Console.Write("Сколько чисел будет введено?");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (n > 0) count++;
}
Console.WriteLine($"Было введено {count} числа(чисел) больше нуля");
}


void Zadacha43()
{
int k1 = 8;
int b1 = 2;
int k2 = 4;
int b2 = 10;

if (k1 == k2)
{
    Console.WriteLine("нет точки");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine($"координаты точки пересечения A({x}, {y})");
    Console.WriteLine($"координаты точки пересечения A({x}, {y2})");
}
}
//Zadacha41();
Zadacha43();