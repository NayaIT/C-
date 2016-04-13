/* 09. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h. 
The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
 */

namespace Trapezoids
{
    using System;

    class Trapezoid
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine("{0:0.0000000}", area);
        }
    }
}
