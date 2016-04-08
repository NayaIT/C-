/* 13. Comparing Floats
 Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */

namespace ComparingFloats
{
    using System;

    class Comparing
    {
        static void Main()
        {
            const double eps = 0.000001; 

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            bool equal = Math.Abs(firstNumber - secondNumber) < eps;

            Console.WriteLine(equal ? "true" : "false");
            
        }
    }
}