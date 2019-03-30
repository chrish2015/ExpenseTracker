using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class UserLoginForm : Form
    {
        MainView mainView = new MainView();
        public UserLoginForm()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            String username = txtUsername.Text;
            String password = txtPassword.Text;
            UserController userController = new UserController();
            bool isUserEnable = userController.VerifyLogin(username, password);
            if (isUserEnable)
            {
                mainView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error");
            }
        }
    }
}
