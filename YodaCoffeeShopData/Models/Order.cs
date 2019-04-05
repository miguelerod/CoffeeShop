using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;

namespace YodaCoffeeShopData.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public double SubTotal { get; set; }
        public double ITBIS { get; set; }
        public double Tip { get; set; }
        public double Total { get; set; }
        public bool State { get; set; } = true;
         
        [ForeignKey("ClientId")] public virtual Client Client { get; set; }
    }
}
