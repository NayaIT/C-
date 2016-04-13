/*06. Biggest of 5
Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
 */


namespace BiggestOf5
{
    using System;

    class BiggestOfFive
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            double forthNumber = double.Parse(Console.ReadLine());
            double fifthNumber = double.Parse(Console.ReadLine());

            double maxFromFirstAndSecond = Math.Max(firstNumber, secondNumber);
            double maxFromThirdAndForth = Math.Max(thirdNumber, forthNumber);

            if (maxFromFirstAndSecond > maxFromThirdAndForth & maxFromFirstAndSecond > fifthNumber)
            {
                Console.WriteLine(maxFromFirstAndSecond);
            }
            else if (maxFromThirdAndForth > maxFromFirstAndSecond & maxFromThirdAndForth > fifthNumber)
            {
                Console.WriteLine(maxFromThirdAndForth);
            }
            else
            {
                Console.WriteLine(fifthNumber);
            }
        }
    }
}
