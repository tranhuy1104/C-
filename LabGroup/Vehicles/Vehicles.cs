using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Vehicle
    {
        public double fuelQuantity { get; set; }
        public double fuelConsume { get; set; }
        public double Distance { get; set; }

        public virtual double countDistance()
        {
            return fuelQuantity / fuelConsume;
        }
        public virtual void Compare()
        {

        }

    }
}
