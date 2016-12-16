using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication2.Models
{
    public static class WorkingWithComments
    {
        private static string connectionParams = @"Data Source = .\SQLEXPRESS;
                                        Initial Catalog = training;
                                        Integrated Security = False;
                                        User Id = root;
                                        Password = toor";

        public static List<Comment> readComments()
        {
            List<Comment> comments = new List<Comment>();
            using (SqlConnection connection = new SqlConnection(connectionParams))
            {
                string query = "SELECT* FROM comments";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comments.Add(new Comment(reader["userName"].ToString(),
                                                 reader["userEmail"].ToString(),
                                                 reader["comment"].ToString()));
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            };
            return comments;
        }

        public static int addComment(Comment comment)
        {
            using (SqlConnection connection = new SqlConnection(connectionParams))
            {
                string query = string.Format("INSERT INTO comments VALUES (@userName, @userEmail, @comment)");
                SqlCommand command = new SqlCommand(query, connection);
                try 
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@userName", comment.getUserName());
                    command.Parameters.AddWithValue("@userEmail", comment.getUserEmail());
                    command.Parameters.AddWithValue("@comment", comment.getComment());
                    return command.ExecuteNonQuery();
                }
            catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return 0;
                }
            };
    }
    }
}