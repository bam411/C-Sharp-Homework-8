// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int n = ReadInt("Введите N: ");
double[,] numbers = new double[n + 1, 2 * n + 1];

FillTriangle(numbers);
EditTriangle(numbers);
WriteArray(numbers);

void EditTriangle(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

void FillTriangle(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        numbers[i, 0] = 1;
    }
    for (int j = 1; j < numbers.GetLength(0); j++)
    {
        for (int k = 1; k < j + 1; k++)
        {
            numbers[j, k] = numbers[j - 1, k] + numbers[j - 1, k - 1];
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
                Console.Write(array[i, j] + " ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
