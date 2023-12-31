﻿// 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum += i; // sum = sum + i
        }
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

int sumNumbers = SumNumbers(number);

Console.WriteLine($"Сумму чисел от 1 до {number} = {sumNumbers}");