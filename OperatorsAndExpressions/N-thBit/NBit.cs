/* 12. N-th bit
 Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.
 */

namespace N_thBit
{
    using System;

    class NBit
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());

            double positionPow = (ulong)Math.Pow(2, 55);

            if ((position < 55) && (number <= positionPow))
            {
                ulong result = (number >> position) & 1;
                Console.WriteLine(result == 0 ? "0" : "1");
            }
        }
    }
}
