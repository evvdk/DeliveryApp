using System;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AuthButton_Click(object sender, System.EventArgs e)
        {
            LoginMessage.Text = "Вход...Ожидайте";
            try
            {
                ClientActions.Login(LoginInput.Text, PasswordInput.Text);
                (new Delivery()).Show();
                this.Dispose();
            }
            catch(Exception ex)
            {
                LoginMessage.Text = ex.Message;
            }
        }

        private void Registrate_Click(object sender, EventArgs e)
        {
            RegMessage.Text = "Регистрация...Ожидайте";
            try
            {
                ClientActions.Register(LoginRegistration.Text, PasswordRegistration.Text, NameRegistration.Text, PhoneRegistration.Text, EmailRegistration.Text);
                (new Delivery()).Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                RegMessage.Text = ex.Message;
            }
        }
    }
}