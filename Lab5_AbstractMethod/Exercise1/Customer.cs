using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Customer
    {
        public string cusName;
        public void getName()
        {
            Console.Write("Enter your name : ");
            cusName = Console.ReadLine();
        }
    }
}
