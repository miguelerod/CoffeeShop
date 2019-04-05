using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YodaCoffeeShopData;
using YodaCoffeeShopData.Models;
using YodaCoffeeShopData.Repositories.Entities;

namespace MyCoffeeProject
{
    public partial class EditCustomerForm : Form
    {
        public Client Customer { get; set; }
        public List<ReceiptType> ReceiptTypes;
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            Text = $@"Editing Customer {Customer.Name}"; ////Change the title of the dialog box
            NameTextBox.Text = Customer.Name;
            EmailTextBox.Text = Customer.Email;
            RNCTextBox.Text = Customer.RNC;
            PhNumTextBox.Text = Customer.PhoneNumber;


            var receiptTypeRep = new ReceiptTypeRepository(Context);
            ReceiptTypes = receiptTypeRep.GetAll(rt => rt.Status == true).ToList();
            foreach (var type in ReceiptTypes)
            {
                CustTypeComboBox.Items.Add(type.Name);
            }
            CustTypeComboBox.SelectedText = Customer.ReceiptType.Name;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var custRep = new ClientRepository(Context);
            Customer.Name = NameTextBox.Text;
            Customer.Email = EmailTextBox.Text;
            Customer.PhoneNumber = PhNumTextBox.Text;


            custRep.Update(Customer);
            Close();
        }
    }
}
