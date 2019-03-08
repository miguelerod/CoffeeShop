using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YodaCoffeeShopData
{
    static class SqlStatements
    {
        public static string createAdmin = @"INSERT INTO [YodaCoffeeShop].[dbo].[Users]
                                                        ( Name,
                                                         Email,
                                                         UserName,
                                                         Password,
                                                         State
                                                         )
                                                    Values ('admin', 
                                                            'na@na.com', 
                                                            'admin', 
                                                            'admin',
                                                            'TRUE'";
    }
}
