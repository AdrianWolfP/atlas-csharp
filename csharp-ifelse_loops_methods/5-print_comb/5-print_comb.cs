using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int display = 0;
            for (; display < 99; ++display)
            {
                Console.Write("{0:D2}, ", display);
            }
            Console.Write("{0:D2}\n", display);
        }
    }
}