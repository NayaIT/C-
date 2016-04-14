/*07. Sum of 5 Numbers
Write a program that reads 5 integer numbers from the console and prints their sum.
 */

namespace SumOf5Numbers
{
    using System;

    class SumOfNumbers
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());
            int fifthNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;
            Console.WriteLine(sum);
        }
    }
}