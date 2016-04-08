/* 07. Quotes in Strings
Write a program that outputs The "use" of quotations causes difficulties.
 */

namespace QuotesInStrings
{
    using System;

    class PrintQuotes
    {
        static void Main()
        {
            string quotesInStrEscaping = "The \"use\" of quotations causes difficulties.";
            //string quotesInStr = @"The ""use"" of quotations causes difficulties."; //second way
            
            Console.WriteLine(quotesInStrEscaping);
            //Console.WriteLine("Second way to print quotes is: " + quotesInStr);
        }
    }
}
