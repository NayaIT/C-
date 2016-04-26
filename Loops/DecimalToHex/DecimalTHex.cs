/*13. Decimal to Hex
Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.

Input
On the first and only line you will receive an integer in the decimal numeral system.

Output
On the only output line write the hexadecimal representation of the read number.
Constraints
All numbers will always be valid 64-bit integers.
 */

using System;
using System.Text;

namespace DecimalToHex
{
    class DecimalTHex
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            while (input != 0)
            {
                var number = input % 16;
                input /= 16;

                sb.Insert(0, number.ToString("X"));

            }

            Console.WriteLine(sb);           
        }
    }
}

//2nd way
//string output = string.Empty;
//output = number.ToString("X");
//Console.WriteLine(number.ToString("X"));