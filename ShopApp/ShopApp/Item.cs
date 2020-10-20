using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Item
    {
        public decimal price { get; set; }
        public string name { get; set; }
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
    Material = 4,
    Trinket = 5,
    Book = 6,
    Food = 7,
    Drink = 8,
}

