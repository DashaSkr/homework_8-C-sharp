// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void SortDescendingMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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
int[,] matrix = GetMatrixMAndN(m, n, 0, 10);
Console.WriteLine($"m = {m}, n = {n}. ");
Console.WriteLine();
PrintMatrix(matrix);
SortDescendingMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);






