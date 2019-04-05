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
    public partial class ClientOrdersForm : Form
    {
        public Client Client { get; set; }
        public List<Order> Orders { get; set; }
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();

        public ClientOrdersForm()
        {
            InitializeComponent();
        }

        private void ClientOrdersForm_Load(object sender, EventArgs e)
        {
            var ordersRep = new OrderRepository(Context);

            Orders = ordersRep.GetAll(or => or.ClientId == Client.Id).ToList();

            foreach (var order in Orders)
            {
                OrdersListBox.Items.Add($"{order.OrderDate:F} | Order#{Client.ReceiptType.Type}{order.OrderNumber:00000000000} | Total: {order.Total:$00.00}");
            }

            OrdersListBox.Refresh();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedIndex == -1) return;

            var index = OrdersListBox.SelectedIndex;
            var order = Orders[index];

            var checkOrderForm = new CheckOrderForm {Order = order};
            checkOrderForm.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
