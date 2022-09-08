// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int number = Convert.ToInt32(Console.ReadLine()); // конвертация в число.

// int result = number * number;

// Console.WriteLine(result);

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// int a = Convert.ToInt32(Console.ReadLine()); // конвертация в число.
// int b = Convert.ToInt32(Console.ReadLine());
// if a > b
//    a = max;
// else b = max;

// Console.WriteLine(max);


// int a = Convert.ToInt32(Console.ReadLine());//ЗЯП 1 семенар  дз1 задача 2
// int b = Convert.ToInt32(Console.ReadLine());

// int max = a;
// {
//     if (a > b) max = a;

//     else max = b;
// }
// Console.Write("max=");
// Console.WriteLine(max);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// int a = Convert.ToInt32(Console.ReadLine());//ЗЯП 1 семенар  дз1 задача 4
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// {
//     if (max > b) max = max;

//     else max = b;
// }
// {
//     if (max > c) max = max;

//     else max = c;
// }
// Console.Write("max=");
// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да; -3 -> нет; 7 -> нет

// int a = Convert.ToInt32(Console.ReadLine());//ЗЯП 1 семенар  дз1 задача 6
// int result = a % 2;

// if (result == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4; 8 -> 2, 4, 6, 8
int N = Convert.ToInt32(Console.ReadLine());//ЗЯП 1 семенар  дз1 задача 8
int a = 2;

while (a <= N)
{
    Console.Write(a);
    a += 2;
    if (a > N)
    {
        break;
    }
}




