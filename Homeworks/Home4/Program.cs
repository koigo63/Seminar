//Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//========

// Console.WriteLine ("Введите число A=");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("введите степень числа B=");
// int b=Convert.ToInt32(Console.ReadLine());
// int pow=1;
// for (int i=1;i<=b;i++)
// {
// pow=pow*a;
// }

// Console.WriteLine($" {a} в степени {b} = {pow}");

//======================

//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//=======

// int Number(int num)
// {
//     int summ = 0;
//     while (num != 0)
//     {
//         summ = summ + num % 10;
//         num /= 10;
//     }
//     return summ;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Number(a);
// Console.WriteLine($"Сумма цифр числа {a} = {result}");

//============================

//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//====== Общий вариант для случайных чисел

// int[] CreateRandomArray(int size, int minValue, int MaxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, MaxValue + 1);
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
// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Min массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Max массива");
// int max = Convert.ToInt32(Console.ReadLine());

// // int[] newArray= CreateRandomArray(Length, min,max);
// //ShowArray(newArray);
// ShowArray(CreateRandomArray(Length, min, max));

//===================

// Вариант для вводимых чисел

int[] CreateRandomArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Размер массива");
int Length = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(Length));


