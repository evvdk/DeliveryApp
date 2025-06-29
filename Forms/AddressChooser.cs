﻿using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DeliveryApp.Forms
{
    public enum Mode { Edit, Order, ReadyOrderChange }
    public partial class AddressChooser : Form
    {
        private Mode Mode;
        private List<RadioButton> radioButtons = new List<RadioButton>();
        public AddressChooser(Mode mode)
        {
            this.Mode = mode;
            List <Address_By_Login> addresses = ClientActions.GetAddresses();
            InitializeComponent();
            UpdateList();
            switch (Mode)
            {
                case Mode.Order:
                    this.Apply.Click += new EventHandler(this.Apply_InitOrder);
                    this.Apply.Text = "Создать заказ";
                    break;
                case Mode.Edit:
                    this.Apply.Text = "Закрыть";
                    this.Apply.Click += (p, e) => {
                        this.Close();
                    };
                    break;
            }
        }

        private int OrderId;
        public AddressChooser(int Order)
        {
            this.Mode = Mode.ReadyOrderChange;
            this.OrderId = Order;
            List<Address_By_Login> addresses = ClientActions.GetAddresses();
            int orderAddress = ClientActions.GetAddressIdByOrder(Order);
            InitializeComponent();
            UpdateList();
            radioButtons.Where(p => (int)p.Tag == orderAddress).First().Checked = true;
            this.Apply.Click += (s, e) => {
                try
                {
                    var selected = radioButtons.Where(p => p.Checked);
                    if (selected.Count() != 1) throw new Exception("Адрес не выбран");
                    int address = (int)selected.First().Tag;
                    ClientActions.ChangeAddressInOrder(Order, address);
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
        }

        private void AddAddressPanel(Address_By_Login address)
        {
            FlowLayoutPanel FlowLayoutAddress = new FlowLayoutPanel();
            RadioButton radioButton = new RadioButton();
            CustomButton Edit = new CustomButton();
            CustomButton Delete = new CustomButton();

            FlowLayoutAddress.SuspendLayout();

            this.FlowLayout.Controls.Add(FlowLayoutAddress);
            // 
            // radioButton1
            // 
            radioButton.AutoSize = true;
            radioButton.Dock = DockStyle.Fill;
            radioButton.Location = new System.Drawing.Point(3, 3);
            if (this.Mode == Mode.Order || this.Mode == Mode.ReadyOrderChange) radioButton.Checked = false;
            else radioButton.Checked = true;
            radioButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            radioButton.Text = $"{address.City}, {address.District}, {address.Street}, {address.Building}, {address.Room}";
            radioButton.UseVisualStyleBackColor = true;
            radioButton.Tag = address.Address_ID;
            if (this.Mode == Mode.Order || this.Mode == Mode.ReadyOrderChange) radioButton.Click += new EventHandler(radioButton_Clear);
            radioButtons.Add(radioButton);
            // 
            // FlowLayoutAddress
            // 
            FlowLayoutAddress.AutoSize = true;
            FlowLayoutAddress.Controls.Add(radioButton);
            FlowLayoutAddress.Controls.Add(Edit);
            FlowLayoutAddress.Controls.Add(Delete);
            FlowLayoutAddress.Location = new System.Drawing.Point(0, 0);
            FlowLayoutAddress.Margin = new Padding(0);
            FlowLayoutAddress.Size = new System.Drawing.Size(400, 38);
            //
            // Edit
            // 
            Edit.AutoSize = true;
            Edit.Dock = DockStyle.Fill;
            Edit.Location = new System.Drawing.Point(122, 3);
            Edit.Text = "Редактировать";
            Edit.Tag = address.Address_ID;
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += new EventHandler(this.Apply_EditAddress);

            Delete.AutoSize = true;
            Delete.Dock = DockStyle.Fill;
            Delete.Location = new System.Drawing.Point(122, 3);
            Delete.Text = "Удалить";
            Delete.Tag = address.Address_ID;
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += new EventHandler(this.Apply_DeleteAddress);

            FlowLayoutAddress.ResumeLayout(false);
            FlowLayoutAddress.PerformLayout();
        }

        private void radioButton_Clear(object sender, System.EventArgs e)
        {
            try
            {
                foreach (var single in radioButtons)
                {
                    single.Checked = false;
                }
                RadioButton radio = sender as RadioButton;
                if (radio == null)
                    throw new Exception("Error during cast");

                radio.Checked = true;
            }
            catch
            {
                MessageBox.Show("Error during checking");
            }
        }

        private void Apply_InitOrder(object sender, EventArgs e)
        {
            try
            {
                var selected = radioButtons.Where(p=>p.Checked);
                if (selected.Count() != 1) throw new Exception("Адрес не выбран");
                int address = (int)selected.First().Tag;
                ClientActions.InitOrder(address);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Apply_EditAddress(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if (btn == null) throw new Exception("Error passing button");
                int addressId = (int)btn.Tag;
                AddressEditor edit = new AddressEditor(addressId);
                edit.Show();
                edit.FormClosed += (s, ev) => {
                    UpdateList();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Apply_DeleteAddress(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                if (btn == null) throw new Exception("Error passing button");
                int addressId = (int)btn.Tag;
                ClientActions.DeleteAddress(addressId);
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateList()
        {
            List<Address_By_Login> addresses = ClientActions.GetAddresses();
            this.FlowLayout.Controls.Clear();
            this.radioButtons.Clear();
            foreach (var address in addresses)
            {
                AddAddressPanel(address);
            }
            if(this.Mode == Mode.ReadyOrderChange)
            {
                int orderAddress = ClientActions.GetAddressIdByOrder(this.OrderId);
                radioButtons.Where(p => (int)p.Tag == orderAddress).First().Checked = true;
            }
        }

        private void AddNewAddress(object sender, EventArgs e)
        {
            try
            {
                AddressEditor edit = new AddressEditor();
                edit.Show();
                edit.FormClosed += (s, ev) =>
                {
                    UpdateList();
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
