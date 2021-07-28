using System;
using System.Collections.Generic;   

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a list of menu items and their prices.
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            
            menu["banana"] = 0.50m;
            menu["apple"] = 0.25m;
            menu["watermelon"] = 10.00m;
            menu["green Pepper"] = 1.00m;

            //list the menu when ur program begins
            Console.WriteLine("\nMenu: ");
            foreach (var pair in menu)
            {
            Console.WriteLine($"{pair.Key}.....{pair.Value}");
            }
            //ask what they want to do
            //Console.WriteLine("\nWhich would you like to do?");
            //Console.WriteLine("\nA. Add a new item"+ "\nR. Remove an item"+ "\nC. Change an item" + "\nQ. Quit");
            //string choice = Console.ReadLine().ToLower();

            bool picking = false;
            while (picking == false)
            {
                Console.WriteLine("\nWhich would you like to do?");
                Console.WriteLine("\nA. Add a new item" + "\nR. Remove an item" + "\nC. Change an item's price" + "\nQ. Quit");
                string choice = Console.ReadLine().ToLower();

                if (choice == "a")
                {
                    Console.WriteLine("What is the name of the item you would like to add?");
                    string additem = Console.ReadLine().ToLower();
                    Console.WriteLine("What is the price of the item?");
                    decimal addprice = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(additem);
                    Console.WriteLine(addprice);
                }
                else if (choice == "r")
                {
                    Console.WriteLine("What is the name of the item you would like to remove?");
                    string removename = Console.ReadLine();
                }
                else if (choice == "c")
                {
                    Console.WriteLine("What is the name of the item you would like to update?");
                    string updateitem = Console.ReadLine().ToLower();
                    if (!menu.ContainsKey(updateitem))
                    {
                        Console.WriteLine();
                    }//i'm stuck here rn
                }
                else if (choice == "q")
                {
                    picking = true;
                }
                        

            }


        }
    }
}
