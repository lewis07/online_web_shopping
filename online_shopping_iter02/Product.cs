using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace online_shopping_iter02
{
    public class Product
    {
        private int id { get; }
        private string name;
        private decimal price;

        public Product(int new_id)
        {
            id = new_id;

            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\online_shopping_db.mdf;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ProductId = " + new_id.ToString(), connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            name = (string)reader["ProductName"];
            price = (decimal)reader["ProductPrice"];

        }

        public string get_name()
        {
            return name;
        }

        public decimal get_price()
        {
            return price;
        }
    }
}