using CommunityToolkit.Mvvm.ComponentModel;

namespace BroCalculator.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !isLoading;
    }
}
