using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int LastDigit = Math.Abs (number % 10);
        Console.Write("{0}", LastDigit);
        return LastDigit;
    }
}