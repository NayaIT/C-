﻿/*05. Calculate!
Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
Use only one loop. Print the result with 5 digits after the decimal point.

Input
On the first line you will receive one number - N.
On the second line you will receive another number - x.

Output
Output only one number - the sum of the sequence for the given N and x.

Constraints
N will always be a valid integer between 2 and 10, inclusive.
X will always be a valid floating-point number between 0.5 and 100
 */

namespace Calculate_
{

    using System;
    using System.Globalization;
    using System.Threading;

    class SumQuotientsFactorialsPowers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ulong N = ulong.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double sum = 1;
            ulong factorial = 1;

            //Sum = 0!/X^0 + 1!/X^1 + 2!/X^2 + … + N!/X^N 
            for (ulong i = 1; i <= N; i++)
            {
                factorial *= i;

                sum += factorial / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum); //or {0:0.00000}
        }

    }
}