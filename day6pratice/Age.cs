using System;


class main
{
    
    private int age;
    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value >= 18)
            {
                age=value;
            }
            else
            {
                Console.WriteLine("INVALID AGE");
            }
        }
    }

    static void Main(string[] args)
    {
        main m = new main();
        m.Age=21;
        Console.WriteLine(m.Age);
    }
}
    



        
    
