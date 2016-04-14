/*01. Numbers from 1 to N
 Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.
 */

namespace NumbersFrom1ToN
{
    using System;

    class NumbersToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
