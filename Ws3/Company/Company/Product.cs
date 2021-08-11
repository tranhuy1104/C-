using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Product
    {
        static void Main(string[] args)
        {
            object objProductID;
            object objProductName;
            object objPrice;
            object objQuantity;

            Console.Write("Enter the id of product: ");
            objProductID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of product: ");
            objProductName = Console.ReadLine();

            Console.Write("Enter price : ");
            objPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity : ");
            objQuantity = Covert.ToInt32(Console.ReadLine());

            int productID = (int)objProductID;
            string productName = (string)objProductName;
            double price = (double)objPrice;
            int quantity = (int)objQuantity;
            double amtPayable = (int)objQuantity * Price;

            Console.WriteLine("\nProduct Details:");
            Console.WriteLine("Product ID : " + productID);
            Console.WriteLine("Product Name : " + productName );
            Console.WriteLine("Price : $" + price);
            Console.WriteLine("Quantity : " + quantity);
            Console.WriteLine("Amt Payable (0:F2): ", amtPayable);
        }
    }
}
