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
            LoginPanel.Visible = true;
        }

        void ShowRegisterLayout()
        {
            LoginPanel.Visible = false;
        }

        private void AuthButton_Click(object sender, System.EventArgs e)
        {
            this.Message.Visible = false;
            try
            {
                if (ClientActions.Login(LoginInput.Text, PasswordInput.Text))
                {
                    (new MainWindow()).Show();
                    this.Close();
                }
                else
                {
                    Message.Text = "Wrong login or password";
                    this.Message.Visible = true;
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

        private void CreateAccount_Click()
        {
            try
            {
                ClientActions.Register("Sasefiwhfiwheed", "Sas", "Sas", "+7950475698", "email@test.com");
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

        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}