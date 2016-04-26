/*08. Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula: Cn = (1/n+1) * (2n/n) = (2n)! / (n + 1)! * n! = Pi * (n+k)/k
Write a program to calculate the Nth Catalan number by given N

Input
On the only line, you will receive the number N

Output
Output a single number - the Nth Catalan number

Constraints
N will always be a valid integer number in the range [0, 100]


Cn = (2n)! / (n + 1)! * n!;
 */



namespace CatalanNumbers
{
    using System;
    using System.Numerics;

    class CatalanNum
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            
            
            BigInteger factorial2 = 1;
            BigInteger factorialN = 1;            
            BigInteger catalanN;

            for (int i = 1; i <= 2*N; i++)
            {
                factorial2 *= i;

                if (i <= N)
                {
                    factorialN *= i;
                }
            }

            //Cn = (2n)! / (n + 1)! * n!;
            BigInteger factorielPlus1 = factorialN * (N + 1);
            catalanN = factorial2 / (factorielPlus1 * factorialN);

            Console.WriteLine(catalanN);
        }
    }
}