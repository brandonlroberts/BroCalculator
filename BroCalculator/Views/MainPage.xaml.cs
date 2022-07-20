namespace BroCalculator;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		foodList.ItemsSource = App._foodService.GetAllFoods();
	}
}

