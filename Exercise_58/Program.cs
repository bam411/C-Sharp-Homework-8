// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowsA = ReadInt("Введите количество строк первой матрицы: ");
int columnsA = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] firstMatrix = new int[rowsA, columnsA];

int rowsB = ReadInt("\nВведите количество строк второй матрицы: ");
int columnsB = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] secondMatrix = new int[rowsB, columnsB];

if (columnsA != rowsB)
{
    Console.WriteLine("\nТакие матрицы нельзя перемножить.");
    return;
}

FillMatrixRandomNumbers(firstMatrix);
WriteMatrix(firstMatrix);

FillMatrixRandomNumbers(secondMatrix);
WriteMatrix(secondMatrix);

int[,] result = new int[rowsA, columnsB];

Multiplication(firstMatrix, secondMatrix, result);
WriteMatrix(result);

void Multiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = sum;
        }
    }
}

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
