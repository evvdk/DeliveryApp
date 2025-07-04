﻿using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using DeliveryApp.EF;

namespace DeliveryApp
{
    class ClientActions
    {
        private static byte[] HashString(string Input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(Input);
                return sha256.ComputeHash(InputBytes);
            }
        }

        static public void Login(string Login, string Password)
        {
            if (Login.Length == 0 || Password.Length == 0) throw new Exception("Есть незаполненные поля");
            try
            {
                byte[] password = HashString(Password);
                if (!Database.IsValidUser(Login, password))
                    throw new Exception("Неправильный логин или пароль");
                User.userInfo = new User(Login, password);
            }
            catch (SqlException ex)
            {
                throw new Exception($"Database error {ex.Number}\n{ex.Message}");
            }
        }

        public static string FormatPhone(string phone)
        {
            string[] charsToRemoveFromPhone = new string[] { "(", ")", "-", " " };
            foreach (string c in charsToRemoveFromPhone)
                phone = phone.Replace(c, string.Empty);

            if (phone[0] == '8')
            {
                phone = "+7" + phone;
            }

            return phone;
        }

        public static void Register(string Login, string Password, string Name, string Phone, string Email)
        {
            if (Password.Length < 5 || Password.Length > 16)
                throw new Exception("Пароль должен быть от 5 до 16 символов");
            byte[] password = HashString(Password);

            Phone = FormatPhone(Phone);

            try
            {
                Database.InsertUser(Login, password, Name, Phone, Email);
                User.userInfo = new User(Login, password);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50000:
                        throw new Exception("Логин должен быть от 5 до 30 символов");
                    case 50001:
                        throw new Exception("Пользователь с таким логином уже существует");
                    case 50002:
                        throw new Exception("Имя должно быть от 3 до 20 символов");
                    case 50003:
                        throw new Exception("Телефон уже используется");
                    case 50004:
                        throw new Exception("Телефон заполнен неверно");
                    case 50005:
                        throw new Exception("Почта заполнена неверно");
                    default:
                        throw new Exception($"Database error {ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Processing error. Try again\n{ex.Message}");
            }

        }

        public static List<Order_Status_Table> GetClosedUserOrders(string Login)
        {
            try
            {
                return Database.GetClosedUserOrders(Login);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error retriving orders\n{ex.Message}");
            }
        }

        public static Client getClientInfo()
        {
            try
            {
                return Database.GetUserInfo(User.userInfo.Login, User.userInfo.Password);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error retriving user data\n{ex.Message}");
            }
        }

        public static void ChangePassword(string NewPassword, string RetypedPassword)
        {

            if (NewPassword.Length < 5 || NewPassword.Length > 16) throw new
                Exception("Пароль должен быть от 5 до 16 символов");

            if (NewPassword != RetypedPassword) throw new Exception("Пароли не совпадают");

            byte[] newPassword = HashString(NewPassword);

            if (User.userInfo.Password == newPassword)
                throw new Exception("Новый и старый пароли одинаковы");

            try
            {
                Database.ChangePassword(User.userInfo.Login, User.userInfo.Password, newPassword);
                User.userInfo.Password = newPassword;
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Пользователь с логином и паролем не существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during changing password\n{ex.Message}");
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
                        throw new Exception("Логин должен быть от 5 до 30 символов");
                    case 50001:
                        throw new Exception("Логин уже существует");
                    case 50006:
                        throw new Exception("Пользователь не существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during changing password\n{ex.Message}");
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
                        throw new Exception("Имя должно быть от 3 до 20 символов");
                    case 50006:
                        throw new Exception("Неправильный логин или пароль");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during changing name\n{ex.Message}");
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
                        throw new Exception("Телефон уже используется");
                    case 50004:
                        throw new Exception("Телефон заполнен неверно");
                    case 50006:
                        throw new Exception("Пользователь не существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during changing phone\n{ex.Message}");
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
                        throw new Exception("Почта заполнена неверно");
                    case 50006:
                        throw new Exception("Пользователь не существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during changing email\n{ex.Message}");
            }
        }

        public static void DeleteAccount()
        {
            try
            {
                Database.DeleteAccount(User.userInfo.Login, User.userInfo.Password);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Пользователь не существет");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during deleting account\n{ex.Message}");
            }
        }

        public static List<Address_By_Login> GetAddresses()
        {
            try
            {
                return Database.GetAddresses(User.userInfo.Login, User.userInfo.Password);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving addresses\n{ex.Message}");
            }
        }

        public static List<All_Dishes> GetAllDishes()
        {
            try
            {
                return Database.GetAllDishes();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving dishes\n{ex.Message}");
            }
        }

        public static bool HasOpenedOrder()
        {
            try
            {
                return Database.HasOpenedOrder(User.userInfo.Login);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving order\n{ex.Message}");
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
                throw new Exception($"Адрес не выбран");
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving order\n{ex.Message}");
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
                        throw new Exception("Пользователь с данным логином не существует");
                    case 50011:
                        throw new Exception("У Вас более одного заказа");
                    default: 
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during initing order\n{ex.Message}");
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
                        throw new Exception("Заказ не создан");
                    case 50010:
                        throw new Exception("Разные блюда в одном заказе не могут находиться");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during adding dish to order\n{ex.Message}");
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
                        throw new Exception("Блюдо не найдено в заказе");
                    default: 
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during deleting dish from order\n{ex.Message}");
            }
        }

        public static void AddAdress(string City, string District, string Street, string Building, string Room)
        {
            try
            {
                Database.AddAdress(User.userInfo.Login, User.userInfo.Password, City, District, Street, Building, Room);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Пользователь не найден");
                    case 50014:
                        throw new Exception("Адрес уже существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during adding address\n{ex.Message}");
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
                        throw new Exception("Пользователь не существует");
                    case 50007:
                        throw new Exception("Адрес не существует");
                    case 50013:
                        throw new Exception("Адрес находится в заказе");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during deleting address\n{ex.Message}");
            }
        }

        public static void EditAddress(int Address, string City, string District, string Street, string Building, string Room)
        {
            try
            {
                Database.EditAdress(Address, User.userInfo.Login, User.userInfo.Password, City, District, Street, Building, Room);
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50006:
                        throw new Exception("Пользователь не существует");
                    case 50007:
                        throw new Exception("Адрес не существует");
                    case 50014:
                        throw new Exception("Адрес уже существует");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during deleting address\n{ex.Message}");
            }
        }

        public static List<Order_Set> GetOrderSet(int order)
        {
            try
            {
                return Database.GetOrderSet(order);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving order data\n{ex.Message}");
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
                        throw new Exception("Заказ не может быть собран");
                    default:
                        throw new Exception($"Database error{ex.Number}\n{ex.Message}");
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during applying order\n{ex.Message}");
            }
        }

        public static int GetAddressIdByOrder(int Order)
        {
            try
            {
                return Database.GetAddressIdByOrder(Order);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error reciving address by order\n{ex.Message}");
            }
        }

        public static void ChangeAddressInOrder(int Order, int NewAddress)
        {
            try
            {
                Database.ChangeAddressInOrder(Order, NewAddress);
            } 
            catch(Exception ex)
            {
                throw new Exception($"Error during changing address in order\n{ex.Message}");
            }
        }

        public static List<Order_On_Producer> GetProducerByOrder(int Order)
        {
            try
            {
                return Database.GetProducerByOrder(Order);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving producers by order\n{ex.Message}");
            }
        }

        public static List<Dish_All_Info> GetDishInfo(int DishID)
        {
            try
            {
                return Database.GetDishInfo(DishID);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving dish data\n{ex.Message}");
            }
        }

        public static Order_Status_Table GetAddressOfOrder(int Order)
        {
            try
            {
                return Database.GetAddressOfOrder(Order);
            }
            catch(Exception ex)
            {
                throw new Exception($"Error during reciving address of order\n{ex.Message}");
            }
        }
    }
}