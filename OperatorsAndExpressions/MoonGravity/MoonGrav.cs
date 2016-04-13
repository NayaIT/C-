/* 02. Moon Gravity
The gravitational field of the Moon is approximately 17% of that on the Earth.

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
The weight W should be read from the console.
 */

namespace MoonGravity
{
    using System;

    class MoonGrav
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());

            double weightOnMoon = weight * 0.17;

            Console.WriteLine("{0:0.000}", weightOnMoon);
        }
    }
}