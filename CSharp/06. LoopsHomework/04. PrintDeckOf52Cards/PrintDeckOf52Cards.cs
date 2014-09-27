using System;

class PrintDeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i <= 14; i++)
        {
            for (int k = 0; k < 4; k++)
            {
                switch (i)
                {
                    case 2:
                        Console.Write("2");
                        break;
                    case 3:
                        Console.Write("3");
                        break;
                    case 4:
                        Console.Write("4");
                        break;
                    case 5:
                        Console.Write("5");
                        break;
                    case 6:
                        Console.Write("6");
                        break;
                    case 7:
                        Console.Write("7");
                        break;
                    case 8:
                        Console.Write("8");
                        break;
                    case 9:
                        Console.Write("9");
                        break;
                    case 10:
                        Console.Write("10");
                        break;
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                }
                switch (k)
                {
                    case 0:
                        Console.Write("♣");
                        break;
                    case 1:
                        Console.Write("♦");
                        break;
                    case 2:
                        Console.Write("♥");
                        break;
                    case 3:
                        Console.Write("♠");
                        break;
                }
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}