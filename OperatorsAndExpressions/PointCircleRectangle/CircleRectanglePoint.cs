/* 10. Point, Circle, Rectangle
Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

namespace PointInACircle
{
    using System;

    class CirclePoint
    {
        static void Main()
        {

            const double r = 1.5;
            const double circleX = 1;
            const double circleY = 1;
            const double top = 1;
            const double left = -1;
            const double width = 6;
            const double height = 2;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //double distanceCircle = Math.Sqrt(x * x + y * y);

            bool isInCircle = (Math.Abs(x - circleX)) * (Math.Abs(x - circleX)) + (Math.Abs(y - circleY)) * (Math.Abs(y - circleY)) <= r * r;

            bool isInRectangle = (x < width && y >= left) && (y >= left && y <= top);

            Console.Write(isInCircle ? "inside circle " : "outside circle ");
            Console.Write(isInRectangle ? "inside rectangle" : "outside rectangle");
        }
    }
}
