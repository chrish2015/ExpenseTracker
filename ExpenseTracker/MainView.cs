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
    public partial class MainView : Form
    {
        public static User user;

        public MainView(User user)
        {
            InitializeComponent();
            MainView.user = user;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm=new TransactionForm();
            transactionForm.TopLevel = false;
            transactionForm.AutoScroll = true;
            this.pnlMain.Controls.Add(transactionForm);
            transactionForm.Show();
        }
    }
}
