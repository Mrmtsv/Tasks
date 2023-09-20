/*59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен наименьший элемент массива.*/

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

int[] FindIndexOfMinimumElement(int[,] mtr)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);
    int rowMin = 0;
    int colMin = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (mtr[i, j] < mtr[rowMin, colMin])
            {
                rowMin = i;
                colMin = j;
            }
        }
    }
    return new int[] { rowMin, colMin };
}

int[,] DeleteRowAndColOfMinElem(int[,] mtr, int rowMin, int colMin)
{
    int rows = mtr.GetLength(0);
    int columns = mtr.GetLength(1);
    int[,] newMtr = new int[rows - 1, columns - 1];
    int m = 0, n = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        if (m == rowMin) m += 1;
        for (int j = 0; j < columns - 1; j++)
        {
            if (n == colMin) n += 1;
            newMtr[i, j] = mtr[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMtr;
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
Console.WriteLine();
int[] minIndexes = FindIndexOfMinimumElement(matrix);
int[,] newMatrix = DeleteRowAndColOfMinElem(matrix, minIndexes[0], minIndexes[1]);
PrintArray(newMatrix);