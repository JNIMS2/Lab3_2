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
            menu["green pepper"] = 1.00m;

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
                string choice;
                do
                {
                    Console.WriteLine("\nWhich would you like to do?");
                    Console.WriteLine("\nA. Add a new item" + "\nR. Remove an item" + "\nC. Change an item's price" + "\nQ. Quit");
                    choice = Console.ReadLine().ToLower();
                }
                while (choice != "a" && choice != "r" && choice != "c" && choice != "q");

                if (choice == "a")
                {
                    Console.WriteLine("What is the name of the item you would like to add?");
                    string additem = Console.ReadLine().ToLower();
                    if (menu.ContainsKey(additem))
                    {
                        Console.WriteLine("\nThis item already exists. Please try again.");
                    }
                    else if (!menu.ContainsKey(additem))
                    {
                        Console.WriteLine("What is the price of the item?");
                        decimal addprice = decimal.Parse(Console.ReadLine());
                        menu.Add(additem, addprice);
                    }
                    Console.WriteLine("\nMenu: ");
            foreach (var pair in menu)
            {
            Console.WriteLine($"{pair.Key}.....{pair.Value}");
            }
                }
                else if (choice == "r")
                {
                    Console.WriteLine("What is the name of the item you would like to remove?");
                    string removename = Console.ReadLine();
                    if (menu.ContainsKey(removename))
                    {
                        menu.Remove(removename);
                    }
                    else if (!menu.ContainsKey(removename))
                    {
                        Console.WriteLine("\nThat item does not exist in the menu. Please try again");
                    }
                        Console.WriteLine("\nMenu: ");
                    foreach (var pair in menu)
                    {
                        Console.WriteLine($"{pair.Key}.....{pair.Value}");
                    }
                }
                else if (choice == "c")
                {
                    Console.WriteLine("What is the name of the item you would like to update?");
                    string updateitem = Console.ReadLine().ToLower();
                    if (menu.ContainsKey(updateitem))
                    {
                       decimal value = menu[updateitem];
                        //Console.WriteLine("This item exists");
                        Console.WriteLine($"The current price of {updateitem} is {value}");
                        Console.WriteLine("What is the  new price of the item?");
                        decimal addprice = decimal.Parse(Console.ReadLine());
                        menu[updateitem] = addprice;

                        Console.WriteLine("\nMenu: ");
                        foreach (var pair in menu)
                        {
                            Console.WriteLine($"{pair.Key}.....{pair.Value}");
                        }
                    }
                    else if (!menu.ContainsKey(updateitem))
                    {
                        Console.WriteLine("\nThis item doesn't exist. Plese try again.");
                    }
                }
                else if (choice == "q")
                {
                    picking = true;
                }
                        

            }


        }
    }
}
