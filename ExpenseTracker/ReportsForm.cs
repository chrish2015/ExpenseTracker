using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker
{
    public partial class ReportsForm : Form
    {
        private readonly TransactionController _transactionController = new TransactionController();
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            int expense = 0;
            int income = 0;
            var transactions = _transactionController.getMonthlyExpenses();
            foreach (var transaction in transactions)
            {
                if (transaction.transactionType == "Expense")
                {
                    expense += transaction.value;
                }
                else
                {
                    income += transaction.value;
                }
            }
            DrawPieChart(income, expense);
        }

        private void DrawPieChart(int income, int expenses)
        {
            expenseChart.Series.Clear();
            expenseChart.Legends.Clear();

            expenseChart.Legends.Add("Transactions");
            expenseChart.Legends[0].BorderColor = Color.Black;
            expenseChart.Legends[0].Alignment = StringAlignment.Center;
            expenseChart.Legends[0].Title = "Transactions";
            expenseChart.Legends[0].Docking = Docking.Bottom;
            expenseChart.Legends[0].LegendStyle = LegendStyle.Table;

            string transactionSeries = "Transactions";
            expenseChart.Series.Add(transactionSeries);
            expenseChart.Series[transactionSeries].ChartType = SeriesChartType.Pie;

            expenseChart.Series[transactionSeries].Points.AddXY("Income", income);
            expenseChart.Series[transactionSeries].Points.AddXY("Expenses", expenses);
        }
    }
}
