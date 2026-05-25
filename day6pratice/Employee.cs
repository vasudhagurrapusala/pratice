using System;

class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = "Unknown";

    public decimal Salary { get; private set; }

  
    public string Company { get; }

    public required string Department { get; set; }

    public Employee(decimal salary)
    {
        Salary = salary;
        Company = "Infosys";
    }

    public void Increment(decimal amount)
    {
        Salary += amount;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee(25000)
        {
            Id = 18,
            Department = "IT"
        };

        emp.Name = "Vasudha";

        emp.Increment(5000);

        Console.WriteLine(emp.Id);
        Console.WriteLine(emp.Name);
        Console.WriteLine(emp.Salary);
        Console.WriteLine(emp.Company);
        Console.WriteLine(emp.Department);
    }
}