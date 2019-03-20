using System;
using System.Linq;
using System.Windows.Forms;
using YodaCoffeeShopData;

namespace MyCoffeeProject
{
    public partial class LoginForm : Form
    {
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

            using (var context = new YodaCoffeeShopContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == userName);
                if (user == null)
                {
                    wrongCredentials.Visible = true;
                }
                else
                {
                    if (PasswordHasher.ValidatePassword(password, user.Password))
                    {
                        Program.LoggedUser = user;
                        Program.LoginSuccess = true;
                        Close();
                    }
                    else
                    {
                        wrongCredentials.Visible = true;
                    }
                }
            }

            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
