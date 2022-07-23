using BroCalculator.Models;
using BroCalculator.ViewModels;

namespace BroCalculator.Views;

public partial class AddFoodPage : ContentPage
{
	private readonly AddFoodViewModel _addFoodViewModel;

	public AddFoodPage(AddFoodViewModel addFoodViewModel)
	{
		InitializeComponent();
		BindingContext = addFoodViewModel;
		_addFoodViewModel = addFoodViewModel;
	}
}

