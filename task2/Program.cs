//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1, 7->такого числа в массиве нет

int[] InputToArray(string nums)
{
    int[] arr = Array.ConvertAll(nums.Trim().Split(' '), Convert.ToInt32);
    return arr;
}

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

string ElementSearch(int[,] arr, int m, int n)
{
    if (m < 0 || m > (arr.GetLength(0) - 1) || n < 0 || n>(arr.GetLength(1)-1))
    {
        return "Такого элемента нет";
    }
    return $"{arr[m, n]}";
}

int[,] array = new int[3, 4];

Fill2dArray(array);

Console.WriteLine("Введите позицию элемента");
int[] coords = InputToArray(Console.ReadLine());

string result = ElementSearch(array, coords[0], coords[1]);

Print2dArray(array);
Console.WriteLine(result);