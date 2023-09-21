/*62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] CreateMatrixSpiralFillingInt(int startNumber)
{
    int[,] matrix = new int[4, 4];
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);

    for (int j = 0; j < column; j++)
    {
        matrix[0, j] = startNumber;
        startNumber++;
    }
    for (int i = 1; i < row - 1; i++)
    {
        matrix[i, 3] = startNumber;
        startNumber++;
    }
    for (int j = column - 1; j >= 0; j--)
    {
        matrix[3, j] = startNumber;
        startNumber++;
    }
    matrix[2, 0] = startNumber;
    startNumber++;
    for (int j = 0; j < column - 1; j++)
    {
        matrix[1, j] = startNumber;
        startNumber++;
    }
    for (int j = column - 2; j > 0; j--)
    {
        matrix[2, j] = startNumber;
        startNumber++;
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
            Console.Write($"{arr[i, j].ToString("00"),5}");
        }
        Console.WriteLine();
    }
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int startNum = Convert.ToInt32(ConsoleText("Укажите начальное число сптрально заполненной матрицы."));

int[,] matrix = CreateMatrixSpiralFillingInt(startNum);
PrintArray(matrix);