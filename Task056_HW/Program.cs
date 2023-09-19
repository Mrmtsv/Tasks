/* 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
с наименьшей суммой элементов.*/

int[,] CreateMatrixRndInt(int countRowsColumns, int min, int max)
{
    int[,] matrix = new int[countRowsColumns, countRowsColumns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[] ArraySumNumsRows(int[,] matrix)
{
    int[] sumNums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumNums[i] = sum;
    }
    return sumNums;
}

int FindingSmallNumArray(int[] sumNums)
{
    int min = sumNums[0];
    int num = 0;
    for (int i = 1; i < sumNums.Length; i++)
    {
        if (sumNums[i] < min)
        {
            min = sumNums[i];
            num = i;
        }
    }
    return num + 1;
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int resolutionMatrix = Convert.ToInt32(ConsoleText("Укажите количество столбцов и строк прямоугольного двумерного массива"));
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение массива"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение массива"));

int[,] matrix = CreateMatrixRndInt(resolutionMatrix, minValue, maxValue);
PrintArray(matrix);
int[] array = ArraySumNumsRows(matrix);
int res = FindingSmallNumArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {res} строка.");