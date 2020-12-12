using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class BrowseScreen
    {
        
        public void ItemTypeList(Customer customer)
        {
            var choice = "";
            Console.Clear();
            Console.WriteLine("Hello " + customer.customerName);
            Console.WriteLine("Please select which type of item you want to purchase by pressing the number.");
            Console.WriteLine("1 = WEAPONS\n2 = APPAREL\n3 = POTION\n4 = TRINKETS\n5 = BOOKS\n6 = ALL ITEMS");
            
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    for (int i = 0; i < ShopInventory.Weapons.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Weapons[i].itemNumber + "\nName: " + ShopInventory.Weapons[i].name + "\nPrice: " + ShopInventory.Weapons[i].price + "\nDescription: " + ShopInventory.Weapons[i].description + "\nTax Percentage: " + ShopInventory.Weapons[i].taxPercentage + "\n- - - - - -");
                    break;
                case "2":
                    for (int i = 0; i < ShopInventory.Apparel.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Apparel[i].itemNumber + "\nName: " + ShopInventory.Apparel[i].name + "\nPrice: " + ShopInventory.Apparel[i].price + "\nDescription: " + ShopInventory.Apparel[i].description + "\nTax Percentage: " + ShopInventory.Apparel[i].taxPercentage + "\n- - - - - -");
                    break;
                case "3":
                    for (int i = 0; i < ShopInventory.Potions.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Potions[i].itemNumber + "\nName: " + ShopInventory.Potions[i].name + "\nPrice: " + ShopInventory.Potions[i].price + "\nDescription: " + ShopInventory.Potions[i].description + "\nTax Percentage: " + ShopInventory.Potions[i].taxPercentage + "\n- - - - - -");
                    break;
                case "4":
                    for (int i = 0; i < ShopInventory.Trinkets.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Trinkets[i].itemNumber + "\nName: " + ShopInventory.Trinkets[i].name + "\nPrice: " + ShopInventory.Trinkets[i].price + "\nDescription: " + ShopInventory.Trinkets[i].description + "\nTax Percentage: " + ShopInventory.Trinkets[i].taxPercentage + "\n- - - - - -");
                    break;
                case "5":
                    for (int i = 0; i < ShopInventory.Books.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Books[i].itemNumber + "\nName: " + ShopInventory.Books[i].name + "\nPrice: " + ShopInventory.Books[i].price + "\nDescription: " + ShopInventory.Books[i].description + "\nTax Percentage: " + ShopInventory.Books[i].taxPercentage + "\n- - - - - -");
                    break;
                case "6":
                    for (int i = 0; i < ShopInventory.Items.Count; i++)
                        Console.WriteLine("Item Number:" + ShopInventory.Items[i].itemNumber + "\nName: " + ShopInventory.Items[i].name + "\nPrice: " + ShopInventory.Items[i].price + "\nDescription: " + ShopInventory.Items[i].description + "\nTax Percentage: " + ShopInventory.Items[i].taxPercentage + "\n- - - - - -");
                    break;

                default:
                    Console.WriteLine("Invalid number.");
                    Console.Clear();
                    break;
            }

        }

        public void AddToCart(Customer customer)
        {
            
            Console.WriteLine("Type in the ITEM NUMBER of item you would like to purchase.");
            string itemNumber = Console.ReadLine().Trim();
            for(int i  = 0; i <= ShopInventory.Items.Count; i++)
            {
               if(itemNumber == ShopInventory.Items[i].itemNumber)
                {
                    string itemName = ShopInventory.Items[i].itemNumber;
                    customer.customerItems.Add(itemName);
                    customer.totalPrice += ShopInventory.Items[i].price;
                    Console.WriteLine(ShopInventory.Items[i].name + " added to your inventory.");
                    Console.ReadKey();
                }

                
            }

            return;
            
        }
        
       
       
    }
}
