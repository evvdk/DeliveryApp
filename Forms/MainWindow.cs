using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using DeliveryApp.EF;
using System.Globalization;
using DeliveryApp.Forms;

namespace DeliveryApp
{
    public partial class Delivery : Form
    {

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

        private void AddOrderIntoTabs(Panel parentPanel, Order_Status_Table order)
        {
            Panel SingleOrder = new Panel();
            Label OrderName = new Label();
            Label Status = new Label();

            SingleOrder.SuspendLayout();
            SingleOrder.BackColor = SystemColors.ControlLightLight;
            
            SingleOrder.Controls.Add(OrderName);
            SingleOrder.Controls.Add(Status);
            SingleOrder.Location = new Point(0, 0);
            SingleOrder.Margin = new Padding(0, 10, 0, 0);
            SingleOrder.Size = new Size(550, 37);
            SingleOrder.Tag = order.ID;
            SingleOrder.Click += new EventHandler(this.SingleOrder_Click);
            
            OrderName.AutoSize = true;
            OrderName.Enabled = false;
            OrderName.Dock = DockStyle.Left;
            OrderName.Font = new Font("Microsoft Sans Serif", 13.8F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            OrderName.Location = new Point(0, 0);
            OrderName.Text = $"Order#{order.ID}";

            if (!(order.Ordered_At is null))
            {
                Label OrderedTime = new Label();

                SingleOrder.Controls.Add(OrderedTime);
                OrderedTime.AutoSize = true;
                OrderedTime.Enabled = false;
                OrderedTime.Dock = DockStyle.Right;
                OrderedTime.Location = new Point(0, 0);
            
                OrderedTime.Text = $"Ordered at {order.Ordered_At.Value.ToString("F")}";
            }

            Status.AutoSize = true;
            Status.Enabled = false;
            Status.Dock = DockStyle.Top;
            Status.Location = new Point(0, 0);
            Status.Text = order.Status_Value;

            parentPanel.Controls.Add(SingleOrder);

            SingleOrder.ResumeLayout(false);
            SingleOrder.PerformLayout();
        }

        private void EmpthyHeader(Panel parentPanel)
        {
            Label Header = new Label();

            Header.AutoSize = true;
            Header.Enabled = false;
            Header.Dock = DockStyle.Left;
            Header.Font = new Font("Microsoft Sans Serif", 13.8F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Header.Location = new Point(0, 0);
            Header.Text = "You haven't order anything :(";

            
            parentPanel.Controls.Add(Header);
        }

        private void DrawOrders(List <Order_Status_Table> orders)
        {
            
            Point CurrentPoint = OrdersLayout.AutoScrollPosition;
            this.OrdersLayout.Controls.Clear();
            this.OrdersLayout.SuspendLayout();
            if (orders.Count == 0)
            {
                EmpthyHeader(this.OrdersLayout);
            }
            else
            {
                foreach (var order in orders)
                {
                    AddOrderIntoTabs(this.OrdersLayout, order);
                }
            }
            this.OrdersLayout.ResumeLayout();
            this.OrdersLayout.AutoScrollPosition = new Point(Math.Abs(OrdersLayout.AutoScrollPosition.X), Math.Abs(CurrentPoint.Y));
        }

        private void UpdateClientOrders_Tick(object sender, System.EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            try
            {
                List<Order_Status_Table> orders = ClientActions.GetClosedUserOrders(User.userInfo.Login);
                DrawOrders(orders);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserTabs.SelectedIndex = 0;
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
                    UpdateClientInfo();
                    break;
            }
            if(UserTabs.SelectedIndex == 1) OredersUpdateTimer.Enabled = true;
            else OredersUpdateTimer.Enabled = false;
        }

        void drawAll() {
            GetOrders();
            UpdateClientInfo();
            // ....
        }

        private void UpdateClientInfo()
        {
            try
            {
                this.WelcomeMessage.Text = "Hello, " + User.userInfo.Login;

                Client user = ClientActions.getClientInfo();
                Account_UserLogin.Text = user.Login;
                Account_UserName.Text = user.Name;
                Account_UserPhone.Text = user.Phone;
                if (!(user.Email is null))
                    Account_UserEmail.Text = user.Email;
                Account_CreatedAt.Text = "Created " + user.Created.ToString("F");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserTabs.SelectedIndex = 0;
            }
        }

        private void SingleOrder_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                int orderID = Convert.ToInt32(clickedPanel.Tag);
                MessageBox.Show($"Order id {orderID}");
                // ****
            }
        }

        private void Account_ChangeButton_Click(object sender, EventArgs e)
        {
            Button clickedPanel = sender as Button;
            if (clickedPanel != null)
            {
                ChangeTypeValue orderID = (ChangeTypeValue)Convert.ToInt32(clickedPanel.Tag);
                ChangeAccountInfo wind = new ChangeAccountInfo(orderID);
                wind.FormClosed += new FormClosedEventHandler(this.ChnageAccoutWindow_Closed);
                wind.Show();
            }
        }

        private void ChnageAccoutWindow_Closed(object sender, FormClosedEventArgs e)
        {
            UpdateClientInfo();
        }
    }
}
