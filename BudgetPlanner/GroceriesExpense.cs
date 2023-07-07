using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class GroceriesExpense : Expense
    {
        private string _nameMeat;
        private string _nameFV;
        private string _fruitOrVegetable;

        public GroceriesExpense(string nameMeat, string nameFV, string fruitOrVegetable, 
                                decimal amount, ExpenseCategory category, DateTime date)
                                : base(amount, category, date)
        {
            this._nameMeat = nameMeat;
            this._nameFV = nameFV;
            this._fruitOrVegetable = fruitOrVegetable;
        }

        public void SetNameMeat(string nameMeat)
        {
            _nameMeat = nameMeat;
        }
        public string GetNameMeat()
        {
            return _nameMeat;
        }

        public void SetNameFV(string nameFV)
        {
            _nameFV = nameFV;
        }
        public string GetNameFV()
        {
            return _nameFV;
        }

        public void SetFruitOrVegetable(string fruitOrVegetable)
        {
            _fruitOrVegetable = fruitOrVegetable;
        }
        public string GetFruitOrVegetable()
        {
            return _fruitOrVegetable;
        }
    }
}
