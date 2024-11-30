using System;

class Distance
{
    public int Dist1 { get; set; }
    public int Dist2 { get; set; }
    public int Dist3 { get; set; }

    public Distance(int dist1, int dist2)
    {
        Dist1 = dist1;
        Dist2 = dist2;
    }

    public void AddDistances()
    {
        Dist3 = Dist1 + Dist2;
    }

    public void DisplayDistance()
    {
        Console.WriteLine("Total distance: " + Dist3);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Distance distance = new Distance(10, 20);
        distance.AddDistances();
        distance.DisplayDistance();
    }
}



















Total distance: 30