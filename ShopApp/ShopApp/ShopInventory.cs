using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ShopApp
{
    public static class ShopInventory
    {
        public static List<Item> Items { get; set; }
        public static List<Item> Weapons { 
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Weapon).ToList();
            } 
        }

        public static List<Item> Apparel
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Apparel).ToList();
            }
        }
        public static List<Item> Potions
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Potion).ToList();
            }
        }
             
             
        public static List<Item> Trinkets
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Trinket).ToList();
            }
        }
        public static List<Item> Books
        {
            get
            {
                return ShopInventory.Items.Where(i => i.type == ItemType.Book).ToList();
            }
        }

    }
}


