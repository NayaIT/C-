/* 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

namespace BankAccountData
{
    using System;

    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine("Please enter your names each on separate line: ");
            string name = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();

            string bankName = "Societe Generale Expressbank";
            long moneyBalance = 170000;
            string iban = "BG78 UNCTT 319631 38179";

            long creditCardN1 = 89731964;
            long creditCardN2 = 64296510;
            long creditCardN3 = 59874396;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("{0} \n\nAcount details: {1} {2} {3} \nIBAN: {4} \nBalance: {5} \nCredit Cards: \nNo: {6} \nNo: {7} \nNo: {8}", bankName, name, middleName, lastName, iban, moneyBalance, creditCardN1, creditCardN2, creditCardN3);
        }
    }
}
