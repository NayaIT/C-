/*05. Numbers Comparer
Write a program that gets two numbers from the console and prints the greater of them.
 */

namespace NumbersComparer
{
    using System;

    class CompareNums
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            //double greaterNumber = Math.Max(firstNumber, secondNumber);
            //
            //Console.WriteLine(greaterNumber);

            bool greaterNumber = firstNumber > secondNumber;

            if (greaterNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
