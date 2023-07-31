using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class Expense
    {
        private Guid _id;
        private decimal _amount;
        private ExpenseCategory _category;
        private DateTime _date;

        public Expense(decimal amount, ExpenseCategory category, DateTime? date, Guid id)
        {
            this._amount = amount;
            this._category = category;

            if (date.HasValue)
            {
                this._date = date.Value;
            }
            else
            {
                this._date = DateTime.Now;
            }

            _id = id;
        }

        public Expense(decimal amount, ExpenseCategory category, DateTime? date)
        {
            this._amount = amount;
            this._category = category;

            if (date.HasValue)
            {
                this._date = date.Value;
            }
            else
            {
                this._date = DateTime.Now;
            }

            _id = Guid.NewGuid();
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
        public DateTime GetDate()
        {
            return _date;
        }

        public void SetId(Guid id)
        {
            _id = id;
        }
        public Guid GetId()
        {
            return _id;
        }

        public override string ToString()
        {
            return $"Category: {_category}, Amount: {_amount}, Date: {_date}";
        }

    }
}
