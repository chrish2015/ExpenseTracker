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

        public void Save(string transactionName, int value, string description, DateTime dateTime, RadioButton checkedType, RadioButton checkedRecurringOption, Contact contact)
        {
            using (var dbEntities = new ExpenseTrackerDBEntities())
            {
                dbEntities.Transactions.Add(new Transaction()
                {
                    User = MainView.user,
                    date = dateTime,
                    transactionName = transactionName,
                    description = description,
                    value = value,
                    transactionType= checkedType.Text,
                    isRecurring = checkedRecurringOption.Text,
                    Contact = contact
                    
                });
                dbEntities.SaveChanges();
            }
        }

        public Transaction getTransaction(ExpenseTrackerDBEntities dbEntities, Transaction transaction)
        {
            return dbEntities.Transactions.Where(x => x.transactionId == transaction.transactionId).FirstOrDefault();
        }
    }
}
