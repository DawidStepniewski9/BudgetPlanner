using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class BudgetPlanner
    {
        List<Expense> expenses;

        public BudgetPlanner()
        {
            expenses = new List<Expense>();
        }


        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public void RemoveExpense(Expense expense)
        {
            expenses.Remove(expense);
        }

        public List<Expense> GetExpensesByCategory(ExpenseCategory category)    //zwraca listę wydatków dla określonej kategorii,
        {
            List<Expense> filteredExpenses = new List<Expense>();

            foreach (Expense expense in expenses)
            {
                if (expense.GetCategory() == category)
                {
                    filteredExpenses.Add(expense);
                }
            }
            return filteredExpenses;
        }

        public decimal GetTotalExpenses()
        {
            decimal totalExpenses = 0;

            foreach (Expense expense in expenses)
            {
                totalExpenses += expense.GetAmount();
            }

            return totalExpenses;
        }

        public decimal GetTotalExpensesByCategory(ExpenseCategory category)   // zwraca sumę wydatków dla określonej kategorii.
        {
            decimal totalExpenses = 0;

            foreach (Expense expense in expenses)
            {
                if (expense.GetCategory() == category)
                {
                    totalExpenses += expense.GetAmount();
                }
            }

            return totalExpenses;
        }
    }
}
