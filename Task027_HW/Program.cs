// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigNum(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += (num % 10);
        num /= 10;
    }
    return res;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigNum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {result}.");