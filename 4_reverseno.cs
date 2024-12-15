using System;
public class ReverseAndSumDigits
{
    public static void Main(string[] args)
    {
        int number, sum = 0, reversedNumber = 0;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number is negative. Converting to positive.");
            number = Math.Abs(number); 
        }
        int originalNumber = number;
        while (number != 0)
        {
            int digit = number % 10;  
            sum += digit;            
            reversedNumber = reversedNumber * 10 + digit;  
            number /= 10;             
        }
        Console.WriteLine("Original Number: " + originalNumber);
        Console.WriteLine("Reversed Number: " + reversedNumber);
        Console.WriteLine("Sum of Digits: " + sum);
    }
}

















Enter a number: 12
Original Number: 12
Reversed Number: 21
Sum of Digits: 3
