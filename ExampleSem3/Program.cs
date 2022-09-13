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

// Console.WriteLine("Введите пятизначное число: ");
// bool isNumberM = int.TryParse(Console.ReadLine(), out int M); //проверка на не число

// if (!isNumberM) ;
// {
//     Console.WriteLine("Не число");
//     return;
// }

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

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// формулу для нахождения расстояния между точками в пространстве
// |AB| = сумма квадратов под корнем (Xb -Xa)кв+(Yb -Ya)кв+(Zb -Za)кв
// Эта формула также справедлива, если точки А и В совпадают;
// принадлежат одной из координатных осей или прямой, параллельной одной из координатных осей;
// принадлежат одной из координатных плоскостей или плоскости, параллельной 
// одной из координатных плоскостей.

Console.WriteLine("Введите координаты точки a: Xa  ");
bool isNumberXa = double.TryParse(Console.ReadLine(), out double Xa);

Console.WriteLine("Ya  ");
bool isNumberYa = double.TryParse(Console.ReadLine(), out double Ya);

Console.WriteLine("Za  ");
bool isNumberZa = double.TryParse(Console.ReadLine(), out double Za);

if (isNumberXa != true || isNumberYa != true || isNumberZa != true)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

Console.WriteLine("Введите координаты точки b: Xb  ");
bool isNumberXb = double.TryParse(Console.ReadLine(), out double Xb);

Console.WriteLine("Yb  ");
bool isNumberYb = double.TryParse(Console.ReadLine(), out double Yb);

Console.WriteLine("Zb  ");
bool isNumberZb = double.TryParse(Console.ReadLine(), out double Zb);

if (isNumberXb != true || isNumberYb != true || isNumberZb != true)
{
    Console.WriteLine("Числа введены не верно.");
    return;
}

double Method(double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    double ab = Math.Sqrt((Math.Pow(Xb - Xa), 2) + (Math.Pow(Yb - Ya), 2) + (Math.Pow(Zb - Za), 2));
    return ab;
}
Console.WriteLine($"Расстояние между точками a и b равно: {Method(Xa, Ya, Za, Xb, Yb, Zb)}");
