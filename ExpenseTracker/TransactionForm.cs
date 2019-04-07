using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class TransactionForm : Form
    {
        private readonly TransactionController _transactionController = new TransactionController();
        Transaction _transaction = new Transaction();
        private int id = 0;
        private List<Contact> _payees;
        private List<Contact> _payers;
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            using (var dbEntity = new ExpenseTrackerDBEntities())
            {
                _payers = dbEntity.Contacts.Where(r => r.contactType == "Payer").ToList<Contact>();
                _payees = dbEntity.Contacts.Where(r => r.contactType == "Payee").ToList<Contact>();
                if (_payees.Count == 0 || _payers.Count == 0)
                {
                    MessageBox.Show("Please add payers and payees via the contact list", "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }


            PopulateTransactionsDataGridView();
            Clear();
        }

        private void Clear()
        {
            txtName.Text = txtDescription.Text = txtValue.Text = "";
            datePickerTransactions.Value = DateTime.Now;
            btnSubmit.Text = "Save";
            id = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_payees.Count == 0 || _payers.Count == 0)
            {
                MessageBox.Show("Please add payers and payees via the contact list", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            var checkedType = pnlType.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var checkedRecurringOption = pnlRecurring.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            Contact contact = (Contact)cmbBoxContacts.SelectedItem;
            if (txtName.Text.Trim() != "" && txtValue.Text.Trim() != "" && txtDescription.Text.Trim() != "" && checkedType != null && checkedRecurringOption != null && contact != null)
                _transactionController.Save(txtName.Text, Int32.Parse(txtValue.Text), txtDescription.Text, datePickerTransactions.Value,
                    checkedType, checkedRecurringOption, contact, id);
            else
                MessageBox.Show("Please data into all the fields", "Errors", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            Clear();
            PopulateTransactionsDataGridView();
        }

        private void txtValue_Validating(object sender, CancelEventArgs e)
        {
            string txtValueText;
            NumberStyles numberStyles;
            CultureInfo cultureInfo;
            decimal result;

            txtValueText = txtValue.Text;
            numberStyles = NumberStyles.AllowCurrencySymbol | NumberStyles.Number;
            cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
            if (!Decimal.TryParse(txtValueText, numberStyles, cultureInfo, out result))
            {
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Amount", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                var q = from t1 in dbEntities.Transactions
                        join t2 in dbEntities.Contacts on t1.ContactId equals t2.contactId
                        select new { t1.transactionId, t1.transactionName, t1.date, t1.description, t1.isRecurring, t1.transactionType, t1.UsersId, t1.value, t2.contactName, t2.contactId };
                dataGridTransactions.DataSource = q.ToList();


            }
        }

        private void dataGridTransactions_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridTransactions.CurrentRow.Index != -1)
            {
                _transaction.transactionId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells["transactionId"].Value);
                id = _transaction.transactionId;
                int contactId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells["contactId"].Value);
                using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
                {
                    _transaction = _transactionController.GetTransaction(dbEntities, _transaction);
                    txtName.Text = _transaction.transactionName;
                    txtDescription.Text = _transaction.description;
                    txtValue.Text = _transaction.value.ToString();
                    if (_transaction.isRecurring == "Yes")
                    {
                        rbtYes.Checked = true;
                    }
                    else
                    {
                        rbtNo.Checked = true;
                    }

                    if (_transaction.transactionType == "Income")
                    {
                        btnIncome.Checked = true;
                        int index = _payers.IndexOf(_payers.Find(r => r.contactId == contactId));
                        income_Combo();
                        cmbBoxContacts.SelectedIndex = index;

                    }
                    else if (_transaction.transactionType == "Expense")
                    {
                        btnExpense.Checked = true;
                        int index = _payees.IndexOf(_payees.Find(r => r.contactId == contactId));
                        expense_Combo();
                        cmbBoxContacts.SelectedIndex = index;
                    }


                    btnSubmit.Text = "Update";
                }

            }
        }

        private void expense_Checked(object sender, EventArgs e)
        {
            expense_Combo();
        }
        private void income_Clicked(object sender, EventArgs e)
        {
            income_Combo();
        }

        private void expense_Combo()
        {
            lblContact.Text = "Payee";
            cmbBoxContacts.DataSource = _payees;
            cmbBoxContacts.DisplayMember = "contactName";
        }



        private void income_Combo()
        {
            lblContact.Text = "Payer";
            cmbBoxContacts.DataSource = _payers;
            cmbBoxContacts.DisplayMember = "contactName";
        }

    }
}