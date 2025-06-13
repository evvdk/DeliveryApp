using System.Drawing;
using System.Windows.Forms;

namespace DeliveryApp
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox() : base()
        {
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new Padding(0);
        }

        
    }
}
