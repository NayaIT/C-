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
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double coefficientA = double.Parse(Console.ReadLine());
            double coefficientB = double.Parse(Console.ReadLine());
            double coefficientC = double.Parse(Console.ReadLine());
            
            //string output = string.Empty;

            //double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC; 
            double discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
            double discriminantRoot = Math.Sqrt(discriminant);

            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (discriminant == 0)
            {

                double x = -coefficientB / (2 * coefficientA); //-b / (2 * a);

                Console.WriteLine("{0:0.00}", x);
            }
            else
            {
                
                double x1 = (-coefficientB + discriminantRoot) / (2 * coefficientA);
                double x2 = (-coefficientB - discriminantRoot) / (2 * coefficientA);

                double maxX = Math.Max(x1, x2);
                double minX = Math.Min(x1, x2);

                Console.WriteLine("{0:0.00} \n{1:0.00}", maxX, minX);

                //if (x1 > x2)
                //{
                //    Console.WriteLine("{0:0.00} \n{1:0.00}", x1, x2);
                //}
                //else
                //{
                //    Console.WriteLine("{0:0.00} \n{1:0.00}", x2, x1);
                //}
            }
          
        }
    }
}

/*
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string output = string.Empty;

        double discriminant = (b * b) - (4 * a * c);
        if (discriminant < 0)
        {
            output = "no real roots";
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            output = string.Format("{0:F2}", root);
        }
        else
        {
            double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
            string formatedOutput = "{0:F2}\n{1:F2}";

            output = firstRoot < secondRoot ?
               string.Format(formatedOutput, firstRoot, secondRoot) :
               string.Format(formatedOutput, secondRoot, firstRoot);
        }

        Console.WriteLine(output);
*/