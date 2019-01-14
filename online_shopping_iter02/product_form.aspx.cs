using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace online_shopping_iter02
{
    public partial class product_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null)
                Response.Redirect("catalog_form.aspx");

            if (Session["User"] != null)
            {
                lnkbtn_profile.Visible = true;
                imgbtn_cart.Visible = true;
                btn_logout.Visible = true;
                lnkbtn_login.Visible = false;
            }
            else
            {
                lnkbtn_login.Visible = true;
                lnkbtn_profile.Visible = false;
                imgbtn_cart.Visible = false;
                btn_logout.Visible = false;
            }
        }

        protected void lnkbtn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("login_form.aspx");
        }

        protected void btn_minus_Click(object sender, EventArgs e)
        {
            int amount;
            if (lbl_amount.Text != "1")
            {
                amount = int.Parse(lbl_amount.Text);
                amount--;
                lbl_amount.Text = amount.ToString();
            }
        }

        protected void btn_plus_Click(object sender, EventArgs e)
        {
            int amount;
            amount = int.Parse(lbl_amount.Text);
            amount++;
            lbl_amount.Text = amount.ToString();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Cart cart_inst = (Cart)Session["Cart"];
            Purchase new_purchase = new Purchase(int.Parse(Request.QueryString["id"]), int.Parse(lbl_amount.Text));

            cart_inst.add_product(new_purchase);
        }
    }
}