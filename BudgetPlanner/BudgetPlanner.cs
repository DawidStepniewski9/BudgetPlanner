using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;


namespace BudgetPlanner
{
    public class BudgetPlanner
    {
        List<Expense> expenses;

        public BudgetPlanner()
        {
            expenses = new List<Expense>();
        }

        public List<Expense> GetList()
        {
            return expenses;
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

        public void SaveToFile(string filename, List<Expense> expenses)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(expenses);
            File.WriteAllText(filename, json);
        }

        //public void LoadFromFile(string filename)
        //{
        //    if (File.Exists(filename))
        //    {
        //        string json = File.ReadAllText(filename);
        //        expenses = JsonConvert.DeserializeObject<List<Expense>>(json);
        //    }
        //}
    }
}
