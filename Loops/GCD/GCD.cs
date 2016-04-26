/*15. GCD
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
Use the Euclidean algorithm (find it in Internet).

Input
On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.

Output
Output a single number - the GCD of the numbers A and B.

Constraints
The numbers A and B will always be valid integers in the range [2, 500].
 */

using System;
using System.Linq;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var entities = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // splits string with whitespaces into string[]
            var numbers = entities.Select(x => ulong.Parse(x)).ToArray(); // converts string[] to int[]

            var a = numbers[0];
            var b = numbers[1];

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b; //swap
                }
                else
                {
                    b = b - a;
                }
                   
            }

            Console.WriteLine(a);
        }
    }
}