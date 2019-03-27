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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.username = "test";
            user.password = "test";

            ExpenseTrackerDBEntities et = new ExpenseTrackerDBEntities();
            et.Users.Add(user);
            et.SaveChanges();
        }
    }
}
