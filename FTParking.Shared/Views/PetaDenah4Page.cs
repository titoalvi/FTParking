using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using AppStudio.DataProviders.Menu;
using FTParking;
using FTParking.Sections;
using FTParking.ViewModels;

namespace FTParking.Views
{
    public sealed partial class PetaDenah4Page : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, MenuSchema> ViewModel { get; set; }

        public PetaDenah4Page()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, MenuSchema>(new PetaDenah4Config());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
