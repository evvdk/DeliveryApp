using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class MainWindow: Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            this.label1.Text = "Hello, " + User.userInfo.Login;
        }
    }
}
