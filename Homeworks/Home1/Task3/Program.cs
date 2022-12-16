Console.WriteLine("Введи число");
int a = Convert.ToInt32( Console.ReadLine());

int ost=a % 2;
if (ost!=0) 
{
 Console.WriteLine($"{a} четное число?");    
Console.WriteLine("Нет");  
}
else
{
    Console.WriteLine($"{a} четное число?"); 
    Console.WriteLine("Да");
}
