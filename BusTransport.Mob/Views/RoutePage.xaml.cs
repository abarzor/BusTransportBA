
namespace BusTransport.Mob.Views;

public partial class RoutePage : ContentPage
{
	public RoutePage()
	{
		InitializeComponent();
	}

    public static implicit operator View(RoutePage v)
    {
        return v.Content;
    }
}