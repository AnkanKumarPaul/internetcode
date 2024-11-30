using System;

namespace ReverseAndSumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int reversedNum = 0, sum = 0, remainder;

            while (num > 0)
            {
                remainder = num % 10;
                reversedNum = reversedNum * 10 + remainder;
                sum += remainder;
                num /= 10;
            }

            Console.WriteLine("Reversed number: " + reversedNum);
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}





























Enter a number: 1234
Reversed number: 4321
Sum of digits: 10