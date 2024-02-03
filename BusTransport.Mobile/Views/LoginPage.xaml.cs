using BusTransport.Mobile.Services;
using BusTransport.Mobile.ViewModels;

namespace BusTransport.Mobile.Views;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;

    public LoginPage()
    {
        InitializeComponent();
        _viewModel = new LoginViewModel();
        BindingContext = _viewModel;
    }


    private void OnReportProblemClicked(object sender, EventArgs e)
    {
        _viewModel.ReportProblemCommand.Execute(null);
    }

    private async Task OnLoginClickedAsync(object sender, EventArgs e)
    {
        _viewModel.LoginCommand.Execute(null);
        await Shell.Current.Navigation.PopModalAsync();
    }
}
