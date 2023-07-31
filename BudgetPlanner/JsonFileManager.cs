using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;
using BudgetPlanner.DtoModels;

namespace BudgetPlanner
{
    public static class JsonFileManager
    {
        public static void SaveToFile(string filename, List<Expense> expenses)
        {
            ExpenseListModel model = new ExpenseListModel();

            foreach(var expense in expenses)
            {
                model.ExpenseList.Add(
                    new ExpenseModel()
                    {
                        Amount = expense.GetAmount(),
                        Category = expense.GetCategory(),
                        Date = expense.GetDate(),
                        Id = expense.GetId()
                    });
            }

            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(filename, json);
        }

        public static List<Expense> LoadFromFile(string filename)
        {
            List<Expense> result = new List<Expense>();

            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                var expenses = JsonConvert.DeserializeObject<ExpenseListModel>(json);

                foreach(var expense in expenses.ExpenseList)
                {
                    result.Add(new Expense(expense.Amount, expense.Category, expense.Date, expense.Id));
                }
            }
            return result;
        }

    }
}
