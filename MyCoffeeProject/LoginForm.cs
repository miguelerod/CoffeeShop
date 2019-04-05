using System;
using System.Linq;
using System.Windows.Forms;
using YodaCoffeeShopData;
using YodaCoffeeShopData.Repositories.Entities;

namespace MyCoffeeProject
{
    public partial class LoginForm : Form
    {
        public YodaCoffeeShopContext Context = new YodaCoffeeShopContext();

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


        private void UserBox_inputKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SelectNextControl(this, true, false, false, true);
            }
        }

        private void PasswordBox_inputKey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                signInButton_Click(this, new EventArgs());
            }
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
            var user = new UserRepository(Context);
            if (!user.Login(userName, password))
            {
                wrongCredentials.Visible = true;
                return;
            }
            Program.LoggedUser = user;
            Program.LoginSuccess = true;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
