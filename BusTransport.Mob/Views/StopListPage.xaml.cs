using BusTransport.Mob.ViewModels;

namespace BusTransport.Mob.Views;

public partial class StopListPage : ContentPage
{
    public StopListPage()
    {
        InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
        BindingContext = new BusStopViewModel();
    }

    public static implicit operator View(StopListPage v)
    {
        return v.Content;
    }
}