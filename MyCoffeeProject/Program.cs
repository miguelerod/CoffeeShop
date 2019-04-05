using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCoffeeProject;
using YodaCoffeeShopData.Repositories.Entities;

namespace MyCoffeeProject
{
    static class Program
    {
        /// <summary>
        /// Global Variables.
        /// </summary>
        public static bool LoginSuccess = false;
        public static UserRepository LoggedUser { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            if (LoginSuccess)
            {
                Application.Run(new YodaCoffeeShop());
            }
        }
    }
}
