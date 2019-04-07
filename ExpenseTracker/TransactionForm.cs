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
            }


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
            var checkedType = pnlType.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var checkedRecurringOption = pnlRecurring.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            Contact contact = (Contact)cmbBoxContacts.SelectedItem;

            _transactionController.Save(txtName.Text, Int32.Parse(txtValue.Text), txtDescription.Text, datePickerTransactions.Value,
                checkedType, checkedRecurringOption, contact);
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
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Value", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                var q = from t1 in dbEntities.Transactions
                        join t2 in dbEntities.Contacts on t1.ContactId equals t2.contactId
                        select new { t1.transactionId, t1.transactionName, t1.date, t1.description, t1.isRecurring, t1.transactionType, t1.UsersId, t1.value, t2.contactName, t2.contactId };
                dataGridTransactions.DataSource = q.ToList();


            }
        }


        private void dataGridTransactions_DoubleClick(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (dataGridTransactions.CurrentRow.Index != -1)
            {
                transaction.transactionId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells["transactionId"].Value);
                int contactId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells["contactId"].Value);
                using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
                {
                    transaction = _transactionController.getTransaction(dbEntities, transaction);
                    txtName.Text = transaction.transactionName;
                    txtDescription.Text = transaction.description;
                    txtValue.Text = transaction.value.ToString();
                    if (transaction.isRecurring == "Yes")
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
                        int index = _payers.IndexOf(_payers.Find(r => r.contactId == contactId));
                        income_Combo();
                        cmbBoxContacts.SelectedIndex = index;

                    }
                    else if (transaction.transactionType == "Expense")
                    {
                        btnExpense.Checked = true;
                        int index = _payees.IndexOf(_payees.Find(r => r.contactId == contactId));
                        expense_Combo();
                        cmbBoxContacts.SelectedIndex = index;
                    }


                    btnSubmit.Text = "Update";
                    btnDelete.Enabled = true;
                }

            }
        }

        private void expense_Checked(object sender, EventArgs e)
        {
            expense_Combo();
        }

        private void expense_Combo()
        {
            lblContact.Text = "Payee";
            cmbBoxContacts.DataSource = _payees;
            cmbBoxContacts.DisplayMember = "contactName";
        }


        private void income_Clicked(object sender, EventArgs e)
        {
            income_Combo();
        }

        private void income_Combo()
        {
            lblContact.Text = "Payer";
            cmbBoxContacts.DataSource = _payers;
            cmbBoxContacts.DisplayMember = "contactName";
        }

    }
}