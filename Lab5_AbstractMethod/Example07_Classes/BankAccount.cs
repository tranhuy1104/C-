using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07_Classes
{
    public class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id
        {
            get;set;
        }
        public decimal Balance { get; set; }
    }
}
