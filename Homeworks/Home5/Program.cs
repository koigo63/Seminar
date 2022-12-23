// Задача 34: 
// Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//========

// int[] CreateRandomArray(int size) //, int minValue, int MaxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(100, 1000);
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

// void Sum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count = count + 1;

//     }
//     Console.WriteLine($"Количество чётных чисел в массиве = {count}");

// }

// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] newarray = CreateRandomArray(Length);
// ShowArray(newarray);
// Sum(newarray);

//===============================

//Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size) //, int minValue, int MaxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(-9, 10);
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
// void Sum(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i=i+2)
//     {

//             summ = summ + array[i];

//     }
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {summ}");

// }

// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] newarray = CreateRandomArray(Length);
// ShowArray(newarray);
// Sum(newarray);

//================================

//Задача 38: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size)
{
    double[] myArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        double numb = new Random().Next(-1000, 1000);
        myArray[i] = numb / 100;
    }
    return myArray;
}
void ShowArray(double[] array)
{
    Console.WriteLine("Полученный массив->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
}
void difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine($" минимальное число = {min}");
    Console.WriteLine($" максимальное число = {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива"
    + $" = {Math.Round(max - min, 2)}");

}

Console.WriteLine("Размер массива");
int Length = Convert.ToInt32(Console.ReadLine());
double[] newarray = CreateRandomArray(Length);
ShowArray(newarray);
difference(newarray);

//========================