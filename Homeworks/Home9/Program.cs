﻿//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//=======
// Console.Write("Введите число: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// PrintNUm(numb, count);
// void PrintNUm(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         PrintNUm(n, count + 1);
//         Console.Write(count + " ");
//     }
//   }
//   Console.WriteLine();

//============================================

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//===

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumMToN(m, n);
// void SumMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n)
// {
//     int sum = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         sum = m + SumMN(m, n);
//         return sum;
//     }
// }
// Console.WriteLine();

//==================================

//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkFunct(m,n);

void AkkFunct(int m, int n)
{
    Console.Write(Akker(m, n)); 
}

// функция Аккермана
int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}
Console.WriteLine();

//=======================