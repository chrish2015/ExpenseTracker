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
        public int predictExpense()
        {
            int recurringValue = 0;
            int recurringCount = 0;

            int totalValue = 0;
            int totalCount = 0;
            List<Transaction> expenses = _transactionController.getMonthlyExpenses();

            foreach (var expense in expenses)
            {
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
            return predictedValue;
        }
    }
}
