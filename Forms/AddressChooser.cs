using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DeliveryApp.Forms
{
    public partial class AddressChooser: Form
    {

        List<RadioButton> radioButtons = new List<RadioButton>();
        public AddressChooser()
        {
            List <Address_By_Login> addresses = ClientActions.GetAddresses();
            InitializeComponent();
            foreach(var address in addresses)
            {
                update(address);
            }
        }

        private void update(Address_By_Login address)
        {
            FlowLayoutPanel FlowLayoutAddress = new FlowLayoutPanel();
            RadioButton radioButton1 = new RadioButton();
            Button Edit = new Button();

            FlowLayoutAddress.SuspendLayout();

            this.FlowLayout.Controls.Add(FlowLayoutAddress);

            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Fill;
            radioButton1.Location = new System.Drawing.Point(3, 3);
            radioButton1.Checked = false;
            radioButton1.Text = $"{address.Region}, {address.City}, {address.District}, {address.Street}, {address.Building}, {address.Room}";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Tag = address.Address_ID;
            radioButton1.Click += new EventHandler(radioButton1_CheckedChanged);
            radioButtons.Add(radioButton1);
            // 
            // FlowLayoutAddress
            // 
            FlowLayoutAddress.AutoSize = true;
            FlowLayoutAddress.Controls.Add(radioButton1);
            FlowLayoutAddress.Controls.Add(Edit);
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
            Edit.TabIndex = 1;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;

            FlowLayoutAddress.ResumeLayout(false);
            FlowLayoutAddress.PerformLayout();

        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
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

        private void Apply_Click(object sender, EventArgs e)
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
    }
}
