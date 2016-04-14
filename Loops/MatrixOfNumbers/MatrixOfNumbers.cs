/*09. Matrix of Numbers
Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.

Challenge: achieve the same effect without nested loops
 */

namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", i);

                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(j);
                }
                
            }
        }
    }
}
