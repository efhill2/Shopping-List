using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> items = new Dictionary<string, double>();

            items["Desk Fan"] = 4.99;
            items["32\" Monitor"] = 49.99;
            items["Gaming Laptop"] = 1299.99;
            items["Desktop Speakers"] = 19.99;
            items["Wireless Controller"] = 29.99;
            items["Wireless Printer"] = 49.99;
            items["Bluetooth Headphones"] = 399.99;
            items["Tablet"] = 299.99;

            ArrayList itemName = new ArrayList();

            ArrayList itemPrice = new ArrayList();

            bool keepGoing = true;

            //string[] itemName = { "Desk Fan", "32\" Monitor", "Gaming Laptop", "Desktop Speakers", "Wireless Controller", "Wireless Printer", "Bluetooth Headphoned", "Tablet"};
            //double[] itemPrice = { 4.99, 49.99, 1299.99, 19.99, 29.99, 49.99, 399.99, 299.99};

            Console.WriteLine("Welcome to Genie's Store");

            Console.WriteLine();

            while (keepGoing)
            {


                Console.WriteLine(String.Format("{0 , 20} {1 , 20}", "Product", "Price"));
                Console.WriteLine(String.Format("{0 , 20} {1 , 20}", "==========", "=========="));


                foreach (var key in items.Keys)
                {

                    Console.WriteLine(String.Format("{0 , 20} {1 , 20}", key, items[key]));
                }

                Console.WriteLine();

                Console.WriteLine("What would you like to add to shopping cart?");
                var product = Console.ReadLine();                                

                Console.WriteLine();

                if (items.ContainsKey(product))
                {
                    itemName.Add(product);
                    itemPrice.Add(items.Values);

                    for (int i = 0; i < itemName.Count; i++)
                    {
                        string current = (string)itemName[i];

                        for (int j = 0; j < itemPrice.Count; j++)
                        {
                            var price = itemPrice[j];

                            Console.Write($"Adding {current} to cart at {price}");
                        }                               
                       
                    }
                }
                else
                {
                    Console.WriteLine("Not a product");
                }

                Console.WriteLine();

                Console.WriteLine("Would you like to continue? (yes/no)");
                string cont = Console.ReadLine().ToLower();

                if (cont == "no")
                {
                    keepGoing = false;
                }

                Console.WriteLine();
                Console.WriteLine("Thanks for you order! \n" +
                    "Here is what's in your cart:;");

                for (int i = 0; i < itemName.Count; i++)
                {
                    Console.Write((string)itemName[i]);


                }
            }
            

        }
    }
}
