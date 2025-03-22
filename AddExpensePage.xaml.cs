using Microsoft.Maui.Controls;
using System;

namespace PanfilovPR3
{
    public partial class AddExpensePage : ContentPage
    {
        private ExpenseDatabase _database;

        public AddExpensePage()
        {
            InitializeComponent();
            _database = new ExpenseDatabase(DatabaseHelper.GetDatabasePath()); 
        }

        private async void OnSaveExpenseClicked(object sender, EventArgs e)
        {
            var newExpense = new Expense
            {
                Amount = decimal.Parse(AmountEntry.Text),
                Category = CategoryPicker.SelectedItem.ToString(),
                Date = DatePicker.Date
            };

            _database.AddExpense(newExpense);

            await DisplayAlert("Успех", "Расход успешно добавлен", "OK");

            await Navigation.PopAsync();
        }
    }
}
