using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ShopApp
{
    public static class JsonAccess
    {

        public static void ShopInventoryLoad()
        {
            string json = File.ReadAllText("shopItems.txt");
            ShopInventory.Items = JsonConvert.DeserializeObject < List<Item>>(json);
        }

    }
}
