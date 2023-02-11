/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int n = 4;
int m = 4;

int[,] InitMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSum(int[,] matrix)
{
    int min = 0;
    int minsum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < min)
        {
            min = sum;
            minsum = i;
        }
        sum = 0;
    }
    Console.Write($"{minsum + 1} строка");
}

int[,] matrix = InitMatrix(n, m);
PrintMatrix(matrix);
Console.WriteLine();
MinSum(matrix);