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
        private Button _lastButton;
        public static string file;
        public MainView(User user)
        {
            InitializeComponent();
            MainView.user = user;
            _lastButton = btnTransactions;
            DisplayTransactionForm();
            ColourButton(btnTransactions);
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            file = System.IO.Path.Combine(path, "Events.xml");
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


        private void btnPredictions_Click(object sender, EventArgs e)
        {

            this.pnlMain.Controls.Clear();
            btnGneerate predictionsForm = new btnGneerate();
            predictionsForm.TopLevel = false;
            predictionsForm.AutoScroll = true;
            this.pnlMain.Controls.Add(predictionsForm);
            predictionsForm.Show();
            ColourButton((Button)sender);
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

        private void btnEvents_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            EventView eventView = new EventView();
            eventView.TopLevel = false;
            eventView.AutoScroll = true;
            this.pnlMain.Controls.Add(eventView);
            eventView.Show();
            ColourButton((Button)sender);
        }
        

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            ReportsForm reports = new ReportsForm();
            reports.TopLevel = false;
            reports.AutoScroll = true;
            this.pnlMain.Controls.Add(reports);
            reports.Show();
            ColourButton((Button)sender);
        }

        private void ColourButton(Button button)
        {
            _lastButton.BackColor = DefaultBackColor;
            button.BackColor = Color.Aqua;
            _lastButton = button;
        }
        private void btnExitProgram_Click(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }
}
