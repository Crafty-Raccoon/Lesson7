//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

double GenerateDouble(double min, double max)
{
    Random rnd = new Random();
    double number = rnd.NextDouble();
    double rndDouble = number * (max - min) + min;
    return rndDouble;
}

void Fill2dArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GenerateDouble(-10, 10);
        }
    }
}

void Print2dArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 2)} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m, n];

Fill2dArray(array);
Print2dArray(array);
