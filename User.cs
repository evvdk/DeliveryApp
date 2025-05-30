namespace DeliveryApp
{
    class User
    {
        public string Login { get; set; }
        public byte[] Password { get; set; }

        public User(string login, byte[] password)
        {
            Login = login;
            Password = password;
        }

        public static User userInfo = null;
    }
}
