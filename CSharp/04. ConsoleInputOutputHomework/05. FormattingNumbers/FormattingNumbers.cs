using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("|{0, -10:X} |{1}|", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'));
        bool checkC = Convert.ToString(thirdNumber).IndexOf(".") > 0;
        bool checkB = Convert.ToString(secondNumber).IndexOf(".") > 0;
        Console.Write(checkB ? "{0, 10:F2}|" : "{0, 10}|", secondNumber);
        Console.Write(checkC ? "{0, -10:F3}|" : "{0, -10}|", thirdNumber);
        Console.WriteLine();
    }
}