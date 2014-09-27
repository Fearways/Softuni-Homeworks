using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ((number & 1) == 1) 
        {
            Console.WriteLine("odd : " + true);
        }
        else
        {
            Console.WriteLine("odd : " + false);
        }
    }
}