/* 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
 */

namespace EmployeeData
{
    using System;

    class Employee
    {
        static void Main()
        {
            Console.WriteLine("Please enter your unique employee number: ");
            long uniqueNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            string firstName = "Jhon";
            string lastName = "Jackson";
            int age = 36;
            char gender = 'm';
            long personalID = 8002196754;
            long uniqueEmNumber = uniqueNumber;

            Console.WriteLine(" | First name: {0} \n | Last Name: {1} \n | Age: {2} \n | Gender: {3} \n | Personal ID number: {4} \n | Unique employee number: {5}", firstName, lastName, age, gender, personalID, uniqueEmNumber);
        }
    }
}
