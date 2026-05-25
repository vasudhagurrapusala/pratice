using System;
class Try
{
    public static void Main(string[] arge)
    {
        int a=10;
        int b=0;

        int c;
        try{
         c=a/b;
        Console.WriteLine(c);
        }
        catch(NullReferenceException e)
        {
            Console.WriteLine("Error: " + e);
        }
        // catch(DivideByZeroException)
        // {
        //     Console.WriteLine("Error: Cannot divide by zero.");
        // }
        catch(Exception e)
        {
            c= a/1;
            Console.WriteLine("we cant divide by zero so we are using 1 as denominator by default"+c);
            //  Console.WriteLine(c);
        }

    }
}