using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtName.Text = "aditya";
            txtPassword.Text = "aditya";
        }

        private void btnLogin_OnClick(object sender, EventArgs e)
        {
            if (txtName.Text == "aditya" && txtPassword.Text == "aditya")
            {
                if (string.Compare(txtPassword.Text, "aditya", true) == 0)
                {
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                    Hide();

                }
                else
                    MessageBox.Show("Invalid Username or Password.");
            }
            else
                MessageBox.Show("Invalid Username or Password.");
        }
    }
}
