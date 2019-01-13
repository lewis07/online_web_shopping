using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace online_shopping_iter02
{
    public partial class login_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		//Added with hard link
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            //If username field or password field is empty
            if (txtbox_email.Text == "" || txtbox_password.Text == "")
            {
                lbl_error.Text = "Please enter username and password";
            }
            else
            {
                //Open database connection
                SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\online_shopping_db.mdf;Integrated Security=True");
                
                try
                {
                    connection.Open();
                }
                catch
                {
                    lbl_error.Text = "There was a problem logging-in. Please try again later";
                    Response.Write("<script>console.log('Error upon opening database');</script>");
                }

                //If the connection is open
                if (connection.State.ToString() == "Open")
                {
                    string SQLString = "SELECT UserId, Password FROM Users " +
                        "WHERE EmailAdd = '" + txtbox_email.Text + "'";
                    //Select username and password based on entered e-mail
                    SqlCommand command = new SqlCommand(SQLString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    //If a data is retrieved and the entered password matches the
                    //   stored password
                    if (reader.Read() && txtbox_password.Text == 
                        (string)reader["Password"])
                    {
                        //Create user session
                        Session["User"] = reader["UserId"].ToString();
                        //CREATE CART
                        Response.Redirect("catalog_form.aspx");
                    }
                    else
                    {
                        //Display username or password is invalid
                        lbl_error.Text = "Username or password is invalid";
                    }
                }
                //Close database connection
                connection.Close();
            }
        }
    }
}