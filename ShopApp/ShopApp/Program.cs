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
            WelcomeScreen();
            StartBrowseScreen browseScreen = new StartBrowseScreen();

        }


        static void WelcomeScreen()
        {
            Console.WriteLine("Hello new customer! Welcome to Aurora's Realm Shop.");
            Console.ReadLine();
            Console.WriteLine("We have a selection of goods available to you at best prices in all Waterdeep.");
            Console.ReadLine();
            Console.WriteLine("Feel free to browse.");
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

