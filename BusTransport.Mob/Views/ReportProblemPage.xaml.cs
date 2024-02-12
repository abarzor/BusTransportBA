using BusTransport.Mob.ViewModels;

namespace BusTransport.Mob.Views;

public partial class ReportProblemPage : ContentPage
{
	public ReportProblemPage()
	{
		InitializeComponent();
        this.BindingContext = new ReportCategoryViewModel();
    }

    private void OnReportProblemClicked(object sender, EventArgs e)
    {
        DisplayAlert("Zg³oszenie poprawne", "Zg³oszenie zosta³o przes³ane dalej", "OK");
    }
}
