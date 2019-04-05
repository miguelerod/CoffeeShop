using System;
using System.Collections.Generic;
using System.Linq;
using YodaCoffeeShopData.Models;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(YodaCoffeeShopContext context) : base(context)
        {
        }

        public List<Item> Items { get; } = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public new void Create(Order order)
        {
            order.OrderDate = DateTime.Now;
            var lastOrder = GetLastOrderOfType(order.Client.ReceiptType.Type);
            if (lastOrder == null || lastOrder.OrderNumber == 999999999) order.OrderNumber = 0;
            else order.OrderNumber = lastOrder.OrderNumber + 1;

            Context.Orders.Add(order);

            foreach (var item in Items)
            {
                var newOrderLine = new OrderLine { Item = item, Order = order };
                Context.OrderLines.Add(newOrderLine);
            }

            Context.SaveChanges();
        }

        public List<OrderLine> GetOrderItems(Order order)
        {
            return Context.OrderLines.Where(ol => ol.OrderId == order.Id).ToList();
        }

        public void SetTotal(Order order)
        {
            var subTotal = CalculateSubTotal();
            double itbis;
            if (order.Client.ReceiptType.Type == "14")
            {
                itbis = 0;
            }
            else
            {
                itbis = subTotal * 0.18;
            }
            var tip = subTotal * 0.1;
            var total = subTotal + itbis + tip;
            
            order.SubTotal = subTotal;
            order.ITBIS = itbis;
            order.Tip = tip;
            order.Total = total;
        }

        private double CalculateSubTotal()
        {
            double subTotal = 0;
            foreach (var item in Items)
            {
                subTotal += item.Price;
            }

            return subTotal;
        }

        private Order GetLastOrderOfType(string receiptType)
        {
            return Context.Orders
                .Where(order => order.Client.ReceiptType.Type == receiptType)
                .OrderByDescending(time => time.OrderDate)
                .FirstOrDefault();
        }
    }
}
