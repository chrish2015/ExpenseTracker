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
        private readonly EventController _eventController = new EventController();
        private readonly TransactionController _transactionController = new TransactionController();
        public WeeklyView()
        {
            InitializeComponent();
        }

        public void PopulateTransactionsDataGridView()
        {
            dataGridWeeklyView.AutoGenerateColumns = false;
            dataGridWeeklyView.DataSource = _transactionController.GetWeeklyExpenses();

            dataGridEventsWeely.AutoGenerateColumns = false;
            dataGridEventsWeely.DataSource = _eventController.GetWeeklyEvents(MainView.file);

        }

        private void WeeklyView_Load(object sender, EventArgs e)
        {
            PopulateTransactionsDataGridView();
        }

    }
}
