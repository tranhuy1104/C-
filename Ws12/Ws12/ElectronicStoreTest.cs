using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ws12
{
    class ElectronicStoreTest
    {
        ElectronicStore objStore = new ElectronicStore();
        //private double total;
        //private object objTest;

        bool Display()
        {
            Rebate objRebate = new Rebate(objStore.Discount);
            double total = objStore.ValueOfGoods();
            double value = objRebate(total);
            double netValue = total - value;

            WriteLine();
            WriteLine("Product Name: \t\t" + objStore.ItemName);
            WriteLine("Price per unit: \t\t" + objStore.ItemPrice);
            WriteLine("Number of Units sold: \t " + objStore.Quantity);
            WriteLine("Discount Rate: \t\t" + objStore.Rate + "%");
            WriteLine("Discount: \t\t" + value);
            WriteLine("Net Value: \t\t" + netValue);
            return true;
        }
        static void Main(string[] args)
        {
            ElectronicStoreTest objTest = new ElectronicStoreTest();
            Call objCall = new Call(objTest.objStore.ChooseProduct);
            if(objCall())
            {
                objCall -= new Call(objTest.objStore.ChooseProduct);
                objCall += new Call(objTest.Display);
                objCall();
            }
            else
            {
                return;
            }
        }
    }
}
