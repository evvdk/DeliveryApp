using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class Delivery: Form
    {
        public Delivery()
        {
            InitializeComponent();
            this.WelcomeMessage.Text = "Hello, " + User.userInfo.Login;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserOrderLayout_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i<5; i++)
            {
                AddTab();
            }
        }

        void AddTab()
        {
            
        }
    }
}
