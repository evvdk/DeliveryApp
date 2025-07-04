﻿namespace DeliveryApp.Forms
{
    partial class OrderWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OrderName = new System.Windows.Forms.Label();
            this.TotalBill = new System.Windows.Forms.Label();
            this.Producer = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.Dishes = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangeAddressButton = new DeliveryApp.CustomButton();
            this.Apply = new DeliveryApp.CustomButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.Dishes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.OrderName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalBill, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Producer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeAddressButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Status, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddressLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(961, 94);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // OrderName
            // 
            this.OrderName.AutoSize = true;
            this.OrderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderName.Location = new System.Drawing.Point(3, 0);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(310, 51);
            this.OrderName.TabIndex = 0;
            this.OrderName.Text = "Order#1";
            this.OrderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalBill
            // 
            this.TotalBill.AutoSize = true;
            this.TotalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalBill.Location = new System.Drawing.Point(754, 0);
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.Size = new System.Drawing.Size(204, 51);
            this.TotalBill.TabIndex = 1;
            this.TotalBill.Text = "Summ";
            this.TotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Producer
            // 
            this.Producer.AutoSize = true;
            this.Producer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Producer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Producer.Location = new System.Drawing.Point(319, 0);
            this.Producer.Name = "Producer";
            this.Producer.Size = new System.Drawing.Size(429, 51);
            this.Producer.TabIndex = 2;
            this.Producer.Text = "Producer";
            this.Producer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Status.Location = new System.Drawing.Point(3, 51);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(310, 20);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddressLabel.Location = new System.Drawing.Point(319, 51);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(429, 43);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dishes
            // 
            this.Dishes.AutoScroll = true;
            this.Dishes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dishes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Dishes.Location = new System.Drawing.Point(4, 98);
            this.Dishes.Name = "Dishes";
            this.Dishes.Size = new System.Drawing.Size(954, 363);
            this.Dishes.TabIndex = 3;
            this.Dishes.WrapContents = false;
            // 
            // ChangeAddressButton
            // 
            this.ChangeAddressButton.AutoSize = true;
            this.ChangeAddressButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ChangeAddressButton.BorderRadius = 5;
            this.ChangeAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeAddressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeAddressButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.ChangeAddressButton.ForeColor = System.Drawing.Color.White;
            this.ChangeAddressButton.Location = new System.Drawing.Point(754, 54);
            this.ChangeAddressButton.Name = "ChangeAddressButton";
            this.ChangeAddressButton.Size = new System.Drawing.Size(204, 37);
            this.ChangeAddressButton.TabIndex = 4;
            this.ChangeAddressButton.Text = "Изменить адрес";
            this.ChangeAddressButton.UseVisualStyleBackColor = true;
            this.ChangeAddressButton.Click += new System.EventHandler(this.ChangeAddressButton_Click);
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Apply.BorderRadius = 5;
            this.Apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(0, 411);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(800, 39);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Сохранить";
            this.Apply.UseVisualStyleBackColor = true;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OrderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label OrderName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label TotalBill;
        private System.Windows.Forms.Label Producer;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.FlowLayoutPanel Dishes;
        private CustomButton Apply;
        private CustomButton ChangeAddressButton;
        private System.Windows.Forms.Label AddressLabel;
    }
}