// int FindQuart(double x, double y)
// {
//    if (x>0 && y>0) 
//    return 1;
//     if (x<0 && y>0) 
//    return 2;
//     if (x<0 && y<0) 
//    return 3;
//    if (x>0 && y<0) 
//    return 4;

// return 0;
// }

// Console.WriteLine("input x=");
// double x=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y=");
// double y=Convert.ToDouble(Console.ReadLine());

// int result = FindQuart(x,y);
//  if (result==0)
//  Console.WriteLine("Point not find");
//  else
//   Console.WriteLine($"Point located in {result} quart");

// void  FindCoordinats(int quart)
// {
//     if (quart == 1)
//         Console.WriteLine("x+ y+");
//     if (quart == 2)
//         Console.WriteLine("x- y+");
//     if (quart == 3)
//         Console.WriteLine("x- y-");
//     if (quart == 4)
//         Console.WriteLine("x+ y-");
//     if (quart < 1 || quart > 4)
//         Console.WriteLine("Нет");


// }
// Console.WriteLine("input x=");
//  int x=Convert.ToInt32(Console.ReadLine());
//  FindCoordinats(x);
 //Задача 3. Напишите программу, которая принимает
 // на вход координаты двух точек и находит
 // расстояние между ними в 2D пространстве Math.Sqrt

 //Задача 4. Напишите программу которая принимает 
 //на вход число (N) и выдает на консоль квадраты 
 //чисел от 1 до N


// void Coordinats( double x, double y,double x1, double y1)
// {
//    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x-x1),2)+Math.Pow((y-y1),2)),2));
// }
// Console.WriteLine("input x=");
// double x=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y=");
// double y=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input x1=");
// double x1=Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input y1=");
// double y1=Convert.ToDouble(Console.ReadLine());
// Coordinats(x,y,x1,y1);

void Quad(int N)
{
    if (N<1)
    {
        Console.WriteLine("Вы ввели неправильные данные");
    }
    int index=1;
    while(index < N+1) 
    {
        Console.WriteLine($"{index} -> {Math.Pow(index,2)}");
    index=index+1;
    }
}
Console.WriteLine("input N=");
 int x=Convert.ToInt32(Console.ReadLine());
 Quad(x);