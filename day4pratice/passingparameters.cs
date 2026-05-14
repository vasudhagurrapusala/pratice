using System;
namespace day4;
class Passingparameters
{
     static void subtract(int a,int b)
    {
        Console.WriteLine("the difference is"+(a-b));
        
    }
   public  static void Main(String[] args)
    {
        Console.WriteLine("enter numbers");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        subtract(a,b);

    }
}