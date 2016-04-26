/*12. Decimal to Binary
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.

Input
On the only input line you will receive the decimal integer number.

Output
Output a single string - the representation of the input decimal number in it's binary representation.
 */

using System;

namespace DecimalToBinary
{
    class DecimalTBinary
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            //or
            //string output = Convert.ToString(input, 2);

            string output = string.Empty;

            while (input != 0)
            {
                long binary = input % 2;
                input /= 2;

                output += binary.ToString();
            }

            Console.WriteLine(ReverseString(output));
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
