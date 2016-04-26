/*11. Binary to Decimal
Using loops write a program that converts a binary integer number to its decimal form
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Input
You will receive exactly one line containing an integer number representation in binary

Output
On the only output line write the decimal representation of the number

Constraints
All input numbers will be valid 32-bit integers
 */

using System;

namespace BinaryToDecimal
{
    class BinaryTDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();

            long decimalNum = 0;

            for (int index = 0; index < input.Length; index++)
            {
                var digit = input[index];

                if (digit == '0')
                {
                    continue;
                }

                decimalNum += (long)Math.Pow(2, input.Length - 1 - index);
            }

            Console.WriteLine(decimalNum);

            //or
            //Console.WriteLine(Convert.ToInt32(input, 2).ToString());

            //or
            //Console.WriteLine(Convert.ToInt64(input, 2));

        }
    }
}