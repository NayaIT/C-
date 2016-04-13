/*08. Prime Check
Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
 */

namespace PrimeCheck
{
    using System;

    class Prime
    {
        static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());

            bool isPrime = false;

            if (numberN > 1 && numberN < 101)
            {
                if (numberN == 2 || numberN == 3 || numberN == 5 || numberN == 7)
                {
                    isPrime = true;
                }
                else if (numberN % 2 != 0 && numberN % 3 != 0 && numberN % 5 != 0 && numberN % 7 != 0)
                {
                    isPrime = true;
                }
            }
            Console.WriteLine(isPrime.ToString().ToLower());
        }
    }
}