//09. Print Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace PrintSequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            int number;

            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    number = i;
                }
                else
                {
                    number = -i;
                }
            
                Console.WriteLine(number);
            }

            //Console.WriteLine("2\n-3\n4\n-5\n6\n-7\n8\n-9\n10\n-11");
        }
    }
}
