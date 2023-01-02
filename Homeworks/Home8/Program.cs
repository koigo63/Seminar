//Задача 54:
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//==========

// int[,] firstArray = { { 1, 4, 7, 2}, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] SortingArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1)-1; j++)
//         {
//             int maxPosition = 0;
//             for (int m = 1; m < array.GetLength(1); m++)
//             {

//                 if (array[i, m] > array[i, maxPosition])
//                 {
//                     int temporary = array[i, m];
//                     array[i, m] = array[i, maxPosition];
//                     array[i, maxPosition] = temporary;
//                     maxPosition = m;
//                 }
//                 else
//                 {
//                     maxPosition = m;
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
//     return array;
// }
// Show2DArray(firstArray);
// SortingArray(firstArray);
// Show2DArray(firstArray);

//======================


//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] firstArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void SumRows(int[,] array)
// {
//     int[] sum = new int[array.GetLength(0)];
//     int min = 0;
//     int minRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum[i] = sum[i] + array[i, j];
//         }
//         min = sum[i];
//         Console.WriteLine($"Сумма строки {i} => {sum[i]}");
//     }
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (sum[i] <= min)
//         {
//             min = sum[i];
//             minRow = i;
//             Console.WriteLine($"Минимальное значение суммы строка {minRow} => {min}");
//         }
//     }
// }
// Show2DArray(firstArray);
// SumRows(firstArray);

//==========================================
//Задача 58:
// Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

// int[,] firstArray = { { 2, 4 }, { 3, 2 } };
// int[,] secondArray = { { 3, 4 }, { 3, 3 } };

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void multiplyMatrix(int[,] array1, int[,] array2)
// {
//     int[,] arraySum = new int[array1.GetLength(0), array1.GetLength(1)];
//     int sum = 0;
//     if (array1.GetLength(0) == array2.GetLength(1))

//         for (int i = 0; i < array1.GetLength(0); i++)
//         {
//             for (int j = 0; j < array2.GetLength(1); j++)
//             {
//                 sum = 0;
//                 for (int k = 0; k < array1.GetLength(1); k++)
//                 {
//                     sum = sum + array1[i, k] * array2[k, j];
//                 }
//                 Console.Write(sum + " ");
//             }
//             Console.WriteLine();
//         }
// }
// Show2DArray(firstArray);
// Console.WriteLine();
// Show2DArray(secondArray);

// Console.WriteLine("Произведение матриц");
// multiplyMatrix(firstArray, secondArray);

//===============================

//Задача 60. .
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//=====

// int[,,] Create3DRandomArray(int rows, int column, int pag)
// {
//     int[,,] myArray = new int[rows, column, pag];

//     for (int i = 0; i < myArray.GetLength(1); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < myArray.GetLength(2); k++)
//             {
//                 myArray[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
//     return myArray;
// }
// void Show3DRandomArray(int[,,] nArray)
// {
//      for (int i = 0; i < nArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < nArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < nArray.GetLength(2); k++)
//             {
//                 Console.Write(nArray[i, j, k] + $" ({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[] Repeat3DRandomArray(int[,,] myArray)
// {
//     int i = 0;
//     int j = 0;
//     int k = 0;
//     int[] repeat = new int[myArray.GetLength(0) * myArray.GetLength(1) * myArray.GetLength(1)];
//     for (i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (j = 0; j < myArray.GetLength(1); j++)
//         {
//             for (k = 0; k < myArray.GetLength(2); k++)
//             {
//                 repeat[4 * i + 2 * j + k] = myArray[i, j, k];
//          }
        
//         }
//             }
//      return repeat;
// }
// void ShowRandomArray(int[] myArray)
// {
//     int count = 0;
//     int n=0;
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
                      
//                  Console.Write(myArray[i] + " ");
//         for (int m = 0; m < myArray.Length; m++)
//         {
//             count = 0;
//             for (int j = 0; j < myArray.Length; j++)
//             {

//                 if (myArray[m] == myArray[j])
//                     count =count+1;
                        
//             }
//              if(count>1)
//              n=2;
//                 }
      
//     }
//     Console.WriteLine();
//     if(n==2) 
//    Console.WriteLine("Есть повторяющиеся числа"); 
   
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество страниц ");
// int min = Convert.ToInt32(Console.ReadLine());

// int[,,] newArray = Create3DRandomArray(m, n, min);

// Show3DRandomArray(newArray);
// int[] new1Array= Repeat3DRandomArray(newArray);
// ShowRandomArray(new1Array);


// ==============================================
//Задача 62. Напишите программу,
// которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//=============================

int[,] Show2DArray()
{
    int k = 0;
    int m = 0;
    int[,] array = new int[4,4];

    for (int j = m; j < array.GetLength(1); j++)
    {
        if (j == 0)
        {
        array[k, j] = 1;
        }
        else
            array[k, j] = array[k, j - 1] + 1;
        m = j;
    }
    for (int i = k; i < array.GetLength(1); i++)
    {
        if (i == 0)
        { }
        else
            array[i, m] = array[i - 1, m] + 1;
        k = i;
    }
    for (int j = m; j >= 0; j = j - 1)
    {
        if (j == m)
        {}
        else
            array[k, j] = array[k, j + 1] + 1;
        m = j;
    }
    for (int i = k; i >= array.GetLength(0) - (k + 1); i--)
    {
        if (i == k)
        { }
        else
            array[i, m] = array[i + 1, m] + 1;
        k = i;
    }
    for (int j = m; j <= array.GetLength(1) - (k + 1); j = j + 1)
    {
        if (j == m)
        {}
        else
            array[k, j] = array[k, j - 1] + 1;
        m = j;
    }
    for (int i = k; i <= array.GetLength(1) - (k + 1); i++)
    {
        if (i == k)
        {}
        else
            array[i, m] = array[i - 1, m] + 1;
        k = i;
    }
    for (int j = m; j > array.GetLength(1) - 4; j = j - 1)
    {
        if (j == m)
        {}
        else
            array[k, j] = array[k, j + 1] + 1;
        m = j;
    }
    return array;
}

void Show2DArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write("0" + array[i, j] + " ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array=Show2DArray();
Console.WriteLine();
Show2DArray1(array);
Console.WriteLine();


//=======

