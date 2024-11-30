using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, number;

            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); // print the first two Fibonacci numbers

            for (i = 2; i < number; ++i) // start from the third Fibonacci number
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.Write("\n");
        }
    }
}

























Enter the number of elements: 10
0 1 1 2 3 5 8 13 21 34 