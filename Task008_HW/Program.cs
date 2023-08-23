Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Перечень всех четных чисел до {number} включительно:");
int numberX = 1;
while (numberX <= number)
{
    if ((numberX % 2) == 0) Console.WriteLine(numberX);
    numberX++;
}