// 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

double[] CreateArrayRndDouble(int size, int minimum, int maximum)      //Метод генерации массива из псевдослучайных чисел
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.Next(minimum, maximum) + rnd.NextDouble(), 2);
    }
    return arr;
}

void PrintArr(double[] mass)                               //Метод печати массива
{
    Console.Write($"[");
    for (int i = 0; i < mass.Length - 1; i++)
    {
        if (i < mass.Length - 1) Console.Write($"{mass[i]}, ");
        else Console.Write($"{mass[i]}");
    }
    Console.Write($"{mass[mass.Length - 1]}]");
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

double[] MaxMinArray(double[] mass, int minimum, int maximum)                  //Метод нахождения максимального и минимального элемента массива
{
    double max = minimum;
    double min = maximum;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max) max = mass[i];
        if (mass[i] < min) min = mass[i];
    }
    double[] arrayMaxMin = { max, min };
    return arrayMaxMin;
}

int lenArray = Convert.ToInt32(ConsoleText("Укажите длину массива"));
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение массива"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение массива"));

double[] array = CreateArrayRndDouble(lenArray, minValue, maxValue);
Console.Write($"Разница между максимальным и минимальным элементами массива ");
PrintArr(array);
double[] resMaxMinArray = MaxMinArray(array, minValue, maxValue);
Console.Write($" составляет {resMaxMinArray[0]} - {resMaxMinArray[1]} = {Math.Round(resMaxMinArray[0] - resMaxMinArray[1], 2)}.");