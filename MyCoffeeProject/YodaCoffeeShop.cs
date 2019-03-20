using MyCoffeeProject.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using MyCoffeeProject.Classes.Derived_Coffee_Drinks; //because in folder need to import additional folder
using YodaCoffeeShopData;

namespace MyCoffeeProject
{

    public partial class YodaCoffeeShop : Form, IHello //need partial. WHY?
    {
        // 'public List<Customer> YodaCustomerList = new List<Customer>;

        public List<Client> CustomerList;
        public List<Item> ProductList;
        Order order;

        public YodaCoffeeShop()
        {
            InitializeComponent();
        }

       

        private void saveCustBtn_Click(object sender, EventArgs e)
        {
            
            //add customer to db
            var clientName = nameTxtBox.Text;
            var clientEmail = emailTxtBox.Text;
            var clientPhNum = phoneNumtextBox.Text;
            var newClient = new Client {Name = clientName, Email = clientEmail, PhoneNumber = clientPhNum};

            var emailExists = false;
            foreach (var cust in CustomerList)
            {
                if (cust.Email == newClient.Email)
                {
                    InvalidEmail.Visible = true;
                    emailExists = true;
                    break;
                }
            }


            if (!emailExists)
            {
                InvalidEmail.Visible = false;

                newClient.Insert();
                
                CustomerList = Client.GetByState(true);

                PopulateClientListBox();

                ClearAll();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void PopulateClientListBox()
        {
            ClientListBox.Items.Clear();

            foreach (var cust in CustomerList)
            {
                ClientListBox.Items.Add($"{cust.Name} | {cust.Email} | {cust.PhoneNumber}");
            }

            ClientListBox.Refresh();
        }

        private void PopulateProductListBox()
        {
            ClientListBox.Items.Clear();

            foreach (var item in ProductList)
            {
                ProductListBox.Items.Add($"{item.Name} | {item.Description} | {item.Price}");
            }

            ProductListBox.Refresh();
        }

        #region Clear All Method
        private void ClearAll()
        {
            nameTxtBox.Text = "";
            phoneNumtextBox.Text = "";
            emailTxtBox.Text = "";

            //clear the list box
            priceLabel.Text = "Price:";

            smRadioBtn.Checked = false;
            medRadioBtn.Checked = false;
            lgRadioBtn.Checked = false;

            icedCoffeeRdBtn.Checked = false;
            icedLatteRdBtn.Checked = false;
        }
        #endregion

        #region Calculate Cost Button Click
        private void calcCostBtn_Click(object sender, EventArgs e)
        {//make cleaner and easier   https://stackoverflow.com/questions/18547326/how-do-i-get-which-radio-button-is-checked-from-a-groupbox
            //https://social.msdn.microsoft.com/Forums/windows/en-US/c0c36595-9d98-40f7-8e6a-176a5a3af929/how-to-detect-which-radio-button-is-checked-inside-a-groupbox-control?forum=winforms

            var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

            string  coffeeType;
            string iceamt = "normal";
            string size;

            if (icedCoffeeRdBtn.Checked == true)
            {
                string bTime = "long";
                coffeeType = "Iced Coffee"; 

                if (smRadioBtn.Checked == true)
                {
                    size = "Small";
                }
                else if (medRadioBtn.Checked == true)
                {
                    size = "Medium";
                }
                else
                {
                    size = "Large";
                }
                //create new Iced Coffee object
                IcedCoffee custsCoffee = new IcedCoffee(size,bTime, iceamt, 3.35  );
                //Set Price
                priceLabel.Text = "Price: " + custsCoffee.Price.ToString("C2");
                //Add object to list
                //order.Add(custsCoffee);
                //Count total
                //ttlCoffeesLabel.Text = "Total:" + order.Capacity.ToString();
            }
            else if (icedLatteRdBtn.Checked == true)
            {
                string bTime = "short";
                string icea = "normal";
                string milkAmount = "normal";
                coffeeType = "Iced Latte";

                if (smRadioBtn.Checked == true)
                {
                    size = "Small";
                }
                else if (medRadioBtn.Checked == true)
                {
                    size = "Medium";
                }
                else
                {
                    size = "Large";
                }

                //create new Iced Latte object
                IcedLatte custsCoffee = new IcedLatte(size, bTime, icea, milkAmount, 5.35);
                //Set Price
                priceLabel.Text = "Price: " + custsCoffee.Price.ToString("C2");

                //Add object to list
                //order.Add(custsCoffee); //TODO wrong
                //Count total
                //ttlCoffeesLabel.Text = "Total:" + order.Capacity.ToString();
            }

           // CoffeeDrinks customersCoffee = new CoffeeDrinks();     
        }
        #endregion

        //need to define and use the hello () because I implement the interface at top of the program
        public void Hello()
        {
            Console.WriteLine("Yoda says Hello");
        }

        private void icedCoffeeRdBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YodaCoffeeShop_Load(object sender, EventArgs e)
        {
            Hello();
            PopulateClientListBox();
        }

        private void lblCustomerHeader_Click(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            if (CustomersSearchBar.Text != "")
            {
                CustomerList = Client.SearchByName(CustomersSearchBar.Text);
                PopulateClientListBox();
            }
            else
            {
                CustomerList = Client.GetByState(true);
                PopulateClientListBox();
            }
           
        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ClientListBox.SelectedIndex;

            if (index == (ClientListBox.Items.Count - 1))
            {
                
            }
        }

        private void enterFNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var index = ClientListBox.SelectedIndex;
            var customer = CustomerList[index];
            
            customer.Remove();

            PopulateClientListBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (ProductSearchBar.Text != "")
            {
                CustomerList = Client.SearchByName(ProductSearchBar.Text);
                PopulateClientListBox();
            }
            else
            {
                CustomerList = Client.GetByState(true);
                PopulateClientListBox();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
