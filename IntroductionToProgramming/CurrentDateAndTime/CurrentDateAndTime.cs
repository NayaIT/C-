//14. Current Date and Time
//Create a console application that prints the current date and time. Find out how in Internet.

namespace CurrentDateAndTime
{
    using System;

    class CurrentDateAndTime
    {
        static void Main()
        {
            DateTime date = DateTime.Today;

            Console.WriteLine("Current Date and Time: \n{0}", date);
        }
    }
}
