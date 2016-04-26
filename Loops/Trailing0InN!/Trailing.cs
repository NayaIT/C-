/*16. Trailing 0 in N!
Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
Your program should work well for very big numbers, e.g. N = 100000.

Input
On the only input line, you will receive a single integer - the number N

Output
Output a single number - the count of trailing zeroes for the N!

Constraints
N will always be a valid positive integer number.
 */

using System;

public class Trailing
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int zeros = 0;
        int divider = 5;

        while (input / divider >= 1)
        {
            zeros += input / divider;
            divider *= 5;
        }

        Console.WriteLine(zeros);
    }
}