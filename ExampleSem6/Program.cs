// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#nullable disable
// Задача 41: Пользователь вводит с клавиатуры M чисел. Задача 41
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Какое количество чисел вы введете?");
// bool isNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!isNumber || length <= 0)
// {
//     Console.WriteLine("Это не количество");
//     return;
// }
// int[] UserArray(int length)
// {
//     int[] numbers = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         Console.WriteLine($"Вводите число: ");
//         string string1 = Console.ReadLine();
//         numbers[i] = Convert.ToInt32(string1);
//     }
//     Console.WriteLine($"Достаточно ");
//     return numbers;
// }
// int MoreThenNull(int[] array)//больше нуля
// {
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int[] array = UserArray(length);
// Console.WriteLine($"Из {length} введенных чисел {MoreThenNull(array)} больше нуля");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,Задача 43
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// double[,] array = new double[2, 2];
// Console.WriteLine("Задайте уравнение 1: b1= ");
// bool isNumberb1 = double.TryParse(Console.ReadLine(), out double b1);
// if (!isNumberb1)
// {
//     Console.WriteLine($"Это не число");
//     return;
// }
// array[0, 0] = b1;// b1 == array[0,0]

// Console.WriteLine("k1= ");
// bool isNumberk1 = double.TryParse(Console.ReadLine(), out double k1);
// if (!isNumberk1)
// {
//     Console.WriteLine($"Это не число");
//     return;
// }
// array[0, 1] = k1;// k1 == array[0,1]

// Console.WriteLine("Задайте уравнение 2: b2= ");
// bool isNumberb2 = double.TryParse(Console.ReadLine(), out double b2);
// if (!isNumberb2)
// {
//     Console.WriteLine($"Это не число");
//     return;
// }
// array[1, 0] = b2;// b2 == array[1,0]

// Console.WriteLine("k2= ");
// bool isNumberk2 = double.TryParse(Console.ReadLine(), out double k2);
// if (!isNumberk2)
// {
//     Console.WriteLine($"Это не число");
//     return;
// }
// array[1, 1] = k2;// k2 == array[1,1]

// double[] IntersectionPoint(double[,] array)
// {
//     double[] xy = new double[2]; // x, y
//     xy[0] = (array[1, 0] - array[0, 0]) / (array[0, 1] - array[1, 1]); //(b2 - b1)/(k1 - k2) x
//     xy[1] = (array[0, 0] * array[1, 1] - array[1, 0] * array[0, 1]) / (array[1, 1] - array[0, 1]);
//     // (b1*k2 - b2*k1)/(k2- k1) y
//     return xy;
// }
// if ((array[0, 1] - array[1, 1] == 0) && (array[1, 1] - array[0, 1] == 0))
// {
//     Console.WriteLine("Система уравнений не имеет решения");
//     return;
// }
// else
// {
//     double[] xy = IntersectionPoint(array);
//     Console.WriteLine($"Коодинаты точки пересечения ({xy[0]}; {xy[1]})");
//     return;
// }