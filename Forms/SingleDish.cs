using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System.Linq;
namespace DeliveryApp.Forms
{
    public partial class SingleDish: Form
    {
        int DishID;
        public SingleDish(int dishID)
        {
            this.DishID = dishID;
            InitializeComponent();
            List<Dish_All_Info> dishInfo = ClientActions.GetDishInfo(this.DishID);
            string dishName = dishInfo.First().Dish_Name;
            string producer = dishInfo.First().Producer_Name;
            int cal = dishInfo.First().Calories;
            decimal cost = decimal.Round((decimal)dishInfo.First().Cost);
            byte[] imageBytes = dishInfo.First().Image;
            this.Text = dishName;
            List<string> ingridientsList = dishInfo.Select(p =>  p.Ingredient_Name ).ToList();
            foreach(var each in ingridientsList)
            {
                Label IngridientValue = new Label();
                this.DishFlowLayout.Controls.Add(IngridientValue);
                IngridientValue.AutoSize = true;
                IngridientValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                IngridientValue.Text = each;
            }
            this.DishName.Text = dishName;
            this.ProducerName.Text = producer;
            this.CalValue.Text = cal.ToString();
            this.CostLabelValue.Text = $"{cost.ToString()} ₽";
            this.Image.BackgroundImage = DatabaseImage.BytesToImage(imageBytes);
            this.Image.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
