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
        public UserLoginForm()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            String username = txtUsername.Text;
            String password = txtPassword.Text;
            UserController userController = new UserController();
            bool user = userController.VerifyLogin(username, password);
            if (user == true)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
