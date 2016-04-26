/*10. Odd and Even Product
You are given N integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

Input
On the first line you will receive the number N
On the second line you will receive N numbers separated by a whitespace

Output
If the two products are equal, output a string in the format "yes PRODUCT_VALUE", otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

Constraints
N will always be a valid integer number in the range [4, 50]
All input numbers from the second line will also be valid integers
 */

using System;
using System.Linq;

namespace OddAndEvenProduct
{
    class OddEvenProduct
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var entities = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // splits string with whitespaces into string[]
            var numbers = entities.Select(x => ulong.Parse(x)).ToArray(); // converts string[] to int[]

            ulong productOdd = 1;
            ulong productEven = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productOdd *= numbers[i];
                }
                else
                {
                    productEven *= numbers[i];
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes {0}", productOdd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }

        }
    }
}
