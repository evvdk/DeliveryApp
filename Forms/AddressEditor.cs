using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DeliveryApp.EF;

namespace DeliveryApp.Forms
{
    public partial class AddressEditor: Form
    {
        private int addressID;
        private bool editMode;
        public AddressEditor()
        {
            this.editMode = false;
            InitializeComponent();
        }

        public AddressEditor(int addressID)
        {
            this.editMode = true;
            this.addressID = addressID;
            InitializeComponent();
            try
            {
                Address_By_Login address = ClientActions.GetAddresses().Where(p => p.Address_ID == addressID).First();
                RegionField.Text = address.Region;
                CityField.Text = address.City;
                DistrictField.Text = address.District;
                StreetField.Text = address.Street;
                BuildingField.Text = address.Building;
                if(!(address.Floor is null))
                    FloorField.Text = address.Floor.ToString();
                RoomField.Text = address.Room;
            }catch
            {
                MessageBox.Show("Error during initting form");
            }

        }

        private void Apply_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(this.RegionField.Text.Length == 0 
                    || this.CityField.Text.Length == 0 || this.DistrictField.Text.Length == 0
                    || this.StreetField.Text.Length == 0 || this.BuildingField.Text.Length == 0 
                    || this.RoomField.Text.Length == 0)
                    throw new Exception("Some fields are empthy");
                int? Floor;
                if (FloorField.Text.Length == 0)
                {
                    Floor = null;
                }
                else Floor = Convert.ToInt32(this.FloorField.Text);

                if (!editMode)
                {
                    ClientActions.AddAdress(this.RegionField.Text, this.CityField.Text, this.DistrictField.Text, this.StreetField.Text, this.BuildingField.Text, Floor, this.RoomField.Text);
                }
                else
                {
                    ClientActions.EditAddress(this.addressID, this.RegionField.Text, this.CityField.Text, this.DistrictField.Text, this.StreetField.Text, this.BuildingField.Text, Floor, this.RoomField.Text);
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
