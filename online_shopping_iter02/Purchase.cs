using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_shopping_iter02
{
    public class Purchase : Product
    {
        private int amount { get; set; }
        private decimal subtotal { get; set; }

        public Purchase (int new_int, int new_amount) : base(new_int)
        {
            amount = new_amount;
        }

        public decimal calculate_subtotal()
        {
            subtotal = amount * subtotal;
            return subtotal;
        }
    }
}