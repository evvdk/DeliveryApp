using System;
using System.Security.Cryptography;
using System.Text;

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

        static public bool Login(string Login, string Password)
        {
            Password = HashString(Password);
            if (Database.IsValidUser(Login, Password))
            {
                User.userInfo = new User(Login, Password);
                return true;
            }
            return false;
        }

        static public void Register(string Login, string Password, string Name, string Phone, string Email)
        {
            if (Password.Length < 5 || Password.Length > 16) throw new Exception("Password should be more than 5 and less than 16 letters");
            Password = HashString(Password);
            Database.InsertUser(Login, Password, Name, Phone, Email);
            User.userInfo = new User(Login, Password);
        }
    }
}
