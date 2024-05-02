using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace BusTransport.Mob.Views;

public partial class RoutePage : ContentPage
{
    public RoutePage()
    {
        InitializeComponent();

        Location location = new Location(52.4641019924326, 19.22456548319925);

        Map map = new Map()
        {
            IsShowingUser = true,
        };
        map.MapClicked += OnMapClicked;

        void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Location.Latitude}, {e.Location.Longitude}");
        }

        Pin pin = new Pin
        {
            Label = "Santa Cruz",
            Address = "The city with a boardwalk",
            Type = PinType.Place,
            Location = new Location(36.9628066, -122.0194722)
        };
        map.Pins.Add(pin);


        Content = map;
    }

    public static implicit operator View(RoutePage v)
    {
        return v.Content;
    }
}