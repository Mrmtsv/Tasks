/*60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)*/

/*
int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max)    //метод построения трехмерного массива из псевдослучайных чисел
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}
*/

int[,,] CreateMatrix3DTwoDigitNonRepeatingNumInt(int rows, int columns, int depth)    //метод построения трехмерного массива из двузначных неповторяющихся чисел
{
    int[,,] matrix = new int[rows, columns, depth];
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = num;
                num += 1;
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] arr)        //метод печати трехмерного массива
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int depths = arr.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                Console.Write($"{arr[i, j, k],5}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool CheckingNumOfTwoDigit(int rows, int columns, int depth)
{
    return rows * columns * depth < 90;
}

int ConsoleText(string msg)                          //Метод ввода/вывода информации
{
    Console.WriteLine(msg);
    string ReadIn = Console.ReadLine();
    int resReadIn = int.Parse(ReadIn);
    return resReadIn;
}

int columnMatrix = Convert.ToInt32(ConsoleText("Укажите количество столбцов матрицы"));
int rowMatrix = Convert.ToInt32(ConsoleText("Укажите количество строк матрицы"));
int depthMatrix = Convert.ToInt32(ConsoleText("Укажите глубину матрицы"));
/*
int minValue = Convert.ToInt32(ConsoleText("Укажите минимальное значение первой матрицы"));
int maxValue = Convert.ToInt32(ConsoleText("Укажите максимальное значение первой матрицы"));
int[,,] matrix = CreateMatrix3DRndInt(3, 3, 3, 10, 100);
*/
int[,,] matrix = CreateMatrix3DTwoDigitNonRepeatingNumInt(rowMatrix, columnMatrix, depthMatrix);

if (!CheckingNumOfTwoDigit(rowMatrix, columnMatrix, depthMatrix))
{
    Console.WriteLine("В матрице заданного размера превышено количество неповторяющихся двузначных чисел!");
    return;
}

PrintArray(matrix);