// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// напишите программу которая выводит случайное число из отрезке 10 99 и показывает наибольшую цифру числа
// 78 -> 8; 12 -> 2; 85 -> 8
// Random random = new Random(); // для генерации рандомных\случайных чисел
// //string str = Console.ReadLine(); //этот метод возвращает стоку
// int random1 = random.Next(10, 100); //вызываем одно случайное число, возвращает число//int random2 = random.Next(10, 100); //вызываем второе случайное число
// // int random2 = random.Next(10,100); указываем интервал не включительно//вызываем второе случайное число, возвращает число//int random2 = random.Next(10, 100); //вызываем второе случайное число
// Console.WriteLine(random1);
// // Console.WriteLine(random2);
// int lastNumber = random1 % 10; // находим остаток т е вторую цифру двухзначного числа
// int firstNumber = random1 / 10; // находим десятки  т е первую цифру двухзначного числа
// if (lastNumber > firstNumber) // находим два последних числа random1 % 100 и т д
// {
//     Console.WriteLine(lastNumber);
// }
// else
// {
//     Console.WriteLine($"Максимальное число равно {firstNumber} - верное решение");
// } int выводит целые числа
// красивый ответ 1 способ сложить число и строчку Console.WriteLine("Максимальное число равно " + firstNumber);
// второй способ интерполяция переменная внутри строчки Console.WriteLine($"Максимальное число равно {firstNumber} - верное решение");
//  обращать внимание на скобку в условии, круглые квадр в отрезка, включ не включ крайние числа
// double firstNumber = (double) random1 / 10; такая строчка выведет число с одним знаком после запятой
//  удалить число - используем оператор деления и процент от деления
//  метод int GetMaxNumber(int number) написание с заглавной с глагола место в коде - начало
// GetMaxNumber - находит макс число, return - завершает код, то что ниже не будет выполняться
// int a = random.Next(99, 1000);
// int a = Convert.ToInt32(Console.ReadLine());
//задача 10 д з 2
// Random random = new Random(); //вводим случайное трехзначное число] //задача 10 д з 2
// int random1 = random.Next(99, 1000);

// Console.WriteLine(random1);
// int random2 = random1 % 100;
// int secontNumber = random2 / 10;
// Console.WriteLine(secontNumber);

// return;

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // Аналогично предыдущим считали с консоли и послали в метод.if (number == 6)

// if (number == 6)
// {
//     Console.WriteLine("да");
// }
// else if (number == 7)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Math.Round(num, 1)// число и один знак после запятой

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введите число: ");

string? input = Console.ReadLine();

bool ValidateInput(string input)
{
    bool isNumber = int.TryParse(input, out int number);
    if (!isNumber)
    {
        return false;
    }
    if (input.Length < 3)
    {
        return false;
    }
    return true;
}
char Get3Number(string number)
{
    return number[2];
}
bool isValid = ValidateInput(input);
if (!isValid)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}
char result = Get3Number(input);
Console.WriteLine($"Третья цифра числа - {result}");
