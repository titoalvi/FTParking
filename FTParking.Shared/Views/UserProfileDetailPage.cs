using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Navigation;
using AppStudio.DataProviders.DynamicStorage;
using FTParking;
using FTParking.Sections;
using FTParking.ViewModels;

namespace FTParking.Views

{
    public sealed partial class UserProfileDetailPage : PageBase
    {
        private DataTransferManager _dataTransferManager;
        public DetailViewModel<DynamicStorageDataConfig, UserProfile1Schema> ViewModel { get; set; }

        public UserProfileDetailPage()
        {
            this.ViewModel = new DetailViewModel<DynamicStorageDataConfig, UserProfile1Schema>(new UserProfileConfig());
            this.InitializeComponent();            
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync(navParameter as ItemViewModel);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _dataTransferManager = DataTransferManager.GetForCurrentView();
            _dataTransferManager.DataRequested += OnDataRequested;

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _dataTransferManager.DataRequested -= OnDataRequested;

            base.OnNavigatedFrom(e);
        }

        private void OnDataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            bool supportsHtml = true;
#if WINDOWS_PHONE_APP
            supportsHtml = false;
#endif
            ViewModel.ShareContent(args.Request, supportsHtml);
        }
    }
}
