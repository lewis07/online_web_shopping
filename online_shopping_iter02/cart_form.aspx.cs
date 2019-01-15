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
            int current_page, total_page;

            if (Session["User"] == null)
                Response.Redirect("login_form.aspx");

            int display_range;
            Cart cart = (Cart)Session["Cart"];
            total_page = (int)Math.Ceiling((double)cart.get_item_total() / 5.0);

            if (Request.QueryString["page"] == null)
            {
                current_page = 1;
                btn_back.Visible = false;
            }
            else
            {
                current_page = int.Parse(Request.QueryString["page"]);
                btn_back.Visible = true;
            }
                

            if (current_page == total_page)
                btn_next.Visible = false;
            else
                btn_next.Visible = true;



            if (cart.get_item_total() == 0)
            {
                div_table.Visible = false;
            }
            else
            {
                div_table.Visible = true;



                if (current_page == total_page)
                {
                    display_range = cart.get_item_total() % 5;
                    if (display_range == 0)
                        display_range = 5;
                }
                else
                {
                    display_range = 5;
                }

                if (display_range >= 1)
                {
                    purchase_01.Visible = true;
                    int index = (current_page * 5 - 1) - 4;
                    Purchase purchase = cart.get_purchase(index);
                    lbl_name_01.Text = purchase.get_name() + " (" + purchase.get_amount().ToString() + ")";
                    lbl_price_01.Text = "P " + purchase.calculate_subtotal().ToString("F2");
                }
                else
                {
                    purchase_01.Visible = false;
                }
                if (display_range >= 2)
                {
                    purchase_02.Visible = true;
                    int index = (current_page * 5 - 1) - 3;
                    Purchase purchase = cart.get_purchase(index);
                    lbl_name_02.Text = purchase.get_name() + " (" + purchase.get_amount().ToString() + ")";
                    lbl_price_02.Text = "P " + purchase.calculate_subtotal().ToString("F2");
                }
                else
                {
                    purchase_02.Visible = false;
                }
                if (display_range >= 3)
                {
                    purchase_03.Visible = true;
                    int index = (current_page * 5 - 1) - 2;
                    Purchase purchase = cart.get_purchase(index);
                    lbl_name_03.Text = purchase.get_name() + " (" + purchase.get_amount().ToString() + ")";
                    lbl_price_03.Text = "P " + purchase.calculate_subtotal().ToString("F2");
                }
                else
                {
                    purchase_03.Visible = false;
                }
                if (display_range >= 4)
                {
                    purchase_04.Visible = true;
                    int index = (current_page * 5 - 1) - 1;
                    Purchase purchase = cart.get_purchase(index);
                    lbl_name_04.Text = purchase.get_name() + " (" + purchase.get_amount().ToString() + ")";
                    lbl_price_04.Text = "P " + purchase.calculate_subtotal().ToString("F2");
                }
                else
                {
                    purchase_04.Visible = false;
                }
                if (display_range >= 5)
                {
                    purchase_05.Visible = true;
                    int index = (current_page * 5 - 1);
                    Purchase purchase = cart.get_purchase(index);
                    lbl_name_05.Text = purchase.get_name() + " (" + purchase.get_amount().ToString() + ")";
                    lbl_price_05.Text = "P " + purchase.calculate_subtotal().ToString("F2");
                }
                else
                {
                    purchase_05.Visible = false;
                }

            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            int back_page;
            back_page = int.Parse(Request.QueryString["page"]) - 1;
            if (back_page == 1)
                Response.Redirect("cart_form.aspx");
            else
                Response.Redirect("cart_form.aspx?page=" + back_page.ToString());
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            int next_page;
            if (Request.QueryString["page"] == null)
                next_page = 2;
            else
            {
                next_page = int.Parse(Request.QueryString["page"]) + 1;
            }
            Response.Redirect("cart_form.aspx?page=" + next_page.ToString());
        }

        protected void btn_remove_01_Click(object sender, EventArgs e)
        {
            remove_btn_click(1);
        }

        protected void btn_remove_02_Click(object sender, EventArgs e)
        {
            remove_btn_click(2);
        }

        protected void btn_remove_03_Click(object sender, EventArgs e)
        {
            remove_btn_click(3);
        }

        protected void btn_remove_04_Click(object sender, EventArgs e)
        {
            remove_btn_click(4);
        }

        protected void btn_remove_05_Click(object sender, EventArgs e)
        {
            remove_btn_click(5);
        }

        void remove_btn_click (int index)
        {
            int current_page;
            Cart cart = (Cart)Session["Cart"];
            if (Request.QueryString["page"] == null)
                current_page = 1;
            else
                current_page = int.Parse(Request.QueryString["page"]);
            cart.remove_product((current_page * 5 - 1) - (5 - index));
            if (current_page == 1)
                Response.Redirect("cart_form.aspx");
            else
                Response.Redirect("cart_form.aspx?" + current_page.ToString());
        }
    }
}