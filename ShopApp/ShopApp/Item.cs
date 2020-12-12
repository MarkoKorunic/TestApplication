using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Item
    {
        public string itemNumber { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        
        public string description { get; set; }
        public ItemType type { get; set; }
        public int taxPercentage { get; set; }

        
    }
}

public enum ItemType
{
    Weapon = 1,
    Apparel = 2,
    Potion = 3,
    Trinket = 4,
    Book = 5
}

