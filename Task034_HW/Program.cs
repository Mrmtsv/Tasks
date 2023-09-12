//34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int size)               //Метод генерации массива из псевдослучайных чисел
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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

int[] array = CreateArrayRndInt(lenArray);
int resCountEven = CountEvenNumsArray(array);
Console.Write($"Количество четных чисел в массиве ");
PrintArray(array);
Console.Write($" равно {resCountEven}.");