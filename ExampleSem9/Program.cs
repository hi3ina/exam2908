// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
#nullable disable
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Задача 64:

// Console.WriteLine("Введите m = ");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n = ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberN || !isNumberM || n < m)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// string NumbersRec(int m, int n)
// {
//     if (m < n) return $"{m}, " + NumbersRec(m + 1, n);
//     else return $"{m}";
// }
// Console.WriteLine(NumbersRec(m, n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов  Задача 66:
// в промежутке от M до N. M = 1; N = 15 -> 120  M = 4; N = 8. -> 30

// Console.WriteLine("Введите m = ");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n = ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberN || !isNumberM || n < m)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// string NumbersRec(int m, int n)
// {
//     if (m < n) return $"{m}, " + NumbersRec(m + 1, n);
//     else return $"{m}";
// }
// Console.WriteLine(NumbersRec(m, n));

// int Summ(int m, int n)
// {
//     if (n - m == -1) return 0;
//     return m + Summ(m + 1, n);
// }
// Console.WriteLine(Summ(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Задача 68:
// Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 29

// Console.WriteLine("Введите m = ");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
// Console.WriteLine("Введите n = ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if (!isNumberN || !isNumberM || m < 0 || n < 0)
// {
//     Console.WriteLine("Неверный ввод");
//     return;
// }
// void Recursive(int m, int n)
// {
//     if (n - m == -1) return;
//     Console.WriteLine(m);
//     Recursive(m + 1, n);
// }
// Console.WriteLine();
// Recursive(m, n);

// uint m1 = (uint)(int)m;
// uint n1 = (uint)(int)n;
// static uint A(uint m1, uint n1)
// {
//     if (m1 == 0)
//         return n1 + 1;
//     else
//       if ((m1 != 0) && (n1 == 0))
//         return A(m1 - 1, 1);
//     else
//         return A(m1 - 1, A(m1, n1 - 1));
// }
// uint res = A(m1, n1);
// Console.WriteLine(res);