void Zadacha47()
{
Random random = new Random();
int m = random.Next(3, 4);
int n = random.Next(4, 5);
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);
}

void FillArray(double [,] array)
{
int m = array.GetLength(0);
int n = array.GetLength(1);
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(random.NextDouble() * 10 - 5);
    }
}
}
void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    
    }
}



void Zadacha50()
{
Random random = new Random();
int rows = random.Next(3, 4);
int columns = random.Next(4, 5);
int [,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= rows && row > 0 && column <= columns && column > 0)
{
    Console.WriteLine($"Искомый элемент {array[row - 1, column - 1]}");
}
else
{
    Console.WriteLine("Элемент не существует");
}
void FillArray(int [,] array)
{
int rows = array.GetLength(0);
int columns = array.GetLength(1);
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 50);
    }
}
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    
    }

}
}

void Zadacha52()
{
Random random = new Random();
int rows = random.Next(3, 4);
int columns = random.Next(4, 5);
int [,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum+= array[i, j];
    }
    Console.Write(Math.Round (sum/rows, 2) + "\t");
}

void FillArray(int [,] array)
{
int rows = array.GetLength(0);
int columns = array.GetLength(1);
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 10);
    }
}
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    
    }
}
}


void Zadacha54()
{
    int rows = 5;
    int columns = 6;
    int [,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    for (int i = 0; i < rows; i++)
    {
        for (int j = columns - 1; j > 0; j--)
        {
            for (int a = 0; a < j; a++)
            {
                if (array[i, a] < array[i, a + 1])
                {
                    int temp = array[i, a];
                    array [i, a] = array[i, a + 1];
                    array [i, a + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(array);


static void FillArray(int [,] array)
{
int rows = array.GetLength(0);
int columns = array.GetLength(1);
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 50);
    }
}
}
static void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}
}


void Zadacha56()
{
int rows = 5;
int columns = 6;
int [,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

int min = array[0, 0];
int sumMin = FirstSum(array);
int indexMin = 0;
Console.WriteLine($"Сумма элементов {indexMin+1} строки равна {sumMin}");

for (int i = 1; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Сумма элементов {i+1} строки равна {sum}");
    if(sum < sumMin)
    {
        sumMin = sum;
        indexMin = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальная сумма находится в строке {indexMin+1} и равна {sumMin}");

void FillArray(int [,] array)
{
int rows = array.GetLength(0);
int columns = array.GetLength(1);
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 10);
    }
}
}
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}    
}
int FirstSum(int[,] array)
{
    int sum = 0;
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++) sum += array[0, j];
    return sum;
}



void Zadacha58()
{
int rows = 4;
int columns = 4;
int [,] array = new int[rows, columns];
int row = 0;
int column = 0;
int changeRow = 0;
int changeColumn = 1;
int steps = columns;
int turn = 0;

for (int i = 0 ; i < array.Length; i++)
{
    array[row, column] = i + 1;
    steps--;
    //Console.Write(array[row, column] + " ");
    if (steps == 0)
    {
        steps = rows - 1 - turn/2;
        int temp = changeRow;
        changeRow = changeColumn;
        changeColumn = -temp;
        turn++;
    }
    row += changeRow;
    column += changeColumn;
}
PrintArray(array);

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}       
}



//Zadacha47();
//Zadacha50();
//Zadacha52();
//Zadacha54();
//Zadacha56();
Zadacha58();
