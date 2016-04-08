/* 14. Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).
Note: You may need to use for-loops (learn in Internet how).
 */

namespace PrintASCIITable
{
    using System;
    using System.Text;

    class ASCIITable
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                char symbol = (char)i;    

                Console.Write(symbol);
            }

            //second way with StringBuilder
            //var stringBuilder = new StringBuilder();
            //for (int i = 33; i <= 126; i++)
            //{
            //    stringBuilder.Append((char)i);
            //}
            //
            //Console.WriteLine(stringBuilder);
        }
    }
}
