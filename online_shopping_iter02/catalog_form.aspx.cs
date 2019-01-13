using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace online_shopping_iter02
{
    public partial class catalog_form : System.Web.UI.Page
    {
        string[] id = new string[5];
        string search_string;

        protected void Page_Load(object sender, EventArgs e)
        {
            int item_total, page_total, current_page, display_range;
            string search_query;

            //If User is logged-in
            if (Session["User"] != null)
            {
                lnk_profile.Visible = true;
                btn_logout.Visible = true;
                lnk_login.Visible = false;
                imgbtn_cart.Visible = true;
            }
            else
            {
                lnk_profile.Visible = false;
                btn_logout.Visible = false;
                lnk_login.Visible = true;
                imgbtn_cart.Visible = false;
            }

            //Hide no match found
            lbl_no_match.Visible = false;

            //If Search Query String exists
            if (Request.QueryString["search"] != null)
                search_string = Request.QueryString["search"].ToString();
            else
                search_string = "";

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\online_shopping_db.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                connection.Open();
            }
            catch
            {
                Response.Redirect("error_page.aspx");
            }
            search_query = Request.QueryString["search"].Replace("+", " ");
            SqlCommand command = new SqlCommand(
                "SELECT COUNT(*) FROM Products WHERE ProductName LIKE '%"
                + search_query + "%'", connection);
            command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            item_total = (int)reader[0];
            connection.Close();

            //If there is at least one match
            if (item_total > 0)
            {
                page_total = (int)Math.Ceiling((double)item_total / 5);
                if (Request.QueryString["page"] != null)
                    current_page = int.Parse(Request.QueryString["page"]);
                else
                    current_page = 1;

                if (current_page == 1)
                    btn_previous.Visible = false;
                else
                    btn_previous.Visible = true;

                lbl_page.Text = current_page.ToString() + " of " + page_total.ToString();

                if (current_page == page_total)
                {
                    btn_next.Visible = false;
                    display_range = item_total % 5;
                    if (display_range == 0)
                        display_range = 5;
                }
                else
                {
                    btn_next.Visible = true;
                    display_range = 5;
                }


            }
            //Else if there is no match found
            else
            {
                lbl_no_match.Visible = true;
                display_range = 0;

                btn_previous.Visible = false;
                btn_next.Visible = false;
                lbl_page.Visible = false;
            }

            if (display_range >= 1)
                div_product_01.Visible = true;
            else
                div_product_01.Visible = false;

            if (display_range >= 2)
                div_product_02.Visible = true;
            else
                div_product_02.Visible = false;

            if (display_range >= 3)
                div_product_03.Visible = true;
            else
                div_product_03.Visible = false;
        }

        //LINK CLICKS EVENTS

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string search_query = txtbox_search.Text.Replace(" ", "+");
            Response.Redirect("catalog_form.aspx?search=" + search_query);
        }

        protected void lnk_product_01_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_form.aspx?id=" + id[0]);
        }

        protected void lnk_product_02_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_form.aspx?id=" + id[1]);
        }

        protected void lnk_product_03_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_form.aspx?id=" + id[2]);
        }

        protected void lnk_product_04_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_form.aspx?id=" + id[3]);
        }

        protected void lnk_product_05_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_form.aspx?id=" + id[4]);
        }

        protected void drplst_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = "";
            string page = "";
            string order = "";
            string query_string = "";


            //If Search Query String exists
            if (Request.QueryString["search"] != null)
                search = "search=" + Request.QueryString["search"];

            if (Request.QueryString["page"] != null)
                page = "page=" + Request.QueryString["page"];

            //If Selected Index is not 0:
            if (drplst_sort.SelectedIndex != 0)
            {
                //If Selected Index is 1:
                if (drplst_sort.SelectedIndex == 1)
                    order = "order=Price_ASC";
                else
                    order = "order=Price_DESC";
            }

            //If search is empty
            if (search == "")
            {
                //If page is empty
                if (page == "")
                {
                    //If order is not empty
                    if (order != "")
                        query_string = order;
                }
                else
                {
                    //If order is empty
                    if (order == "")
                        query_string = page;
                    else
                        query_string = page + "&" + order;
                }
            }
            else
            {
                //If page is empty
                if (page == "")
                {
                    //If order is empty
                    if (order == "")
                        query_string = search;
                    else
                        query_string = search + "&" + order;
                }
                else
                {
                    //If order is empty
                    if (order == "")
                        query_string = search + "&" + page;
                    else
                        query_string = search + "&" + page + "&" + order;
                }
            }

            Response.Redirect("catalog_form.aspx?" + query_string);
        }
    }
}