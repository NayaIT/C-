﻿/*04. Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
 */

namespace MultiplicationSign
{
    using System;

    class MultiplSign
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double product = firstNumber * secondNumber * thirdNumber;

            if (firstNumber == 0 | secondNumber == 0 | thirdNumber == 0 )
            {
                
                Console.WriteLine(0);
            }
            else if (firstNumber > 0 & secondNumber > 0 & thirdNumber > 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber > 0 & secondNumber < 0 & thirdNumber < 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 & secondNumber > 0 & thirdNumber < 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 & secondNumber < 0 & thirdNumber > 0)
            {
                Console.WriteLine("+");
            }
            else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            
        }
    }
}
