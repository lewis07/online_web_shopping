using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_shopping_iter02
{
    public class Purchase : Product
    {
        private int amount;
        private decimal subtotal;

        public Purchase (int new_int) : base(new_int)
        {

        }

        public void calculate_subtotal()
        {
            subtotal = amount * subtotal;
        }
    }
}