//15. Age
//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.

namespace Age
{
    using System;

    class AgeAfterTenY
    {
        static void Main()
        {
            DateTime userBirthday = DateTime.Parse(Console.ReadLine()); //please use the following format MM.DD.YYYY
            long result = DateTime.Today.Subtract(userBirthday).Ticks;

            Console.WriteLine(new DateTime(result).Year - 1);
            Console.WriteLine(new DateTime(result).AddYears(10).Year - 1);
        }
    }
}


/* second way - user friendly

Console.Write("Enter your b-day in the following format (MM.DD.YYYY): "); // if the program doesn't work - change location settings
DateTime userBirthday = DateTime.Parse(Console.ReadLine());
long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
Console.WriteLine("In 10 years you will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1); 
 */