/*55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для пользователя.*/

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

void ReplaceRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
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

if (!IsSquareMatrix(matrix))
{
    Console.WriteLine("Невозможно заменить строки на столбцы!");
    return;
}

ReplaceRowsToColumns(matrix);
Console.WriteLine();
PrintArray(matrix);