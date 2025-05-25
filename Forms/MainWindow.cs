using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using DeliveryApp.EF;
using System.Globalization;

namespace DeliveryApp
{
    public partial class Delivery : Form
    {

        CultureInfo culture = new CultureInfo("en-us");

        private Timer OredersUpdateTimer = new Timer();
        public Delivery()
        {
            InitializeComponent();
            User.userInfo = new User("UserLogin", "e7cf3ef4f17c3999a94f2c6f612e8a888e5b1026878e4e19398b23bd38ec221a");
            this.WelcomeMessage.Text = "Hello, " + User.userInfo.Login;
            this.OredersUpdateTimer.Interval = 5000;
            this.OredersUpdateTimer.Tick += new EventHandler(this.UpdateClientOrders_Tick);

            drawAll();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddOrderIntoTabs(Panel parentPanel, Order order)
        {
            Panel SingleOrder = new Panel();
            Label OrderedTime = new Label();
            Label OrderName = new Label();
            Label Status = new Label();
            // 
            // SingleOrder
            // 
            SingleOrder.SuspendLayout();
            SingleOrder.BackColor = SystemColors.ControlLightLight;
            SingleOrder.Controls.Add(OrderedTime);
            SingleOrder.Controls.Add(OrderName);
            SingleOrder.Location = new Point(0, 0);
            SingleOrder.Margin = new Padding(0, 10, 0, 0);
            SingleOrder.Size = new Size(792, 37);
            SingleOrder.Tag = order.ID;
            SingleOrder.Click += new EventHandler(this.SingleOrder_Click);
            // 
            // OrderName
            // 
            OrderName.AutoSize = true;
            OrderName.Dock = DockStyle.Left;
            OrderName.Font = new Font("Microsoft Sans Serif", 13.8F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            OrderName.Location = new Point(0, 0);
            OrderName.Text = "Order#" + order.ID.ToString();
            // 
            // OrderedTime
            // 
            OrderedTime.AutoSize = true;
            OrderedTime.Dock = DockStyle.Left;
            OrderedTime.Location = new Point(0, 0);
            if (!(order.Ordered_At is null))
            {
                OrderedTime.Text = $"Ordered at {order.Ordered_At.Value.ToString("d")}";
            }
            

            parentPanel.Controls.Add(SingleOrder);

            SingleOrder.ResumeLayout(false);
            SingleOrder.PerformLayout();
        }

        private void DrawOrders(List <Order> orders)
        {
            this.OrdersLayout.Controls.Clear();
            foreach (var order in orders)
            {
                AddOrderIntoTabs(this.OrdersLayout, order);              
            }
        }

        private void UpdateClientOrders_Tick(object sender, System.EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            try
            {
                List<Order> orders = ClientActions.GetClosedUserOrders(User.userInfo.Login);
                DrawOrders(orders);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserTabs_Selected(object sender, TabControlEventArgs e)
        {
            switch (UserTabs.SelectedIndex)
            {
                case 0:
                    
                    break;
                    
                case 1:
                    GetOrders();
                    break;

                case 2:
                    
                    break;
            }
            if(UserTabs.SelectedIndex == 1) OredersUpdateTimer.Enabled = true;
            else OredersUpdateTimer.Enabled = false;
        }

        void drawAll() {
            
        }

        private void SingleOrder_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            //this.panel1.Tag = 15;
            if (clickedPanel != null)
            {
                int orderID = Convert.ToInt32(clickedPanel.Tag);  // Произвольные данные (например, ID)
                MessageBox.Show($"ID order: {orderID}");
            }
        }
    }
}
