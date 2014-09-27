using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter four-digit number :");
        int number = int.Parse(Console.ReadLine());
        int firstDigit = (number / 1000) % 10;
        int secondDigit = (number / 100) % 10;
        int thirdDigit = (number / 10) % 10;
        int fourthDigit = number % 10;
        Console.WriteLine("Sum of digits : {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("Reversed : {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Last digit in front : {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Second and third digits exchanged : {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}