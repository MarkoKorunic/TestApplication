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
        public ShopInventory shop { get; set; }
        public void ItemTypeList()
        {
            Console.Clear();
            Console.WriteLine("Please select which type of item you want to purchase by pressing the number.");
            Console.WriteLine("1 = WEAPONS");
            Console.WriteLine("2 = APPAREL");
            Console.WriteLine("3 = POTIONS");
            Console.WriteLine("4 = MATERIALS");
            Console.WriteLine("5 = TRINKETS");
            Console.WriteLine("6 = BOOKS");
            Console.WriteLine("7 = FOOD");
            Console.WriteLine("8 = DRINK");

            
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
