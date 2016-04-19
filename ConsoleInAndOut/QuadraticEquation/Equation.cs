/*06. Quadratic Equation
Description
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

Input
On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order

Output
If two different real roots exist, print them on two separate lines
Print the smaller root on the first line
If only one real root exists, print it on the only output line
If no real root exists, print the string "no real roots"
The roots, should they exist, must be printed with precision exactly two digits after the floating point
 */

namespace QuadraticEquation
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Equation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double coefficientA = double.Parse(Console.ReadLine());
            double coefficientB = double.Parse(Console.ReadLine());
            double coefficientC = double.Parse(Console.ReadLine());


            double x1, x2;

            //Discriminant < 0
            if (coefficientB * coefficientB - 4 * coefficientA * coefficientC < 0)                                              
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                //Discriminant == 0    
                if (coefficientB * coefficientB - 4 * coefficientA * coefficientC == 0)                                    
                {
                    x1 = x2 = -coefficientB / (2 * coefficientA);
                    Console.WriteLine("{0:F2}", x1);
                }
                //Discriminant > 0
                else
                {
                    x1 = (-coefficientB - Math.Sqrt(coefficientB * coefficientB - 4 * coefficientA * coefficientC)) / (2 * coefficientA);
                    x2 = (-coefficientB + Math.Sqrt(coefficientB * coefficientB - 4 * coefficientA * coefficientC)) / (2 * coefficientA);

                    if (x1 < x2)
                    {
                        Console.WriteLine("{0:F2}\r\n{1:F2}", x1, x2);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}\r\n{1:F2}", x2, x1);
                    }
                }
            }

        }
    }
}
