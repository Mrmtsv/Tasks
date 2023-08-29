//  25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ExponentiationAB(int num1, int num2)
{
    int res = 1;
    int i = 0;
    while (i < num2)
    {
        res *= num1;
        i++;
    }
    return res;
}

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 1)
{
    Console.WriteLine("Ошибка ввода! Число B должно быть натуральным.");
}
else
{
    int result = ExponentiationAB(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}.");
}