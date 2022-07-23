using BroCalculator.Services;
using BroCalculator.ViewModels;
using BroCalculator.Views;

namespace BroCalculator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<FoodService>();
		builder.Services.AddSingleton<FoodListViewModel>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<AddFoodPage>();


		return builder.Build();
	}
}
