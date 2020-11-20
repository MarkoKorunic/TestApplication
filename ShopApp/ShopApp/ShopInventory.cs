using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class ShopInventory
    {
        public static List<Item> Items { get; set; }
        public static List<Item> Weapons { 
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Weapon).ToList();
            } 
        }

        public List<Item> Apparel
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Apparel).ToList();
            }
        }
        public List<Item> Potions
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Potion).ToList();
            }
        }

        public List<Item> Materials
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Material).ToList();
            }
        }
        public List<Item> Food
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Food).ToList();
            }
        }
        public List<Item> Drink
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Drink).ToList();
            }
        }
        public List<Item> Trinkets
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Trinket).ToList();
            }
        }
        public List<Item> Books
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Book).ToList();
            }
        }

    }
}


