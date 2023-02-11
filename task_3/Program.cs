/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int m = 2;
int n = 2;

void InitMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(2, 5);
    }
  }
}

void PrintMatrix (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void Composition(int[,] oneMatrix, int[,] twoMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < oneMatrix.GetLength(1); k++)
      {
        sum += oneMatrix[i,k] * twoMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] firstMartrix = new int[m, n];
InitMatrix(firstMartrix);
PrintMatrix(firstMartrix);
int[,] secomdMartrix = new int[n, m];
InitMatrix(secomdMartrix);
Console.WriteLine();
PrintMatrix(secomdMartrix);
int[,] resultMatrix = new int[m,n];
Composition(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintMatrix(resultMatrix);