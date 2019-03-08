using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes
{
    abstract class User
    {
        public string UserName { get; set; }
        private string _password;
        
        public Dictionary<string, bool> PermissionsValues;

        protected User(string userName, string password, Dictionary<string, bool> permissionsValues)
        {
            UserName = userName;
            _password = password;
            PermissionsValues = permissionsValues;
        }
    }
}
