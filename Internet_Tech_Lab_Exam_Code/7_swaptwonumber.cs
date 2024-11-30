using System;
class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Swap(ref float a, ref float b)
    {
        float temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        float p = 3.14f, q = 2.71f;
        Console.WriteLine("Before swapping integers:");
        Console.WriteLine("x = " + x + ", y = " + y);
        Console.WriteLine("Before swapping floats:");
        Console.WriteLine("p = " + p + ", q = " + q);
        Swap(ref x, ref y);
        Swap(ref p, ref q);

        Console.WriteLine("After swapping integers:");
        Console.WriteLine("x = " + x + ", y = " + y);

        Console.WriteLine("After swapping floats:");
        Console.WriteLine("p = " + p + ", q = " + q);
    }
}



























Before swapping integers:
x = 10, y = 20
Before swapping floats:
p = 3.14, q = 2.71
After swapping integers:
x = 20, y = 10
After swapping floats:
p = 2.71, q = 3.14