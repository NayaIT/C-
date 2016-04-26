/*09. Matrix of Numbers
Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.
Challenge: achieve the same effect without nested loops

Input
The input will always consist of a single line, which contains the number N

Output
See the examples.

Constraints
1 <= N <= 20
N will always be a valid integer number
 */

namespace MatrixOfNumbers
{
    using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //int [,] currentNum = new int [n, n];

            for (int row = 1; row <= n; row++)
            {
               
                for (int col = row; col < row + n; col++)
                {
                    
                    Console.Write("{0} ", col);
                }

                Console.WriteLine();
            }

        }
    }
}
