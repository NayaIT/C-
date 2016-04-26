/*06. Calculate Again!
Write a program that calculates N! / K! for given N and K.
Use only one loop.

Input
On the first line, there will be only one number - N
On the second line, there will be only one number - K

Output
Output a single line, consisting of the result from the calculation described above.

Constraints
1 < K < N < 100
Hint: overflow is possible
N and K will always be valid integer numbers
 */

// N!=1*2*3..*K...*N and  K! = 1*2*3.....*K
// N!/K! = 1*2*3..*K*(K+1)...*N/1*2*3.....*K = (K+1)*(K+2)..*N

namespace CalculateAgain_
{
    using System;
    using System.Numerics; //reference for BigInteger

    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            BigInteger factorielN = 1;
            BigInteger factorielK = 1;
            BigInteger result = 1;

            for (int i = 1, j = 1; i <= N; i++, j++)
            {
                factorielN *= i;

                if (j <= K)
                {
                    factorielK *= j;
                }
            }

            result = factorielN / factorielK;

            Console.WriteLine(result);
        }
    }
}