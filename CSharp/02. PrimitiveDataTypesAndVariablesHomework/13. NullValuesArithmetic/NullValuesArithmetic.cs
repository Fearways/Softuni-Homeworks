using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableInteger = null;
        double? floatNumber = null;
        Console.WriteLine("Null value: " + nullableInteger);
        Console.WriteLine("Null value: " + floatNumber);

        nullableInteger += 3;
        floatNumber += 9.5;
        Console.WriteLine("Number + null value: " + nullableInteger);
        Console.WriteLine("Number + null value: " + floatNumber);

        nullableInteger = 1;
        floatNumber = 5.5;
        Console.WriteLine("Number value: " + nullableInteger);
        Console.WriteLine("Number value: " + floatNumber);
    }
}