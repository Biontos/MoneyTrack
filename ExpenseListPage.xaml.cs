using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace PanfilovPR3
{
    public partial class ExpenseListPage : ContentPage
    {
        private ExpenseDatabase _database;

        public ExpenseListPage()
        {
            InitializeComponent();
            _database = new ExpenseDatabase(DatabaseHelper.GetDatabasePath()); 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var expenses = _database.GetAllExpenses();
            ExpensesListView.ItemsSource = expenses;
        }
    }
}
