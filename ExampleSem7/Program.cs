// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#nullable disable
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.Задача 47

// Console.WriteLine("Задайте число строк m= ");
// bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
// if (!isNumberm || m <= 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// Console.WriteLine("Задайте число столбцов n= ");
// bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumbern || n <= 1)
// {
//     Console.WriteLine("Неверный ввод");//задали размер проверили на число
//     return;
// }
// double[,] mn = new double[m, n];// double массив вещественных чисел
// void CreateRandomDoubleArray(int m, int n)
// {
//     Random random = new Random();
//     for (int i = 0; i < mn.GetLength(0); i++)
//     {
//         for (int j = 0; j < mn.GetLength(1); j++)
//         {
//             mn[i, j] = Convert.ToDouble(random.Next(100));
//         }
//     }
// }
// void Print2DDoubleArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// CreateRandomDoubleArray(m, n);
// Print2DDoubleArray(mn);
//
//Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, Задача 50. 
//и возвращает индексы этого элемента или же указание, что такого элемента нет.
//
// Console.WriteLine("Задайте число строк m= ");
// bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
// if (!isNumberm || m <= 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// Console.WriteLine("Задайте число столбцов n= ");
// bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumbern || n <= 1)
// {
//     Console.WriteLine("Неверный ввод");//задали размер проверили на число
//     return;
// }
// int[,] CreateRandomIntArray(int m, int n)// int массив
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(9, 99);
//         }
//     }
//     return array;
// }
// void Print2DIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array2 = CreateRandomIntArray(m, n);
// Print2DIntArray(array2);//вывели массив на экран

// Console.WriteLine("Что ищем?");

// int number = Convert.ToInt32(Console.ReadLine());
// string GuessArrayNumber(int[,] array, int number)
// {
//     string someString = "";
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == number) someString = $"{i}, {j}"; ;
//         }
//     }
//     return someString;
// }
// Console.WriteLine(GuessArrayNumber(array2, number));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
// Console.WriteLine("Задайте число строк m= ");
// bool isNumberm = int.TryParse(Console.ReadLine(), out int m);
// if (!isNumberm || m <= 1)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// Console.WriteLine("Задайте число столбцов n= ");
// bool isNumbern = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumbern || n <= 1)
// {
//     Console.WriteLine("Неверный ввод");//задали размер проверили на число
//     return;
// }
// int[,] CreateRandomIntArray(int m, int n)// int массив
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(15);
//         }
//     }
//     return array;
// }
// void Print2DIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array2 = CreateRandomIntArray(m, n);
// Print2DIntArray(array2);

// void PrintDoubleArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} | ");
//     }
// }
// double[] NumberRow(int[,] array)
// {
//     double[] numberRow = new double[n];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             numberRow[j] = numberRow[j] + array[i, j];
//         }
//         numberRow[j] = numberRow[j] / array.GetLength(0); //Math.Round(num, 1)
//     }
//     return numberRow;
// }
// double[] numberRowDouble = NumberRow(array2);
// Console.WriteLine();
// PrintDoubleArray(numberRowDouble);