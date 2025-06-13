using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System.Linq;
using System;
namespace DeliveryApp.Forms
{
    public partial class OrderWindow: Form
    {
        private int OrderID;
        public OrderWindow(int OrderId)
        {
            this.OrderID = OrderId;
            InitializeComponent();

            UpdateOrder();
        }

        private void UpdateOrder()
        {
            List<Order_Set> order = ClientActions.GetOrderSet(this.OrderID);
            Order_Status_Table address = ClientActions.GetAddressOfOrder(this.OrderID);

            if(order.Count() == 0)
            {
                this.OrderName.Text = "Card is empthy";
                this.TotalBill.Text = "";
                this.Producer.Text = "";
                this.Status.Text = "";
                this.Dishes.Controls.Clear();
                this.Apply.Text = "Close";
                this.ChangeAddressButton.Enabled = false;
                return;
            }

            decimal Cost = decimal.Round((decimal)order.Sum(p => p.Sum));
            string Producer = order.First().Producer_Name;
            string Status = order.First().Order_Status_Value;
            bool isOpen = order.First().Order_Status == 0;

            this.OrderName.Text = $"Order#{OrderID}";
            this.TotalBill.Text = $"{Cost} ₽";
            this.Producer.Text = $"Ordered from {Producer}";
            this.AddressLabel.Text = $"Address: {address.City}, {address.District}, {address.Building}, {address.Room}";
            if (isOpen)
            {
                this.Status.Text = "";
                this.Apply.Text = "Apply";
                this.Apply.Click += (s, e) =>
                {
                    try
                    {
                        if(ClientActions.HasOpenedOrder())
                            ClientActions.ApplyOrder(this.OrderID);
                        this.Close();
                    } catch(Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                };
            }
            else
            {
                this.Status.Text = $"{Status}";
                this.Apply.Text = "Close";
                this.ChangeAddressButton.Enabled = false;
                this.ChangeAddressButton.Visible = false;
                this.Apply.Click += (s, e) =>
                {
                    this.Close();
                };
            }

            bool isOpened = order.All(p => p.Order_Status == 0);

            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();

            this.Dishes.Controls.Clear();

            foreach (var each in order)
            {
                TableLayoutPanel SingleDish = new TableLayoutPanel();
                Label DishName = new Label();
                Label DishCost = new Label();
                Label Count = new Label();
                Button Remove = new Button();
                Button Add = new Button();

                this.Dishes.Controls.Add(SingleDish);

                SingleDish.SuspendLayout();

                // 
                // SingleDish
                // 
                SingleDish.ColumnCount = 5;
                SingleDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                SingleDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
                SingleDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                SingleDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                SingleDish.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
                SingleDish.Controls.Add(Remove, 4, 0);
                SingleDish.Controls.Add(DishName, 0, 0);
                SingleDish.Controls.Add(DishCost, 1, 0);
                SingleDish.Controls.Add(Count, 3, 0);
                SingleDish.Controls.Add(Add, 2, 0);
                SingleDish.Location = new System.Drawing.Point(0, 41);
                SingleDish.Margin = new System.Windows.Forms.Padding(0);
                SingleDish.Name = "SingleDish";
                SingleDish.RowCount = 1;
                SingleDish.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                SingleDish.Size = new System.Drawing.Size(546, 33);
                // 
                // Remove
                // 
                Remove.AutoSize = true;
                Remove.Dock = DockStyle.Fill;
                Remove.Location = new System.Drawing.Point(609, 3);
                Remove.Name = "Remove";
                Remove.Size = new System.Drawing.Size(34, 27);
                Remove.Tag = each.Dish_ID;
                Remove.Text = "-";
                Remove.Enabled = isOpened;
                Remove.Click += new EventHandler(this.Remove_Click);
                // 
                // DishName
                // 
                DishName.AutoSize = true;
                DishName.Dock = DockStyle.Fill;
                DishName.Location = new System.Drawing.Point(3, 0);
                DishName.Size = new System.Drawing.Size(372, 33);
                DishName.TabIndex = 0;
                DishName.Text = $"{each.Dish_Name}";
                DishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // DishCost
                // 
                DishCost.AutoSize = true;
                DishCost.Dock = DockStyle.Fill;
                DishCost.Location = new System.Drawing.Point(381, 0);
                DishCost.Size = new System.Drawing.Size(142, 33);
                DishCost.Text = $"{decimal.Round((decimal)each.Cost)} ₽";
                DishCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Count
                // 
                Count.AutoSize = true;
                Count.Dock = DockStyle.Fill;
                Count.Location = new System.Drawing.Point(569, 0);
                Count.Size = new System.Drawing.Size(34, 33);
                Count.Text = $"{each.Count}";
                Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Add
                // 
                Add.AutoSize = true;
                Add.Enabled = isOpened;
                Add.Dock = DockStyle.Fill;
                Add.Location = new System.Drawing.Point(529, 3);
                Add.Tag  = each.Dish_ID;
                Add.Size = new System.Drawing.Size(34, 33);
                Add.Text = "+";
                Add.Click += new System.EventHandler(this.Add_Click);
                
                SingleDish.ResumeLayout(false);
                SingleDish.PerformLayout();
            }

            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private void Add_Click(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (button is null) throw new Exception("Button is not found");
            int dishId = (int)button.Tag;
            ClientActions.AddToOrder(this.OrderID, dishId);
            UpdateOrder();
        }

        private void Remove_Click(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (button is null) throw new Exception("Button is not found");
            int dishId = (int)button.Tag;
            ClientActions.DeleteFromOrder(this.OrderID, dishId);
            UpdateOrder();
        }

        private void ChangeAddressButton_Click(object sender, EventArgs e)
        {
            AddressChooser wnd = new AddressChooser(this.OrderID);
            wnd.Show();
            wnd.FormClosed += (s, ev) =>
            {
                UpdateOrder();
            };
        }
    }
}
