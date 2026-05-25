using System;
using System.ComponentModel;

class Lambda
{
delegate int AddNumbers(int a, int b);

    static void Main()
    {
        AddNumbers add = (x, y) => x + y;

        Console.WriteLine(add(5, 15));
    }
}
