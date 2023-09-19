/*58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrix;
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int column1row2Matrix = Convert.ToInt32(ConsoleText("Укажите количество столбцов первой матрицы/строк второй матрицы"));
int rowMatrix1 = Convert.ToInt32(ConsoleText("Укажите количество строк первой матрицы"));
int minValue1 = Convert.ToInt32(ConsoleText("Укажите минимальное значение первой матрицы"));
int maxValue1 = Convert.ToInt32(ConsoleText("Укажите максимальное значение первой матрицы"));
int columnMatrix2 = Convert.ToInt32(ConsoleText("Укажите количество столбцов второй матрицы"));
int minValue2 = Convert.ToInt32(ConsoleText("Укажите минимальное значение второй матрицы"));
int maxValue2 = Convert.ToInt32(ConsoleText("Укажите максимальное значение второй матрицы"));

int[,] matrix1 = CreateMatrixRndInt(rowMatrix1, column1row2Matrix, minValue1, maxValue1);
int[,] matrix2 = CreateMatrixRndInt(column1row2Matrix, columnMatrix2, minValue2, maxValue2);

Console.WriteLine("Произведение матриц ");
PrintArray(matrix1);
Console.WriteLine(" и ");
PrintArray(matrix2);
Console.WriteLine(" равно ");
int[,] matrix3 = MultiplicationMatrix(matrix1, matrix2);
PrintArray(matrix3);