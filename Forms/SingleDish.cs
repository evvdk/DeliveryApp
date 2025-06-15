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
            string description = dishInfo.First().Description;
            int cal = dishInfo.First().Calories;
            decimal cost = decimal.Round((decimal)dishInfo.First().Cost);
            byte[] imageBytes = dishInfo.First().Image;
            this.Text = dishName;
            List<string> ingridientsList = dishInfo.Where(p => p.Ingredient_Name != null).Select(p =>  p.Ingredient_Name ).ToList();
            if (ingridientsList.Count == 0) this.IngridientsLabel.Visible = false;
            foreach (var each in ingridientsList)
            {
                Label IngridientValue = new Label();
                this.DishFlowLayout.Controls.Add(IngridientValue);
                IngridientValue.AutoSize = true;
                IngridientValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                IngridientValue.Text = each;
            }
            this.DishName.Text = dishName;
            this.DishDescription.Text = description;
            this.ProducerName.Text = producer;
            this.CalValue.Text = cal.ToString() + " Ккал";
            this.CostLabelValue.Text = $"{cost.ToString()} ₽";
            if(imageBytes != null)
                this.Image.BackgroundImage = DatabaseImage.BytesToImage(imageBytes);
            this.Image.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
