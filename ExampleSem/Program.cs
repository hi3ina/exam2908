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

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
{
    if (a > b) max = a;

    else max = b;
}
Console.Write("max=");
Console.WriteLine(max);