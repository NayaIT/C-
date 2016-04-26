/*03. MMSA of N Numbers
Description
Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
The output is like in the examples below.

Input
On the first line, you will receive the number N.
On each of the next N lines, you will receive a single floating-point number.
 
Output
You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
min=3
max=6
sum=9
avg=4.5

Constraints
1 <= N <= 1000
 */

namespace MMSAOfNNumbers
{
    using System;

    class MMSANumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double number;
            double sum = 0;
            double average;

            //or with List
            //var list = new List<double>();
            var arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                number = double.Parse(Console.ReadLine());
                //list.Add(number);

                arr[i] = number;

                sum += number;
            }

            average = sum / n;
            //list.Sort();

            Array.Sort(arr);

            Console.WriteLine("min={0:F2} \nmax={1:F2} \nsum={2:F2} \navg={3:F2}", arr[0], arr[n - 1], sum, average); // list[0], list[n - 1], sum, average);
        }
    }
}