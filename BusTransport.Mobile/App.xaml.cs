using BusTransport.Mobile.Views;

namespace BusTransport.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}
