using System;
using System.Collections.Generic;

namespace BudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetPlanner budgetPlanner = new BudgetPlanner();
            

            // Dodawanie przykładowych wydatków
            Expense expense1 = new Expense(100.50m, ExpenseCategory.Food, new DateTime(2023, 7, 1));
            Expense expense2 = new Expense(10.50m, ExpenseCategory.Food, new DateTime(2023, 7, 1));
            Expense expense3 = new Expense(500.75m, ExpenseCategory.Rent, new DateTime(2023, 7, 2));
            Expense expense4 = new Expense(600.75m, ExpenseCategory.Rent, new DateTime(2023, 7, 2));
            Expense expense5 = new Expense(50.25m, ExpenseCategory.Transport, new DateTime(2023, 7, 3));


            budgetPlanner.AddExpense(expense1);
            budgetPlanner.AddExpense(expense2);
            budgetPlanner.AddExpense(expense3);
            budgetPlanner.AddExpense(expense4);
            budgetPlanner.AddExpense(expense5);

            List<Expense> lista = budgetPlanner.GetList();

            // Zapisywanie do pliku
            budgetPlanner.SaveToFile("budget.json", lista);
            Console.WriteLine("Zapisano dane do pliku.");

            // Odczytywanie z pliku
            //budgetPlanner.LoadFromFile("budget.json");
            //Console.WriteLine("Wczytano dane z pliku.");

            //// Wyświetlanie wydatków
            //Console.WriteLine("Wyświetlanie listy wydatków dla określonej kategorii:");
            //foreach (Expense expense in budgetPlanner.GetExpensesByCategory(ExpenseCategory.Food))
            //{
            //    Console.WriteLine(expense.ToString());
            //}

            //// Obliczanie sumy wydatków
            //decimal totalExpenses = budgetPlanner.GetTotalExpenses();
            //Console.WriteLine($"Suma wszystkich wydatków: {totalExpenses}");

            //// Obliczanie sumy wydatków dla określonej kategorii
            //decimal totalFoodExpenses = budgetPlanner.GetTotalExpensesByCategory(ExpenseCategory.Food);
            //Console.WriteLine($"Suma wydatków na jedzenie: {totalFoodExpenses}");
        }
    }
}
