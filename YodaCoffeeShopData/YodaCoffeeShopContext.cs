using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaCoffeeShopData
{
    public class YodaCoffeeShopContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public YodaCoffeeShopContext() : base("YodaCoffeeShop")
        {
            
        }
    }
}
