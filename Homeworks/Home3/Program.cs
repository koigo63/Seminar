//Задача 19
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

//=========================


// void Polindrom(int num)
// {
//      if (num<10000 ||num>99999)
//     {
//         Console.WriteLine("Неправильно введено число");
//     }
//     else
//     {
//     if (num / 10000 == num % 10)
//     {
//         int num3 = num % 10000 / 10;

//         if (num3 / 100 == num3 % 10)

//             Console.WriteLine($"Число {num} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} не является палиндромом");
//     }
//     }

// }
// Console.WriteLine("input x=");
// int x = Convert.ToInt32(Console.ReadLine());
// Polindrom(x);


// =====================


// Второй вариант Задачи 19


// void Polindrom(int num)
// {
//     if (num < 10000 || num > 99999)
//     {
//         Console.WriteLine("Неправильно введено число");
//     }
//     else
//     {
//         int num3 = num / 1000;
//         int num4 = num % 100;

//         if (num3 / 10 == num4 % 10)
//         {
//             if (num3 % 10 == num4 / 10)

//                 Console.WriteLine($"Число {num} является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine($"Число {num} не является палиндромом");
//         }
//     }

// }
// Console.WriteLine("input x=");
// int x = Convert.ToInt32(Console.ReadLine());
// Polindrom(x);

//====================

// Задача 21
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//============

//  void Distance( double x, double y, double z,double x1, double y1, double z1)
// {
//    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x-x1),2)+Math.Pow((y-y1),2)+Math.Pow((z-z1),2)),2));
// }
// Console.WriteLine("input x=");
// double x=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y=");
// double y=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input z=");
// double z=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input x1=");
// double x1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y1=");
// double y1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input z1=");
// double z1=Convert.ToDouble(Console.ReadLine());
// Distance(x,y,z,x1,y1,z1);

//==============================
// Задача 23
//Напишите программу, которая принимает 
//на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//=======================

void Cube(int N)
{
    if (N<1)
    {
        Console.WriteLine("Вы ввели неправильные данные");
    }
    int index=1;
    while(index < N+1) 
    {
        Console.WriteLine($"{index} -> {Math.Pow(index,3)}");
    index=index+1;
    }
}
Console.WriteLine("input N=");
 int x=Convert.ToInt32(Console.ReadLine());
 Cube(x);

 //=============================
