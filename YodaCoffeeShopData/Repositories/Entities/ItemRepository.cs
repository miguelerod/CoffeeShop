using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using YodaCoffeeShopData.Models;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class ItemRepository : BaseRepository<Item>
    {
        public ItemRepository(YodaCoffeeShopContext context) : base(context)
        {
        }

        public List<Item> Search(string searchString)
        {
            return Context.Items
                .Where(it => it.Name.Contains(searchString) && it.State)
                .ToList();
        }
    }
}
