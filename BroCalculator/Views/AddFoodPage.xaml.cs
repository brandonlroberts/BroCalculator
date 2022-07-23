using BroCalculator.ViewModels;

namespace BroCalculator.Views;

public partial class AddFoodPage : ContentPage
{
    public AddFoodPage(FoodListViewModel foodListViewModel)
	{
		InitializeComponent();
        BindingContext = foodListViewModel;
    }
}
