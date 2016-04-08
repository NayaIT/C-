/* 04. Unicode Character
Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.
 */

namespace UnicodeCharacter
{
    using System;

    class UnicodeChar
    {
        static void Main()
        {
            //int decimalNumber = 0x2A;
            char symbol = '\u002A';

            Console.WriteLine(symbol);
            //Console.WriteLine("The desimal number {0} in hexadesimal format is '2A'. The symbol that has Unicode code {0} is {1}", decimalNumber, symbol);
        }
    }
}
