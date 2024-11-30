using System;

class Furniture
{
    public string Material { get; set; }
    public int Price { get; set; }
}

class Table : Furniture
{
    public double Height { get; set; }
    public double SurfaceArea { get; set; }

    public void AcceptData()
    {
        Console.Write("Enter material: ");
        Material = Console.ReadLine();
        Console.Write("Enter price: ");
        Price = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        Height = double.Parse(Console.ReadLine());
        Console.Write("Enter surface area: ");
        SurfaceArea = double.Parse(Console.ReadLine());
    }

    public void DisplayData()
    {
        Console.WriteLine("Material: " + Material);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Surface Area: " + SurfaceArea);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();
        table.AcceptData();
        table.DisplayData();
    }
}





























Enter material: wood
Enter price: 1000
Enter height: 12
Enter surface area: 23
Material: wood
Price: 1000
Height: 12
Surface Area: 23