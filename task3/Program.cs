//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Fill2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }

    }
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i],1)} ");
    }
}

double[] AverageInColumn(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    int div = arr.GetLength(0);
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i=0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        result[j] = sum / div;
    }
    return result;
}


int[,] array = new int[3, 4];
Fill2dArray(array);
double[] result = new double[array.GetLength(1)];
result = AverageInColumn(array);

Print2dArray(array);
PrintResult(result);

