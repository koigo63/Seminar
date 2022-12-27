// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//=============

//  double[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
// {                                                                                
//     double[,] newArray = new double[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             double numb = new Random().Next(minValue, maxValue+1)+ new Random().NextDouble(); 
//              newArray[i,j]=Math.Round(numb,2);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);

//===========================

//Задача 50.
//Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//===============

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

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
//     Console.WriteLine();
// }
// void Show2DArray1(int[,] array, int rowsElement, int columnsElement)
// {
//     if (rowsElement <= array.GetLength(0) && columnsElement <= array.GetLength(1))
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (i == (rowsElement - 1) && j == (columnsElement - 1))
//                     Console.WriteLine($"Элемента с позицией {rowsElement};{columnsElement} ={array[i, j]}");

//             }
//         }
//      else
//     Console.WriteLine($"Элемента с позицией {rowsElement};{columnsElement} нет");
//     Console.WriteLine();
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите строку элемента ");
// int rowsElement = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец элемента ");
// int columnsElement = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m, n, min, max);
// Show2DArray(myArray);
// Show2DArray1(myArray, rowsElement, columnsElement);

///=============================================
//Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

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
    Console.WriteLine();
}
int [,] TurnArray(int[,] array)
{
    int[,] newTurnarray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < newTurnarray.GetLength(0); i++)
    {
        for (int j = 0; j < newTurnarray.GetLength(1); j++)
        {
            newTurnarray[i,j]=array[j, i];
            //Console.Write(newTurnarray[i,j]+ " ");
        }
      //Console.WriteLine();
        
    }
    return newTurnarray;
        
}
///

void AverageColumn(int[,] array)
{ double average=0;
  double elem=0;
  int columns=0;
  
 
  
            for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum=0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
              sum = sum +array[i,j];
              columns++;       
            }
                       elem =sum;
          
        Console.WriteLine($"Сумма {columns/array.GetLength(1)}-го столбца= {elem}");
              average=Math.Round(elem/array.GetLength(1),2);
            
            Console.WriteLine($"Среднеарифметическое {columns/array.GetLength(1)}-го столбца  = {average} ");
            Console.WriteLine();
        }
     
                 
                
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray(myArray);
int[,] newTurnarray=TurnArray(myArray);
AverageColumn(newTurnarray);