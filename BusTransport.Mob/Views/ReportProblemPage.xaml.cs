using BusTransport.Mob.ViewModels;

namespace BusTransport.Mob.Views;

public partial class ReportProblemPage : ContentPage
{
	public ReportProblemPage()
	{
		InitializeComponent();
        this.BindingContext = new ReportProblemViewModel();
	}

    private void OnReportProblemClicked(object sender, EventArgs e)
    {
        DisplayAlert("Report", "Your problem has been reported.", "OK");
    }
}