// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Условие: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
#nullable disable
/*
string[] RecordString()
{
    string[] someString = new string[5];
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Введите один элемент:");//вводим все элементы по одному
        someString[i] = Console.ReadLine();
    }
    return someString;
}

string[] recordString = RecordString();
Console.Write("Найдены элементы [");
int i = 0;
while (i < recordString.Length)
{
    if (recordString[i].Length <= 3)
    {
        Console.Write($" {recordString[i]}");//выводим все положительные результаты по одному
    }
    i++;

}
Console.WriteLine("]");