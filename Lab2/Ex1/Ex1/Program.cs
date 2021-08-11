using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap ten ban : ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi : ");
            string address = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai: ");
            string phone = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine(phone);

            Console.ReadKey();

        }
    }
}
