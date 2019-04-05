using System.ComponentModel.DataAnnotations;

namespace YodaCoffeeShopData.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool State { get; set; } = true;
    }
}
