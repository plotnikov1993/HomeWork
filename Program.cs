
void Zadacha34()
{
int size = 8;
int [] array = new int [size];
Random(array);
Even(array);
}


void Random(int [] array)
{
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next (100, 1000);
    
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}

void Even(int [] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
      n++ ;
    }
}
Console.WriteLine("количество четных чисел в массиве: " + n);
}


void Zadacha36()
{
int size = 8;
int [] array = new int [size];
Random2(array);
Sum(array);
}

void Random2(int [] array)
{
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next (0, 21);
    
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}

void Sum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
      sum += array[i] ;
    
    }
}
Console.WriteLine(sum);

}



void Zadacha38()
{
int size = 5;
double [] array = new double[size];
Random3(array);
//Dif(array);
MaxMin(array);

}

void Random3(double [] array)
{
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-50, 50) + random.NextDouble();
    
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}
void MaxMin(double [] array)
{
double max = -50;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
    max = array[i];
    }
}
double min = max;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
    min = array[i];
    }
}
Console.WriteLine(max);
Console.WriteLine(min);
Console.WriteLine(Math.Abs(max) - Math.Abs(min));
}



//Zadacha34();
//Zadacha36();
Zadacha38();