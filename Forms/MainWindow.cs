using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using DeliveryApp.EF;
using DeliveryApp.Forms;
using System.Linq;
using System.Data.SqlClient;

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

        private void DrawMarket(List<All_Dishes> market)
        {
            var producers = market.GroupBy(p => new { p.Producer_ID, p.Producer_Name }).Where(grp => grp.Count() > 0).Select(p => new { ID = p.Key.Producer_ID, Name = p.Key.Producer_Name }).ToList();
            foreach (var producer in producers)
            {

                TableLayoutPanel ProducerDishes = new TableLayoutPanel();
                Label Producer = new Label();

                FlowLayoutPanel DishFlowScrollLayout = new FlowLayoutPanel();

                ProducerDishes.SuspendLayout();
                DishFlowScrollLayout.SuspendLayout();


                this.MarketList.Controls.Add(ProducerDishes);
                
                ProducerDishes.ColumnCount = 1;
                ProducerDishes.AutoSize = true;
                ProducerDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                ProducerDishes.Controls.Add(Producer, 0, 0);
                ProducerDishes.Controls.Add(DishFlowScrollLayout, 0, 1);
                ProducerDishes.RowCount = 2;
                ProducerDishes.Margin = new Padding(0);
                ProducerDishes.Padding = new Padding(0);
                ProducerDishes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                ProducerDishes.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
                
                Producer.AutoSize = true;
                Producer.Dock = DockStyle.Top;
                Producer.Location = new Point(0, 0);
                Producer.Text = $"{producer.Name}";
                Producer.Margin = new Padding(0);
                Producer.Padding = new Padding(0);
                Producer.Font = new Font("Microsoft Sans Serif", 13.8F,
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                
                DishFlowScrollLayout.AutoScroll = true;
                DishFlowScrollLayout.AutoSize = true;
                DishFlowScrollLayout.Dock = DockStyle.Fill;
                DishFlowScrollLayout.Location = new Point(0, 29);
                DishFlowScrollLayout.Margin = new Padding(0);
                DishFlowScrollLayout.Padding = new Padding(0);
                DishFlowScrollLayout.WrapContents = false;
                
                string producerName = market.Where(p => p.Producer_ID == producer.ID).First().Producer_Name;
                var producersDishes = market.Where(p => p.Producer_ID == producer.ID);
                foreach (var dish in producersDishes)
                {
                    
                    TableLayoutPanel DishTable = new TableLayoutPanel();

                    Button AddDish = new Button();
                    Label DishName = new Label();
                    Panel Image = new Panel();


                    DishTable.SuspendLayout();

                    DishFlowScrollLayout.Controls.Add(DishTable);


                    Image.Dock = DockStyle.Fill;
                    Image.BackColor = SystemColors.Menu;

                    DishTable.BackColor = Color.Silver;
                    DishTable.ColumnCount = 2;
                    DishTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
                    DishTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
                    DishTable.Controls.Add(Image, 0, 0);
                    DishTable.Controls.Add(DishName, 1, 0);
                    DishTable.Controls.Add(AddDish, 0, 1);
                    DishTable.Location = new Point(0, 0);
                    DishTable.Margin = new Padding(0,0,10,0);
                    DishTable.RowCount = 2;
                    DishTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    DishTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                    DishTable.Size = new Size(208, 102);
                    
                    DishName.AutoSize = true;
                    DishName.Dock = DockStyle.Fill;
                    DishName.Location = new Point(131, 0);
                    DishName.Size = new Size(74, 72);
                    DishName.TabIndex = 2;
                    DishName.Text = $"{dish.Dish_Name}";
                    DishName.TextAlign = ContentAlignment.MiddleCenter;
                    
                    AddDish.AutoSize = true;
                    AddDish.Dock = DockStyle.Fill;
                    AddDish.Location = new Point(3, 75);
                    AddDish.Size = new Size(66, 24);
                    AddDish.Text = "+";
                    AddDish.UseVisualStyleBackColor = true;
                    AddDish.Tag = dish.Dish_ID;
                    AddDish.Click += new EventHandler(this.Dish_Add_Click);
                    
                    DishTable.ResumeLayout(false);
                    DishTable.PerformLayout();

                }

                ProducerDishes.ResumeLayout(false);
                ProducerDishes.PerformLayout();
                DishFlowScrollLayout.ResumeLayout(false);

            }
        }

        private void getMarket()
        {
            try
            {
                List<All_Dishes> dishes = ClientActions.GetAllDishes();
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
                    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    int orderID = Convert.ToInt32(clickedPanel.Tag);
                    (new OrderWindow(orderID)).Show();
                }
            }
            catch
            {
                MessageBox.Show("Error during openning order");
            }
        }

        private void Dish_Add_Click(object sender, EventArgs e)
        {

            try
            {
                Button clickedPanel = sender as Button;
                if (clickedPanel == null) throw new Exception("Error reciving dish ID");
                int dishID = Convert.ToInt32(clickedPanel.Tag);

                if (ClientActions.HasOpenedOrder())
                {
                    int orderId = ClientActions.GetOpenOrderID();
                   ClientActions.AddToOrder(orderId, dishID);
                }
                else
                {
                    AddressChooser wnd = new AddressChooser(Mode.Order);
                    wnd.Show();
                    wnd.FormClosed += (s, ev) =>
                    {
                        try
                        {
                            int orderId = ClientActions.GetOpenOrderID();
                            ClientActions.AddToOrder(orderId, dishID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    };
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void Account_ChangeButton_Click(object sender, EventArgs e)
        {
            Button clickedPanel = sender as Button;
            if (clickedPanel != null)
            {
                ChangeTypeValue InfoType = (ChangeTypeValue)Convert.ToInt32(clickedPanel.Tag);
                ChangeAccountInfo wind = new ChangeAccountInfo(InfoType);
                wind.FormClosed += (s, ev) => { UpdateClientInfo(); };
                wind.Show();
            }
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
            (new AddressChooser(Mode.Edit)).Show();
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClientActions.HasOpenedOrder())
                {
                    MessageBox.Show("Card is emphty");
                }
                else
                {
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    int openedOrder = ClientActions.GetOpenOrderID();
                    (new OrderWindow(openedOrder)).Show();
                }
            }
            catch
            {
                MessageBox.Show("Error during openning card");
            }
            
        }
    }
}
