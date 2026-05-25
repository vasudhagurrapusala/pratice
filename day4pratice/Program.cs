using System;

 namespace day4;

class Program
{
   public static void Add()
{
    Console.WriteLine("enter numbers");
    int a=Convert.ToInt32(Console.ReadLine());
    int b=Convert.ToInt32(Console.ReadLine());
    int c=a+b;
    Console.WriteLine("the sum is "+c);
    
}
}
class Hello
    {
        
    
 public static void Main(String[] args)
{
    Program program=new Program();
    Program.Add();
   
    }
}

