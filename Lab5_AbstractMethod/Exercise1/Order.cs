using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Order
    {
        class Grocery_items
        {
            public void Order_grocery()
            {
                Customer cust = new Customer();
                cust.getName();
                Console.WriteLine("Welcome {0} !", cust.cusName);
                Console.WriteLine("Thank you for ordering Grocery Items !!");
            }
        }

        class Bakery_products
        {
            public void Order_Bakery()
            {
                Customer cust1 = new Customer();
                cust1.getName();
                Console.WriteLine("Welcome {0} !", cust1.cusName);
                Console.WriteLine("Thank you for ordering Bakery Products !!");
            }
        }

        class OrderTest
        {
            static void Main(string[] args)
            {
                string choice;
                Console.WriteLine("\n\tWhat would you laike to order ?\n\t\t1-Grocery Items\n\t\t2-Bakery Items");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Grocery_items grocery = new Grocery_items();
                    grocery.Order_grocery();
                }
                else
                {
                    if (choice == "2")
                    {
                        Bakery_products bakery = new Bakery_products();
                        bakery.Order_Bakery();
                    }
                    else
                    {
                        Console.WriteLine("Enter either 1 or 2 !");
                    }
                }
                Console.ReadLine();
            }

        }
    }
}
