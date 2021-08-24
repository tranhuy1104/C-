using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Test_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            while (commands[0]!="stop")
            {
                if (commands[0] == "create")
                {
                    BankAccount.Create(commands, accounts);
                }else if(commands[0]=="deposit"){
                    BankAccount.Deposit(commands, accounts);
                }
                else if (commands[0] == "withdraw")
                {
                    BankAccount.Withdraw(commands, accounts);
                }

                else if (commands[0] == "print")
                {
                    BankAccount.Print(commands, accounts);
                }

                commands = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.None);

            }

        }
    }
}
