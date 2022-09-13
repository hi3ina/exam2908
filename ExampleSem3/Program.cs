// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

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

// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// Console.Write("Введите пятизначное число: ");
// bool number = int.TryParse(Console.ReadLine(), out int M);

// bool IsValidate(bool number) //проверка на не число
// {
//     if (number != true)
//     {
//         Console.WriteLine("Некорректное число");
//         return false;
//     }
//     if (M < -9999 || M > -99999)// проверяем что б число было пятизначным
//     {
//         int minus = M * -1; //избавляемся от минуса
//         return true;
//     }
//     if (M < 10000 || M > 99999) // проверяем что б число было пятизначным
//     {
//         Console.WriteLine("Некорректное число");
//         return false;
//     }
//     return true;
// }
// bool result = IsValidate(number);
// if (!result)
// {
//     return;
// }
// bool Palindrom(bool number)
// {
//     int m1 = M / 10000; // разбираем число на цифры
//     int m2 = M / 1000;
//     int m4 = M % 100;
//     int m5 = M % 10;
//     if (m1 == m5 && m2 == m4)
//     {
//         Console.WriteLine($"Число {M} является Палиндромом");
//         return true;
//     }

//     Console.WriteLine($"Число {M} не является Палиндромом");
//     return false;
// }
// Palindrom(number);

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// формулу для нахождения расстояния между точками в пространстве
// |AB| = сумма квадратов под корнем (Xb -Xa)кв+(Yb -Ya)кв+(Zb -Za)кв

Console.Write("Введите координаты точки a: Xa  ");
bool isNumberXa = int.TryParse(Console.ReadLine(), out int Xa);
Console.Write("Ya  ");
bool isNumberYa = int.TryParse(Console.ReadLine(), out int Ya);
Console.Write("Za  ");
bool isNumberZa = int.TryParse(Console.ReadLine(), out int Za);

if (!isNumberXa || !isNumberYa || !isNumberZa)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}
Console.Write("Введите координаты точки b: Xb  ");
bool isNumberXb = int.TryParse(Console.ReadLine(), out int Xb);
Console.Write("Yb  ");
bool isNumberYb = int.TryParse(Console.ReadLine(), out int Yb);
Console.Write("Zb  ");
bool isNumberZb = int.TryParse(Console.ReadLine(), out int Zb);

if (!isNumberXb || !isNumberYb || !isNumberZb)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}
Console.Write($"Расстояние между точками a и b равно: {GetLenght(Xa, Ya, Za, Xb, Yb, Zb)}");

double GetLenght(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    return Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
    // return ab;
}