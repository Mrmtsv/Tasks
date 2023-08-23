int ExtrThirdDig(int num)
{
    while (num > 999)
        num /= 10;
    num %= 10;
    return num;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if ((Math.Abs(number)) < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра введенного числа - {ExtrThirdDig(number)}");
}