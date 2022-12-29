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

// void Show3DRandomArray(int rows, int column,int pag)
// {
//         int[,,] myArray = new int[rows, column, pag];
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
          
//             for (int k = 0; k <myArray.GetLength(2); k++)
//             {
//                 myArray[i, j, k] = new Random().Next(10, 100);
//                 Console.Write(myArray[i,j,k]+$" ({i},{j},{k}) ");
//                            }
//              Console.WriteLine();
//         }
//           }
//     }
// Console.Write("Введите количество строк ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество страниц ");
// int pag = Convert.ToInt32(Console.ReadLine());
// Show3DRandomArray(row,col, pag);

//======================================

//Задача 62. Напишите программу,
// которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07