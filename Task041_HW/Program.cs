// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.

int[] CreateArrayInputInt(int size)               //Метод построения массива из вводимых чисел
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число массива.");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int CountNumsGreatZero(int[] mass)                  //Метод подсчета количества элементов массива больше нуля
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0) count++;
    }
    return count;
}

int lenArray = Convert.ToInt32(ConsoleText("Укажите длину массива"));

int[] array = CreateArrayInputInt(lenArray);
int resCountNumsGreatZero = CountNumsGreatZero(array);
Console.Write($"Количество чисел больше нуля в веденном Вами массиве ");
PrintArray(array);
Console.Write($" равно {resCountNumsGreatZero}.");