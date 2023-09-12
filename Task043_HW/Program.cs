// 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

float DefinitionX(float par1Line1, float par2Line1, float par1Line2, float par2Line2)
{
    float x = ((par1Line2 - par1Line1) / (par2Line1 - par2Line2));
    return x;
}

float DefinitionY(float x, float par1Line1, float par2Line1)
{
    float y = (par2Line1 * x + par1Line1);
    return y;
}

Console.WriteLine("Введите значние b1");
float b1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите значние k1");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите значние b2");
float b2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите значние k2");
float k2 = Convert.ToSingle(Console.ReadLine());

float resX = DefinitionX(b1, k1, b2, k2);
float resY = DefinitionY(resX, b1, k1);
Console.Write($"Координаты точки пересечения двух прямых, описанных функциями y = {k1} * x + {b1} и y = {k2} * x + {b2}, равны ({resX}, {resY}).");