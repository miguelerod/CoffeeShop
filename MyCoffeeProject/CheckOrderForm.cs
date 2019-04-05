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
    public partial class CheckOrderForm : Form
    {
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();
        public OrderRepository OrderRepository;
        public Order Order;
        public List<OrderLine> OrderLines;

        public CheckOrderForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            var itemRepository = new ItemRepository(Context);
            OrderRepository = new OrderRepository(Context);
            Text = $@"Order#{Order.Client.ReceiptType.Type}{Order.OrderNumber:000000000}";
            CustInfoTextBox.Text = $@"Client: {Order.Client.Name} | RNC: {Order.Client.RNC}";
            OrderInfoTextBox.Text = $@"Order#{Order.Client.ReceiptType.Type}{Order.OrderNumber:000000000} | Date: {Order.OrderDate}";

            OrderLines = OrderRepository.GetOrderItems(Order);

            foreach (var line in OrderLines)
            {
                var item = itemRepository.Get(it => it.Id == line.ItemId);
                OrderItemListBox.Items.Add($"{item.Name}");
                PriceBox.Items.Add($"{item.Price:$00.00}");
            }

            OrderItemListBox.Refresh();
            PriceBox.Refresh();

            SubTotalBox.Text = $@"{Order.SubTotal:$00.00}";
            ITBISBox.Text = $@"{Order.ITBIS:$00.00}";
            TipBox.Text = $@"{Order.Tip:$00.00}";
            TotalBox.Text = $@"{Order.Total:$00.00}";
        }

        private void OrderInfoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
