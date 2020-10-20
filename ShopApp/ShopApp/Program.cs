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
            Customer customer = new Customer();
            customer.customerName = WelcomeScreen();
            StartBrowseScreen browseScreen = new StartBrowseScreen();

        }


        static string WelcomeScreen()
        {
            Console.WriteLine("Hello new customer! Welcome to Aurora's Realm Shop.");
            Console.ReadLine();
            Console.WriteLine("We have a selection of goods available to you at best prices in all Waterdeep.");
            Console.ReadLine();
            Console.WriteLine("Feel free to browse. May I ask your name?");
            string name =  Console.ReadLine();
            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            Console.WriteLine("Hello {0}. What would you like to buy?", name);
            return name;
        }

        public void ItemTypeList()
        {
           
        }


        public void CursorMarker(string textLine)
        {
            System.Console.BackgroundColor = ConsoleColor.White;
            System.Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine(textLine);
            System.Console.BackgroundColor = ConsoleColor.Black;
            System.Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

