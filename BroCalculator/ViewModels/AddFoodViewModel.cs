using System.Collections.ObjectModel;
using System.Diagnostics;
using BroCalculator.Models;
using BroCalculator.Services;
using BroCalculator.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BroCalculator.ViewModels
{
    public partial class AddFoodViewModel : BaseViewModel
    {
        private readonly FoodService _foodService;
        string message = string.Empty;

        public AddFoodViewModel(FoodService foodService)
        {
            Title = "MacBro Tracker";
            _foodService = foodService;
        }

        [ObservableProperty]
        bool isRefreshing;
    }
}
