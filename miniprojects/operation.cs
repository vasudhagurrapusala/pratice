
namespace miniproject;
class Operation
{
    public static decimal Add(decimal num1, decimal num2)
    {
        try
        {
            return num1 + num2;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            return 0;
        }
    }
}