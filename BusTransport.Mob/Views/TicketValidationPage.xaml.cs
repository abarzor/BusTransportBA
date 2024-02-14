
namespace BusTransport.Mob.Views;

public partial class TicketValidationPage : ContentPage
{
	public TicketValidationPage()
	{
		InitializeComponent();
	}

    public static implicit operator View(TicketValidationPage v)
    {
        return v.Content;
    }
}