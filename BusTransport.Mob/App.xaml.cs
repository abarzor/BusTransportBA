using BusTransport.Mob.Views;

namespace BusTransport.Mob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;
            //MainPage = new AppShell();
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
