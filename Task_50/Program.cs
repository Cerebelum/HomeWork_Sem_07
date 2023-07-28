// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// ================================================================================================
// Вариант 1. Задаются две координаты элемента

// void CheckElementOfArray(int[,] array)
// {
//     Console.WriteLine("Введите позиции искомого элемента в двумерном массиве:");
//     int row = PromptNumber("номер строки (1, 2, ...): ");       // это не индекс, а порядковый номер
//     int column = PromptNumber("номер столбца (1, 2, ...): ");   // для удобства пользователя
//     if (row > array.GetLength(0) || column > array.GetLength(1))
//     {
//         Console.WriteLine("Такого элемента в массиве нет");
//     }
//     else Console.WriteLine($"Искомый элемент равен: {array[row - 1, column - 1]}");
// }

// int PromptNumber(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(from, to);
//         }
//     }
//     return array;
// }

// int m = PromptNumber("Задайте количество строк массива: ");
// int n = PromptNumber("Задайте количество столбцов массива: ");
// int[,] matrix = GenerateRandomArray2D(m, n, 1, 10);
// Console.WriteLine("Сгенерирован двумерный массив");
// PrintArray2D(matrix);
// CheckElementOfArray(matrix);

// ================================================================================================
// Вариант 2. Задается порядковый номер элемента.
// Вычисление индексов строки и столбца искомого элемента.

// void CheckElementOfArray2(int[,] array)
// {
//     int n = PromptNumber("Введите порядковый номер искомого элемента в массиве: (1, 2, ...): ");
//     int columnIndex = n % array.GetLength(1) - 1;   // индекс столбца, в котором находится элемент
//     int rowIndex = n / array.GetLength(1);          // индекс строки, в которой находится элемент
//     if (n > array.GetLength(0) * array.GetLength(1))
//     {
//         Console.WriteLine("Такого элемента в массиве нет");
//     }
//     else if (n % array.GetLength(1) == 0)   // костыль для последнего столбца
//     {
//         columnIndex = array.GetLength(1) - 1;
//         rowIndex = n / array.GetLength(1) - 1;
//     }
//     Console.WriteLine($"Искомый элемент равен: {array[rowIndex, columnIndex]}");
// }

// int PromptNumber(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(from, to);
//         }
//     }
//     return array;
// }

// int m = PromptNumber("Задайте количество строк массива: ");
// int n = PromptNumber("Задайте количество столбцов массива: ");
// int[,] matrix = GenerateRandomArray2D(m, n, 10, 100);
// Console.WriteLine("Сгенерирован двумерный массив");
// PrintArray2D(matrix);
// CheckElementOfArray2(matrix);

// ================================================================================================
// Вариант 3. Задается порядковый номер элемента.
// Поэлементный перебор массива через count.

void CheckElementOfArray3(int[,] array)
{
    int n = PromptNumber("Введите порядковый номер искомого элемента в массиве: (1, 2, ...): ");
    if (n > array.GetLength(0) * array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        int count2 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int count1 = count2;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // int count1 = count2;
                count1++;
                if (count1 == n)
                {
                    Console.WriteLine($"Искомый элемент равен: {array[i, j]}");
                    break;
                }
            }
            count2 = count1;
        }
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
CheckElementOfArray3(matrix);
