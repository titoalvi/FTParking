using FTParking;
using System;
using Windows.UI.Popups;
using System.Threading.Tasks;

namespace FTParking.Views
{
    public sealed partial class ParkingSlotPage : PageBase
    {
        private async void Launch_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            progressring.IsActive = true;
            await Task.Delay(TimeSpan.FromSeconds(5));
            progressring.IsActive = false;
            //Visibility="Collapsed"
        }
    }
}
