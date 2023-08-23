int ExtrSecDig(int num)
{
    num /= 10;
    num %= 10;
    return num;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра введенного числа - {ExtrSecDig(number)}");