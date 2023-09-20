/*57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент входных данных.*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void FrequencyDictionary(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{num} -> {count}");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} -> {count}");
}

int[] MatrixToArray(int[,] matrix)
{
    int k = 0;
    int[] array = new int[matrix.Length];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.Write(mass[i] + " ");
        i++;
    }
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int columnMatrix = Convert.ToInt32(ConsoleText("Укажите количество столбцов массива"));
int rowMatrix = Convert.ToInt32(ConsoleText("Укажите количество строк массива"));
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение массива"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение массива"));

int[,] matrix = CreateMatrixRndInt(rowMatrix, columnMatrix, minValue, maxValue);
PrintArray(matrix);

int[] array = MatrixToArray(matrix);
Array.Sort(array);
Console.WriteLine();
PrintArr(array);
Console.WriteLine();
FrequencyDictionary(array);