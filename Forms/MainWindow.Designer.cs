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
            this.UserTabs.SuspendLayout();
            this.MarketPage.SuspendLayout();
            this.UserOdersPage.SuspendLayout();
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
            this.OrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrdersLayout.Location = new System.Drawing.Point(0, 0);
            this.OrdersLayout.Name = "OrdersLayout";
            this.OrdersLayout.Size = new System.Drawing.Size(792, 394);
            this.OrdersLayout.TabIndex = 0;
            // 
            // UserAccountPage
            // 
            this.UserAccountPage.Location = new System.Drawing.Point(4, 25);
            this.UserAccountPage.Name = "UserAccountPage";
            this.UserAccountPage.Size = new System.Drawing.Size(792, 394);
            this.UserAccountPage.TabIndex = 2;
            this.UserAccountPage.Text = "Account";
            this.UserAccountPage.UseVisualStyleBackColor = true;
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
    }
}