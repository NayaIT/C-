/* 02. Float or Double
 Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 
 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

namespace FloatOrDouble
{
    using System;

    class FloatDouble
    {
        static void Main()
        {
            float firstNumber = 12.345f;
            double secondNumber = 34.567839023d;
            float thirdNumber = 3456.091f;
            double fourthNumber = 8923.1234857d;

            Console.WriteLine("Represent the following types & numbers:\n \nfloat - {0} \ndouble - {1} \nfloat - {2} \ndouble - {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);

        }
    }
}
