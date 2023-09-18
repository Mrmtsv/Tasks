/* 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
двумерного массива.*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // rows = 3, columns = 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 4
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

void SortNumsRowsInDescending(int[,] matrix, int minNum)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
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
SortNumsRowsInDescending(matrix, minValue);
Console.WriteLine();
PrintArray(matrix);