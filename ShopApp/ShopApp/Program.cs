using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Customer customer = new Customer();
                customer.customerName = WelcomeScreen();
                BrowseScreen browseScreen = new BrowseScreen();
                browseScreen.customer = customer;
                Console.ReadKey();
                JsonAccess.ShopInventoryLoad();
                browseScreen.ItemTypeList();



            }
        }


        static string WelcomeScreen()
        {
            string name = "";
            try
            {
                Console.WriteLine("Hello new customer! Welcome to Aurora's Realm Shop.");
                Console.ReadLine();
                Console.WriteLine("We have a selection of goods available to you at best prices in all Waterdeep.");
                Console.ReadLine();
                Console.WriteLine("Feel free to browse. May I ask your name?  (Type in your name)");
                name = Console.ReadLine();
                name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
                Console.WriteLine("Hello {0}. Enjoy your shopping!", name);
                return name;
            }
            catch (Exception)
            {
                Console.WriteLine("Don't want to tell your name? Ok, I will sign you in as anonymus.");
                Console.WriteLine("Not a problem. Enjoy your shopping!");
                return name = "Anonymus";
            }
        }

        public void ItemTypeList()
        {
            Console.WriteLine("Please select type of goods you wish to buy.");
            
        }


       
    }
}

