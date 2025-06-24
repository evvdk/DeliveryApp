using System.Windows.Forms;
using DeliveryApp.EF;
using System.Collections.Generic;
using System.Linq;
namespace DeliveryApp.Forms
{
    public partial class SingleDish: Form
    {
        string DishID;
        public SingleDish(string dishID)
        {
            this.DishID = dishID;
            InitializeComponent();
            List<Меню> dishInfo = ClientActions.GetDishInfo(this.DishID);
            string dishName = dishInfo.First().Название;
            string description = dishInfo.First().Описание;
            int cal = (int)dishInfo.First().Калорийность;
            decimal cost = decimal.Round((decimal)dishInfo.First().Цена);
          
            this.Text = dishName;
            this.DishName.Text = dishName;
            this.DishDescription.Text = description;
            this.CalValue.Text = cal.ToString() + " Ккал";
            this.CostLabelValue.Text = $"{cost.ToString()} ₽";
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
