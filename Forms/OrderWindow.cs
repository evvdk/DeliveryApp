using System.Windows.Forms;

namespace DeliveryApp.Forms
{
    public partial class OrderWindow: Form
    {
        private int OrderID;
        public OrderWindow(int OrderId)
        {
            this.OrderID = OrderId;
            InitializeComponent();
        }
    }
}
