using BusTransport.Mobile.Services;
using BusTransport.Mobile.ViewModels;

namespace BusTransport.Mobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(IAuthenticationService authenticationService)
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(authenticationService);
    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Assuming the existence of a LoginViewModel with a Login method
        // This part will be more fleshed out when the ViewModel is implemented
        var username = UsernameEntry.Text;
        var password = PasswordEntry.Text;

        // Placeholder for actual login logic, to be replaced with ViewModel interaction
        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            // Navigate to the main page with tabs upon successful login
            // This will be replaced with proper ViewModel-based navigation
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // Show an error message or handle invalid login
        }
    }
}