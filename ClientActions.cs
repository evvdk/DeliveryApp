using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using DeliveryApp.EF;

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
            } catch (SqlException)
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
                        throw new Exception("SQL error during changing email");
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
                        throw new Exception("SQL error during changing email");
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
                        throw new Exception("SQL error during changing email");
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
                        throw new Exception("SQL error during changing email");
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
                        throw new Exception("SQL error during changing email");
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
                        throw new Exception("SQL error during changing email");
                }
            }
            catch
            {
                throw new Exception("Error during changing email");
            }
        }
    }
}
