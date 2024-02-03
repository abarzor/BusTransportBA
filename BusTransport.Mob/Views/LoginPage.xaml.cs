
namespace BusTransport.Mob.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void OnReportProblemClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ReportProblemPage");
    }

    private bool ValidateCredentials(string username, string password)
    {
        // Replace this with actual authentication logic
        return username == "admin" && password == "password";
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Mock authentication logic
        if (UsernameEntry.Text == "admin" && PasswordEntry.Text=="admin")
        {
            // Navigate to the AppShell, which contains your main app structure
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Login Failed", "Invalid username or password.", "OK");
        }
    }
}