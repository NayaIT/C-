/*04. Rectangles
 Write an expression that calculates rectangle’s area and perimeter by given width and height. The width and height should be read from the console.
 */

namespace Rectangles
{
    using System;

    class Rect
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);

        }
    }
}
