using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_shopping_iter02
{
    public partial class cart_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart cart = (Cart)Session["Cart"];

            for(int i = 0; i < cart.get_item_total(); i++)
            {
                Response.Write("<p>" + cart.get_purchase(i).get_name() + " </t> " + cart.get_purchase(i).calculate_subtotal().ToString() + "</p>");
            }


        }
    }
}