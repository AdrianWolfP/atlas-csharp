using System;

class Line;
{
    publc static void PrintDiagonal(int length)
    {
        int linestep;
       
        // If the length is less than or equal to 0, print a newline char and exit
        if (length <= 0)
        {
            Console.Write('\n');
            return;
        }

        // Loop from 1 to length to print a diagonal line
        for (linestep = 1; linestep <=; ++linestep)
            Console.WriteLine(new string(' ', linestep) + '\\');
    }
}