using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using YodaCoffeeShopData;

namespace MyCoffeeProject.Classes
{
    public partial class LoginForm : Form
    {
        public static User user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wrongCredentials_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string userName = UserBox.Text;
            string password = PasswordBox.Text;

            using (var Context = new YodaCoffeeShopContext())
            {
                var user = Context.Users.
                                    Where(u => u.UserName == userName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
