using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class TransactionController
    {

        public void Save(string transactionName, int value, string description, DateTime dateTime,
            RadioButton checkedType, RadioButton checkedRecurringOption, Contact contact, int id)
        {
            using (var dbEntities = new ExpenseTrackerDBEntities())
            {
                Transaction transaction = new Transaction()
                {
                    UsersId = MainView.user.Id,
                    transactionId = id,
                    date = dateTime,
                    transactionName = transactionName,
                    description = description,
                    value = value,
                    transactionType = checkedType.Text,
                    isRecurring = checkedRecurringOption.Text,
                    ContactId = contact.contactId

                };
                if (id == 0)
                {
                    dbEntities.Transactions.Add(transaction);
                }
                else
                {
                    dbEntities.Entry(transaction).State = EntityState.Modified;
                }

                dbEntities.SaveChanges();
            }
        }

        public Transaction GetTransaction(ExpenseTrackerDBEntities dbEntities, Transaction transaction)
        {
            return dbEntities.Transactions.Where(x => x.transactionId == transaction.transactionId).FirstOrDefault();
        }

        public List<dynamic> GetWeeklyExpenses()
        {
            using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
            {
                var dateTime = DateTime.Now.AddDays(-7);
                var todayDateTime = DateTime.Now;
                return dbEntities.Transactions.Where(r => todayDateTime > r.date && r.date > dateTime).ToList<dynamic>();

            }
        }
        public List<Transaction> GetMonthlyExpenses()
        {
            using (ExpenseTrackerDBEntities dbEntities = new ExpenseTrackerDBEntities())
            {
                var dateTime = DateTime.Now.AddDays(-31);
                var todayDateTime = DateTime.Now;
                return dbEntities.Transactions.Where(r => todayDateTime > r.date && r.date > dateTime).ToList<Transaction>();

            }
        }
    }

}
