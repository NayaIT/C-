/* 11. 3rd Bit
Description

Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
The bits are counted from right to left, starting from bit 0.
The result of the expression should be either 1 or 0. Print it on the console.

Input
On the only input line, you will receive a single positive integer - the number whose 3rd bit you must print.

Output
Output a single number - 1 or 0 - the value of the 3rd bit, counted from 0 and from right to left.
 */

namespace _3rdBit
{
    using System;

    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string numberToBinary = Convert.ToString(number, 2).PadLeft(32, '0');
            int length = numberToBinary.Length;
            var result = numberToBinary[length - 4];

            Console.WriteLine(result);

        }
    }
}
