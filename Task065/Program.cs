// 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void RangeNaturalNumbers(int from, int to)
{
    if (from < to)
    {
        Console.Write($"{from} ");
        RangeNaturalNumbers(from + 1, to);
    }
    else if (from > to)
    {
        Console.Write($"{from} ");
        RangeNaturalNumbers(from - 1, to);
    }
    else
    {
        Console.Write($"{from}");
    }

}

Console.WriteLine("Введите диапазон натуральных чисел");
Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

RangeNaturalNumbers(numberOne, numberTwo);