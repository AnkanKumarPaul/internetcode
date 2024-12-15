using System;

public class Salary
{
    public double Basic { get; set; }
    public double TA { get; set; }
    public double DA { get; set; } = 0.10; 
    public double HRA { get; set; } = 0.05; 

    public Salary(double basic, double ta)
    {
        Basic = basic;
        TA = ta;
    }

    public double CalculateSalary()
    {
        return Basic + TA + (Basic * DA) + (Basic * HRA);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Salary employeeSalary = new Salary(50000, 5000);
        double totalSalary = employeeSalary.CalculateSalary();

        Console.WriteLine($"Total Salary: {totalSalary}");
        Console.ReadLine();
    }
}























Total Salary: 62500
