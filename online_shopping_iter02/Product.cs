using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_shopping_iter02
{
    public class Product
    {
        private int id { get; }
        private string name { get; set; }
        private decimal price { get; set; }

        public Product(int new_id)
        {
            id = new_id;
        }
    }
}