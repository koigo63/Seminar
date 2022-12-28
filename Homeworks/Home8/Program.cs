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

int[,] firstArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 } , { 8, 4, 2, 4 }, { 5, 2, 6, 0 } };

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SumRows(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    int min=0;
    int minRow = 0;
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i, j];

        }
        min=sum[i];
        Console.WriteLine($"Сумма строки {i} => {sum[i]}");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)

    { 
        if (sum[i]<= min)
       {
        //Console.WriteLine(sum[i]);
        min=sum[i];
        minRow=i;
        //Console.WriteLine(min +" d");
        Console.WriteLine($"Минимальное значение суммы строка {minRow} => {min}");
       }
    }
   
}





Show2DArray(firstArray);
SumRows(firstArray);