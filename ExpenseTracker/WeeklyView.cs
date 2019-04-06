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
    public partial class WeeklyView : Form
    {
        public WeeklyView()
        {
            InitializeComponent();
        }

        public void PopulateTransactionsDataGridView()
        {
            dataGridWeeklyView.AutoGenerateColumns = false;
            using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
            {
                var dateTime = DateTime.Now.AddDays(-7);
                var todayDateTime = DateTime.Now;
                dataGridWeeklyView.DataSource =
                    dbEntities.Transactions.Where(r => todayDateTime > r.date && r.date > dateTime).ToList();

            }
        }

        private void WeeklyView_Load(object sender, EventArgs e)
        {
            PopulateTransactionsDataGridView();
        }
    }
}
