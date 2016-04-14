/*08. Numbers from 1 to n
Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.
 */

namespace NumbersFrom1ToN
{
    using System;

    class NumbersN
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
