using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace online_shopping_iter02
{
    public partial class register_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /*
        protected void chkbox_billing_add_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox_billing_add.Checked == true)
            {
                txtbox_billing_add.Enabled = false;
                //txtbox_billing_add.Text = txtbox_shipping_add.Text;
            }
            else
            {
                txtbox_billing_add.Enabled = true;
            }
            txtbox_billing_add.Text = txtbox_shipping_add.Text;
        }
        */

        protected void btn_register_Click(object sender, EventArgs e)
        {
            string email_add, password, full_name, contact_no;
            string shipping_add, billing_add, row_string;
            int random_id;

            email_add = txtbox_email_add.Text;
            password = txtbox_password.Text;
            full_name = txtbox_full_name.Text;
            contact_no = txtbox_contact_no.Text;
            shipping_add = txtbox_shipping_add.Text;
            billing_add = txtbox_billing_add.Text;

            Random generator = new Random();
            random_id = generator.Next(1, 1000);

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\online_shopping_db.mdf;Integrated Security=True;Connect Timeout=30");
            try
            {
                connection.Open();
            }
            catch
            {
                Response.Redirect("error_page.aspx");
            }

            row_string = random_id.ToString() + ", '" +
                full_name + "', '" + email_add + "', " +
                contact_no + ", '" + shipping_add + "', '" +
                billing_add + "', '" + password + "'";

            SqlCommand command = new SqlCommand("INSERT INTO Users (UserId, FullName, EmailAdd, ContactNo, ShippingAdd, BillingAdd, Password) " +
                "VALUES (" + row_string + ")", connection);

            command.ExecuteNonQuery();

            connection.Close();

            Response.Redirect("login_form.aspx");
        }
    }
}