/*66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N. Выполнить с помощью рекурсии.*/

Console.WriteLine("Задайте значение M.");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N.");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    System.Console.WriteLine("Некорректный ввод!");
    return;
}

int res = SumNaturalNumbersInRange(numberM, numberN);
Console.Write($"M = {numberM}, N = {numberN} -> {res}");
int SumNaturalNumbersInRange(int from, int to)
{
    if (from == to) return from;

    else if (from < to)
    {
        from += SumNaturalNumbersInRange(from + 1, to);
    }
    else if (from > to)
    {
        from += SumNaturalNumbersInRange(from - 1, to);
    }
    return from;
}