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
        public static bool IsValidUser(string Login, byte[] Password)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Client.Where(p => p.Login == Login && p.Password == Password && p.Active_Account == 1).Count() != 0;
            }
        }

        public static void InsertUser(string Login, byte[] Password, string Name, string Phone, string Email)
        {
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
            {
               return context.Order_Status_Table.Where(p => p.Client_Login == Login && p.Status_ID != 0).ToList();
            }
        }

        public static Client GetUserInfo(string Login, byte[] Password)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Client.Where(p => p.Login == Login && p.Password == Password).First();
            }
        }

        public static void ChangePassword(string Login, byte[] OldPassword, byte[] NewPassword)
        {
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
            {
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);

                context.Database.ExecuteSqlCommand("exec DeleteClient @login, @password", login, password);
            }
        }

        public static List<Address_By_Login> GetAddresses(string Login, byte[] Password)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Address_By_Login.Where(p => p.Client_Login == Login && p.Password == Password && p.Active_Address == 1).ToList();
            }
        }

        public static List<Order_Set> GetOrderSet(int order)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Order_Set.Where(p => p.Order_ID == order).ToList();
            }
        }

        public static List<All_Dishes> GetAllDishes()
        {
            using (var context = new DeliveryAppContext())
            {
                return context.All_Dishes.ToList();
            }
        }

        public static bool HasOpenedOrder(string Login)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Order_Status_Table.Where(p => p.Client_Login == Login && p.Status_ID == 0).Count() == 1;
            }
        }

        public static int GetOpenedOrderID(string Login)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Order_Status_Table.Where(p => p.Client_Login == Login && p.Status_ID == 0).First().ID;
            }
        }
        public static void InitOrder(string Login, int Address)
        {
            using (var context = new DeliveryAppContext())
            {
                var login = new SqlParameter("@login", Login);
                var address = new SqlParameter("@address", Address);

                context.Database.ExecuteSqlCommand("exec InitOrder @login, @address",login, address);
            }
        }

        public static void AddToOrder(int OrderID, int DishID, int Count)
        {
            using (var context = new DeliveryAppContext())
            {
                var order = new SqlParameter("@orderID", OrderID);
                var dish = new SqlParameter("@dishID", DishID);
                var count = new SqlParameter("@count", Count);

                context.Database.ExecuteSqlCommand("exec AddToOrder @orderID, @dishID, @count", order, dish, count);
            }
        }

        public static void DeleteFromOrder(int OrderID, int DishID)
        {
            using (var context = new DeliveryAppContext())
            {
                var order = new SqlParameter("@orderID", OrderID);
                var dish = new SqlParameter("@dishID", DishID);

                context.Database.ExecuteSqlCommand("exec DeleteFromOrder @orderID, @dishID", order, dish);
            }
        }

        public static void ApplyOrder(string Login)
        {
            using (var context = new DeliveryAppContext())
            {
                var login = new SqlParameter("@orderID", Login);

                context.Database.ExecuteSqlCommand("exec ApplyOrder @login", login);
            }
        }

        public static void AddAdress(string Login, byte[] Password, string City, string District, string Street, string Building, string Room)
        {
            using (var context = new DeliveryAppContext())
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
            using (var context = new DeliveryAppContext())
            {
                var address = new SqlParameter("@address", Address);
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);

                context.Database.ExecuteSqlCommand("exec DeleteClientAddress @address, @login, @password",
                    address, login, password);
            }
        }

        public static void EditAdress(int Address, string Login, byte[] Password, string City, string District, string Street, string Building, string Room)
        {
            using (var context = new DeliveryAppContext())
            {
                var address = new SqlParameter("@address", Address);
                var login = new SqlParameter("@login", Login);
                var password = new SqlParameter("@password", Password);
                var city = new SqlParameter("@city", City);
                var district = new SqlParameter("@district", District);
                var street = new SqlParameter("@street", Street);
                var building = new SqlParameter("@building", Building);
                var room = new SqlParameter("@room", Room);

                context.Database.ExecuteSqlCommand("exec EditClientAddress @address, @login, @password, @city, @district, @street, @building, @room",
                    address, login, password, city, district, street, building, room);
            }
        }

        public static void ApplyOrder(int Order)
        {
            using (var context = new DeliveryAppContext())
            {
                var order = new SqlParameter("@order", Order);

                context.Database.ExecuteSqlCommand("exec ApplyOrder @order", order);
            }
        }

        public static int GetAddressByOrder(int Order)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Order_Status_Table.Where(p => p.ID == Order).First().Client_Address_ID;
            }
        }

        public static void ChangeAddressInOrder(int Order, int NewAddress)
        {
            using (var context = new DeliveryAppContext())
            {
                var order = new SqlParameter("@order", Order);
                var address = new SqlParameter("@address", NewAddress);

                context.Database.ExecuteSqlCommand("exec ChangeOrderAddress @order, @address", order, address);
            }
        }

        public static List<Order_On_Producer> GetProducerByOrder(int Order)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Order_On_Producer.Where(p => p.Order_ID == Order).ToList();
            }
        }

        public static List<Dish_All_Info> GetDishInfo(int dishID)
        {
            using (var context = new DeliveryAppContext())
            {
                return context.Dish_All_Info.Where(p => p.ID == dishID).ToList();
            }
        }
    }
}
