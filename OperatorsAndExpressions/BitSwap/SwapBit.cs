/*15. BitSwap
Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
 */

namespace BitSwap
{
    using System;

    class SwapBit
    {
        static void Main()
        {
            uint numberN;
            bool checkUInteger = uint.TryParse(Console.ReadLine(), out numberN);

            if (checkUInteger == false)
            {
                Console.WriteLine("Out of unsigned integer range!");
            }
            else
            {
                int numberP = int.Parse(Console.ReadLine());
                int numberQ = int.Parse(Console.ReadLine());
                int numberK = int.Parse(Console.ReadLine());
                int lenght = Math.Min(numberP, numberQ) + numberK;

                if (Math.Min(numberP, numberQ) + numberK >= Math.Max(numberP, numberQ))
                {
                    Console.WriteLine("Overlapping!");
                }
                else if (numberP < 0 || numberQ < 0 || numberP + numberK > 32 || numberQ + numberK > 32)
                {
                    Console.WriteLine("Out of range!");
                }
                else
                {
                    for (; Math.Min(numberP, numberQ) < lenght; numberP++, numberQ++)
                    {
                        uint mask1 = (uint)(numberN & 1 << numberP);
                        uint mask2 = (uint)(numberN & 1 << numberQ);

                        if (mask1 != 0)
                        {
                            numberN = numberN | (uint)(1 << numberQ);
                        }
                        else
                        {
                            numberN = numberN & (uint)(~(1 << numberQ));
                        }

                        if (mask2 != 0)
                        {
                            numberN = numberN | (uint)(1 << numberP);
                        }
                        else
                        {
                            numberN = numberN & (uint)(~(1 << numberP));
                        }
                    }

                    Console.WriteLine(numberN);
                }
            }
        }
    }
}
