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
        private Button lastButton;
        public MainView(User user)
        {
            InitializeComponent();
            MainView.user = user;
            lastButton = btnTransactions;
            DisplayTransactionForm();
            ColourButton(btnTransactions);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            DisplayTransactionForm();
            ColourButton((Button)sender);
        }

        private void DisplayTransactionForm()
        {
            this.pnlMain.Controls.Clear();
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.TopLevel = false;
            transactionForm.AutoScroll = true;
            this.pnlMain.Controls.Add(transactionForm);
            transactionForm.Show();
        }

        private void btnWeeklyView_Click(object sender, EventArgs e)
        {

            this.pnlMain.Controls.Clear();
            WeeklyView weeklyView = new WeeklyView();
            weeklyView.TopLevel = false;
            weeklyView.AutoScroll = true;
            this.pnlMain.Controls.Add(weeklyView);
            weeklyView.Show();
            ColourButton((Button)sender);
        }

        private void ColourButton(Button button)
        {
            lastButton.BackColor = DefaultBackColor;
            button.BackColor = Color.Aqua;
            lastButton = button;
        }

        private void btnPredictions_Click(object sender, EventArgs e)
        {

        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            ContactsForm userForm = new ContactsForm();
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            this.pnlMain.Controls.Add(userForm);
            userForm.Show();
            ColourButton((Button)sender);
        }

        private void btnExitProgram_Click(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
