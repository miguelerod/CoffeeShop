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

        public static string makeReceiptTypes = @"INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Factura de Crédito Fiscal (Tipo 01)',
	                                                        1
                                                        )
                                                        INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Factura de Consumo (Tipo 02)',
	                                                        1
                                                        )
                                                        INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Notas de Débito (Tipo 03)',
	                                                        1
                                                        )
                                                        INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Notas de Crédito (Tipo 04)',
	                                                        1
                                                        )
                                                        INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Regímenes Especiales de Tributación (Tipo 14)',
	                                                        1
                                                        )
                                                        INSERT INTO [ReceiptTypes]
                                                        VALUES(
	                                                        'Comprobantes Gubernamentales (Tipo​ 15)',
	                                                        1
                                                        )";
    }
}
