using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaCoffeeShopData.Models
{
    public class OrderLine
    {
        [Key]
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("OrderId")] public Order Order { get; set; }
        [ForeignKey("ItemId")] public Item Item { get; set; }
    }
}
