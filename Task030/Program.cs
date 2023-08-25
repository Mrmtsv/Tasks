// int array1 = new int[8] {5,7,8,5,23,87,12,1};    //заполнение отдельных элементов
// int array2 = new int[] {5,7,8,5,23,87,12,1};     //заполнение отдельных элементов
// int array3 = {5,7,8,5,23,87,12,1};               //заполнение отдельных элементов
// var array4 = new int[8];

// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// array[6] = 6456;    //заполнение отдельных элементов
// array[2] = 34;      //заполнение отдельных элементов

// //FillArray (int[] array)        //заполнение через функцию
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
// }

// //PrintArray                     //печать через функцию
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArr(int[] mass)
{
    int i = 0;
    var random = new Random();
    while (i < mass.Length)
    {
        mass[i] = random.Next(2);
        i++;
    }
}

void PrintArr(int[] mass)
{
    int i = 0;
    while (i < mass.Length)
    {
        Console.Write($"{mass[i]} ");
        i++;
    }
}

int[] array = new int[8];
FillArr(array);
PrintArr(array);