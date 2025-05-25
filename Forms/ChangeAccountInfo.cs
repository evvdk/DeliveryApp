using System;
using System.Windows.Forms;

namespace DeliveryApp.Forms
{

    public enum ChangeTypeValue {Login = 0, Password = 1, Name = 2, Phone = 3, Email = 4};
    public partial class ChangeAccountInfo: Form
    {
        private ChangeTypeValue OperationType;
        public ChangeAccountInfo(ChangeTypeValue operationType)
        {
            InitializeComponent();
            this.OperationType = operationType;
            Init();  
        }

        private void Init()
        {
            switch (this.OperationType)
            {
                case ChangeTypeValue.Login:
                    NewFieldName.Text = "Login";
                    this.Text = "Change Login";

                    break;
                case ChangeTypeValue.Password:
                    NewFieldName.Text = "Password";
                    this.Text = "Change Password";
                    NewFieldInput.PasswordChar = '*';
                    RetypePasswordInput.PasswordChar = '*';
                    break;
                case ChangeTypeValue.Name:
                    NewFieldName.Text = "New name";
                    this.Text = "Change Name";
                    break;
                case ChangeTypeValue.Phone:
                    NewFieldName.Text = "New phone";
                    this.Text = "Change Phone";
                    break;
                case ChangeTypeValue.Email:
                    NewFieldName.Text = "New email";
                    this.Text = "Change Email";
                    break;
            }
            if (this.OperationType != ChangeTypeValue.Password)
            {
                PasswordTitle.Visible = false;
                RetypePasswordInput.Visible = false;
            }
        }

        private void Apply_Click(object sender, System.EventArgs e)
        {
            try
            {
                string value = NewFieldInput.Text;
                switch (this.OperationType)
                {
                    case ChangeTypeValue.Login:
                        ClientActions.ChangeLogin(value);
                        break;
                    case ChangeTypeValue.Password:
                        ClientActions.ChangePassword(value, RetypePasswordInput.Text);
                        break;
                    case ChangeTypeValue.Name:
                        ClientActions.ChangeName(value);
                        break;
                    case ChangeTypeValue.Phone:
                        ClientActions.ChangePhone(value);
                        break;
                    case ChangeTypeValue.Email:
                        ClientActions.ChangeEmail(value);
                        break;
                }
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
