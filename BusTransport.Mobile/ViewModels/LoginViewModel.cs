using BusTransport.Mobile.Services;
using System.ComponentModel;
using System.Windows.Input;

namespace BusTransport.Mobile.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _loginMessage;
        private readonly IAuthenticationService _authenticationService;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string LoginMessage
        {
            get => _loginMessage;
            set
            {
                _loginMessage = value;
                OnPropertyChanged(nameof(LoginMessage));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            LoginCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            var isAuthenticated = await _authenticationService.AuthenticateAsync(Username, Password);

            if (isAuthenticated)
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                LoginMessage = "Invalid username or password. Please try again.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
