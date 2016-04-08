/* 01. Declare Variables
 Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following 
 values: 52130, -115, 4825932, 97, -10000.Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
*/

namespace DeclareVariables
{
    using System;

    class VariablesDeclaration
    {
        static void Main()
        {
            short firstNumber = -10000;
            sbyte secondNumber = -115;
            byte thirdNumber = 97;
            ushort fourthNumber = 52130;
            int fifthNumber = 4825932;

            Console.WriteLine("Represent the following types & numbers: \nshort - {0} \nsbyte - {1} \nbyte - {2} \nushort - {3} \nint - {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }
}
