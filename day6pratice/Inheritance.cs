using System;
 class Parent
{
     public void dog()
    {
        Console.WriteLine("this is parent method");
    
    }
    class  Animal: Parent
    {
        public void eat()
        {
         Console.WriteLine("this is child method");
        }
    }

    class birds : Animal
    {
        public void fly()
        {
            Console.WriteLine("this is 2nd chaild");
        }
    }
    


    static void Main(String[] arge)
    {
        birds b=new birds();
        b.dog();
        b.eat();
        b.fly();
        

        
    }
}