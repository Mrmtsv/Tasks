// 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultiplicationNums(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mult *= i;
        }
    }
    return mult;
}

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
else
{
    int multiplicationNums = MultiplicationNums(number);

    Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplicationNums}");
}