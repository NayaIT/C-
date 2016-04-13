/*07. Sort 3 Numbers
 Write a program that enters 3 real numbers and prints them sorted in descending order.

Use nested if statements.
Don’t use arrays and the built-in sorting functionality.
 */

namespace Sort3Numbers
{
    using System;

    class SortNumbers
    {
        static void Main()
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber & firstNumber > thirdNumber)
            {
                if (secondNumber > thirdNumber)
                {
                    Console.Write("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else if (secondNumber > firstNumber & secondNumber > thirdNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }

            }
            else if (thirdNumber > firstNumber & thirdNumber > secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
                }
            }
            else if (firstNumber == secondNumber & thirdNumber == secondNumber)
            {
                Console.Write("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }

        }
    }
}
