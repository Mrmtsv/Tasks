// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix,
// который принимал бы числа m и n (размеренность массива),
// а также minLimitRandom и maxLimitRandom,
// которые указывают на минимальную и максимальную границы
// случайных чисел.
// Также, задайте метод PrintArray,
// который выводил бы массив на экран.

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(minLimitRandom, maxLimitRandom) + rnd.NextDouble(), 2);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateRandomMatrix(5, 5, 0, 10);
PrintArray(matrix);
//Console.WriteLine();
//int sumElements = SumBothCommonIndexes(matrix);
//Console.WriteLine(sumElements);