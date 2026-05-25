using System;

abstract class Employee
{
    public string Name { get; set; }

    // Abstract method
    public abstract decimal CalculateSalary();

    // Normal method
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }
}

class FullTimeEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }
}

class Program
{
    static void Main()
    {
        FullTimeEmployee emp = new FullTimeEmployee
        {
            Name = "Vasudha",
            MonthlySalary = 5000
        };

        emp.DisplayInfo();

        Console.WriteLine($"Salary: {emp.CalculateSalary()}");
    }
} 