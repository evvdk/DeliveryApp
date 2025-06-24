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
            List<Блюда_в_заказе> order = ClientActions.GetOrderSet(this.OrderID);

            if(order.Count() == 0)
            {
                this.Text = "Корзина пуста";
                this.OrderName.Text = "Корзина пуста";
                this.TotalBill.Text = "";
                this.Status.Text = "";
                this.Dishes.Controls.Clear();
                this.Apply.Text = "Закрыть";
                return;
            }

            this.Text = $"Заказ#{OrderID}";
            decimal Cost = decimal.Round((decimal)order.Sum(p => p.Сумма_стоимости_блюда));
            string Status = order.First().Статус;
            bool isOpen = order.First().ID_Статуса == 0;

            this.OrderName.Text = $"Заказ#{OrderID}";
            this.TotalBill.Text = $"Cтоимость {Cost} ₽";
           
            if (isOpen)
            {
                this.Status.Text = "";
                this.Apply.Text = "Заказать";
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
                this.Apply.Text = "Закрыть";
                this.Apply.Click += (s, e) =>
                {
                    this.Close();
                };
            }

            bool isOpened = order.All(p => p.ID_Статуса == 0);

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
                Remove.Tag = each.Название;
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
                DishName.Text = $"{each.Название}";
                DishName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // DishCost
                // 
                DishCost.AutoSize = true;
                DishCost.Dock = DockStyle.Fill;
                DishCost.Location = new System.Drawing.Point(381, 0);
                DishCost.Size = new System.Drawing.Size(142, 33);
                DishCost.Text = $"{decimal.Round((decimal)each.Цена)} ₽";
                DishCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Count
                // 
                Count.AutoSize = true;
                Count.Dock = DockStyle.Fill;
                Count.Location = new System.Drawing.Point(569, 0);
                Count.Size = new System.Drawing.Size(34, 33);
                Count.Text = $"{each.Название}";
                Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // Add
                // 
                Add.AutoSize = true;
                Add.Enabled = isOpened;
                Add.Dock = DockStyle.Fill;
                Add.Location = new System.Drawing.Point(529, 3);
                Add.Tag  = each.Название;
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
    }
}
