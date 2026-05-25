using System;
namespace day4;
class Refactor
{
    int price=700;
    double discount=2.0;
    int quantity=5;


    public void calculateTotal( int price, int quantity)
    {
        int total=price*quantity;
        Console.WriteLine("the total price is"+total);
    }
    public void calculateDiscount(int total, double discount)
    {
        double discountAmount =total*discount/100;
        Console.WriteLine("the discount is"+discountAmount);
    }
    public void calculateFinalAmount(int total, double discount)
    {
        double finalAmount=total-discount;
        Console.WriteLine("the final amount is"+finalAmount);
    }

/*public static void Main(string[] args)
    {
        Refactor refactor=new Refactor();
        refactor.calculateTotal(refactor.price,refactor.quantity);
        int total=refactor.price*refactor.quantity;
        refactor.calculateDiscount(total,refactor.discount);
        double discountAmount =total*refactor.discount/100;
        refactor.calculateFinalAmount(total,discountAmount);
   }*/
}