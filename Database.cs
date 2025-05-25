using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections.Generic;
using DeliveryApp.EF;
using System.Linq;

namespace DeliveryApp
{
    static class Database
    {
        private const string ConnectionString = "Data Source = LAPTOP\\SQLEXPRESS; Initial Catalog = Delivery; Integrated Security = true;";

        public static bool IsValidUser(string Login, string Password)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                return context.Client.Where(p => p.Login == Login && p.Password == Password && p.Active_Account == 1).Count() != 0;
            }
        }

        public static void InsertUser(string Login, string Password, string Name, string Phone, string Email)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var name = new SqlParameter("@name", Name);
                var phone = new SqlParameter("@phone", Phone);
                SqlParameter email = Email.Length == 0 
                    ? new SqlParameter("@email", SqlInt32.Null) 
                    : new SqlParameter("@email", Email);

                context.Database.ExecuteSqlCommand("exec RegisterClient @login, @password, @name, @phone, @email",
                        login, password, name, phone, email);
            }
        }

        public static List<Order_Status_Table> GetClosedUserOrders(string Login)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
               return context.Order_Status_Table.Where(p => p.Client_Login == Login && p.Status_ID != 0).ToList();
            }
        }

        public static Client GetUserInfo(string Login, string Password)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                return context.Client.Where(p => p.Login == Login && p.Password == Password).First();
            }
        }
    }
}
