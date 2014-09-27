using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int variableA = 5;
        int variableB = 10;
        int variableC = variableA;
        Console.WriteLine("Before the exchange: \n{0}\n{1}", variableA, variableB);
        variableA = variableB;
        variableB = variableC;
        Console.WriteLine("After the exchange: \n{0}\n{1}", variableA, variableB);
    }
}