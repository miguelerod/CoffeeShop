using System.Collections.Generic;
using System.Linq;
using YodaCoffeeShopData.Models;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository(YodaCoffeeShopContext context) : base(context)
        {
        }

        public List<Client> Search(string searchString)
        {
            return Context.Clients.Where(cl =>
                cl.Name.Contains(searchString) ||
                cl.Email.Contains(searchString)).ToList();
        }
    }
}
