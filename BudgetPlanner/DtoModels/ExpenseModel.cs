using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner.DtoModels
{
    public record ExpenseModel
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public ExpenseCategory Category { get; set; }
        public DateTime Date { get; set; }
    }

    public record ExpenseListModel
    {
        public List<ExpenseModel> ExpenseList { get; set; } = new List<ExpenseModel>();
    }
}
