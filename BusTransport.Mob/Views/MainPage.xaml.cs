using BusTransport.Mob.Views;
using System.Diagnostics;

namespace BusTransport.Mob
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;
        }

        private void OnRoutePageClicked(object sender, EventArgs e)
        {
            try
            {
                ContentArea.Content = new RoutePage();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }

        }

        private void OnBusMapPageClicked(object sender, EventArgs e)
        {
            ContentArea.Content = new BusMapPage();
        }

        private async void OnStopListPageClicked(object sender, EventArgs e)
        {
            try
            {
                ContentArea.Content = new StopListPage();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }

        private void OnTicketValidationPageClicked(object sender, EventArgs e)
        {
            ContentArea.Content = new TicketValidationPage();
        }
    }

}
