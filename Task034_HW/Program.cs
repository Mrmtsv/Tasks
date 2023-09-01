//34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArr(int[] mass)              //Метод генерации массива из псевдослучайных чисел
{
    int i = 0;
    while (i < mass.Length)
    {
        mass[i] = new Random().Next(100, 1000);
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
    Console.Write($"{mass[mass.Length - 1]}] -> ");
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int CountEvenNumsArray(int[] mass)                  //Метод определения четности элемента массива
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if ((mass[i] % 2) == 0) count++;
    }
    return count;
}

int lenArray = Convert.ToInt32(ConsoleText("Укажите длину массива"));

int[] array = new int[lenArray];
FillArr(array);
PrintArr(array);
int resCountEven = CountEvenNumsArray(array);
Console.Write(resCountEven);