using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace YodaCoffeeShopData.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public int ReceiptTypeId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string RNC { get; set; }
        public string Email { get; set; }
        public bool State { get; set; } = true;

        [ForeignKey("ReceiptTypeId")] public virtual ReceiptType ReceiptType { get; set; }
    }
}
