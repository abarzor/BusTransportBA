
namespace BusTransport.Mob.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnReportProblemClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReportProblemPage());
    }

    //private bool ValidateCredentials(string username, string password)
    //{
    //    return username == "admin" && password == "password";
    //}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (UsernameEntry.Text == "admin" && PasswordEntry.Text=="admin")
        {
            // Navigate to the AppShell, which contains your main app structure
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Logowanie nieudane", "Nieprawid³owy login lub has³o.", "OK");
        }
    }
}