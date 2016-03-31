//Problem 16.* Print Long Sequence
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

namespace LongSequence
{
    using System;
    class Program
    {
        
        static void Main()
        {
            int numberToPrint;
            for (int i = 0; i <1001; i++)
            {
                if (i % 2 == 0)
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i*(-1);
                }
                Console.WriteLine(numberToPrint);
            }
        }
    }
}
