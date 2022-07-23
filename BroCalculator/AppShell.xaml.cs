using BroCalculator.Views;

namespace BroCalculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddFoodPage), typeof(AddFoodPage));

	}
}
