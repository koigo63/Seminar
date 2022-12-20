//Задача 1. Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// int Findsum(int num)
// {
//     intsum=0;
//     for (int current=1, current < num , current++)
//     {
//         sum+= current;
//     }
//     return sum;
// }
// Console
// Console.WriteLine("input a=");
// int a=Convert.ToInt32(Console.ReadLine());
// int result =Findsum(a);
// Console.WriteLine(result);

//Задача 2.Напишите программу, которая принимает на вход 
//число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

//Задача 3. Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Number (int num)
// {
//     int count = 0;
//     while (num != 0)
//     {
//       num /= 10;
//       count++;
//     }
//     return count;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Number(a);
// Console.WriteLine(result);

// int Findsum(int num)
// {
//     int fact=1;
//     for (int current=1; current <= num ; current++)
//     {
//         fact=fact*current;
//     }
//     return fact;
// }
// Console.WriteLine ("input a=");
// int a=Convert.ToInt32(Console.ReadLine());
// int result =Findsum(a);
// Console.WriteLine(result);

//Задача 4. Напишите программу, которая выводит 
//массив из 8 элементов, заполненный нулями и единицами 
//в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] CreateRandomArray(int size, int minValue, int MaxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, MaxValue + 1);
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
        Console.WriteLine();
    }
}
Console.WriteLine("Размер массива");
int Length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max массива");
int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray= CreateRandomArray(Length, min,max);
//ShowArray(newArray);
ShowArray(CreateRandomArray(Length, min, max));