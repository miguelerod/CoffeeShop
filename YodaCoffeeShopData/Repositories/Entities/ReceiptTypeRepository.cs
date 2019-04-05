using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YodaCoffeeShopData.Models;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class ReceiptTypeRepository : BaseRepository<ReceiptType>
    {
        public ReceiptTypeRepository(YodaCoffeeShopContext context) : base(context)
        {
        }
    }
}
