using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : Vehicle
    {
        public double fuelQuantity { get; set; }

        public double fuelConsumtion
        {
            get; set;
        }
        public double Distance { get; set; }
        public Car()
        {

        }
        public Car(double quantity, double consumtion, double distance)
        {
            this.fuelConsume = consumtion;
            this.fuelQuantity = quantity;
            this.Distance = distance;
        }

        public override double countDistance()
        {
            return ((fuelQuantity) / (fuelConsumtion + 0.9));
        }

        public override void Compare()
        {
            if (Distance < countDistance())
            {
                Console.WriteLine($"\n\t Distance : {this.Distance}");

            }
            else
            {
                Console.WriteLine("\n\t Please!Let's go get gas.");
            }
        }



    }
}

