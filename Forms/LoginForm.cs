using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ShowLoginLayout();
        }

        private void LoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void ShowLoginLayout()
        {
            TabsControl.SelectedIndex = 0;
        }

        void ShowRegisterLayout()
        {
            TabsControl.SelectedIndex = 1;
        }

        private void AuthButton_Click(object sender, System.EventArgs e)
        {
            this.LoginMessage.Visible = false;
            try
            {
                if(LoginInput.Text.Length == 0 || PasswordInput.Text.Length == 0)
                {
                    LoginMessage.Text = "Required fields are empthy";
                    this.LoginMessage.Visible = true;
                    return;
                }
                if (ClientActions.Login(LoginInput.Text, PasswordInput.Text))
                {
                    (new Delivery()).Show();
                    this.Close();
                }
                else
                {
                    LoginMessage.Text = "Wrong login or password";
                    this.LoginMessage.Visible = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL: " + ex.Number.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Click(object sender, System.EventArgs e)
        {
            ShowRegisterLayout();
        }

        private void Register_Back_Click(object sender, System.EventArgs e)
        {
            ShowLoginLayout();
        }

        private void Registrate_Click(object sender, EventArgs e)
        {
            try
            {
                ClientActions.Register(LoginRegistration.Text, PasswordRegistration.Text, NameRegistration.Text, PhoneRegistration.Text, EmailRegistration.Text);
                (new Delivery()).Show();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}