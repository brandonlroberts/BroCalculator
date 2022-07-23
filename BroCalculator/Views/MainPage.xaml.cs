using BroCalculator.Models;
using BroCalculator.ViewModels;

namespace BroCalculator.Views;

public partial class MainPage : ContentPage
{
	private readonly FoodListViewModel _foodListViewModel;
	
	public MainPage(FoodListViewModel foodListViewModel)
	{
		InitializeComponent();
		BindingContext = foodListViewModel;
		_foodListViewModel = foodListViewModel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _foodListViewModel.GetFoodList();
	}

	void DeleteFood_Invoked(object sender, EventArgs e)
    {
		var selectedFood = ((SwipeItem)sender).BindingContext as Food;

		var result = _foodListViewModel.DeleteFood(selectedFood.Id);

		if (result == 1)
			DisplayAlert("Delete Successfull", $"{selectedFood.Name} has been DELETED from your daily log!", "Thanks");
		else DisplayAlert("Delete FAILED", $"There was an issue deleting {selectedFood.Name}!", "Please try again...");
	}

	void Settings_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Settings Clicked", $"This is where you will click to change your user settings.", "Thanks");
	}

	void Help_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("Help Clicked", $"This is where you will click to view the helper page.", "Thanks");
	}

}

