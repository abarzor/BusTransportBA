using BusTransport.Mobile.Services;
using System.Windows.Input;

namespace BusTransport.Mobile.ViewModels
{
    public class LoginViewModel
    {
        public ICommand LoginCommand { get; }

        private readonly IAuthenticationService _authenticationService;

        public LoginViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            // This would be bound to the UI inputs
            string username = "inputtedUsername";
            string password = "inputtedPassword";

            var isAuthenticated = await _authenticationService.AuthenticateAsync(username, password);

            if (isAuthenticated)
            {
                // Navigate to the main page with tabs upon successful login
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                // Handle failed login, show an error message, etc.
            }
        }
    }
}
