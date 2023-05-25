// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetMultMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] array = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraySecond.GetLength(0); k++)
            {
                array[i, j] += arrayFirst[i, k] * arraySecond[k, j]; 
            }    
        }
    }
    return array;
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

int[,] GetMatrix(int rows, int col, int start, int end)
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

int[,] matrixFirst = GetMatrix(2, 2, 1, 4);
int[,] matrixSecond = GetMatrix(2, 2, 1, 4);
PrintMatrix(matrixFirst);
Console.WriteLine();
PrintMatrix(matrixSecond);
Console.WriteLine();
int[,] multiplication = GetMultMatrix(matrixFirst, matrixSecond);
PrintMatrix(multiplication);
