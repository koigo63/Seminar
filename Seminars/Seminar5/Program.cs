// Console.WriteLine("Min массива");
// int min = Convert.ToInt32(Console.ReadLine());
//       int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, MaxValue + 1);
//     }
//     return myArray;
// int result =Findsum(a);
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
//         Console.WriteLine(array[i] + " ");
//         Console.WriteLine();
//     }
// }

// void FindSumm(int[] array)
// {
//     int sumpositiv = 0;
//     int sumnegativ = 0;
//     for (int i = 0; i < array.Length; i++)


//     {
//         if (array[i] > 0) sumpositiv += array[i];
//         else
//             sumnegativ += array[i];

//     }
//     Console.WriteLine($"Размер поз {sumpositiv} отриц {sumnegativ}");
// }
// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Min массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Max массива");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] newArray=CreateRandomArray(Length, min, max);
// ShowArray(newArray);
// FindSumm(newArray);

//Задача 2. Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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
//         Console.WriteLine(array[i] + " ");
//         Console.WriteLine();
//     }
// }

// int[] ChangeElemets (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }


// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());                                  

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// newArray = ChangeElemets(newArray);
// ShowArray(newArray);

//Задача 3.Задайте массив. Напишите программу, к
//оторая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int[] CreateRandomArray(int size)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
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

// void Show(int[] array, int num)
// {
// for (int i = 0; i < array.Length; i++)

//     if (num ==array[i]) Console.WriteLine($" Число {num}входит в массив");

// }


// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите число");
// int numb = Convert.ToInt32(Console.ReadLine());
// int[] newarray=CreateRandomArray(Length);
// ShowArray(newarray);

// Show( newarray ,numb);

//==============
//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int[] CreateRandomArray(int size) //, int minValue, int MaxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(0,1000);
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
//      Console.WriteLine();
// }

// void Sum(int[] array, int num, int num2)
// {
// int count=0;
// for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i]>=num && array[i]<=num2)
//       count =count+1;

//     }
// Console.WriteLine(count);

// }

//  Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите нижнюю границу");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите верхнюю гграницу");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// int[] newarray=CreateRandomArray(Length);
// ShowArray(newarray);
// Sum( newarray ,numb, numb2);
int[] array = { 10, 5, 3, 2};
         for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {

                if (array[i] == array[j])
                    count = count + 1;
            }
            if (count>1)
            Console.WriteLine(" Есть повторяющиеся числа");
        }
        
