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
            Console.WriteLine("Welcome to Aurora's Realm Shop.");
            Console.ReadLine();
            Console.WriteLine("We have a selection of goods available to you at best prices in all Waterdeep.");
            Console.ReadLine();
            Console.WriteLine("Feel free to browse.");
            StartBrowseScreen browseScreen = new StartBrowseScreen();

        }
    }
}
