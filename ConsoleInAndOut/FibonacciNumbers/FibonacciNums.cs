/*10. Fibonacci Numbers
Description
Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

Input
On the only line you will receive the number N

Output
On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)

Constraints
1 <= N <= 50
N will always be a valid positive integer number
Time limit: 0.1s
Memory limit: 16MB
 */

namespace FibonacciNumbers
{
    using System;

    class FibonacciNums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long currentNumber;
            long firstNumber = 0;
            long secondNumber = 1;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    currentNumber = firstNumber;
                }
                else if (i == 1)
                {
                    currentNumber = secondNumber;
                }
                else
                {
                    currentNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                }

                if (i < n - 1)
                {
                    Console.Write("{0}, ", currentNumber);
                }
                else
                {
                    Console.Write(currentNumber);
                }

            }

           
