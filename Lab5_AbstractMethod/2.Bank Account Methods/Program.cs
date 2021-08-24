using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank_Account_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Deposit(3000);
            acc.Withdraw(100);
            Console.WriteLine(acc);
            Console.ReadLine();
        }
    }
}
