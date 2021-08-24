using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 2;
            acc.Balance = 3000;
            Console.WriteLine(acc);
        }
    }
}
