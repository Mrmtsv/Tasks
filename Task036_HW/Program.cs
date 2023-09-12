// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
//элементов, стоящих на нечётных позициях.

int[] CreateArrayRndInt(int size, int min, int max)             //Метод генерации массива из псевдослучайных чисел
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)                      //Метод печати массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int SummOddNums(int[] mass)                  //Метод суммирования элементов массива, стоящих на нечетных позициях
{
    int summ = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0) summ += mass[i];
    }
    return summ;
}

int lenArray = Convert.ToInt32(ConsoleText("Укажите длину массива"));
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение массива"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение массива"));

int[] array = CreateArrayRndInt(lenArray, minValue, maxValue);
Console.Write($"Сумма элементов массива ");
PrintArray(array);
int resSummOdd = SummOddNums(array);
Console.Write($", стоящих на нечетных позициях, равна {resSummOdd}.");