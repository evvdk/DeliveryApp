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
            this.MarketList = new System.Windows.Forms.FlowLayoutPanel();
            this.UserOdersPage = new System.Windows.Forms.TabPage();
            this.OrdersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.UserAccountPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.UserLoginInput = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UserTabs.SuspendLayout();
            this.MarketPage.SuspendLayout();
            this.UserOdersPage.SuspendLayout();
            this.UserAccountPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
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
            this.MarketPage.Controls.Add(this.MarketList);
            this.MarketPage.Location = new System.Drawing.Point(4, 25);
            this.MarketPage.Margin = new System.Windows.Forms.Padding(0);
            this.MarketPage.Name = "MarketPage";
            this.MarketPage.Size = new System.Drawing.Size(792, 394);
            this.MarketPage.TabIndex = 0;
            this.MarketPage.Text = "Market";
            this.MarketPage.UseVisualStyleBackColor = true;
            // 
            // MarketList
            // 
            this.MarketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MarketList.Location = new System.Drawing.Point(0, 0);
            this.MarketList.Margin = new System.Windows.Forms.Padding(0);
            this.MarketList.Name = "MarketList";
            this.MarketList.Size = new System.Drawing.Size(792, 394);
            this.MarketList.TabIndex = 0;
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
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.UserLoginInput);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(567, 28);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.Password);
            this.flowLayoutPanel3.Controls.Add(this.ChangePasswordButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 37);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(607, 28);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(76, 3);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(399, 22);
            this.Password.TabIndex = 1;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangePasswordButton.Location = new System.Drawing.Point(481, 3);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(123, 22);
            this.ChangePasswordButton.TabIndex = 2;
            this.ChangePasswordButton.Text = "ChangePasswordButton";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // UserLoginInput
            // 
            this.UserLoginInput.Enabled = false;
            this.UserLoginInput.Location = new System.Drawing.Point(49, 3);
            this.UserLoginInput.Name = "UserLoginInput";
            this.UserLoginInput.Size = new System.Drawing.Size(515, 22);
            this.UserLoginInput.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.textBox1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(684, 100);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserTabs);
            this.Controls.Add(this.WelcomeMessage);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.UserTabs.ResumeLayout(false);
            this.MarketPage.ResumeLayout(false);
            this.UserOdersPage.ResumeLayout(false);
            this.UserAccountPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
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
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private TextBox Password;
        private Button ChangePasswordButton;
        private TextBox UserLoginInput;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label3;
        private TextBox textBox1;
    }
}