// 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        mass[i] = new Random().Next(-100, 100);
        i++;
    }
}

void PrintArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.Write(mass[i] + " ");
        i++;
    }
    Console.Write("-> [");
    int j = 0;
    while (j < (mass.Length - 1))
    {
        Console.Write(mass[j] + " ");
        j++;
    }
    Console.Write($"{mass[mass.Length - 1]}]");
}
int[] array = new int[8];
FillArr(array);
PrintArr(array);