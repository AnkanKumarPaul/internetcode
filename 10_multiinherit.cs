using System;

public class Student
{
    public int Roll_no { get; set; }
    public string Name { get; set; }

    public Student(int rollNo, string name)
    {
        Roll_no = rollNo;
        Name = name;
    }
}

public class Test : Student
{
    public int Marks1 { get; set; }
    public int Marks2 { get; set; }

    public Test(int rollNo, string name, int marks1, int marks2) : base(rollNo, name)
    {
        Marks1 = marks1;
        Marks2 = marks2;
    }
}

public class Result : Test
{
    public int Total { get; set; }

    public Result(int rollNo, string name, int marks1, int marks2) : base(rollNo, name, marks1, marks2)
    {
        Total = Marks1 + Marks2;
    }

    public void DisplayResult()
    {
        Console.WriteLine($"Roll No: {Roll_no}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks1: {Marks1}");
        Console.WriteLine($"Marks2: {Marks2}");
        Console.WriteLine($"Total Marks: {Total}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Roll No: ");
        int rollNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks1: ");
        int marks1 = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks2: ");
        int marks2 = int.Parse(Console.ReadLine());

        Result result = new Result(rollNo, name, marks1, marks2);
        result.DisplayResult();

        Console.ReadLine();
    }
}























Enter Roll No: 10
Enter Name: ankan
Enter Marks1: 75
Enter Marks2: 79
Roll No: 10
Name: ankan
Marks1: 75
Marks2: 79
Total Marks: 154
