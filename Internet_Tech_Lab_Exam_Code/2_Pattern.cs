using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5; // Number of rows in the pattern

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }

                Console.WriteLine();
            }
        }
    }
}