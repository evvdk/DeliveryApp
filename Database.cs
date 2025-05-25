using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
                if(Email.Length != 0)
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                else
                    command.Parameters.Add("@email", SqlDbType.Int).Value = SqlInt32.Null;
                command.ExecuteNonQuery();
            }
        }

        public static void GetUserOrders(string Login)
        {
            
        }

    }
}
