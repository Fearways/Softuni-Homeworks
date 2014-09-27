using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Name";
        string middleName = "Middle";
        string lastName = "Last";
        decimal money = 3950.57m;
        string bankName = "DSKBank";
        string iban = "BG32 UBBS 4586 1234 6179 05";
        long cardNumber1 = 123675432123509;
        long cardNumber2 = 908745633123456;
        long cardNumber3 = 574836125644789;
        Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
    }
}