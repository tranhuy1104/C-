using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDo dai quang duong ban di : ");
            double dis1 = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(15, 0.3, dis1);
            car.Compare();

            Car car1 = new Car(16, 0.2, 2);
            car1.Compare();

            Console.WriteLine("\nDo dai quang duong ban di : ");
            double dis2 = Convert.ToDouble(Console.ReadLine());
            Truck truck = new Truck(15, 1.2, dis2);
            truck.Compare();

        }
    }
}
