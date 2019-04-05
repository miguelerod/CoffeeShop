using MyCoffeeProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using YodaCoffeeShopData;
using YodaCoffeeShopData.Models;
using YodaCoffeeShopData.Repositories.Entities;

namespace MyCoffeeProject
{

    public partial class YodaCoffeeShop : Form, IHello //need partial. WHY?
    {
        // 'public List<Customer> YodaCustomerList = new List<Customer>;

        public List<Client> CustomerList;
        public List<Item> ProductList;
        public Order Order = new Order();
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();
        public OrderRepository orderRep;
        public List<ReceiptType> ReceiptTypes;

        public YodaCoffeeShop()
        {
            InitializeComponent();
        }

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
            
            //add customer to db
            var clientName = nameTxtBox.Text;
            var clientEmail = emailTxtBox.Text;
            var clientPhNum = PhNumTextBox.Text;
            var clientRNC = RNCTextBox.Text;
            var clientType = ReceiptTypes[CustTypeComboBox.SelectedIndex];
            var newClient = new Client {ReceiptType = clientType, Name = clientName, Email = clientEmail, RNC = clientRNC, PhoneNumber = clientPhNum};
            var clientRep = new ClientRepository(Context);

            var emailExists = false;
            foreach (var cust in CustomerList)
            {
                if (cust.Email != newClient.Email) continue;
                InvalidEmail.Visible = true;
                emailExists = true;
                break;
            }


            if (emailExists) return;
            InvalidEmail.Visible = false;

            clientRep.Create(newClient);
            
            PopulateClientListBox();

            ClearAll();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void PopulateClientListBox()
        {
            var custRep = new ClientRepository(Context);

            CustomerList = custRep.GetAll(cl => cl.State).ToList();

            ClientListBox.Items.Clear();

            foreach (var cust in CustomerList)
            {
                ClientListBox.Items.Add($"{cust.Name} | {cust.Email} | {cust.PhoneNumber}");
            }

            ClientListBox.Refresh();
        }

        private void PopulateProductListBox()
        {
            var prodRep = new ItemRepository(Context);

            ProductList = prodRep.GetAll(it => it.State).ToList();

            ProductListBox.Items.Clear();

            foreach (var product in ProductList)
            {
                ProductListBox.Items.Add($"{product.Name} | {product.Description} | {product.Price:$0.00}");
            }

            ProductListBox.Refresh();
        }

        private void PopulateOrderListBox()
        {
            OrderListBox.Items.Clear();

            foreach (var item in orderRep.Items)
            {
                OrderListBox.Items.Add($"{item.Name}  |  {item.Price:$0.00}");
            }

            OrderListBox.Refresh();

            var subTotal = orderRep.Items.Sum(item => item.Price);
            var itbis = subTotal * 0.18;
            var tip = subTotal * 0.10;
            var total = subTotal + itbis + tip;

            SubTotalBox.Text = $"{subTotal:$0.00}";
            ITBISBox.Text = $"{itbis:$0.00}";
            TipBox.Text = $"{tip:$0.00}";
            TotalBox.Text = $"{total:$0.00}";
        }

        #region Clear All Method
        private void ClearAll()
        {
            nameTxtBox.Text = "";
            PhNumTextBox.Text = "";
            emailTxtBox.Text = "";
        }
        #endregion

        

        //need to define and use the hello () because I implement the interface at top of the program
        public void Hello()
        {
            Console.WriteLine("Yoda says Hello");
        }

        private void YodaCoffeeShop_Load(object sender, EventArgs e)
        {
            orderRep = new OrderRepository(Context);
            var custRep = new ClientRepository(Context);
            var prodRep = new ItemRepository(Context);
            var receiptRep = new ReceiptTypeRepository(Context);
            ReceiptTypes = receiptRep.GetAll(rt => rt.Status == true).ToList();

            foreach (var receiptType in ReceiptTypes)
            {
                CustTypeComboBox.Items.Add(receiptType.Name);
            }

            CustTypeComboBox.SelectedIndex = 1;
            
            Hello();
            CustomerList = custRep.GetAll(cl => cl.State).ToList();
            ProductList = prodRep.GetAll(prod => prod.State).ToList();

            PopulateClientListBox();
            PopulateProductListBox();
        }

        private void CustomerSearchBar_TextChanged(object sender, EventArgs e)
        {
            var custRep = new ClientRepository(Context);

            if (CustomersSearchBar.Text != "")
            {
                CustomerList = custRep.Search(CustomersSearchBar.Text);
                ClientListBox.Items.Clear();

                foreach (var cust in CustomerList)
                {
                    ClientListBox.Items.Add($"{cust.Name} | {cust.Email} | {cust.PhoneNumber}");
                }

                ClientListBox.Refresh();
            }
            else
            {
                CustomerList = custRep.GetAll(cl => cl.State).ToList();
                PopulateClientListBox();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var custRep = new ClientRepository(Context);
            var index = ClientListBox.SelectedIndex;
            if (index == -1) return;
            var customer = CustomerList[index];
            
            custRep.Delete(customer.Id);

            PopulateClientListBox();
        }

        private void EmptyTextBoxOnClick_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.Text = "";
        }

        private void ProductSearchBar_TextChanged(object sender, EventArgs e)
        {
            var prodRep = new ItemRepository(Context);

            if (ProductSearchBar.Text != "")
            {
                ProductList = prodRep.Search(ProductSearchBar.Text);
                ProductListBox.Items.Clear();

                foreach (var product in ProductList)
                {
                    ProductListBox.Items.Add($"{product.Name} | {product.Description} | {product.Price:$0.00}");
                }

                ProductListBox.Refresh();
            }
            else
            {
                ProductList = prodRep.GetAll(prod => prod.State == true).ToList();
                PopulateProductListBox();
            }
        }

        private void EditCustButton_Click(object sender, EventArgs e)
        {
            var index = ClientListBox.SelectedIndex;
            if (index == -1) return;
            var customer = CustomerList[ClientListBox.SelectedIndex];
            var editDialog = new EditCustomerForm {Customer = customer};
            editDialog.ShowDialog();
            PopulateClientListBox();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            var prodRep = new ItemRepository(Context);
            var index = ProductListBox.SelectedIndex;

            if (index == -1) return;
            var product = ProductList[index];
            prodRep.Delete(product.Id);

            PopulateProductListBox();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            AddProductInOrder();
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            var index = ProductListBox.SelectedIndex;
            if (index == -1) return;
            var item = ProductList[index];
            var editDialog = new EditProductForm {Item = item};
            editDialog.ShowDialog();
            PopulateProductListBox();
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            var newProductDialog = new NewItemForm();
            newProductDialog.ShowDialog();
            PopulateProductListBox();
        }

        private void AddProductInOrder()
        {
            var index = ProductListBox.SelectedIndex;

            if (index == -1) return;
            var item = ProductList[index];

            orderRep.AddItem(item);
            PopulateOrderListBox();
        }

        private void ProductListBox_DoubleClick(object sender, EventArgs e)
        {
            AddProductInOrder();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (ClientListBox.SelectedIndex == -1 && Order.State) return;

            Order.Client = CustomerList[ClientListBox.SelectedIndex];
            orderRep.SetTotal(Order);
            orderRep.Create(Order);

            var newOrderDialog = new CheckOrderForm { Order = Order};
            newOrderDialog.ShowDialog();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var index = ProductListBox.SelectedIndex;

            if (index == -1) return;
            var item = ProductList[index];

            orderRep.Items.Remove(item);
            PopulateOrderListBox();
        }

        private void ShowOrdersButton_Click(object sender, EventArgs e)
        {
            if (ClientListBox.SelectedIndex == -1) return;

            var index = ClientListBox.SelectedIndex;
            var client = CustomerList[index];

            var clientOrdersForm = new ClientOrdersForm {Client = client};
            clientOrdersForm.ShowDialog();
        }
    }
}
