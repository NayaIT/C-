/*07. Calculate 3!
In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.
Try to use only two loops.
 */

namespace Calculate3_
{
    using System;
    using System.Numerics;

    class Calculate3
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int NK = N - K;

            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger factorielNK = NK;
            BigInteger result = 1;

            //N! / (K! * (N - K)!)

            for (int i = 1, j = 1; i <= N; i++, j++)
            {
                factorielN *= i;

                if (j <= K)
                {
                    factorielK *= j;
                }
            }

            for (int k = 1; k < NK; k++)
            {
                factorielNK *= k;
            }

            result = factorielN / (factorielK * factorielNK);

            Console.WriteLine(result);
        }
    }
}
