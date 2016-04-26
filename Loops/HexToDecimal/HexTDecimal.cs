/*14. Hex to Decimal
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Input
The input will consists of a single line containing a single hexadecimal number as string.

Output
The output should consist of a single line - the decimal representation of the number as string.

Constraints
All numbers will be valid 64-bit integers.
 */

using System;

namespace HexToDecimal
{
    class HexTDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();

            ////int decValue = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            //int decValue = Convert.ToInt32(input, 16);

            long decimalNum = 0;

            for (int index = 0; index < input.Length; index++)
            {
                var digit = input[index];
                int symbol;
                switch (digit)
                {
                    case 'A':
                        {
                            symbol = 10;
                            break;
                        }
                       
                    case 'B':
                        {
                            symbol = 11;
                            break;
                        }
                     
                    case 'C':
                        {
                            symbol = 12;
                            break;
                        }
                        
                    case 'D':
                        {
                            symbol = 13;
                            break;
                        }
                      
                    case 'E':
                        {
                            symbol = 14;
                            break;
                        }
                    
                    case 'F':
                        {
                            symbol = 15;
                            break;
                        }
                       
                    default:
                        {
                            symbol = (int)char.GetNumericValue(digit);
                            break; // -48 because of ASCII
                        }
                }

                decimalNum += (long)Math.Pow(16, input.Length - 1 - index) * symbol;
            }

            Console.WriteLine(decimalNum);
        }
    }
}
