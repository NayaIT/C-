/* 09. Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
 */

namespace ExchangeVariableValues
{
    using System;

    class ExchangeVariable
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Print the variables values before the exchange: a = {0} and b = {1}", a, b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Print the numbers after exchange: a = {0} and B = {1}", a, b);
        }
    }
}
