using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using DeliveryApp.EF;
using System.Globalization;
using DeliveryApp.Forms;
using System.Linq;

namespace DeliveryApp
{
    public partial class Delivery : Form
    {

        private Timer OredersUpdateTimer = new Timer();
        public Delivery()
        {
            InitializeComponent();
            User.userInfo = new User("UserLogin", "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92");
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

        private void AddDishesToMarket(Panel parentPanel, All_Dishes order)
        {   
            
        }

        private void DrawMarket(List<All_Dishes> market)
        {   
            var producers = market.GroupBy(p => new { p.Producer_ID, p.Producer_Name }).Where(grp => grp.Count() > 0).Select(p => new { ID = p.Key.Producer_ID, Name = p.Key.Producer_Name }).ToList();
            foreach (var producer in producers)
            {
                string producerName = market.Where(p => p.Producer_ID == producer.ID).First().Producer_Name;
                var producersDishes = market.Where(p => p.Producer_ID == producer.ID);
                foreach (var dish in producersDishes)
                {
                }
            }
        }

        private void getMarket()
        {
            try
            {
                List<All_Dishes> dishes = Database.GetAllDishes();
                DrawMarket(dishes);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    getMarket();
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
            getMarket();
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
            try
            {
                Panel clickedPanel = sender as Panel;
                if (clickedPanel != null)
                {
                    int orderID = Convert.ToInt32(clickedPanel.Tag);
                    (new OrderWindow(orderID)).Show();
                }
            }
            catch
            {
                MessageBox.Show("Error during openning order");
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

        private void Account_DeleteAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure? Deleting account cause data loss", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    User.userInfo = null;
                    ClientActions.DeleteAccount();
                    (new LoginForm()).Show();
                    this.Dispose();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Account_LogoutButton_Click(object sender, EventArgs e)
        {
            User.userInfo = null;
            (new LoginForm()).Show();
            this.Dispose();
        }

        private void Account_ChangeAddressButton_Click(object sender, EventArgs e)
        {
            (new AddressChooser()).Show();
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            //int openedOrder = 
            //(new OrderWindow()).Show();
        }
    }
}
