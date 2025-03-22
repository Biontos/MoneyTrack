using Microsoft.Maui.Controls;

namespace PanfilovPR3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddExpenseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExpensePage());
        }

        private async void OnViewExpensesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExpenseListPage());
        }
    }
}
