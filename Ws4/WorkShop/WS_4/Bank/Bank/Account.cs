using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        static void Main(string[] args)
        {
            // Array of integer to store customer ID and account number
            int[] customerID = new int[3];
            int[] accountNumber = new int[3];

            // Array of string to store account type
            string[] accountType = new string[3];

            //Array of datetime to store the date on which the account is opened
            DateTime[] dateOpened = new DateTime[3];

            // Array of double to store desposit and balance
            double[] deposit = new double[3];
            double[] balance = new double[3];

            // Integer variable to store the account number entered
            int  choice = 0;
            int i = 0;
            bool found = false;

            // Accepting the details of account using goto and return statements
            accept:
            {
                Console.Write("Enter the ID of customer : ");
                customerID[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter account number : ");
                accountNumber[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter account type [Fixed/Savings] : (F/S) ");
                accountType[i] = Console.ReadLine();

                Console.Write("Enter the date of opening account [MM/DD/YYYY] : ");
                dateOpened[i] = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Enter the amount desposited : ");
                deposit[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if (deposit[i] <= 0)
                {
                    Console.WriteLine("Invalid Data Entry");
                    return;
                }
                else
                {
                    // Calculating the balance
                    balance[i] = balance[i] + deposit[i];
                }
                i++;
            }
            if (i < customerID.Length)
            {
                goto accept;
            }

            // Displaying the account details
            Console.WriteLine("Account Details : \n");
            Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($)     Balance($)");

            for (i = 0; i < customerID.Length; i++)
            {
                Console.Write("{0}\t{1}  \t", customerID[i], accountNumber[i]);
                Console.Write("{0}\t   {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                Console.WriteLine("{0}\t       {1}", deposit[i], balance[i]);
            }

            // Displaying the details of all except those that were created today
             Console.WriteLine("\n\nAccount  Details : \n");
            Console.WriteLine("ID\tA/c No.\tA/c Type  Opening Date\tDeposit($)   Balance($)");
            DateTime today = DateTime.Today.Date;

            for (i = 0; i < customerID.Length; i++)
            {
                //caculate the difference between dates
                int num = (today.Subtract(dateOpened[i])).Days;
                if (num == 0)
                    continue;
                else
                {
                    Console.Write("{0}\t {1}  \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);
                    
                }
            }

            // Accepting an account number to view details

            Console.Write("\nEnter the account number whose details you want to view :");
            choice = Convert.ToInt32(Console.ReadLine());

            // Displaying the account details according to the choice entered using break statement
            for (i = 0; i < accountNumber.Length; i++)
            {
                if (accountNumber[i] == choice)
                {
                    found = true;

                    Console.WriteLine("Record Found !");
                    Console.WriteLine("ID\tA/c No.\tA/c Type Opening Date\tDeposit($)    Balance($)");
                    Console.Write("{0}\t{1} \t", customerID[i], accountNumber[i]);
                    Console.Write("{0}\t  {1}\t", accountType[i], dateOpened[i].ToShortDateString());
                    Console.WriteLine("{0}\t    {1}", deposit[i], balance[i]);
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Account does not exist.");
        }
    }
}
