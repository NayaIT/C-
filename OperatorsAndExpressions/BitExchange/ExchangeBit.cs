/*14. BitExchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).
 */

namespace BitExchange
{
    using System;

    class ExchangeBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int positionOne = 3;
            int positionTwo = 24;

            int maskOne = 7 << positionOne;
            int maskTwo = 7 << positionTwo;

            int getNumbersOne = number & maskOne;
            int getNumbersTwo = number & maskTwo;
            int change = (number & ~maskOne) & ~maskTwo;

            int maskThree = (getNumbersOne >> positionOne) << positionTwo;
            int maskFour = (getNumbersTwo >> positionTwo) << positionOne;
            int result = (change | maskThree) | maskFour;

            Console.WriteLine(result);
        }
    }
}
