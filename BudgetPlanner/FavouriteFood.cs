using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public class FavouriteFood : Expense 
    {
        private string _nameFood;
        private string _nameRestaurant;

        public FavouriteFood(string nameFood, string nameRestaurant, decimal amount, 
                             ExpenseCategory category, DateTime date) 
                            : base(amount, category, date)
        {
            this._nameFood = nameFood;
            this._nameRestaurant = nameRestaurant;
        }

        public void SetNameFood(string nameFood)
        {
            _nameFood = nameFood;
        }
        public string GetNameFood()
        {
            return _nameFood;
        }

        public void SetNameRestaurant(string nameRestaurant)
        {
            _nameRestaurant = nameRestaurant;
        }
        public string GetNameRestaurant()
        {
            return _nameRestaurant;
        }
    }
}
