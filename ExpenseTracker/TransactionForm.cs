using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class TransactionForm : Form
    {
        TransactionController transactionController = new TransactionController();
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            PopulateTransactionsDataGridView();
            Clear();
        }

        private void Clear()
        {
            txtName.Text = txtDescription.Text = txtValue.Text = "";
            datePickerTransactions.Value = DateTime.Now;
            btnSubmit.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var value = Int32.Parse(txtValue.Text);
            var description = txtDescription.Text;
            var dateTime = datePickerTransactions.Value;

            var checkedType = pnlType.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var checkedRecurringOption = pnlRecurring.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            transactionController.Save(name, value, description, dateTime, checkedType, checkedRecurringOption);
            PopulateTransactionsDataGridView();

        }

        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            string value;
            NumberStyles style;
            CultureInfo culture;
            decimal currency;

            value = txtValue.Text;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            if (!Decimal.TryParse(value, style, culture, out currency))
            {
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // prevent the textbox from losing focus
                e.Cancel = true;
            }
        }

        private void txtValue_Validated(object sender, EventArgs e)
        {
            string input = txtValue.Text.Trim();
            if (input.StartsWith("$"))
            {
                string temp = input.Replace("$", "");
                string specifier = "C";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
                txtValue.Text = Decimal.Parse(temp).ToString(specifier, culture);
            }
        }

        void PopulateTransactionsDataGridView()
        {
            dataGridTransactions.AutoGenerateColumns = false;
            using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
            {
                dataGridTransactions.DataSource = dbEntities.Transactions.ToList<Transaction>();

            }
        }

        private void dataGridTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridTransactions_DoubleClick(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (dataGridTransactions.CurrentRow.Index != -1)
            {
                transaction.Id = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells["id"].Value);
                using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
                {
                    transaction = transactionController.getTransaction(dbEntities, transaction);
                    txtName                            .Text = transaction.name;
                    txtDescription                     .Text = transaction.description;
                    txtValue                           .Text = transaction.value.ToString();
                    if (transaction                    .isRecurring == "Yes")
                    {
                        rbtYes.Checked = true;
                    }
                    else
                    {
                        rbtNo.Checked = true;
                    }

                    if (transaction.transactionType == "Income")
                    {
                        btnIncome.Checked = true;
                    }
                    else if (transaction.transactionType == "Expense")
                    {
                        btnExpense.Checked = true;
                    }

                    btnSubmit.Text = "Update";
                    btnDelete.Enabled = true;
                }

            }
        }


    }
}
