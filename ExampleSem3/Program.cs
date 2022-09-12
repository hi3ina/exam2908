// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int N);
if (!isNumberN)
{
    Console.WriteLine("Не число");
    return;
}
PrintSqares(GetSqares(N));
int[] GetSqares(int n)
{
    int i = 1;
    int[] result = new int[n];
    while (i <= n)
    {
        result[i - 1] = (int)Math.Pow(i, 3);
        i++;
    }
    return result;
}
void PrintSqares(int[] Sqares)
{
    int i = 0;
    int len = Sqares.Length;
    Console.WriteLine($"Таблица кубов чисел от 1 до {N}:");
    while (i < len)
    {
        Console.WriteLine(Sqares[i]);
        i++;
    }
}