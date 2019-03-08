using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using YodaCoffeeShopData;

namespace MyCoffeeProject.Classes
{
    interface IDbService
    {
        YodaCoffeeShopContext NewConnection();
           
        
    }
}
