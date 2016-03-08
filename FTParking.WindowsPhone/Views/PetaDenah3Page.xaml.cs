using FTParking;

namespace FTParking.Views
{
    public sealed partial class PetaDenah3Page : PageBase
    {
        private void Launch_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        private void Launch_Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ParkingSlotPage));
        }
    }
}
