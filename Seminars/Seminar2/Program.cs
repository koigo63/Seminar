// int MaxNumber(int num)
// {
//     int a=num/10;
//     int b=num%10;
//     if (a>b)
//     {
//         return a;       
//     }
//     else
//     {
//         return b;
//     }
// }

// int randomNumder=new Random().Next(10,100);
// Console.WriteLine(randomNumder);
// int result =MaxNumber(randomNumder);
// Console.WriteLine(result);

// int DeleteNumber (int num)
// {
//   int sot=num/100*10;
//   int ed=num%10;
//   return  sot+ed;
// }
// int randomNumder=new Random().Next(100,1000);
// Console.WriteLine(randomNumder);
// int result = DeleteNumber(randomNumder);
// Console.WriteLine(result);
// void Kratnoe (int num,int num2)
// {
//     int ed=num2%num;
//     if (ed==0)
//     {
//     Console.WriteLine($"{num2} кратно {num}");
//     }
//     else
//     {
//     Console.WriteLine($"{num2} не кратно {num}, остаток = {ed}");    
//     }
// }
// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32( Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32( Console.ReadLine());
//  Kratnoe(a,b);

bool Kratnost(int num)
{
    int ost = num % 7 + num % 23;
    if (ost == 0)
    {
        return true;
    }
    else
        return false;

}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
bool result = Kratnost(a);
Console.WriteLine(result);



