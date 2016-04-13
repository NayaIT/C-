/* 05. Third digit
Write a program that reads an integer N from the console and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
The counting is done from right to left, meaning 123456's third digit is 4.
 */

namespace ThirdDigit
{
    using System;

    class ThirdD
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            int number = numberN / 100;
            int thirdDigit = number % 10;

            Console.WriteLine(thirdDigit == 7 ? "true" : "false {0}", thirdDigit);

        }
    }
}