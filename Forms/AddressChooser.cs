using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DeliveryApp.Forms
{
    public enum Mode { Edit, Order}
    public partial class AddressChooser : Form
    {
        Mode Mode;
        List<RadioButton> radioButtons = new List<RadioButton>();
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
                    break;
                case Mode.Edit:
                    this.Apply.Click += (p, e) => {
                        this.Close();
                    };
                    break;
            }
        }

        private void AddAddressPanel(Address_By_Login address)
        {
            FlowLayoutPanel FlowLayoutAddress = new FlowLayoutPanel();
            RadioButton radioButton1 = new RadioButton();
            Button Edit = new Button();
            Button Delete = new Button();

            FlowLayoutAddress.SuspendLayout();

            this.FlowLayout.Controls.Add(FlowLayoutAddress);

            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Fill;
            radioButton1.Location = new System.Drawing.Point(3, 3);
            if (Mode == Mode.Order) radioButton1.Checked = false;
            else radioButton1.Checked = true;
                radioButton1.Text = $"{address.Region}, {address.City}, {address.District}, {address.Street}, {address.Building}, {address.Room}";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Tag = address.Address_ID;
            if(Mode == Mode.Order) radioButton1.Click += new EventHandler(radioButton_Clear);
            radioButtons.Add(radioButton1);
            // 
            // FlowLayoutAddress
            // 
            FlowLayoutAddress.AutoSize = true;
            FlowLayoutAddress.Controls.Add(radioButton1);
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
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.Tag = address.Address_ID;
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += new EventHandler(this.Apply_EditAddress);

            Delete.AutoSize = true;
            Delete.Dock = DockStyle.Fill;
            Delete.Location = new System.Drawing.Point(122, 3);
            Delete.Name = "Delete";
            Delete.Text = "Delete";
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
                if (selected.Count() != 1) throw new Exception("None radios selected");
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
            foreach (var address in addresses)
            {
                AddAddressPanel(address);
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
