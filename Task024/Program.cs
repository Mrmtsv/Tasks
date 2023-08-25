// 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbers(num)
// {
//     int sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//         checked
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(number);

// if(number < 1)
// {
//     Console.WriteLine("Введено не корректное число");
//     return
// }

// Console.WriteLine($"Сумма чисел от 1 до {number} = {SumNumbers}");

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

int sumNumbers = SumNumbers(number);

if (number < 1)
{
    Console.WriteLine("Введено некорректное число");
    return;
}

Console.WriteLine($"Сумму чисел от 1 до {number} = {sumNumbers}");