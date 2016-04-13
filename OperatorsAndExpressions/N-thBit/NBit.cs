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
            uint number = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            uint mask = 1;

            var valueOfNBit = ((mask << position & number) == 0) ? "0" : "1";

            //int valueOfNBit = (number >> position) & 1;

            Console.WriteLine(valueOfNBit);
        }
    }
}
