
// задача 10
void Zadacha10()
{
Console.Write("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int ones = num % 10;
int tens = (num / 10) % 10;
int huns = num / 100;

Console.WriteLine(tens);
}



void Zadacha13()
{
    //Задача 13
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("нет третьего числа");
}
    else
{
    while (num > 999)
{
    num /= 10;
}
    Console.WriteLine(num % 10);
}
}

void Zadacha15()
{
Console.Write("Введите номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
 if (num == 6 || num == 7)
    Console.WriteLine("этот день выходной");
else 
{
    if (num >=1 && num <= 5)
 Console.WriteLine("это будний день");
 else 
    if (num <= 0 || num > 7)
Console.WriteLine("вводные данные не верны");
}
}

//Zadacha10();
//Zadacha13();
//Zadacha15();








