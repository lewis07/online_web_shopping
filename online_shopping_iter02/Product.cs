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
        private decimal price { get; set; }

        public Product(int new_id)
        {
            id = new_id;

            SqlConnection connection = new SqlConnection("");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Products WHERE ProductId = " + new_id.ToString(), connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            name = (string)reader["ProductName"];
            price = decimal.Parse((string)reader["ProductPrice"]);

        }

        public string get_name()
        {
            return name;
        }
    }
}