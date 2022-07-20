using BroCalculator.Services;

namespace BroCalculator;

public partial class App : Application
{
    public static FoodService _foodService { get; private set; }

    public App(FoodService foodService)
	{
		InitializeComponent();

		MainPage = new AppShell();

		_foodService = foodService;
	}
}
