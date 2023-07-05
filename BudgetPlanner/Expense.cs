using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class Expense
    {
        private decimal _amount;
        private ExpenseCategory _category;
        private DateTime _date;

        public Expense(decimal amount, ExpenseCategory category, DateTime date)
        {
            this._amount = amount;
            this._category = category;
            this._date = date;
        }

        public void SetAmount(decimal amount)
        {
            _amount = amount;
        }
        public decimal GetAmount()
        {
            return _amount;
        }

        public void SetCategory(ExpenseCategory category)
        {
            _category = category;
        }
        public ExpenseCategory GetCategory()
        {
            return _category;
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }
        public DateTime GeDate()
        {
            return _date;
        }

        public override string ToString()
        {
            return $"Category: {_category}, Amount: {_amount}, Date: {_date}";
        }

    }
}
