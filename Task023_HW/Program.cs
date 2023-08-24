// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Число должно быть больше нуля!");
}
else
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine($"Куб числа {i} равен {Math.Pow(i, 3)}");
    }
}