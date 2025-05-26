using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryApp.EF;

namespace DeliveryApp.Forms
{
    public partial class AddressEditor: Form
    {
        public AddressEditor()
        {
            InitializeComponent();
        }

        public AddressEditor(Address_By_Login data)
        {
            InitializeComponent();
        }
    }
}
