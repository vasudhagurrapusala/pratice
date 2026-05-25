using System;
using System.ComponentModel;
class Sealed
{

    public void Add()
    {
        int a=10,b=20;
        int c=a+b;
        Console.WriteLine(c);
    }

    class MUL: Sealed
    {
        public void Sub()
        {
        int a=10,b=20;
        int c=a-b;
        Console.WriteLine(c);
            
        }
    }
    static void Main(String[] args)
    { 
        MUL s=new MUL();
        s.Add();
        s.Sub();

    }
}