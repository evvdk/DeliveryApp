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

        public static void ChangePassword(string Login, string OldPassword, string NewPassword)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var oldPassword = new SqlParameter("@oldPassword", OldPassword);
                var newPassword = new SqlParameter("@newPassword", NewPassword);

                context.Database.ExecuteSqlCommand("exec ChangeClientPassword @login, @oldPassword, @newPassword",
                        login, oldPassword, newPassword);
            }
        }

        public static void ChangeLogin(string Login, string Password, string NewLogin)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newLogin = new SqlParameter("@newLogin", NewLogin);

                context.Database.ExecuteSqlCommand("exec ChangeClientLogin @login, @password, @newLogin",
                        login, password, newLogin);
            }
        }

        public static void ChangeName(string Login, string Password, string NewName)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newName = new SqlParameter("@newName", NewName);

                context.Database.ExecuteSqlCommand("exec ChangeClientName @login, @password, @newName",
                        login, password, newName);
            }
        }

        public static void ChangePhone(string Login, string Password, string NewPhone)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newPhone = new SqlParameter("@newPhone", NewPhone);

                context.Database.ExecuteSqlCommand("exec ChangeClientPhone @login, @password, @newPhone",
                        login, password, newPhone);
            }
        }

        public static void ChangeEmail(string Login, string Password, string NewEmail)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newEmail = new SqlParameter("@newEmail", NewEmail);

                context.Database.ExecuteSqlCommand("exec ChangeClientEmail @login, @password, @newEmail",
                        login, password, newEmail);
            }
        }

        public static void DeleteAccount(string Login, string Password)
        {
            using (var context = new DeliveryAppContext(ConnectionString))
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);

                context.Database.ExecuteSqlCommand("exec DeleteClient @login, @password", login, password);
            }
        }
    }
}
