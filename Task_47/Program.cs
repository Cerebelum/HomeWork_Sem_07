// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray2D(double[,] array)
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

double[,] GenerateRandomArray2D(int rows, int columns, double from, double to, int round)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * (to - from) + from), round);
        }
    }
    return array;
}

int PromptNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = PromptNumber("Введите количество строк: ");
int n = PromptNumber("Введите количество столбцов: ");
Console.WriteLine();
double[,] matrix = GenerateRandomArray2D(m, n, -9, 10, 1);
PrintArray2D(matrix);
