using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaCoffeeShopData
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<Item> Items { get; set; }
        public double Total { get; set; }
        public bool State { get; set; } = true;

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
    }
}
