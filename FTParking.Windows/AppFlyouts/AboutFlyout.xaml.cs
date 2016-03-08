using FTParking.ViewModels;
using Windows.UI.Xaml.Controls;

namespace FTParking.AppFlyouts
{
    public sealed partial class AboutFlyout : SettingsFlyout
    {
        public AboutThisAppViewModel AboutThisAppModel { get; private set; }
        public AboutFlyout()
        {
            AboutThisAppModel = new AboutThisAppViewModel();
            this.DataContext = this;
            this.InitializeComponent();
        }
    }
}
