// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#nullable disable
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) Задача 25
// и возводит число A в натуральную степень B.

// Console.Write("Введите число x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа x: ");
// int stepen = Convert.ToInt32(Console.ReadLine());

// int result = Convert.ToInt32(Math.Pow(x, stepen));// Math.Pow(x, stepen);
// Console.Write($"число {x} в степени {stepen} = {result}"); // Console.Write($"{x} ^ {stepen} = {result}");

// Задача 27: Напишите программу, которая принимает на вход число Задача 27
//  и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число - размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size]; //создаем массив size
int[] sum = new int[num];// заполняем массив

for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(array[i].ToString());
for (int i = 0; i < array.Length; i++)
    sum = sum + array[i];

Console.Write($"Сумма цифр числа {num} = {sum}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов Задача 29
// и выводит их на экран.

// Console.WriteLine("Введите данные:");

// bool isNumber = int.TryParse(Console.ReadLine(), out int lenght);
// if (!isNumber || lenght <= 0)
// {
//     Console.WriteLine("Числа введены неверно");
//     return;
// }
// int[] result = FillArray(lenght);
// PrintArray(result);

// void PrintArray(int[] array)
// {
//     if (array.Length == 0)
//     {
//         Console.Write("Числа введены неверно");
//         return;
//     }
//     Console.Write("[");

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }
//     Console.Write(array[array.Length - 1]);
//     Console.Write("]");
// }
// int[] FillArray(int lenght)
// {
//     int[] array = new int[lenght];
//     string input = Console.ReadLine();
//     string[] inputArray = input.Split(",");
//     if (inputArray.Length != lenght)
//     {
//         return new int[0];
//     }
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         array[i] = Convert.ToInt32(inputArray[i]);
//     }
//     return array;
// }

