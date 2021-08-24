using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Test_Client
{
    class BankAccount
    {
        public int id;
        public decimal balance;
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public static void Create(string[] cmdArgs, Dictionary<int,BankAccount> accounts) {
            int id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account is existed !");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.id = id;
                accounts.Add(id, acc);
            }
        }
        public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts) {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not existed");
            }
            else
            {
                accounts[id].Balance += amount;
            }
        }
        public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts) {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not existed");
            }
            else
            {
                accounts[id].Balance -= amount;
            }
        }
        public static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts) {
            int id = int.Parse(cmdArgs[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not existed !");
            }
            else
            {
                Console.WriteLine($"Account ID {accounts[id].id}");
            }
        }
    }
}
