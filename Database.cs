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
        public static bool IsValidUser(string Login, byte[] Password)
        {
            using (var context = new Context())
            {
                return context.Клиент.Where(p => p.Логин == Login && p.Пароль == Password).Count() != 0;
            }
        }

        public static void InsertUser(string Login, byte[] Password, string Name, string Phone, string Email)
        {
            using (var context = new Context())
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

        public static List<Информация_о_заказе> GetClosedUserOrders(string Login)
        {
            using (var context = new Context())
            {
               return context.Информация_о_заказе.Where(p => p.Логин == Login && p.ID_Статуса != 0).ToList();
            }
        }

        public static Клиент GetUserInfo(string Login, byte[] Password)
        {
            using (var context = new Context())
            {
                return context.Клиент.Where(p => p.Логин == Login && p.Пароль == Password).First();
            }
        }

        public static void ChangePassword(string Login, byte[] OldPassword, byte[] NewPassword)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var oldPassword = new SqlParameter("@oldPassword", OldPassword);
                var newPassword = new SqlParameter("@newPassword", NewPassword);

                context.Database.ExecuteSqlCommand("exec ChangeClientPassword @login, @oldPassword, @newPassword",
                        login, oldPassword, newPassword);
            }
        }

        public static void ChangeLogin(string Login, byte[] Password, string NewLogin)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newLogin = new SqlParameter("@newLogin", NewLogin);

                context.Database.ExecuteSqlCommand("exec ChangeClientLogin @login, @password, @newLogin",
                        login, password, newLogin);
            }
        }

        public static void ChangeName(string Login, byte[] Password, string NewName)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newName = new SqlParameter("@newName", NewName);

                context.Database.ExecuteSqlCommand("exec ChangeClientName @login, @password, @newName",
                        login, password, newName);
            }
        }

        public static void ChangePhone(string Login, byte[] Password, string NewPhone)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newPhone = new SqlParameter("@newPhone", NewPhone);

                context.Database.ExecuteSqlCommand("exec ChangeClientPhone @login, @password, @newPhone",
                        login, password, newPhone);
            }
        }

        public static void ChangeEmail(string Login, byte[] Password, string NewEmail)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var newEmail = new SqlParameter("@newEmail", NewEmail);

                context.Database.ExecuteSqlCommand("exec ChangeClientEmail @login, @password, @newEmail",
                        login, password, newEmail);
            }
        }

        public static void DeleteAccount(string Login, byte[] Password)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);

                context.Database.ExecuteSqlCommand("exec DeleteClient @login, @password", login, password);
            }
        }

        public static List<Блюда_в_заказе> GetOrderSet(int order)
        {
            using (var context = new Context())
            {
                return context.Блюда_в_заказе.Where(p => p.ID_заказа == order).ToList();
            }
        }

        public static List<Меню> GetAllDishes()
        {
            using (var context = new Context())
            {
                return context.Меню.ToList();
            }
        }

        public static bool HasOpenedOrder(string Login)
        {
            using (var context = new Context())
            {
                return context.Информация_о_заказе.Where(p => p.Логин == Login && p.ID_Статуса == 0).Count() == 1;
            }
        }

        public static int GetOpenedOrderID(string Login)
        {
            using (var context = new Context())
            {
                return context.Информация_о_заказе.Where(p => p.Логин == Login && p.ID_Статуса == 0).First().ID_заказа;
            }
        }
        public static void InitOrder(string Login)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);

                context.Database.ExecuteSqlCommand("exec InitOrder @login",login);
            }
        }

        public static void AddToOrder(int OrderID, int DishID, int Count)
        {
            using (var context = new Context())
            {
                var order = new SqlParameter("@orderID", OrderID);
                var dish = new SqlParameter("@dishID", DishID);
                var count = new SqlParameter("@count", Count);

                context.Database.ExecuteSqlCommand("exec AddToOrder @orderID, @dishID, @count", order, dish, count);
            }
        }

        public static void DeleteFromOrder(int OrderID, int DishID)
        {
            using (var context = new Context())
            {
                var order = new SqlParameter("@orderID", OrderID);
                var dish = new SqlParameter("@dishID", DishID);

                context.Database.ExecuteSqlCommand("exec DeleteFromOrder @orderID, @dishID", order, dish);
            }
        }

        public static void ApplyOrder(string Login)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@orderID", Login);

                context.Database.ExecuteSqlCommand("exec ApplyOrder @login", login);
            }
        }

        public static void AddAdress(string Login, byte[] Password, string City, string District, string Street, string Building, string Room)
        {
            using (var context = new Context())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var city = new SqlParameter("@city", City);
                var district = new SqlParameter("@district", District);
                var street = new SqlParameter("@street", Street);
                var building = new SqlParameter("@building", Building);
                var room = new SqlParameter("@room", Room);

                context.Database.ExecuteSqlCommand("exec AddClientAddress @login, @password, @city, @district, @street, @building, @room", 
                    login, password, city, district, street, building, room);
            }
        }

        public static void DeleteAddress(int Address, string Login, byte[] Password)
        {
            using (var context = new Context())
            {
                var address = new SqlParameter("@address", Address);
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);

                context.Database.ExecuteSqlCommand("exec DeleteClientAddress @address, @login, @password",
                    address, login, password);
            }
        }

        public static void ApplyOrder(int Order)
        {
            using (var context = new Context())
            {
                var order = new SqlParameter("@order", Order);

                context.Database.ExecuteSqlCommand("exec ApplyOrder @order", order);
            }
        }

        public static List<Меню> GetDishInfo(string dish)
        {
            using (var context = new Context())
            {
                return context.Меню.Where(p => p.Название == dish).ToList();
            }
        }
    }
}
