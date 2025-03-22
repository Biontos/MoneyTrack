using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace PanfilovPR3
{
    public class ExpenseDatabase
    {
        private readonly SQLiteConnection _database;

        public ExpenseDatabase(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Expense>(); 
        }

        public void AddExpense(Expense expense)
        {
            _database.Insert(expense);
        }

        public List<Expense> GetAllExpenses()
        {
            return _database.Table<Expense>().ToList();
        }

        public List<Expense> GetExpensesByCategory(string category)
        {
            return _database.Table<Expense>().Where(e => e.Category == category).ToList();
        }
    }
}
