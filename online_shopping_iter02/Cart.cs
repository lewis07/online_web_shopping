using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace online_shopping_iter02
{
    public class Cart
    {
        private List<Purchase> purchases;
        private int item_total;

        public Cart()
        {
            item_total = 0;
        }

        public bool is_empty()
        {
            if (item_total == 0)
                return true;
            else
                return false;
        }

        public void add_product(Purchase new_purchase)
        {
            purchases.Add(new_purchase);
            item_total++;
        }

        public void remove_product(int index)
        {
            purchases.RemoveAt(index);
            item_total--;
        }

        public Purchase get_purchase(int index)
        {
            return purchases[index];
        }

        public int get_item_total ()
        {
            return item_total;
        }
    }
}