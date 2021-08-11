using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if(max < b)
            {
                max = b;
            }    
            if(max < c)
            {
                max = c;
            }
            Console.WriteLine("Max trong 3 số {0} , {1}, {2} là {3}", a, b, c, max);
            Console.ReadKey();
        }
    }
}
