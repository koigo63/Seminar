// Задача 10
//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает 
//вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//=======
// void SecondDidgit(int num)
// {
// int didgit=num%100/10;
// Console.WriteLine(didgit);
// }
// Console.WriteLine("Введите трехзначное число");
//  int b = Convert.ToInt32( Console.ReadLine());
//   SecondDidgit(b);

//=====
// Задача 13:
// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//====
void Thirddigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int index = 1000;
        int qt=1;
              while (index <num+1)
        {
                      qt=qt*10;
            index = index * 10;
        }
         int numb=num/(qt);
         int dig3=numb%10;
         Console.WriteLine($"Третья цифра = {dig3}");
    }
   }
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Thirddigit(a);
// ======

//*Задача 15:
// Напишите программу, которая принимает
// на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// string Day(int num)
// {
//     if (num == 6 | num == 7)
//     {
//         string a = "да, является выходным";
//         return a;
//     }
//     else
//     {
//         string c = "нет, не является выходным";
//     return c;
//     }
// }
// Console.WriteLine("Введите номер дня недели");
// int b = Convert.ToInt32(Console.ReadLine());
// string result = Day(b);
// Console.WriteLine(result);

//=====