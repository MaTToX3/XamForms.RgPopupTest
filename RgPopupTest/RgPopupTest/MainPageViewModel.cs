using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace RgPopupTest
{
    public class MainPageViewModel : BindableBase
    {
        public string Test { get; set; } = "Hello from View Model";

        private DelegateCommand _launchPopupCommand;
        public DelegateCommand LaunchPopupCommand => _launchPopupCommand ?? (_launchPopupCommand = new DelegateCommand(ExecuteLaunchPopupCommand));
        async void ExecuteLaunchPopupCommand()
        {
            await _navigationService.NavigateAsync("View1");
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private INavigationService _navigationService;
    }
}
