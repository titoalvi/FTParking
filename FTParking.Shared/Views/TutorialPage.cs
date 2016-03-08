using AppStudio.Common;
using AppStudio.Common.Actions;
using Windows.UI.Xaml.Navigation;
using FTParking;
using FTParking.Commands;
using FTParking.ViewModels;

namespace FTParking
{
    public sealed partial class TutorialPage : PageBase
    {
        public MainViewModel ViewModel { get; set; }

        public TutorialPage()
        {
            int visibleItems = 0;
#if WINDOWS_APP
            visibleItems = 6;
#endif
            this.ViewModel = new MainViewModel(visibleItems);
            this.NavigationCacheMode = NavigationCacheMode.Required;
            this.InitializeComponent();

            
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }
    }
}

