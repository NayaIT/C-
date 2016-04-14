/*02. Company Info
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
 */

namespace CompanyInfo
{
    using System;

    class Company
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phonenNumber = Console.ReadLine();
            string faxNAumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            if (faxNAumber.CompareTo(string.Empty) == 0)
            {
                faxNAumber = "(no fax)";
            }

            Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})",
                                companyName, companyAddress, phonenNumber, faxNAumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
