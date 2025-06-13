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
            this.AddToCard = new DeliveryApp.CustomButton();
            this.MarketList = new System.Windows.Forms.FlowLayoutPanel();
            this.UserOdersPage = new System.Windows.Forms.TabPage();
            this.OrdersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.UserAccountPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Account_EmailLabel = new System.Windows.Forms.Label();
            this.Account_UserEmail = new DeliveryApp.CustomTextBox();
            this.Account_UserPhone = new DeliveryApp.CustomTextBox();
            this.Account_PhoneLabel = new System.Windows.Forms.Label();
            this.Account_ChangePhoneButton = new DeliveryApp.CustomButton();
            this.Account_ChangeEmailButton = new DeliveryApp.CustomButton();
            this.Account_UserName = new DeliveryApp.CustomTextBox();
            this.Account_ChangeNameButton = new DeliveryApp.CustomButton();
            this.Account_NameLabel = new System.Windows.Forms.Label();
            this.Account_UserPassword = new DeliveryApp.CustomTextBox();
            this.Account_ChangePasswordButton = new DeliveryApp.CustomButton();
            this.Account_PasswordLabel = new System.Windows.Forms.Label();
            this.Account_ChangeUsernameButton = new DeliveryApp.CustomButton();
            this.Account_UserLogin = new DeliveryApp.CustomTextBox();
            this.Account_LoginLabel = new System.Windows.Forms.Label();
            this.Account_AddressLabel = new System.Windows.Forms.Label();
            this.Account_ChangeAddressButton = new DeliveryApp.CustomButton();
            this.Account_CreatedAt = new System.Windows.Forms.Label();
            this.Account_LogoutButton = new DeliveryApp.CustomButton();
            this.Account_DeleteAccountButton = new DeliveryApp.CustomButton();
            this.UserTabs.SuspendLayout();
            this.MarketPage.SuspendLayout();
            this.UserOdersPage.SuspendLayout();
            this.UserAccountPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.AccountTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.BackColor = System.Drawing.Color.Transparent;
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
            this.UserTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UserTabs.Location = new System.Drawing.Point(0, 27);
            this.UserTabs.Margin = new System.Windows.Forms.Padding(0);
            this.UserTabs.Name = "UserTabs";
            this.UserTabs.SelectedIndex = 0;
            this.UserTabs.Size = new System.Drawing.Size(973, 467);
            this.UserTabs.TabIndex = 1;
            this.UserTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.UserTabs_Selected);
            // 
            // MarketPage
            // 
            this.MarketPage.BackColor = System.Drawing.Color.Transparent;
            this.MarketPage.Controls.Add(this.AddToCard);
            this.MarketPage.Controls.Add(this.MarketList);
            this.MarketPage.Location = new System.Drawing.Point(4, 29);
            this.MarketPage.Margin = new System.Windows.Forms.Padding(0);
            this.MarketPage.Name = "MarketPage";
            this.MarketPage.Size = new System.Drawing.Size(965, 434);
            this.MarketPage.TabIndex = 0;
            this.MarketPage.Text = "Магазин";
            // 
            // AddToCard
            // 
            this.AddToCard.AutoSize = true;
            this.AddToCard.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddToCard.BorderRadius = 5;
            this.AddToCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddToCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCard.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.AddToCard.ForeColor = System.Drawing.Color.White;
            this.AddToCard.Location = new System.Drawing.Point(857, 0);
            this.AddToCard.Name = "AddToCard";
            this.AddToCard.Size = new System.Drawing.Size(108, 34);
            this.AddToCard.TabIndex = 0;
            this.AddToCard.Text = "Карзина";
            this.AddToCard.UseVisualStyleBackColor = true;
            this.AddToCard.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // MarketList
            // 
            this.MarketList.AutoScroll = true;
            this.MarketList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MarketList.BackColor = System.Drawing.Color.Transparent;
            this.MarketList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MarketList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MarketList.Location = new System.Drawing.Point(0, 34);
            this.MarketList.Margin = new System.Windows.Forms.Padding(0);
            this.MarketList.Name = "MarketList";
            this.MarketList.Size = new System.Drawing.Size(965, 400);
            this.MarketList.TabIndex = 0;
            this.MarketList.WrapContents = false;
            // 
            // UserOdersPage
            // 
            this.UserOdersPage.Controls.Add(this.OrdersLayout);
            this.UserOdersPage.Location = new System.Drawing.Point(4, 29);
            this.UserOdersPage.Margin = new System.Windows.Forms.Padding(0);
            this.UserOdersPage.Name = "UserOdersPage";
            this.UserOdersPage.Size = new System.Drawing.Size(965, 434);
            this.UserOdersPage.TabIndex = 1;
            this.UserOdersPage.Text = "Ваши заказы";
            this.UserOdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersLayout
            // 
            this.OrdersLayout.AutoScroll = true;
            this.OrdersLayout.BackColor = System.Drawing.Color.Transparent;
            this.OrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrdersLayout.Location = new System.Drawing.Point(0, 0);
            this.OrdersLayout.Name = "OrdersLayout";
            this.OrdersLayout.Size = new System.Drawing.Size(965, 434);
            this.OrdersLayout.TabIndex = 0;
            this.OrdersLayout.WrapContents = false;
            // 
            // UserAccountPage
            // 
            this.UserAccountPage.Controls.Add(this.flowLayoutPanel1);
            this.UserAccountPage.Location = new System.Drawing.Point(4, 29);
            this.UserAccountPage.Name = "UserAccountPage";
            this.UserAccountPage.Size = new System.Drawing.Size(965, 434);
            this.UserAccountPage.TabIndex = 2;
            this.UserAccountPage.Text = "Аккаунт";
            this.UserAccountPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AccountTableLayout);
            this.flowLayoutPanel1.Controls.Add(this.Account_CreatedAt);
            this.flowLayoutPanel1.Controls.Add(this.Account_LogoutButton);
            this.flowLayoutPanel1.Controls.Add(this.Account_DeleteAccountButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(965, 434);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // AccountTableLayout
            // 
            this.AccountTableLayout.AutoSize = true;
            this.AccountTableLayout.ColumnCount = 3;
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82585F));
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17415F));
            this.AccountTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.AccountTableLayout.Controls.Add(this.Account_EmailLabel, 0, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserEmail, 1, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserPhone, 1, 3);
            this.AccountTableLayout.Controls.Add(this.Account_PhoneLabel, 0, 3);
            this.AccountTableLayout.Controls.Add(this.Account_ChangePhoneButton, 2, 3);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeEmailButton, 2, 4);
            this.AccountTableLayout.Controls.Add(this.Account_UserName, 1, 2);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeNameButton, 2, 2);
            this.AccountTableLayout.Controls.Add(this.Account_NameLabel, 0, 2);
            this.AccountTableLayout.Controls.Add(this.Account_UserPassword, 1, 1);
            this.AccountTableLayout.Controls.Add(this.Account_ChangePasswordButton, 2, 1);
            this.AccountTableLayout.Controls.Add(this.Account_PasswordLabel, 0, 1);
            this.AccountTableLayout.Controls.Add(this.Account_ChangeUsernameButton, 2, 0);
            this.AccountTableLayout.Controls.Add(this.Account_UserLogin, 1, 0);
            this.AccountTableLayout.Controls.Add(this.Account_LoginLabel, 0, 0);
            this.AccountTableLayout.Controls.Add(this.Account_AddressLabel, 0, 5);
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
            this.AccountTableLayout.Size = new System.Drawing.Size(959, 263);
            this.AccountTableLayout.TabIndex = 6;
            // 
            // Account_EmailLabel
            // 
            this.Account_EmailLabel.AutoSize = true;
            this.Account_EmailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_EmailLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_EmailLabel.Location = new System.Drawing.Point(3, 173);
            this.Account_EmailLabel.Name = "Account_EmailLabel";
            this.Account_EmailLabel.Size = new System.Drawing.Size(142, 45);
            this.Account_EmailLabel.TabIndex = 0;
            this.Account_EmailLabel.Text = "Почта";
            this.Account_EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_UserEmail
            // 
            this.Account_UserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_UserEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Account_UserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_UserEmail.Enabled = false;
            this.Account_UserEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_UserEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Account_UserEmail.Location = new System.Drawing.Point(148, 182);
            this.Account_UserEmail.Margin = new System.Windows.Forms.Padding(0);
            this.Account_UserEmail.Name = "Account_UserEmail";
            this.Account_UserEmail.Size = new System.Drawing.Size(565, 26);
            this.Account_UserEmail.TabIndex = 1;
            // 
            // Account_UserPhone
            // 
            this.Account_UserPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_UserPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Account_UserPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_UserPhone.Enabled = false;
            this.Account_UserPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_UserPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Account_UserPhone.Location = new System.Drawing.Point(148, 137);
            this.Account_UserPhone.Margin = new System.Windows.Forms.Padding(0);
            this.Account_UserPhone.Name = "Account_UserPhone";
            this.Account_UserPhone.Size = new System.Drawing.Size(565, 26);
            this.Account_UserPhone.TabIndex = 1;
            // 
            // Account_PhoneLabel
            // 
            this.Account_PhoneLabel.AutoSize = true;
            this.Account_PhoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_PhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_PhoneLabel.Location = new System.Drawing.Point(3, 128);
            this.Account_PhoneLabel.Name = "Account_PhoneLabel";
            this.Account_PhoneLabel.Size = new System.Drawing.Size(142, 45);
            this.Account_PhoneLabel.TabIndex = 0;
            this.Account_PhoneLabel.Text = "Телефон";
            this.Account_PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangePhoneButton
            // 
            this.Account_ChangePhoneButton.AutoSize = true;
            this.Account_ChangePhoneButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangePhoneButton.BorderRadius = 5;
            this.Account_ChangePhoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangePhoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangePhoneButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangePhoneButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangePhoneButton.Location = new System.Drawing.Point(716, 131);
            this.Account_ChangePhoneButton.Name = "Account_ChangePhoneButton";
            this.Account_ChangePhoneButton.Size = new System.Drawing.Size(240, 39);
            this.Account_ChangePhoneButton.TabIndex = 2;
            this.Account_ChangePhoneButton.Tag = "3";
            this.Account_ChangePhoneButton.Text = "Сменить телефон";
            this.Account_ChangePhoneButton.UseVisualStyleBackColor = true;
            this.Account_ChangePhoneButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_ChangeEmailButton
            // 
            this.Account_ChangeEmailButton.AutoSize = true;
            this.Account_ChangeEmailButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangeEmailButton.BorderRadius = 5;
            this.Account_ChangeEmailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangeEmailButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangeEmailButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangeEmailButton.Location = new System.Drawing.Point(716, 176);
            this.Account_ChangeEmailButton.Name = "Account_ChangeEmailButton";
            this.Account_ChangeEmailButton.Size = new System.Drawing.Size(240, 39);
            this.Account_ChangeEmailButton.TabIndex = 2;
            this.Account_ChangeEmailButton.Tag = "4";
            this.Account_ChangeEmailButton.Text = "Сменить почту";
            this.Account_ChangeEmailButton.UseVisualStyleBackColor = true;
            this.Account_ChangeEmailButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_UserName
            // 
            this.Account_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_UserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Account_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_UserName.Enabled = false;
            this.Account_UserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_UserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Account_UserName.Location = new System.Drawing.Point(148, 96);
            this.Account_UserName.Margin = new System.Windows.Forms.Padding(0);
            this.Account_UserName.Name = "Account_UserName";
            this.Account_UserName.Size = new System.Drawing.Size(565, 26);
            this.Account_UserName.TabIndex = 1;
            // 
            // Account_ChangeNameButton
            // 
            this.Account_ChangeNameButton.AutoSize = true;
            this.Account_ChangeNameButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangeNameButton.BorderRadius = 5;
            this.Account_ChangeNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangeNameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangeNameButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangeNameButton.Location = new System.Drawing.Point(716, 93);
            this.Account_ChangeNameButton.Name = "Account_ChangeNameButton";
            this.Account_ChangeNameButton.Size = new System.Drawing.Size(240, 32);
            this.Account_ChangeNameButton.TabIndex = 2;
            this.Account_ChangeNameButton.Tag = 2;
            this.Account_ChangeNameButton.Text = "Сменить имя";
            this.Account_ChangeNameButton.UseVisualStyleBackColor = true;
            this.Account_ChangeNameButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_NameLabel
            // 
            this.Account_NameLabel.AutoSize = true;
            this.Account_NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_NameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_NameLabel.Location = new System.Drawing.Point(3, 90);
            this.Account_NameLabel.Name = "Account_NameLabel";
            this.Account_NameLabel.Size = new System.Drawing.Size(142, 38);
            this.Account_NameLabel.TabIndex = 0;
            this.Account_NameLabel.Text = "Имя";
            this.Account_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_UserPassword
            // 
            this.Account_UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_UserPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Account_UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_UserPassword.Enabled = false;
            this.Account_UserPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_UserPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Account_UserPassword.Location = new System.Drawing.Point(148, 54);
            this.Account_UserPassword.Margin = new System.Windows.Forms.Padding(0);
            this.Account_UserPassword.Name = "Account_UserPassword";
            this.Account_UserPassword.Size = new System.Drawing.Size(565, 26);
            this.Account_UserPassword.TabIndex = 1;
            // 
            // Account_ChangePasswordButton
            // 
            this.Account_ChangePasswordButton.AutoSize = true;
            this.Account_ChangePasswordButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangePasswordButton.BorderRadius = 5;
            this.Account_ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangePasswordButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangePasswordButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangePasswordButton.Location = new System.Drawing.Point(716, 48);
            this.Account_ChangePasswordButton.Name = "Account_ChangePasswordButton";
            this.Account_ChangePasswordButton.Size = new System.Drawing.Size(240, 39);
            this.Account_ChangePasswordButton.TabIndex = 2;
            this.Account_ChangePasswordButton.Tag = "1";
            this.Account_ChangePasswordButton.Text = "Сменить пароль";
            this.Account_ChangePasswordButton.UseVisualStyleBackColor = true;
            this.Account_ChangePasswordButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_PasswordLabel
            // 
            this.Account_PasswordLabel.AutoSize = true;
            this.Account_PasswordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_PasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_PasswordLabel.Location = new System.Drawing.Point(3, 45);
            this.Account_PasswordLabel.Name = "Account_PasswordLabel";
            this.Account_PasswordLabel.Size = new System.Drawing.Size(142, 45);
            this.Account_PasswordLabel.TabIndex = 0;
            this.Account_PasswordLabel.Text = "Пароль";
            this.Account_PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangeUsernameButton
            // 
            this.Account_ChangeUsernameButton.AutoSize = true;
            this.Account_ChangeUsernameButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangeUsernameButton.BorderRadius = 5;
            this.Account_ChangeUsernameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangeUsernameButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangeUsernameButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangeUsernameButton.Location = new System.Drawing.Point(716, 3);
            this.Account_ChangeUsernameButton.Name = "Account_ChangeUsernameButton";
            this.Account_ChangeUsernameButton.Size = new System.Drawing.Size(240, 39);
            this.Account_ChangeUsernameButton.TabIndex = 2;
            this.Account_ChangeUsernameButton.Tag = "0";
            this.Account_ChangeUsernameButton.Text = "Сменить логин";
            this.Account_ChangeUsernameButton.UseVisualStyleBackColor = true;
            this.Account_ChangeUsernameButton.Click += new System.EventHandler(this.Account_ChangeButton_Click);
            // 
            // Account_UserLogin
            // 
            this.Account_UserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Account_UserLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Account_UserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Account_UserLogin.Enabled = false;
            this.Account_UserLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_UserLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Account_UserLogin.Location = new System.Drawing.Point(148, 9);
            this.Account_UserLogin.Margin = new System.Windows.Forms.Padding(0);
            this.Account_UserLogin.Name = "Account_UserLogin";
            this.Account_UserLogin.Size = new System.Drawing.Size(565, 26);
            this.Account_UserLogin.TabIndex = 1;
            // 
            // Account_LoginLabel
            // 
            this.Account_LoginLabel.AutoSize = true;
            this.Account_LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_LoginLabel.Location = new System.Drawing.Point(3, 0);
            this.Account_LoginLabel.Name = "Account_LoginLabel";
            this.Account_LoginLabel.Size = new System.Drawing.Size(142, 45);
            this.Account_LoginLabel.TabIndex = 0;
            this.Account_LoginLabel.Text = "Логин";
            this.Account_LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_AddressLabel
            // 
            this.Account_AddressLabel.AutoSize = true;
            this.Account_AddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_AddressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_AddressLabel.Location = new System.Drawing.Point(3, 218);
            this.Account_AddressLabel.Name = "Account_AddressLabel";
            this.Account_AddressLabel.Size = new System.Drawing.Size(142, 45);
            this.Account_AddressLabel.TabIndex = 3;
            this.Account_AddressLabel.Text = "Адреса";
            this.Account_AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_ChangeAddressButton
            // 
            this.Account_ChangeAddressButton.AutoSize = true;
            this.Account_ChangeAddressButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_ChangeAddressButton.BorderRadius = 5;
            this.Account_ChangeAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Account_ChangeAddressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_ChangeAddressButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_ChangeAddressButton.ForeColor = System.Drawing.Color.White;
            this.Account_ChangeAddressButton.Location = new System.Drawing.Point(716, 221);
            this.Account_ChangeAddressButton.Name = "Account_ChangeAddressButton";
            this.Account_ChangeAddressButton.Size = new System.Drawing.Size(240, 39);
            this.Account_ChangeAddressButton.TabIndex = 5;
            this.Account_ChangeAddressButton.Text = "Редактировать адреса";
            this.Account_ChangeAddressButton.UseVisualStyleBackColor = true;
            this.Account_ChangeAddressButton.Click += new System.EventHandler(this.Account_ChangeAddressButton_Click);
            // 
            // Account_CreatedAt
            // 
            this.Account_CreatedAt.AutoSize = true;
            this.Account_CreatedAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_CreatedAt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Account_CreatedAt.Location = new System.Drawing.Point(768, 269);
            this.Account_CreatedAt.Name = "Account_CreatedAt";
            this.Account_CreatedAt.Size = new System.Drawing.Size(194, 27);
            this.Account_CreatedAt.TabIndex = 0;
            this.Account_CreatedAt.Text = "Account_CreatedAt";
            this.Account_CreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Account_LogoutButton
            // 
            this.Account_LogoutButton.AutoSize = true;
            this.Account_LogoutButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_LogoutButton.BorderRadius = 5;
            this.Account_LogoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_LogoutButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_LogoutButton.ForeColor = System.Drawing.Color.White;
            this.Account_LogoutButton.Location = new System.Drawing.Point(861, 299);
            this.Account_LogoutButton.Name = "Account_LogoutButton";
            this.Account_LogoutButton.Size = new System.Drawing.Size(101, 39);
            this.Account_LogoutButton.TabIndex = 8;
            this.Account_LogoutButton.Text = "Выйти";
            this.Account_LogoutButton.UseVisualStyleBackColor = true;
            this.Account_LogoutButton.Click += new System.EventHandler(this.Account_LogoutButton_Click);
            // 
            // Account_DeleteAccountButton
            // 
            this.Account_DeleteAccountButton.AutoSize = true;
            this.Account_DeleteAccountButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Account_DeleteAccountButton.BorderRadius = 5;
            this.Account_DeleteAccountButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Account_DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_DeleteAccountButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.Account_DeleteAccountButton.ForeColor = System.Drawing.Color.White;
            this.Account_DeleteAccountButton.Location = new System.Drawing.Point(794, 344);
            this.Account_DeleteAccountButton.Name = "Account_DeleteAccountButton";
            this.Account_DeleteAccountButton.Size = new System.Drawing.Size(168, 39);
            this.Account_DeleteAccountButton.TabIndex = 7;
            this.Account_DeleteAccountButton.Text = "Удалить аккаунт";
            this.Account_DeleteAccountButton.UseVisualStyleBackColor = true;
            this.Account_DeleteAccountButton.Click += new System.EventHandler(this.Account_DeleteAccountButton_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(973, 494);
            this.Controls.Add(this.UserTabs);
            this.Controls.Add(this.WelcomeMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доставка еды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.UserTabs.ResumeLayout(false);
            this.MarketPage.ResumeLayout(false);
            this.MarketPage.PerformLayout();
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
        private Label Account_LoginLabel;
        private Label Account_PasswordLabel;
        private CustomTextBox Account_UserPassword;
        private CustomButton Account_ChangePasswordButton;
        private CustomTextBox Account_UserLogin;
        private Label Account_NameLabel;
        private CustomTextBox Account_UserName;
        private Label Account_PhoneLabel;
        private CustomButton Account_ChangeUsernameButton;
        private Label Account_EmailLabel;
        private CustomTextBox Account_UserEmail;
        private CustomButton Account_ChangeEmailButton;
        private Label Account_CreatedAt;
        private CustomButton Account_ChangeNameButton;
        private CustomButton Account_ChangePhoneButton;
        private TableLayoutPanel AccountTableLayout;
        private CustomButton Account_DeleteAccountButton;
        private CustomButton Account_LogoutButton;
        private Label Account_AddressLabel;
        private CustomButton Account_ChangeAddressButton;
        private CustomButton AddToCard;
        private CustomTextBox Account_UserPhone;
    }
}