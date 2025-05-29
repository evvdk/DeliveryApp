using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using DeliveryApp.EF;
using System.Windows.Forms;

namespace DeliveryApp
{
    class ClientActions
    {
        private static string HashString(string Input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(Input);
                byte[] HashBytes = sha256.ComputeHash(InputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in HashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        static public void Login(string Login, string Password)
        {
            if (Login.Length == 0 || Password.Length == 0) throw new Exception("Required fields are empthy");
            try
            {
                Password = HashString(Password);
                if (!Database.IsValidUser(Login, Password))
                    throw new Exception("Wrong login or password");
                User.userInfo = new User(Login, Password);
            }
            catch (SqlException)
            {
                throw new Exception("Database login error");
            }
        }

        public static string FormatPhone(string phone)
        {
            string[] charsToRemoveFromPhone = new string[] { "(", ")", "-", " " };
            foreach (string c in charsToRemoveFromPhone)
                phone = phone.Replace(c, string.Empty);

            phone = phone.Replace("8", "+7");

            return phone;
        }

        public static void Register(string Login, string Password, string Name, string Phone, string Email)
        {
            if (Password.Length < 5 || Password.Length > 16)
                throw new Exception("Password should be more than 5 and less than 16 letters");
            Password = HashString(Password);

            Phone = FormatPhone(Phone);

            try
            {
                Database.InsertUser(Login, Password, Name, Phone, Email);
                User.userInfo = new User(Login, Password);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50000:
                        throw new Exception("Login should be more than 5 and less than 30 letters");
                    case 50001:
                        throw new Exception("User with such login already exists");
                    case 50002:
                        throw new Exception("Name should be more than 2 and less than 20 letters");
                    case 50003:
                        throw new Exception("Phone already is used");
                    case 50004:
                        throw new Exception("Check if phone is correct");
                    case 50005:
                        throw new Exception("Check if email is correct");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Processing error. Try again");
            }

        }

        public static List<Order_Status_Table> GetClosedUserOrders(string Login)
        {
            try
            {
                return Database.GetClosedUserOrders(Login);
            }
            catch
            {
                throw new Exception("Error retriving orders");
            }
        }

        public static Client getClientInfo()
        {
            try
            {
                return Database.GetUserInfo(User.userInfo.Login, User.userInfo.Password);
            }
            catch
            {
                throw new Exception("Error retriving user data");
            }
        }

        public static void ChangePassword(string NewPassword, string RetypedPassword)
        {

            if (NewPassword.Length < 5 || NewPassword.Length > 16) throw new
                Exception("Password should be more than 5 and less than 16 letters");

            if (NewPassword != RetypedPassword) throw new Exception("Retyped password doesn't match");

            NewPassword = HashString(NewPassword);

            if (User.userInfo.Password == NewPassword)
                throw new Exception("Old and new password are equal");

            try
            {
                Database.ChangePassword(User.userInfo.Login, User.userInfo.Password, NewPassword);
                User.userInfo.Password = NewPassword;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("User with such login doesn't exitst");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during changing password");
            }
        }

        public static void ChangeLogin(string NewLogin)
        {
            try
            {
                Database.ChangeLogin(User.userInfo.Login, User.userInfo.Password, NewLogin);
                User.userInfo.Login = NewLogin;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50000:
                        throw new Exception("Login should be more than 5 and less than 30 letters");
                    case 50001:
                        throw new Exception("User with this login already exist");
                    case 50006:
                        throw new Exception("Wrong login or password");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during changing password");
            }
        }


        public static void ChangeName(string NewName)
        {
            try
            {
                Database.ChangeName(User.userInfo.Login, User.userInfo.Password, NewName);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50002:
                        throw new Exception("Name should be more than 2 and less than 20 letters");
                    case 50006:
                        throw new Exception("Wrong login or password");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during changing name");
            }
        }

        public static void ChangePhone(string NewPhone)
        {
            try
            {
                NewPhone = FormatPhone(NewPhone);
                Database.ChangePhone(User.userInfo.Login, User.userInfo.Password, NewPhone);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50003:
                        throw new Exception("Phone already used");
                    case 50004:
                        throw new Exception("Phone doesn't match pattern");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during changing phone");
            }
        }

        public static void ChangeEmail(string NewEmail)
        {
            try
            {
                Database.ChangeEmail(User.userInfo.Login, User.userInfo.Password, NewEmail);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50005:
                        throw new Exception("Email doesn't match pattern");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during changing email");
            }
        }

        public static void DeleteAccount()
        {
            try
            {
                ClientActions.DeleteAccount();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("User doesn't exist");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during deleting account");
            }
        }

        public static List<Address_By_Login> GetAddresses()
        {
            try
            {
                return Database.GetAddresses(User.userInfo.Login, User.userInfo.Password);
            }
            catch
            {
                throw new Exception("Error during reciving addresses");
            }
        }

        public static List<All_Dishes> GetAllDishes()
        {
            try
            {
                return Database.GetAllDishes();
            }
            catch
            {
                throw new Exception("Error during reciving dishes");
            }
        }

        public static bool HasOpenedOrder()
        {
            try
            {
                return Database.HasOpenedOrder(User.userInfo.Login);
            }
            catch
            {
                throw new Exception("Error during reciving order");
            }
        }

        public static int GetOpenOrderID()
        {
            try
            {
                return Database.GetOpenedOrderID(User.userInfo.Login);
            }
            catch(InvalidOperationException)
            {
                throw new Exception("Order doesn't exist");
            }
            catch
            {
                throw new Exception("Error during reciving order");
            }
        }

        public static void InitOrder(int Address)
        {
            try {
                Database.InitOrder(User.userInfo.Login, Address);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Client with login doesn't exists");
                    case 50011:
                        throw new Exception("More than one opened order");
                    default: throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during initing order");
            }
        }

        public static void AddToOrder(int OrderID, int DishID)
        {
            try
            {
                Database.AddToOrder(OrderID, DishID, 1);
            }
            catch(SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50009:
                        throw new Exception("Order doesn't exists");
                    case 50010:
                        throw new Exception("Different producers can't be in the same order");
                    default: throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during adding dish to order");
            }
        }

        public static void DeleteFromOrder(int OrderID, int DishID)
        {
            try
            {
                Database.DeleteFromOrder(OrderID, DishID);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50012:
                        throw new Exception("Dish doesn''t found in order");
                    default: throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during deleting dish from order");
            }
        }

        public static void AddAdress(string Region, string City, string District, string Street, string Building, int? Floor, string Room)
        {
            try
            {
                Database.AddAdress(User.userInfo.Login, User.userInfo.Password, Region, City, District, Street, Building, Floor, Room);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Client with login doesn't exists");
                    default:
                        throw new Exception("Database error");
                }
            }
            catch
            {
                throw new Exception("Error during adding address");
            }
        }

        public static void DeleteAddress(int Address)
        {
            try
            {
                Database.DeleteAddress(Address, User.userInfo.Login, User.userInfo.Password);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Client with login doesn't exists");
                    case 50007:
                        throw new Exception("Client with address doesn''t exists");
                    case 50013:
                        throw new Exception("Address currently in order");
                    default: 
                        throw new Exception($"Database error {ex.Message}");
                }
            }
            catch
            {
                throw new Exception("Error during deleting address");
            }
        }

        public static void EditAddress(int Address, string Region, string City, string District, string Street, string Building, int? Floor, string Room)
        {
            try
            {
                Database.EditAdress(Address, User.userInfo.Login, User.userInfo.Password, Region, City, District, Street, Building, Floor, Room);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Client with login doesn't exists");
                    case 50007:
                        throw new Exception("Client with address doesn't exists");
                    default:
                        throw new Exception($"Database error {ex.Message}");
                }
            }
            catch
            {
                throw new Exception("Error during deleting address");
            }
        }

        public static List<Order_Set> GetOrderSet(int order)
        {
            try
            {
                return Database.GetOrderSet(order);
            }
            catch
            {
                throw new Exception("Error during reciving order data");
            }
        }

        public static void ApplyOrder(int Order)
        {
            try
            {
                Database.ApplyOrder(Order);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50008:
                        throw new Exception("Order can't be assembled");
                    default:
                        throw new Exception($"Database error {ex.Message}");
                }
            }
            catch
            {
                throw new Exception("Error during applying order");
            }
        }

        public static int GetAddressByOrder(int Order)
        {
            try
            {
                return Database.GetAddressByOrder(Order);
            }
            catch
            {
                throw new Exception("Error reciving address by order");
            }
        }

        public static void ChangeAddressInOrder(int Order, int NewAddress)
        {
            try
            {
                Database.ChangeAddressInOrder(Order, NewAddress);
            } catch
            {
                throw new Exception("Error during changing address in order");
            }
        }

        public static List<Order_On_Producer> GetProducerByOrder(int Order)
        {
            try
            {
                return Database.GetProducerByOrder(Order);
            }
            catch
            {
                throw new Exception("Error during reciving producers by order");
            }
        }

        public static List<Dish_All_Info> GetDishInfo(int DishID)
        {
            try
            {
                return Database.GetDishInfo(DishID);
            }
            catch
            {
                throw new Exception("Error during reciving dish data");
            }
        }
    }
}