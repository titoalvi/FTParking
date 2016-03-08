using FTParking;

namespace FTParking.Views
{
    public sealed partial class MapFullPage : PageBase
    {
        private void Launch_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
