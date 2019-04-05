using System.Linq;
using MyCoffeeProject;
using YodaCoffeeShopData.Models;

namespace YodaCoffeeShopData.Repositories.Entities
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(YodaCoffeeShopContext context) : base(context)
        {
            
        }

        public bool Login(string userName, string password)
        {
            var user = Context.Users.FirstOrDefault(u => u.UserName == userName);
            return user != null && PasswordHasher.ValidatePassword(password, user.Password);
        }
    }
}
