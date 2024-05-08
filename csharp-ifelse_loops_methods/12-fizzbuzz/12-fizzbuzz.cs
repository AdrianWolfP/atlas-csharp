using System;

class Program
{
    static void Main(string[] args)
    {
        int Fizzes;
        for (Fizzes = 1; Fizzes <= 100; ++Fizzes)
        {
            switch (Fizzes)
            {
            case int n when (n % 15 == 0):
                Console.Write("Fizzbuzz");
                break;

            case int n when (n % 5 == 0):
                Console.Write("Buzz");
                break;
            
            case int n when (n % 3 == 0):
                Console.Write("Fizz");
                break;

            default:
                Console.Write(Fizzes);
                break;
            }
            if (Fizzes < 100)
                Console.Write(", ");
        }
    }
}