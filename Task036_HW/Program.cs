// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
//элементов, стоящих на нечётных позициях.

void FillArr(int[] mass, int min, int max)              //Метод генерации массива из псевдослучайных чисел
{
    int i = 0;
    while (i < mass.Length)
    {
        mass[i] = new Random().Next(min, max + 1);
        i++;
    }
}

void PrintArr(int[] mass)                               //Метод печати массива
{
    Console.Write($"[");
    int i = 0;
    while (i < (mass.Length - 1))
    {
        Console.Write(mass[i] + ", ");
        i++;
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

int[] array = new int[lenArray];
FillArr(array, minValue, maxValue);
Console.Write($"Сумма элементов массива ");
PrintArr(array);
int resSummOdd = SummOddNums(array);
Console.Write($", стоящих на нечетных позициях, равна {resSummOdd}");