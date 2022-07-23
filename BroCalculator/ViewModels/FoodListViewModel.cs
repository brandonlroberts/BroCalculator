using System.Collections.ObjectModel;
using System.Diagnostics;
using BroCalculator.Models;
using BroCalculator.Services;
using BroCalculator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BroCalculator.ViewModels
{
    public partial class FoodListViewModel : BaseViewModel
    {
        private readonly FoodService _foodService;
        string message = string.Empty;

        public ObservableCollection<Food> Foods { get; private set; } = new();

        public FoodListViewModel(FoodService foodService)
        {
            Title = "MacBro Tracker";
            _foodService = foodService;
        }

        [ObservableProperty]
        bool isRefreshing;
        [ObservableProperty]
        int totalCalories;
        [ObservableProperty]
        int totalProtein;
        [ObservableProperty]
        int remainingCalories;
        [ObservableProperty]
        int remainingProtein;

        [ICommand]
        public async Task GetFoodList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Foods.Any()) Foods.Clear();
                var foods = _foodService.GetAllFoods();
                foreach (var food in foods) Foods.Add(food);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await ShowAlert("Failed to retrive list of cars.");
            }
            finally
            {
                IsLoading = false;
                IsRefreshing = false;
                TotalCalories = Foods.Select(x => x.Calories).Sum();
                TotalProtein = Foods.Select(x => x.Protein).Sum();
                RemainingCalories = 1600 - Foods.Select(x => x.Calories).Sum();
                RemainingProtein = 200 - Foods.Select(x => x.Protein).Sum();
            }
        }

        [ICommand]
        public async Task AddFood()
        {
            await Shell.Current.GoToAsync($"{nameof(AddFoodPage)}", true);
        }
        
        public int DeleteFood(int id)
        {
            return 1;
        }

        private async Task ShowAlert(string message)
        {
            await Shell.Current.DisplayAlert("Info", message, "Ok");
        }
    }
}
