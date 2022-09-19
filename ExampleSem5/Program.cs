// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#nullable disable
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.Задача 34

// Console.WriteLine("Введите размер массива:");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine($"Неверный ввод");//проверка на число
//     return;
// }
// int[] array = GetRandomArray(length);
// PrintArray(array);
// int[] GetRandomArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++) array[i] = random.Next(99, 1000);//числа массива
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.WriteLine("]");
// }
// int EvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] % 2 == 0) count++;
//     }
//     return count;
// }
// int result = EvenNumbers(array);
// Console.WriteLine($"Количество чётных чисел в массиве - {result}");
//
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Задача 36
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("Введите размер массива:");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine($"Неверный ввод");//проверка на число
//     return;
// }
// int[] array = GetRandomArray(length);
// PrintArray(array);
// int[] GetRandomArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++) array[i] = random.Next(-10000, 10000);
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.WriteLine("]");
// }
// int OddNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }
// int result = OddNumbers(array);
// Console.WriteLine($"Сумма элементов нечетных индексов равна {result}");//ответ

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.Задача 38

// Console.WriteLine("Введите размер массива:");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine($"Неверный ввод");//проверка на число
//     return;
// }
// int[] array = GetRandomArray(length);
// PrintArray(array);

// int[] GetRandomArray(int length)
// {
//     int[] array = new int[length];
//     Random random = new Random();
//     for (int i = 0; i < length; i++) array[i] = random.Next(10000);
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");//выводим массив
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.WriteLine("]");
// }
// int GetMaxNumber(int[] array) // метод GetMaxNumber находит максимальное число
// {
//     int max = array[0];
//     for (int i = 1; i < length; i++)
//     {
//         if (max < array[i])
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }
// int GetMinNumber(int[] array)//метод GetMinNumber находит минимальное число
// {
//     int min = array[0];
//     for (int i = 1; i < length; i++)
//     {
//         if (min > array[i]) min = array[i];
//     }
//     return min;
// }
// Console.WriteLine($"Максимальное число массива: {GetMaxNumber(array)}");
// Console.WriteLine($"Минимальное число массива: {GetMinNumber(array)}");

// int result = GetMaxNumber(array) - GetMinNumber(array);
// Console.WriteLine($"{GetMaxNumber(array)} - {GetMinNumber(array)} = {result}");
