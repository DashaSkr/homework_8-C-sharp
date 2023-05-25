// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetNumberOfString(int[,] array)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum = tempSum + array[i, j];           
        }
        Console.Write($"{tempSum} ");
        if (tempSum < sum)
        {
            sum = tempSum;
            index = i;
        }
    }
    Console.Write($"строка {index + 1} = {sum} ");
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i , j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixMAndN(int rows, int col, int start, int end)
{
    int[,] array = new int[rows, col];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
int[,] matrix = GetMatrixMAndN(m, n, 1, 10);
Console.WriteLine($"m = {m}, n = {n}. ");
PrintMatrix(matrix);
GetNumberOfString(matrix);