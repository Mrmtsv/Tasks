/*68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 


!!!!!!!!!!! В Википедии переменные m и n имеют противоположное расположение, нежели в этом примере.
Я адаптировал решение под пример.*/

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    return Ack(m - 1, Ack(m, n - 1));
}

Console.WriteLine("Задайте значение m.");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение n.");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN < 1 || numberM < 1)
{
    System.Console.WriteLine("Некорректный ввод!");
    return;
}

int res = Ack(numberM, numberN);
Console.Write($"m = {numberM}, n = {numberN} -> {res}");