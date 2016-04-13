/* 01. Odd or Even
Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, 
and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
 */

namespace OddOrEven
{
    using System;

    class OddEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            //first way with if-else statement
            if (number%2==0)
            {
                Console.WriteLine("even {0}", number);
            }
            else
            {
                Console.WriteLine("odd {0}", number);
            }

            //second way with bool and ?: operator
            //bool isEven = number % 2 == 0;
            //Console.WriteLine(isEven ? "even {0}" : "odd {0}", number);
        }
    }
}
