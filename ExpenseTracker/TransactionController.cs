using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class TransactionController
    {
        public void Save()
        {

        }

        public void Save(string name, int value, string description, DateTime dateTime, RadioButton checkedType, RadioButton checkedRecurringOption)
        {
            using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
            {
                dbEntities.Transactions.Add(new Transaction()
                {
                    User = MainView.user,
                    date = dateTime,
                    name = name,
                    description = description,
                    value = value,
                    isRecurring = checkedType.Text,
                    transactionType = checkedType.Text
                });
                dbEntities.SaveChanges();
            }
        }
    }
}
