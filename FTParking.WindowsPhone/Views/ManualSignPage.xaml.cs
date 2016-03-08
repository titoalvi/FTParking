using FTParking;
using System;
using Windows.UI.Popups;
using System.Threading.Tasks;

namespace FTParking.Views
{
    public sealed partial class ManualSignPage : PageBase
    {
        private async void Launch_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
            if (Name.Text == "")
            {
                MessageDialog msgbox = new MessageDialog("Please Enter Your Email!");
                await msgbox.ShowAsync();

            }
            else if (Email.Text == "")
            {
                MessageDialog msgbox = new MessageDialog("Please Enter Your Email!");
                await msgbox.ShowAsync();
            }
            else
            {
                MessageDialog msgbox = new MessageDialog("Sign Up Successfull!. Click Continue to Use this Apps ");
                await msgbox.ShowAsync();
            }

            LoadingBar.IsActive = true;
            await Task.Delay(TimeSpan.FromSeconds(5));
            LoadingBar.IsActive = false;
            //Visibility="Collapsed"

        }

        private void Click2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ParkingSlotPage));
        }
    }
}
