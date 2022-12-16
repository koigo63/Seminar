Console.WriteLine("Введи число");
int N = Convert.ToInt32( Console.ReadLine());
int i=2;
 
if (N==1)
 {
   Console.WriteLine($"Четные числа меньшие {N}: "); 
  }
  else
  {
  //  i=2;
   Console.WriteLine($"Четные числа меньшие {N}: ");
       while (i<N+1)
     {
 // Console.WriteLine("Четные числа vtymib:"); 
  Console.Write($" {i} "); 
 
 i=i+2;
 }
  }
   Console.WriteLine(""); 





