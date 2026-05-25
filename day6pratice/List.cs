using System;
using System.Linq;
class List
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>(){1,2,3,4,56};

        List<int> evenNumbers= new List<int>();
         //  //when we use LINQ
        List<int> evenNumber =numbers.Where(n => n % 2 == 0).ToList();

        foreach( int  n in  evenNumber)
        {
            if (n % 2 == 0)
            {
               Console.WriteLine(n);
            }
        
        }

    }
}