﻿//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//=========

// int[] CreateRandomArray(int size)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1}-е число");
//         myArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return myArray;
// }
// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Show(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)

//         if (array[i] > 0)
//         {
//             count++;
//         }

//     Console.WriteLine($" Количесто чисел больше 0 = {count} ");
// }
// Console.WriteLine("Сколько чисел вы хотите ввести");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите число");
// int[] newarray = CreateRandomArray(Length);
// ShowArray(newarray);
// Show(newarray);

//==============================================

//Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//=====
void Show (double b1, double k1, double b2,double k2)
{
  if (k1!=k2)  
 { double x= (b2-b1)/(k1-k2);
  double y= k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых"
    +$" y = k1 * x + b1 и y = k2 * x + b2 равна ({x};{y})");
 }  
 else 
 {
    Console.WriteLine("Прямые не пересекаются!");
 }
}
Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Show(b1,k1,b2,k2);

//=======