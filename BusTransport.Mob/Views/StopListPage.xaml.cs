using BusTransport.Mob.ViewModels;

namespace BusTransport.Mob.Views;

public partial class StopListPage : ContentPage
{
    private BusStopViewModel _viewModel;
    public StopListPage()
	{
		InitializeComponent();
        _viewModel = new BusStopViewModel();
        this.BindingContext = _viewModel;
    }

    public static implicit operator View(StopListPage v)
    {
        return v.Content;
    }
}