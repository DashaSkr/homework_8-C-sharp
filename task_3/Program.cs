// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.WriteLine($"{array[i , j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] GetMatrix(int rows, int col, int deep, int start, int end)
{
    int[,,] array = new int[rows, col, deep];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
            array[i, j, k] = new Random().Next(start, end+1);
            }
        }
    }
    return array;
}

int[,,] matrix = GetMatrix(2, 2, 2, 1, 100);
PrintMatrix(matrix);