/* 03. Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. 
Print the variable and ensure that the result is 254.
 */

namespace VariableInHexadecimalFormat
{
    using System;

    class HexadecimalFormat
    {
        static void Main()
        {
            int numberInHexadecimal = 0xFE; //we can use also const
            Console.WriteLine(numberInHexadecimal);

            //int number = 0xFE;
            //string numberInHexadecimal = "0x##";
            //
            //Console.WriteLine("The value {0} in hexadecimal format is {1}", number, numberInHexadecimal");
        }
    }
}
