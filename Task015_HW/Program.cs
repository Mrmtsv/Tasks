Console.WriteLine("Введите цифру, обозначающую день недели");
int digit = Convert.ToInt32(Console.ReadLine());
if ((digit > 7) || (digit < 1))
{
    Console.WriteLine("Введенная цифра не может обозначать день недели");
}
else
{
    if ((digit > 0) & (digit < 6))
    {
        Console.WriteLine("Не является выходным.");
    }
    else
    {
        Console.WriteLine("Выходной!");
    }
}