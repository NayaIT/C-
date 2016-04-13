/*05. Biggest of 3
Write a program that finds the biggest of three numbers that are read from the console.
 */

namespace BiggestOf3
{
    using System;

    class BiggestOfThree
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double maxNumberFromFirstAndSecond = Math.Max(firstNumber, secondNumber);

            if (maxNumberFromFirstAndSecond>thirdNumber)
            {
                Console.WriteLine(maxNumberFromFirstAndSecond);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
