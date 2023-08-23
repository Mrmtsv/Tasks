Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == numberA)
{
    Console.WriteLine($"Числа {numberA} и {numberB} равны");
}
else
{
if (numberA < numberB)
{
    Console.WriteLine($"Число {numberB} большее, а {numberA} - меньшее");
}
else
{
    Console.WriteLine($"Число {numberA} большее, а {numberB} - меньшее");
}
}