using BusTransport.Mob.ViewModels;

namespace BusTransport.Mob.Views;

public partial class ReportProblemPage : ContentPage
{
	public ReportProblemPage()
	{
		InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Light;
        this.BindingContext = new ReportCategoryViewModel();
    }

    private void OnReportProblemClicked(object sender, EventArgs e)
    {
        DisplayAlert("Zg�oszenie poprawne", "Zg�oszenie zosta�o przes�ane dalej", "OK");
    }
}
