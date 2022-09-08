// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// напишите программу которая выводит случайное число из отрезкеа 10 99 и показывает наибольшую цифру числа
// 78 -> 8; 12 -> 2; 85 -> 8
Random random = new Random(); // для генерации рандомных\случайных чисел

int random1 = random.Next(10, 100); //вызываем одно случайное число
int random2 = random.Next(10, 100); //вызываем второе случайное число

Console.WriteLine(random1);

Console.WriteLine(random2);