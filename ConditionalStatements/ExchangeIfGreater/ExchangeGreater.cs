/*01. Exchange If Greater
Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one. Use an if-statement. 
As a result print the values of the variables A and B, separated by a space.
 */

namespace ExchangeIfGreater
{
    using System;

    class ExchangeGreater
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double tempNum;

            //bool greaterAB =(a > b); 

            if (numberA > numberB)
            {
                tempNum = numberA;
                numberA = numberB;
                numberB = tempNum;

                Console.WriteLine("{0} {1}", numberA, numberB);
            }
            else
            {
                Console.WriteLine("{0} {1}", numberA, numberB);
            }
        }
    }
}

/*
Temp variable:
t = y;
y = x;
x = t;
*/