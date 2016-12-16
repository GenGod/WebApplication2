using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public class Crud
    {
        private static string connectionParams = @"Data Source = .\SQLEXPRESS;
                                        Initial Catalog = training;
                                        Integrated Security = False;
                                        User Id = root;
                                        Password = toor";

        public static List<Product> read()
        {
            List<Product> products = new List<Product>();
            string query = "SELECT* FROM products";

            using (SqlConnection connection = new SqlConnection(connectionParams))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product(Convert.ToInt32(reader[0]), 
                                                reader[1].ToString(), 
                                                reader[2].ToString(),
                                                Convert.ToDouble(reader[3]),
                                                reader[4].ToString()));
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            };
            return products;
        }
    }
}