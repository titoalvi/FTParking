using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.DynamicStorage;
using FTParking;
using FTParking.Sections;
using FTParking.ViewModels;

namespace FTParking.Views
{
    public sealed partial class UserProfileListPage : PageBase
    {
        public ListViewModel<DynamicStorageDataConfig, UserProfile1Schema> ViewModel { get; set; }

        public UserProfileListPage()
        {
            this.ViewModel = new ListViewModel<DynamicStorageDataConfig, UserProfile1Schema>(new UserProfileConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
