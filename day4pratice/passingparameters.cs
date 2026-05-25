using System;
namespace day4;
// class Passingparameters
// {
//      static void subtract(int a,int b)
//     {
//         Console.WriteLine("the difference is"+(a-b));
        
//     }
//    /*public  static void Main(String[] args)
//     {
    //     Console.WriteLine("enter numbers");
    //     int a=Convert.ToInt32(Console.ReadLine());
    //     int b=Convert.ToInt32(Console.ReadLine());
    //     subtract(a,b);

    // }*/

    

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
}