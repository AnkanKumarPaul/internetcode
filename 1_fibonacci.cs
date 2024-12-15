using System;
public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        int n, first = 0, second = 1, next;
        Console.Write("Enter the number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Fibonacci Series: ");
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                next = first;
            }
            else if (i == 1)
            {
                next = second;
            }
            else
            {
                next = first + second;
                first = second;
                second = next;
            }

            Console.Write(next + " ");
        }

        Console.ReadLine();
    }
}

















Enter the number of terms: 10
Fibonacci Series: 0 1 1 2 3 5 8 13 21 34 
