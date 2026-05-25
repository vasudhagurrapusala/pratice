using System;
namespace day5pratice
{
    class Exception
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"The result of {num1} divided by {num2} is: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
            
        }
    }
}
