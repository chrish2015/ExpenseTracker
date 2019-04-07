using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    class PredictionController
    {
        TransactionController _transactionController = new TransactionController();
        public int CalculatePredictions(DateTime dateTime)
        {
            int recurringValue = 0;
            int recurringCount = 0;

            int totalValue = 0;
            int totalCount = 0;

            int dateBasedValue = 0;
            int dateBasedCount = 0;

            var expenses = GetTransactions();

            foreach (var expense in expenses)
            {
                var dateTimeSeven = DateTime.Now.AddDays(-7);
                var dateTimeFourteen = DateTime.Now.AddDays(-14);
                var dateTimeTwentyOne = DateTime.Now.AddDays(-21);

                if (dateTime.Date.AddDays(-7).Equals(dateTimeSeven.Date))
                {
                    dateBasedValue += expense.value;
                    dateBasedCount++;
                }
                else if (dateTime.Date.AddDays(-14).Equals(dateTimeFourteen.Date))
                {
                    dateBasedValue += expense.value;
                    dateBasedCount++;
                }
                else if (dateTime.Date.AddDays(-21).Equals(dateTimeTwentyOne.Date))
                {
                    dateBasedValue += expense.value;
                    dateBasedCount++;
                }

                if (expense.isRecurring == "Yes")
                {
                    recurringCount++;
                    recurringValue += expense.value;
                    totalCount++;
                    totalValue += expense.value;
                }
                else
                {
                    totalCount++;
                    totalValue += expense.value;
                }
            }


            int totalMedium = totalValue / totalCount;
            int recurringMedium = recurringValue / recurringCount;

            int predictedValue = totalMedium + recurringMedium / 2;
            if (dateBasedCount != 0)
            {
                int dateBasedMedium = dateBasedValue / dateBasedCount;
                predictedValue = predictedValue + dateBasedMedium / 2;
            }
            return predictedValue;
        }

        private List<Transaction> GetTransactions()
        {
            List<Transaction> expenses = _transactionController.GetMonthlyExpenses();
            return expenses;
        }
    }
}
