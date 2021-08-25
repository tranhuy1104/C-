using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ws12
{
    public delegate double Rebate(double val);
    public delegate bool Call();
    class ElectronicStore
    {
        internal string ItemName;
        internal float Rate;
        internal double ItemPrice = 0;
        internal int Quantity = 0;
        public bool ChooseProduct()
        {
            bool flag = true;
            int value;

            Console.WriteLine("Select the product sold");
            Console.WriteLine("1. Air Conditinoer \n 2. Televition\n 3. Washing Machine");
            Console.WriteLine("Enter your choice:");
            value = Convert.ToInt32(Console.ReadLine());
            switch(value)
            {
                case 1:
                    ItemName = "Air Conditioner";
                    break;
                case 2:
                    ItemName = "Television";
                    break;
                case 3:
                    ItemName = "Washing Machine";
                    flag = false;
                    break;
            }
            if(flag)
            {
                AcceptDetails();
            }
            else
            {
                return false;
            }
            return true;
        }
        void AcceptDetails()
        {
        Start:
            Console.Write("Enter the product price: ");
            try
            {
                ItemPrice = Convert.ToDouble(Console.ReadLine());
                if(ItemPrice < 0)
                {
                    Console.WriteLine("Value of product connot be negative");
                    goto Start;
                }
            }
            catch(FormatException objFormatOne)
            {
                Console.WriteLine("Error: " + objFormatOne.Message);
            }
        }
        public double Discount(double val)
        {
            double discount;
            if(val <= 1000)
            {
                discount = val * 0.1;
                Rate = 10;
            }
            else if((val > 1000) && (val <= 2000))
            {
                discount = val * 0.2;
                Rate = 20;
            }
            else if ((val > 2000) && (val <= 3000))
            {
                discount = val * 0.3;
                Rate = 30;
            }
            else
            {
                discount = val * 0.5;
                Rate = 50;
            }
            return discount;
        }
        public double ValueOfGoods()
        {
            double value = Quantity * ItemPrice;
            return value;
        }
    }
}
