﻿//                                      Задача 54:
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//                             строки двумерного массива.
// Console.WriteLine("Введите кол-во строк: ");
// int size = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите кол-во столбцов: ");
// int column = int.Parse(Console.ReadLine()!);

// int[,] array = NewArray(size, column, 0, 50);

// int[,] NewArray(int size, int column, int min, int max)
// {
//     int[,] mas = new int[size, column];
//     for (int i = 0; i < mas.GetLength(0); i++)
//     {
//         for (int j = 0; j < mas.GetLength(1); j++)
//         {
//             mas[i, j] = new Random().Next(min, max + 1);
//             Console.Write($"{mas[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return mas;
// }

// int[,] Ordering(int size, int column, int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int v = j + 1; v < array.GetLength(1); v++)
//             {
//                 if (array[i, j] < array[i, v])
//                 {
//                     int max;
//                     max = array[i, j];
//                     array[i, j] = array[i, v];
//                     array[i, v] = max;
//                 }
//             }
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return mas;
// }

// Console.WriteLine();

// Ordering(size, column, array);



//                                      Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
//                              наименьшей суммой элементов.

int size2 = 3;
int column2 = 5;

int[,] secondArray = RectangleArray(size2, column2, 0, 50);
int[,] RectangleArray(int size2, int column2, int min, int max)
{
    int[,] mas = new int[size2, column2];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
    return mas;
}

int MinSum(int[,] secondArray)
{
    int minimum = 9999;
    int line = 0;

    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            sum = secondArray[i, j] + sum;
        }
        if (minimum > sum)
        {
            minimum = sum;
            line = i;
        }
    }
    return line;
}
MinSum(secondArray);
Console.WriteLine($"Наименьшая сумма в строке: {MinSum(secondArray)}");