using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemensCloset
{
    internal class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }

        public Product(string id, string name, int quantity, decimal price, string category)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.category = category;
        }
    }
}
