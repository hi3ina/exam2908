// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
# nullable disable
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Задача 64:

Console.WriteLine("Введите m = ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n = ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberN || !isNumberM || n < m)
{
    Console.WriteLine("Неверный ввод");
    return;
}
string NumbersRec(int m, int n)
{
    if (m < n) return $"{m}, " + NumbersRec(m + 1, n);
    else return $"{m}";
}
Console.WriteLine(NumbersRec(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Задача 68:
// Даны два неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 29

int SumOfNumbers(int m, int n)
{
    if (n - m == -1) return 0;
    return m + SumOfNumbers(m + 1, n);
}
Console.WriteLine(SumOfNumbers(m, n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. M = 1; N = 15 -> 120  M = 4; N = 8. -> 30

long AckermanFunction(int m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermanFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    return n++;
}
Console.WriteLine(AckermanFunction(m, n));