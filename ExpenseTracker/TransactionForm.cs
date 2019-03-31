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
            String name = txtName.Text;
            int value= Int32.Parse(txtValue.Text);
            String description = txtDescription.Text;
            System.DateTime dateTime = datePickerTransactions.Value;

            RadioButton checkedType = pnlType.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            RadioButton checkedRecurringOption = pnlRecurring.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            transactionController.Save(name,value,description,dateTime,checkedType,checkedRecurringOption);
        }
    }
}
