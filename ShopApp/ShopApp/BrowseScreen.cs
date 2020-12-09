using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class BrowseScreen
    {
        public Customer customer { get; set; }
        public void ItemTypeList()
        {
            var choice = "";
            Console.Clear();
            Console.WriteLine("Hello " + customer.customerName);
            Console.WriteLine("Please select which type of item you want to purchase by pressing the number.");
            Console.WriteLine("1 = WEAPONS");
            Console.WriteLine("2 = APPAREL");
            Console.WriteLine("3 = POTIONS");
            Console.WriteLine("4 = MATERIALS");
            Console.WriteLine("5 = TRINKETS");
            Console.WriteLine("6 = BOOKS");
            Console.WriteLine("7 = FOOD");
            Console.WriteLine("8 = DRINK");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Name: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage);
                    break;
                case "2":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Name: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage);
                    break;
                case "3":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Name: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage);
                    break;
                case "4":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Name: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage);
                    break;
                case "5":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Name: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage);
                    break;
                default:
                    break;


            }

        }


        public  void CursorMarker(string textLine)
        {
            System.Console.BackgroundColor = ConsoleColor.White;
            System.Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine(textLine);
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
