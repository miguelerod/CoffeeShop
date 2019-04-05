using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YodaCoffeeShopData;
using YodaCoffeeShopData.Models;
using YodaCoffeeShopData.Repositories.Entities;

namespace MyCoffeeProject
{
    public partial class EditProductForm : Form
    {
        public Item Item { get; set; }
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();

        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            Text = $@"Editing Customer {Item.Name}"; //Change the title of the dialog box
            NameTextBox.Text = Item.Name;
            DescriptionTextBox.Text = Item.Description;
            PriceTextBox.Text = Item.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var itemRep = new ItemRepository(Context);
            Item.Name = NameTextBox.Text;
            Item.Description = DescriptionTextBox.Text;
            Item.Price = double.Parse(PriceTextBox.Text);

            itemRep.Update(Item);
            Close();
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
