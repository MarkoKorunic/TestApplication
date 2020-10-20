using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class Customer
    {
        public string customerName { get; set; }
        public decimal totalPrice { get; set; }

        public List<Item> customerItems { get; set; }

    }
}
