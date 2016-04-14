/*03. Circle
Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.
 */

namespace Circle
{
    using System;

    class Circle
    {
        static void Main()
        {
            const double pi = 3.14159265;
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * pi * radius;
            double area = pi * Math.Pow(radius, 2);

            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        }
    }
}
