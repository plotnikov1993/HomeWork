
// задача 25

void Zadacha25()
{
Console.Write("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());

double cub;

cub = Math.Pow(n, a);

Console.WriteLine(cub);

}


void Zadacha27()

{
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (num > 0)
{
sum +=num%10;
num /=10;
}
Console.WriteLine(" сумма цифр равна " + sum);

}
Console.WriteLine();



void Zadacha29()
{
int size = 8;
int [] array = new int [size];

Random random = new Random();

for (int i =0; i < array.Length; i++)
{
array[i] = random.Next (-10, 11);
}
for (int i =0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = array.Length - 1; i > 0; i--)
{
    for (int a =0; a < i; a++)
{
    if (Math.Abs(array[a]) > Math.Abs(array[a+1]))
    {

    int ord = array[a];
    array[a] = array[a+1];
    array[a+1] = ord;
    }
}
}
for (int i =0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();

}

//Zadacha25();
//Zadacha27();
Zadacha29();