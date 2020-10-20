using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Item
    {
        public int Price { get; set; }
        public string ItemName { get; set; }
        public ItemType ItemType { get; set; }

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
