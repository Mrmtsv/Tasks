// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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
    int i = 0;
    while (i < (mass.Length-1))
    {
        Console.Write(mass[i] + ", ");
        i++;
    }
    Console.Write($"{mass[mass.Length - 1]} -> [");
    int j = 0;
    while (j < (mass.Length - 1))
    {
        Console.Write(mass[j] + ", ");
        j++;
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

int lenArray = Convert.ToInt32(ConsoleText("Укажите длину массива"));
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение"));

int[] array = new int[lenArray];
FillArr(array, minValue, maxValue);
PrintArr(array);