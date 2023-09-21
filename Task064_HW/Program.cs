/*64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.WriteLine("Задайте значение N.");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN < 1)
{
    System.Console.WriteLine("Некорректный ввод!");
    return;
}

Console.Write($"N = {numberN} -> ");
ReverseNaturalNumbers(numberN);

void ReverseNaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    ReverseNaturalNumbers(num - 1);
}