/* Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©

Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it. */

namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    class IsoTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int uniCode = 169;
            //char symbol = '\u00A9';

            Console.WriteLine(@"
                                   ©
                                  © ©
                                 ©   ©
                                © © © ©
                                ");

            //second way
            //Console.WriteLine("    {0} \n", symbol);
            //Console.WriteLine("   {0} {0} \n", symbol);
            //Console.WriteLine("  {0}   {0} \n", symbol);
            //Console.WriteLine(" {0} {0} {0} {0}\n", symbol);
        }
    }
}
