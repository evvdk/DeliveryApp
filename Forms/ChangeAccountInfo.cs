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
                    NewFieldName.Text = "Логин";
                    this.Text = "Смена логина";

                    break;
                case ChangeTypeValue.Password:
                    NewFieldName.Text = "Пароль";
                    this.Text = "Смена пароля";
                    NewFieldInput.PasswordChar = '*';
                    RetypePasswordInput.PasswordChar = '*';
                    break;
                case ChangeTypeValue.Name:
                    NewFieldName.Text = "Новое имя";
                    this.Text = "Смена имени";
                    break;
                case ChangeTypeValue.Phone:
                    NewFieldName.Text = "Новый телефон";
                    this.Text = "Смена телефона";
                    break;
                case ChangeTypeValue.Email:
                    NewFieldName.Text = "Новая почта";
                    this.Text = "Смена почты";
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
