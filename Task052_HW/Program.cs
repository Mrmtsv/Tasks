/*Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray,
PrintListAvr и FindAverageInColumns.
Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
с каждым новым элементом увеличивающимся на опрделенное число. Метод
принимает на вход три числа (n - количество строк матрицы, m - количество
столбцов матрицы, k - число, на которое увеличивается каждый новый элемент)
и возвращает матрицу, удовлетворяющую этим условиям.
Метод PrintArray должен выводить на экран сгенерированную методом
CreateIncreasingMatrix матрицу.
Метод FindAverageInColumns принимает целочисленную матрицу типа int[,]
и возвращает одномерный массив типа double. Этот метод вычисляет среднее
значение чисел в каждом столбце матрицы и сохраняет результаты в виде
списка.
Метод PrintListAvr принимает одномерный массив, возвращенный методом
FindAverageInColumns и выводит этот список на экран в формате "The
averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения
средних значений столбцов, округленные до двух знаков после запятой,
разделенные знаком табуляции.*/

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int firstNum = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = firstNum;
            firstNum += k;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] list = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double num = 0.00;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            num += Convert.ToDouble(matrix[i, j]);
        }
        list[j] = num / Convert.ToDouble(matrix.GetLength(0));
    }
    return list;
}

void PrintListAvr(double[] list)
{
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
    {
        if (i < list.Length) Console.Write($"{list[i].ToString("0.00")}" + "\t");
    }    
}

int[,] array = CreateIncreasingMatrix(5, 6, 4);
PrintArray(array);

double[] arr = FindAverageInColumns(array);
PrintListAvr(arr);