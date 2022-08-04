// задача 19
void Zadacha19()
{
Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());



if (num > 9999 && num < 1000000 )
{
int e = num % 10;
int d = (num / 10) % 10;
int c = (num / 100) % 10;
int b = (num / 1000) % 10;
int a = num / 10000;
if (a == e && b == d) Console.WriteLine("число явлеятся палиндромом");

else Console.WriteLine("число не явлеятся палиндромом");
}
else
{
Console.WriteLine("число введено неверно");
}

}

//Zadacha19();


// задача 21

void Zadacha21()
{
int a_x = 5;
int a_y = 6;
int a_z = 3;
int b_x = 1;
int b_y = 4;
int b_z = 2;
double dist = Math.Sqrt( Math.Pow(a_x - b_x, 2) + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));

Console.WriteLine(dist);
}
//Zadacha21();





// задача 23

void Zadacha23()
{
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
double a = 1;
double cub;
while (a <= n)
{
cub = Math.Pow(a, 3);

Console.WriteLine(cub);
a++;

}
}


//Zadacha23();