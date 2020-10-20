using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class StartBrowseScreen
    {
        
        
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
