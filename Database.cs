using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    static class Database
    {
        private const string DB_ConnectionString = "Data Source = LAPTOP\\SQLEXPRESS; Initial Catalog = Delivery; Integrated Security = true;";

        public static bool IsValidUser(string Login, string Password)
        {
            using (SqlConnection connection = new SqlConnection(DB_ConnectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Client WHERE Login = @login AND Password = @password";
                command.Parameters.AddWithValue("@login", Login);
                command.Parameters.AddWithValue("@password", Password);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
            }
        }

        public static void InsertUser(string Login, string Password, string Name, string Phone, string Email)
        {
            using (SqlConnection connection = new SqlConnection(DB_ConnectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "RegisterClient";
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = Login;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                command.ExecuteNonQuery();
                }

        }
    }
}
