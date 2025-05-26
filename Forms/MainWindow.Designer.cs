using System.Windows.Forms;
using System.Drawing;
namespace DeliveryApp
{
    partial class Delivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.UserTabs = new System.Windows.Forms.TabControl();
            this.MarketPage = new System.Windows.Forms.TabPage();
            this.AddToCart = new System.Windows.Forms.Button();
            this.MarketList = new System.Windows.Forms.FlowLayoutPanel();
            this.ProducerDishes = new System.Windows.Forms.TableLayoutPanel();
            this.Producer = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Dish = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DishName = new System.Windows.Forms.Label();
            this.AddDish = new System.Windows.Forms.Button();
            this.UserOdersPage = new System.Windows.Forms.TabPage();
            this.OrdersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.UserAccountPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.Account_UserEmail = new System.Windows.Forms.TextBox();
            this.Account_UserPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Account_ChangePhoneButton = new System.Windows.Forms.Button();
            this.Account_ChangeEmailButton = new System.Windows.Forms.Button();
            this.Account_UserName = new System.Windows.Forms.TextBox();
            this.Account_ChangeNameButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Account_UserPassword = new System.Windows.Forms.TextBox();
            this.Account_ChangePasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Account_ChangeUsernameButton = new System.Windows.Forms.Button();
            this.Account_UserLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Account_ChangeAddressButton = new System.Windows.Forms.Button();
            this.Account_CreatedAt = new System.Windows.Forms.Label();
            this.Account_DeleteAccountButton = new System.Windows.Forms.Button();
            this.Account_LogoutButton = new System.Windows.Forms.Button();
            this.UserTabs.SuspendLayout();
            this.MarketPage.SuspendLayout();
            this.MarketList.SuspendLayout();
            this.ProducerDishes.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Dish.SuspendLayout();
            this.UserOdersPage.SuspendLayout();
            this.UserAccountPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.AccountTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.WelcomeMessage.Location = new System.Drawing.Point(0, 0);
            this.WelcomeMessage.Margin = new System.Windows.Forms.Padding(0);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(101, 27);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome";
            // 
            // UserTabs
            // 
            this.UserTabs.Controls.Add(this.MarketPage);
            this.UserTabs.Controls.Add(this.UserOdersPage);
            this.UserTabs.Controls.Add(this.UserAccountPage);
            this.UserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTabs.Location = new System.Drawing.Point(0, 27);
            this.UserTabs.Margin = new System.Windows.Forms.Padding(0);
            this.UserTabs.Name = "UserTabs";
            this.UserTabs.SelectedIndex = 0;
            this.UserTabs.Size = new System.Drawing.Size(800, 423);
            this.UserTabs.TabIndex = 1;
            this.UserTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.UserTabs_Selected);
            // 
            // MarketPage
            // 
            this.MarketPage.Controls.Add(this.AddToCart);
            this.MarketPage.Controls.Add(this.MarketList);
            this.MarketPage.Location = new System.Drawing.Point(4, 25);
            this.MarketPage.Margin = new System.Windows.Forms.Padding(0);
            this.MarketPage.Name = "MarketPage";
            this.MarketPage.Size = new System.Drawing.Size(792, 394);
            this.MarketPage.TabIndex = 0;
            this.MarketPage.Text = "Market";
            this.MarketPage.UseVisualStyleBackColor = true;
            // 
            // AddToCart
            // 
            this.AddToCart.AutoSize = true;
            this.AddToCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddToCart.Location = new System.Drawing.Point(717, 0);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(75, 26);
            this.AddToCart.TabIndex = 0;
            this.AddToCart.Text = "Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // MarketList
            // 
            this.MarketList.Controls.Add(this.ProducerDishes);
            this.MarketList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MarketList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MarketList.Location = new System.Drawing.Point(0, 26);
            this.MarketList.Margin = new System.Windows.Forms.Padding(0);
            this.MarketList.Name = "MarketList";
            this.MarketList.Size = new System.Drawing.Size(792, 368);
            this.MarketList.TabIndex = 0;
            this.MarketList.WrapContents = false;
            // 
            // ProducerDishes
            // 
            this.ProducerDishes.ColumnCount = 1;
            this.ProducerDishes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProducerDishes.Controls.Add(this.Producer, 0, 0);
            this.ProducerDishes.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.ProducerDishes.Location = new System.Drawing.Point(3, 3);
            this.ProducerDishes.Name = "ProducerDishes";
            this.ProducerDishes.RowCount = 2;
            this.ProducerDishes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ProducerDishes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.ProducerDishes.Size = new System.Drawing.Size(781, 131);
            this.ProducerDishes.TabIndex = 3;
            // 
            // Producer
            // 
            this.Producer.AutoSize = true;
            this.Producer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Producer.Location = new System.Drawing.Point(3, 0);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(775, 16);
            this.Producer.TabIndex = 0;
            this.Producer.Text = "Producer Name";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(781, 102);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.Controls.Add(this.Dish, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DishName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddDish, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(208, 102);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Dish
            // 
            this.Dish.Controls.Add(this.tableLayoutPanel1);
            this.Dish.Location = new System.Drawing.Point(0, 0);
            this.Dish.Margin = new System.Windows.Forms.Padding(0);
            this.Dish.Name = "Dish";
            this.Dish.Size = new System.Drawing.Size(72, 72);
            this.Dish.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DishName
            // 
            this.DishName.AutoSize = true;
            this.DishName.Dock = System.Windows.Forms.DockStyle.Right;
            this.DishName.Location = new System.Drawing.Point(131, 0);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(74, 72);
            this.DishName.TabIndex = 2;
            this.DishName.Text = "Dish Name";
            this.DishName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDish
            // 
            this.AddDish.AutoSize = true;
            this.AddDish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDish.Location = new System.Drawing.Point(3, 75);
            this.AddDish.Name = "AddDish";
            this.AddDish.Size = new System.Drawing.Size(66, 24);
            this.AddDish.TabIndex = 0;
            this.AddDish.Text = "+";
            this.AddDish.UseVisualStyleBackColor = true;
            // 
            // UserOdersPage
            // 
            this.UserOdersPage.Controls.Add(this.OrdersLayout);
            this.UserOdersPage.Location = new System.Drawing.Point(4, 25);
            this.UserOdersPage.Margin = new System.Windows.Forms.Padding(0);
            this.UserOdersPage.Name = "UserOdersPage";
            this.UserOdersPage.Size = new System.Drawing.Size(792, 394);
            this.UserOdersPage.TabIndex = 1;
            this.UserOdersPage.Text = "Your orders";
            this.UserOdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersLayout
            // 
            this.OrdersLayout.AutoScroll = true;
            this.OrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrdersLayout.Location = new System.Drawing.Point(0, 0);
            this.OrdersLayout.Name = "OrdersLayout";
            this.OrdersLayout.Size = new System.Drawing.Size(792, 394);
            this.OrdersLayout.TabIndex = 0;
            this.OrdersLayout.WrapContents = false;
            // 
            // UserAccountPage
            // 
            this.UserAccountPage.Controls.Add(this.flowLayoutPanel1);
            this.UserAccountPage.Location = new System.Drawing.Point(4, 25);
            this.UserAccountPage.Name = "UserAccountPage";
            this.UserAccountPage.Size = new System.Drawing.Size(792, 394);
            this.UserAccountPage.TabIndex = 2;
            this.UserAccountPage.Text = "Account";
            this.UserAccountPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AccountTableLayout);
            this.flowLayoutPanel1.Controls.Add(this.Account_CreatedAt);
            this.flowLayoutPanel1.Controls.Add(this.Account_DeleteAccountButton);
            this.flowLayoutPanel1.Controls.Add(this.Account_LogoutButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // AccountTableLayout
            // 
            this.AccountTableLayout.AutoSize = true;
            this.AccountTableLayout.ColumnCount = 3;
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82585F));
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17415F));
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.AccountTableLayout.Controls.Add(this.label5, 0, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserEmail, 1, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserPhone, 1, 3);
            this.AccountTableLayout.Controls.Add(this.label4, 0, 3);
            this.AccountTableLayout.Controls.Add(this.Account_ChangePhoneButton, 2, 3);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeEmailButton, 2, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserName, 1, 2);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeNameButton, 2, 2);
            this.AccountTableLayout.Controls.Add(this.label3, 0, 2);
            this.AccountTableLayout.Controls.Add(this.Account_UserPassword, 1, 1);
            this.AccountTableLayout.Controls.Add(this.Account_ChangePasswordButton, 2, 1);
            this.AccountTableLayout.Controls.Add(this.label2, 0, 1);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeUsernameButton, 2, 0);
            this.AccountTableLayout.Controls.Add(this.Account_UserLogin, 1, 0);
            this.AccountTableLayout.Controls.Add(this.label1, 0, 0);
            this.AccountTableLayout.Controls.Add(this.label6, 0, 5);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeAddressButton, 2, 5);
            this.AccountTableLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountTableLayout.Location = new System.Drawing.Point(3, 3);
            this.AccountTableLayout.Name = "AccountTableLayout";
            this.AccountTableLayout.RowCount = 6;
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccountTableLayout.Size = new System.Drawing.Size(786, 192);
            this.AccountTableLayout.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_UserEmail
            // 
            this.Account_UserEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account_UserEmail.Enabled = false;
            this.Account_UserEmail.Location = new System.Drawing.Point(127, 135);
            this.Account_UserEmail.Name = "Account_UserEmail";
            this.Account_UserEmail.Size = new System.Drawing.Size(469, 22);
            this.Account_UserEmail.TabIndex = 1;
            // 
            // Account_UserPhone
            // 
            this.Account_UserPhone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account_UserPhone.Enabled = false;
            this.Account_UserPhone.Location = new System.Drawing.Point(127, 103);
            this.Account_UserPhone.Name = "Account_UserPhone";
            this.Account_UserPhone.Size = new System.Drawing.Size(469, 22);
            this.Account_UserPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangePhoneButton
            // 
            this.Account_ChangePhoneButton.AutoSize = true;
            this.Account_ChangePhoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangePhoneButton.Location = new System.Drawing.Point(602, 99);
            this.Account_ChangePhoneButton.Name = "Account_ChangePhoneButton";
            this.Account_ChangePhoneButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangePhoneButton.TabIndex = 2;
            this.Account_ChangePhoneButton.Tag = "3";
            this.Account_ChangePhoneButton.Text = "Change Phone";
            this.Account_ChangePhoneButton.UseVisualStyleBackColor = true;
            this.Account_ChangePhoneButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_ChangeEmailButton
            // 
            this.Account_ChangeEmailButton.AutoSize = true;
            this.Account_ChangeEmailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeEmailButton.Location = new System.Drawing.Point(602, 131);
            this.Account_ChangeEmailButton.Name = "Account_ChangeEmailButton";
            this.Account_ChangeEmailButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangeEmailButton.TabIndex = 2;
            this.Account_ChangeEmailButton.Tag = "4";
            this.Account_ChangeEmailButton.Text = "Change Email";
            this.Account_ChangeEmailButton.UseVisualStyleBackColor = true;
            this.Account_ChangeEmailButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_UserName
            // 
            this.Account_UserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account_UserName.Enabled = false;
            this.Account_UserName.Location = new System.Drawing.Point(127, 71);
            this.Account_UserName.Name = "Account_UserName";
            this.Account_UserName.Size = new System.Drawing.Size(469, 22);
            this.Account_UserName.TabIndex = 1;
            // 
            // Account_ChangeNameButton
            // 
            this.Account_ChangeNameButton.AutoSize = true;
            this.Account_ChangeNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeNameButton.Location = new System.Drawing.Point(602, 67);
            this.Account_ChangeNameButton.Name = "Account_ChangeNameButton";
            this.Account_ChangeNameButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangeNameButton.TabIndex = 2;
            this.Account_ChangeNameButton.Tag = "2";
            this.Account_ChangeNameButton.Text = "Change Name";
            this.Account_ChangeNameButton.UseVisualStyleBackColor = true;
            this.Account_ChangeNameButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_UserPassword
            // 
            this.Account_UserPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account_UserPassword.Enabled = false;
            this.Account_UserPassword.Location = new System.Drawing.Point(127, 39);
            this.Account_UserPassword.Name = "Account_UserPassword";
            this.Account_UserPassword.Size = new System.Drawing.Size(469, 22);
            this.Account_UserPassword.TabIndex = 1;
            // 
            // Account_ChangePasswordButton
            // 
            this.Account_ChangePasswordButton.AutoSize = true;
            this.Account_ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangePasswordButton.Location = new System.Drawing.Point(602, 35);
            this.Account_ChangePasswordButton.Name = "Account_ChangePasswordButton";
            this.Account_ChangePasswordButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangePasswordButton.TabIndex = 2;
            this.Account_ChangePasswordButton.Tag = "1";
            this.Account_ChangePasswordButton.Text = "Change Password";
            this.Account_ChangePasswordButton.UseVisualStyleBackColor = true;
            this.Account_ChangePasswordButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangeUsernameButton
            // 
            this.Account_ChangeUsernameButton.AutoSize = true;
            this.Account_ChangeUsernameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeUsernameButton.Location = new System.Drawing.Point(602, 3);
            this.Account_ChangeUsernameButton.Name = "Account_ChangeUsernameButton";
            this.Account_ChangeUsernameButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangeUsernameButton.TabIndex = 2;
            this.Account_ChangeUsernameButton.Tag = "0";
            this.Account_ChangeUsernameButton.Text = "Change Username";
            this.Account_ChangeUsernameButton.UseVisualStyleBackColor = true;
            this.Account_ChangeUsernameButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_UserLogin
            // 
            this.Account_UserLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Account_UserLogin.Enabled = false;
            this.Account_UserLogin.Location = new System.Drawing.Point(127, 7);
            this.Account_UserLogin.Name = "Account_UserLogin";
            this.Account_UserLogin.Size = new System.Drawing.Size(469, 22);
            this.Account_UserLogin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Addresses";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangeAddressButton
            // 
            this.Account_ChangeAddressButton.AutoSize = true;
            this.Account_ChangeAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeAddressButton.Location = new System.Drawing.Point(602, 163);
            this.Account_ChangeAddressButton.Name = "Account_ChangeAddressButton";
            this.Account_ChangeAddressButton.Size = new System.Drawing.Size(181, 26);
            this.Account_ChangeAddressButton.TabIndex = 5;
            this.Account_ChangeAddressButton.Text = "Edit Address";
            this.Account_ChangeAddressButton.UseVisualStyleBackColor = true;
            this.Account_ChangeAddressButton.Click += new System.EventHandler(this.Account_ChangeAddressButton_Click);
            // 
            // Account_CreatedAt
            // 
            this.Account_CreatedAt.AutoSize = true;
            this.Account_CreatedAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_CreatedAt.Location = new System.Drawing.Point(667, 198);
            this.Account_CreatedAt.Name = "Account_CreatedAt";
            this.Account_CreatedAt.Size = new System.Drawing.Size(122, 16);
            this.Account_CreatedAt.TabIndex = 0;
            this.Account_CreatedAt.Text = "Account_CreatedAt";
            this.Account_CreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_DeleteAccountButton
            // 
            this.Account_DeleteAccountButton.AutoSize = true;
            this.Account_DeleteAccountButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_DeleteAccountButton.Location = new System.Drawing.Point(657, 217);
            this.Account_DeleteAccountButton.Name = "Account_DeleteAccountButton";
            this.Account_DeleteAccountButton.Size = new System.Drawing.Size(132, 26);
            this.Account_DeleteAccountButton.TabIndex = 7;
            this.Account_DeleteAccountButton.Text = "Delete Account";
            this.Account_DeleteAccountButton.UseVisualStyleBackColor = true;
            this.Account_DeleteAccountButton.Click += new System.EventHandler(this.Account_DeleteAccountButton_Click);
            // 
            // Account_LogoutButton
            // 
            this.Account_LogoutButton.AutoSize = true;
            this.Account_LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_LogoutButton.Location = new System.Drawing.Point(714, 249);
            this.Account_LogoutButton.Name = "Account_LogoutButton";
            this.Account_LogoutButton.Size = new System.Drawing.Size(75, 26);
            this.Account_LogoutButton.TabIndex = 8;
            this.Account_LogoutButton.Text = "Log Out";
            this.Account_LogoutButton.UseVisualStyleBackColor = true;
            this.Account_LogoutButton.Click += new System.EventHandler(this.Account_LogoutButton_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserTabs);
            this.Controls.Add(this.WelcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.UserTabs.ResumeLayout(false);
            this.MarketPage.ResumeLayout(false);
            this.MarketPage.PerformLayout();
            this.MarketList.ResumeLayout(false);
            this.ProducerDishes.ResumeLayout(false);
            this.ProducerDishes.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Dish.ResumeLayout(false);
            this.Dish.PerformLayout();
            this.UserOdersPage.ResumeLayout(false);
            this.UserAccountPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.AccountTableLayout.ResumeLayout(false);
            this.AccountTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WelcomeMessage;
        private TabControl UserTabs;
        private TabPage MarketPage;
        private TabPage UserOdersPage;
        private TabPage UserAccountPage;
        private FlowLayoutPanel OrdersLayout;
        private FlowLayoutPanel MarketList;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox Account_UserPassword;
        private Button Account_ChangePasswordButton;
        private TextBox Account_UserLogin;
        private Label label3;
        private TextBox Account_UserName;
        private Label label4;
        private TextBox Account_UserPhone;
        private Button Account_ChangeUsernameButton;
        private Label label5;
        private TextBox Account_UserEmail;
        private Button Account_ChangeEmailButton;
        private Label Account_CreatedAt;
        private Button Account_ChangeNameButton;
        private Button Account_ChangePhoneButton;
        private TableLayoutPanel AccountTableLayout;
        private Button Account_DeleteAccountButton;
        private Button Account_LogoutButton;
        private Label label6;
        private Button Account_ChangeAddressButton;
        private Button AddToCart;
        private FlowLayoutPanel Dish;
        private Label Producer;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddDish;
        private Label DishName;
        private TableLayoutPanel ProducerDishes;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}