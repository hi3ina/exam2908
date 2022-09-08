// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// напишите программу которая выводит случайное число из отрезкеа 10 99 и показывает наибольшую цифру числа
// 78 -> 8; 12 -> 2; 85 -> 8
Random random = new Random(); // для генерации рандомных\случайных чисел
//string str = Console.ReadLine(); //этот метод возвращает стоку
int random1 = random.Next(10, 100); //вызываем одно случайное число, возвращает число//int random2 = random.Next(10, 100); //вызываем второе случайное число
// int random2 = random.Next(10,100); //вызываем второе случайное число, возвращает число//int random2 = random.Next(10, 100); //вызываем второе случайное число
Console.WriteLine(random1);
// Console.WriteLine(random2);
int lastNumber = random1 % 10; // находим остаток т е вторую цифру двухзначного числа
int firstNumber = random1 / 10; // находим десятки  т е первую цифру двухзначного числа
if (lastNumber > firstNumber) // находим два последних числа random1 % 100 и т д
{
    Console.WriteLine(lastNumber);
}
else
{
    Console.WriteLine(firstNumber);
}