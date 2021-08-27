using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);
            ferrari.PushGasPedal();
            ferrari.UseBrakes();
            Console.WriteLine(ferrari);
            Console.ReadLine();

        }
    }
}
