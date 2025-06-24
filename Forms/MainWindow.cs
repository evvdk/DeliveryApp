using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using DeliveryApp.EF;
using DeliveryApp.Forms;
using System.Linq;
using System.Data;
namespace DeliveryApp
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();

            GetOrders();
            UpdateClientInfo();
            getMarket();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddOrderIntoTabs(Panel parentPanel, Информация_о_заказе order)
        {
            Panel SingleOrder = new Panel();
            Label OrderName = new Label();
            Label Status = new Label();

            SingleOrder.SuspendLayout();
            SingleOrder.BackColor = Color.LightSteelBlue; ;

            SingleOrder.Controls.Add(OrderName);
            SingleOrder.Controls.Add(Status);
            SingleOrder.Location = new Point(0, 0);
            SingleOrder.Margin = new Padding(0, 10, 0, 0);
            SingleOrder.Size = new Size(720, 37);
            SingleOrder.Tag = order.ID_заказа;
            SingleOrder.Click += new EventHandler(this.SingleOrder_Click);
            
            OrderName.AutoSize = true;
            OrderName.Enabled = false;
            OrderName.Dock = DockStyle.Left;
            OrderName.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            OrderName.Location = new Point(0, 0);
            OrderName.Text = $"Заказ#{order.ID_заказа}";

            if (!(order.Время_заказа is null))
            {
                Label OrderedTime = new Label();

                SingleOrder.Controls.Add(OrderedTime);
                OrderedTime.AutoSize = true;
                OrderedTime.Enabled = false;
                OrderedTime.Dock = DockStyle.Right;
                OrderedTime.Location = new Point(0, 0);
            
                OrderedTime.Text = $"Заказано {order.Время_заказа.Value.ToString("F")}";
            }

            Status.AutoSize = true;
            Status.Enabled = false;
            Status.Dock = DockStyle.Top;
            Status.Location = new Point(0, 0);
            Status.Text = order.Статус;

            parentPanel.Controls.Add(SingleOrder);

            SingleOrder.ResumeLayout(false);
            SingleOrder.PerformLayout();
        }

        private void DrawMarket(List<Меню> market)
        {
            this.MarketList.Controls.Clear();

            foreach (var dish in market)
            {
                FlowLayoutPanel DishFlowScrollLayout = new FlowLayoutPanel();

                DishFlowScrollLayout.SuspendLayout();

                DishFlowScrollLayout.Dock = DockStyle.Fill;
                DishFlowScrollLayout.AutoScroll = true;
                DishFlowScrollLayout.AutoSize = true;
                DishFlowScrollLayout.MaximumSize = new Size(700, 500);
                DishFlowScrollLayout.Margin = new Padding(0);
                DishFlowScrollLayout.Padding = new Padding(0);
                DishFlowScrollLayout.WrapContents = false;

                TableLayoutPanel DishTable = new TableLayoutPanel();
                DishTable.Click += (s, e) => { (new SingleDish(dish.Название)).Show(); };

                CustomButton AddDish = new CustomButton();
                Label DishName = new Label();
                Panel ImagePanel = new Panel();

                DishTable.SuspendLayout();

                DishFlowScrollLayout.Controls.Add(DishTable);

                DishTable.BackColor = Color.LightSteelBlue;
                DishTable.ColumnCount = 2;
                DishTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
                DishTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
                DishTable.Controls.Add(ImagePanel, 0, 0);
                DishTable.Controls.Add(DishName, 1, 0);
                DishTable.Controls.Add(AddDish, 0, 1);
                DishTable.Location = new Point(0, 0);
                DishTable.Margin = new Padding(0, 0, 10, 0);
                DishTable.RowCount = 2;
                DishTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
                DishTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
                DishTable.Size = new Size(208, 102);

                DishName.AutoSize = true;
                DishName.Dock = DockStyle.Fill;
                DishName.Location = new Point(131, 0);
                DishName.Size = new Size(74, 72);
                DishName.Text = $"{dish.Название}";
                DishName.TextAlign = ContentAlignment.MiddleCenter;
                DishName.Click += (s, e) => { (new SingleDish(dish.Название)).Show(); };

                AddDish.AutoSize = true;
                AddDish.Dock = DockStyle.Fill;
                AddDish.Location = new Point(3, 75);
                AddDish.Size = new Size(66, 24);
                AddDish.Text = "+";
                AddDish.UseVisualStyleBackColor = true;
                AddDish.Tag = dish;
                AddDish.Click += new EventHandler(this.Dish_Add_Click);

                DishTable.ResumeLayout(false);
                DishTable.PerformLayout();

               
                DishFlowScrollLayout.ResumeLayout(false);
                DishFlowScrollLayout.PerformLayout();

            }
        }

        private void getMarket()
        {
            try
            {
                List<Меню> dishes = ClientActions.GetAllDishes();
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
            Header.Text = "Вы еще ничего не заказывали :(";

            
            parentPanel.Controls.Add(Header);
        }

        private void DrawOrders(List <Информация_о_заказе> orders)
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

        private void GetOrders()
        {
            try
            {
                List<Информация_о_заказе> orders = ClientActions.GetClosedUserOrders(User.userInfo.Login);
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
        }

        private void UpdateClientInfo()
        {
            try
            {
                this.WelcomeMessage.Text = "Здравствуйте, " + User.userInfo.Login;

                Клиент user = ClientActions.getClientInfo();
                Account_UserLogin.Text = user.Логин;
                Account_UserName.Text = user.Имя;
                Account_UserPhone.Text = user.Телефон;
                if (!(user.Эл_почта is null))
                    Account_UserEmail.Text = user.Эл_почта;               
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
                MessageBox.Show("Ошибка открытия заказа");
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
                    getMarket();
                }
                else
                {
                    {   try
                        {
                            ClientActions.InitOrder();
                            int orderId = ClientActions.GetOpenOrderID();
                    ClientActions.AddToOrder(orderId, dishID);
                            getMarket();
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
                DialogResult dialogResult = MessageBox.Show("Вы уверены? Удаление аккаунта вызовет удаление данных", "Внимание", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    ClientActions.DeleteAccount();
                    User.userInfo = null;
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

        private void AddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ClientActions.HasOpenedOrder())
                {
                    MessageBox.Show("Корзина пуста");
                }
                else
                {
                    int openedOrder = ClientActions.GetOpenOrderID();
                    OrderWindow wnd = new OrderWindow(openedOrder);
                    wnd.Show();
                    wnd.FormClosed += (s, ev) =>
                    {
                        getMarket();
                    };

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
    }
}