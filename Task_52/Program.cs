// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticAverageOfColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 1)}\t");
    }
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int m = PromptNumber("Задайте количество строк массива: ");
int n = PromptNumber("Задайте количество столбцов массива: ");
int[,] matrix = GenerateRandomArray2D(m, n, 10, 100);
Console.WriteLine("Сгенерирован двумерный массив");
PrintArray2D(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца");
ArithmeticAverageOfColumns(matrix);
