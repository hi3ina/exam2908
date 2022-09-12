// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int N);
// if (!isNumberN)
// {
//     Console.WriteLine("Не число");
//     return;
// }
// PrintSqares(GetSqares(N));
// int[] GetSqares(int n)
// {
//     int i = 1;
//     int[] result = new int[n];
//     while (i <= n)
//     {
//         result[i - 1] = (int)Math.Pow(i, 3);
//         i++;
//     }
//     return result;
// }
// void PrintSqares(int[] Sqares)
// {
//     int i = 0;
//     int len = Sqares.Length;
//     Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
//     while (i < len)
//     {
//         Console.WriteLine(Sqares[i]);
//         i++;
//     }
// }

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int M); //проверка на не число

if (!isNumberM) ;
{
    Console.WriteLine("Не число");
    return;
}

// проверяем что б число было пятизначным
// переводим число М в массив M() размера m
// вводим пустой массив N размера m
// присваиваем N[4] M[0]
// присваиваем N[3] M[1]
// присваиваем N[2] M[2]
// присваиваем N[1] M[3]
// присваиваем N[0] M[4]
// сравниваем массив M и N
// true Console.WriteLine($"Число {M} является Палиндромом");
// else Console.WriteLine($"Число {M} не является Палиндромом");