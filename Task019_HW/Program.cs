// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool PalindromeDefinition(int num)
{
    int num1 = (num / 10000);
    int num2 = (num % 10000 / 1000);
    int num4 = (num % 100 / 10);
    int num5 = (num % 10);
    return (num1 == num5 || num2 == num4);
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Неверный ввод. Число должно быть пятизначным.");
}
else
{
    bool result = PalindromeDefinition(number);
    Console.WriteLine(result ? "Является палиндромом." : "Не является палиндромом.");
}